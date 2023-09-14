namespace TaskManager
{
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
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            listView1 = new ListView();
            proccess = new ColumnHeader();
            memory = new ColumnHeader();
            id = new ColumnHeader();
            priorityClass = new ColumnHeader();
            basePriority = new ColumnHeader();
            threadsCount = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            stopToolStripMenuItem = new ToolStripMenuItem();
            treeView1 = new TreeView();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1066, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { proccess, memory, id, priorityClass, basePriority, threadsCount });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.Location = new Point(0, 25);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(689, 425);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // proccess
            // 
            proccess.Text = "Proccess";
            proccess.Width = 200;
            // 
            // memory
            // 
            memory.Text = "Memory";
            memory.Width = 200;
            // 
            // id
            // 
            id.Text = "Id";
            // 
            // priorityClass
            // 
            priorityClass.Text = "PriorityClass";
            // 
            // basePriority
            // 
            basePriority.Text = "BasePriority";
            // 
            // threadsCount
            // 
            threadsCount.Text = "Threads Count";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { stopToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 28);
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(109, 24);
            stopToolStripMenuItem.Text = "Stop";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(728, 28);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(307, 410);
            treeView1.TabIndex = 4;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 450);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Task Manager";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ListView listView1;
        private ColumnHeader proccess;
        private ColumnHeader memory;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ColumnHeader id;
        private ColumnHeader priorityClass;
        private ColumnHeader basePriority;
        private ColumnHeader threadsCount;
        private TreeView treeView1;
    }
}