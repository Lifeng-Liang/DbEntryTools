namespace SqlQuerier
{
    partial class DbStruct
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbStruct));
            this.StructTree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.generateClassesGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StructTree
            // 
            this.StructTree.ContextMenuStrip = this.contextMenuStrip1;
            this.StructTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StructTree.ImageIndex = 0;
            this.StructTree.ImageList = this.imageList1;
            this.StructTree.Location = new System.Drawing.Point(0, 0);
            this.StructTree.Name = "StructTree";
            this.StructTree.SelectedImageIndex = 0;
            this.StructTree.ShowLines = false;
            this.StructTree.Size = new System.Drawing.Size(188, 397);
            this.StructTree.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshRToolStripMenuItem,
            this.generateClassesGToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 70);
            // 
            // refreshRToolStripMenuItem
            // 
            this.refreshRToolStripMenuItem.Name = "refreshRToolStripMenuItem";
            this.refreshRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshRToolStripMenuItem.Text = "Refresh(&R)";
            this.refreshRToolStripMenuItem.Click += new System.EventHandler(this.refreshRToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "table.bmp");
            this.imageList1.Images.SetKeyName(1, "column.bmp");
            this.imageList1.Images.SetKeyName(2, "message.bmp");
            this.imageList1.Images.SetKeyName(3, "pk.bmp");
            this.imageList1.Images.SetKeyName(4, "fk.bmp");
            // 
            // generateClassesGToolStripMenuItem
            // 
            this.generateClassesGToolStripMenuItem.Name = "generateClassesGToolStripMenuItem";
            this.generateClassesGToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.generateClassesGToolStripMenuItem.Text = "Generate Class(es)(&G)";
            this.generateClassesGToolStripMenuItem.Click += new System.EventHandler(this.generateClassesGToolStripMenuItem_Click);
            // 
            // DbStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 397);
            this.Controls.Add(this.StructTree);
            this.HideOnClose = true;
            this.Name = "DbStruct";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            this.TabText = "Db Struct";
            this.Text = "Db Struct";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView StructTree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateClassesGToolStripMenuItem;
    }
}