// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ScratchProject;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        TreeNode treeNode1 = new TreeNode("Node0");
        TreeNode treeNode2 = new TreeNode("Node3");
        TreeNode treeNode3 = new TreeNode("Node6");
        TreeNode treeNode4 = new TreeNode("Node7");
        TreeNode treeNode5 = new TreeNode("Node4", new TreeNode[] { treeNode3, treeNode4 });
        TreeNode treeNode6 = new TreeNode("Node5");
        TreeNode treeNode7 = new TreeNode("Node1", new TreeNode[] { treeNode2, treeNode5, treeNode6 });
        TreeNode treeNode8 = new TreeNode("Node2");
        treeViewLeft = new TreeView();
        treeViewRight = new TreeView();
        buttonAdd = new Button();
        buttonDelete = new Button();
        buttonToRight = new Button();
        buttonToLeft = new Button();
        SuspendLayout();
        // 
        // treeViewLeft
        // 
        treeViewLeft.Location = new Point(33, 50);
        treeViewLeft.Name = "treeViewLeft";
        treeNode1.Name = "Node0";
        treeNode1.Text = "Node0";
        treeNode2.Name = "Node3";
        treeNode2.Text = "Node3";
        treeNode3.Name = "Node6";
        treeNode3.Text = "Node6";
        treeNode4.Name = "Node7";
        treeNode4.Text = "Node7";
        treeNode5.Name = "Node4";
        treeNode5.Text = "Node4";
        treeNode6.Name = "Node5";
        treeNode6.Text = "Node5";
        treeNode7.Name = "Node1";
        treeNode7.Text = "Node1";
        treeNode8.Name = "Node2";
        treeNode8.Text = "Node2";
        treeViewLeft.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode7, treeNode8 });
        treeViewLeft.Size = new Size(242, 314);
        treeViewLeft.TabIndex = 0;
        // 
        // treeViewRight
        // 
        treeViewRight.Location = new Point(525, 50);
        treeViewRight.Name = "treeViewRight";
        treeViewRight.Size = new Size(242, 314);
        treeViewRight.TabIndex = 1;
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new Point(311, 59);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(150, 46);
        buttonAdd.TabIndex = 2;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.Location = new Point(311, 129);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(150, 46);
        buttonDelete.TabIndex = 3;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // buttonToRight
        // 
        buttonToRight.Location = new Point(311, 201);
        buttonToRight.Name = "buttonToRight";
        buttonToRight.Size = new Size(150, 46);
        buttonToRight.TabIndex = 4;
        buttonToRight.Text = "->";
        buttonToRight.UseVisualStyleBackColor = true;
        buttonToRight.Click += buttonToRight_Click;
        // 
        // buttonToLeft
        // 
        buttonToLeft.Location = new Point(311, 276);
        buttonToLeft.Name = "buttonToLeft";
        buttonToLeft.Size = new Size(150, 46);
        buttonToLeft.TabIndex = 5;
        buttonToLeft.Text = "<-";
        buttonToLeft.UseVisualStyleBackColor = true;
        buttonToLeft.Click += buttonToLeft_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(buttonToLeft);
        Controls.Add(buttonToRight);
        Controls.Add(buttonDelete);
        Controls.Add(buttonAdd);
        Controls.Add(treeViewRight);
        Controls.Add(treeViewLeft);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private TreeView treeViewLeft;
    private TreeView treeViewRight;
    private Button buttonAdd;
    private Button buttonDelete;
    private Button buttonToRight;
    private Button buttonToLeft;
}
