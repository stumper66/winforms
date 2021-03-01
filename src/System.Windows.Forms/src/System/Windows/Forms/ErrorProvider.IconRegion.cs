﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Drawing;
using static Interop;

namespace System.Windows.Forms
{
    partial class ErrorProvider
    {
        /// <summary>
        ///  This represents the HRGN of icon. The region is calculate from the icon's mask.
        /// </summary>
        internal class IconRegion : IHandle
        {
            private Region region;
            private readonly Icon icon;

            /// <summary>
            ///  Constructor that takes an Icon and extracts its 16x16 version.
            /// </summary>
            public IconRegion(Icon icon)
            {
                this.icon = new Icon(icon, 16, 16);
            }

            /// <summary>
            ///  Returns the handle of the icon.
            /// </summary>
            public IntPtr Handle => icon.Handle;

            /// <summary>
            ///  Returns the handle of the region.
            /// </summary>
            public Region Region
            {
                get
                {
                    if (region is null)
                    {
                        region = new Region(new Rectangle(0, 0, 0, 0));

                        IntPtr mask = IntPtr.Zero;
                        try
                        {
                            Size size = icon.Size;
                            Bitmap bitmap = icon.ToBitmap();
                            mask = ControlPaint.CreateHBitmapTransparencyMask(bitmap);
                            bitmap.Dispose();

                            // It is been observed that users can use non standard size icons (not a 16 bit multiples for width and height)
                            // and GetBitmapBits method allocate bytes in multiple of 16 bits for each row. Following calculation is to get right width in bytes.
                            int bitmapBitsAllocationSize = 16;

                            // If width is not multiple of 16, we need to allocate BitmapBitsAllocationSize for remaining bits.
                            int widthInBytes = 2 * ((size.Width + 15) / bitmapBitsAllocationSize); // its in bytes.
                            byte[] bits = new byte[widthInBytes * size.Height];
                            Gdi32.GetBitmapBits(mask, bits.Length, bits);

                            for (int y = 0; y < size.Height; y++)
                            {
                                for (int x = 0; x < size.Width; x++)
                                {
                                    // see if bit is set in mask. bits in byte are reversed. 0 is black (set).
                                    if ((bits[y * widthInBytes + x / 8] & (1 << (7 - (x % 8)))) == 0)
                                    {
                                        region.Union(new Rectangle(x, y, 1, 1));
                                    }
                                }
                            }
                            region.Intersect(new Rectangle(0, 0, size.Width, size.Height));
                        }
                        finally
                        {
                            if (mask != IntPtr.Zero)
                            {
                                Gdi32.DeleteObject(mask);
                            }
                        }
                    }

                    return region;
                }
            }

            /// <summary>
            ///  Return the size of the icon.
            /// </summary>
            public Size Size => icon.Size;

            /// <summary>
            ///  Release any resources held by this Object.
            /// </summary>
            public void Dispose()
            {
                if (region != null)
                {
                    region.Dispose();
                    region = null;
                }
                icon.Dispose();
            }
        }
    }
}
