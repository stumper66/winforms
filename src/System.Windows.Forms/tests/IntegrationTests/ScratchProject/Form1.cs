// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;

namespace ScratchProject;

// As we can't currently design in VS in the runtime solution, mark as "Default" so this opens in code view by default.
[DesignerCategory("Default")]
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        var parent = treeViewLeft.SelectedNode;
        if (parent is not null)
        {
            TreeNode newNode = new(parent.Text);
            parent.Nodes.Add(newNode);
            if (!parent.IsExpanded)
            {
                parent.Expand();
            }
        }

        parent = treeViewRight.SelectedNode;
        if (parent is not null)
        {
            TreeNode newNode = new(parent.Text);
            parent.Nodes.Add(newNode);
            if (!parent.IsExpanded)
            {
                parent.Expand();
            }

            return;
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        var toDelete = treeViewLeft.SelectedNode;
        if (toDelete is not null)
        {
            treeViewLeft.Nodes.Remove(toDelete);
        }

        toDelete = treeViewRight.SelectedNode;
        if (toDelete is not null)
        {
            treeViewRight.Nodes.Remove(toDelete);
        }
    }

    private void buttonToRight_Click(object sender, EventArgs e)
    {
        if (treeViewLeft.SelectedNode is not null)
        {
            TreeNode node = treeViewLeft.SelectedNode;
            treeViewLeft.Nodes.Remove(node);
            treeViewRight.Nodes.Add(node);
        }
    }

    private void buttonToLeft_Click(object sender, EventArgs e)
    {
        if (treeViewRight.SelectedNode is not null)
        {
            TreeNode node = treeViewRight.SelectedNode;
            treeViewRight.Nodes.Remove(node);
            treeViewLeft.Nodes.Add(node);
        }
    }
}
