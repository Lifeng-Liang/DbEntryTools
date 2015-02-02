namespace AssemblyNameGetter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GetAssembly = new System.Windows.Forms.OpenFileDialog();
            this.AssemblyPath = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.AssemblyName = new System.Windows.Forms.TextBox();
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetAssembly
            // 
            this.GetAssembly.Filter = "Assembly Exe|*.exe|Assembly Dll|*.dll|All File|*.*";
            // 
            // AssemblyPath
            // 
            this.AssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AssemblyPath.BackColor = System.Drawing.SystemColors.Info;
            this.AssemblyPath.Location = new System.Drawing.Point(24, 25);
            this.AssemblyPath.Name = "AssemblyPath";
            this.AssemblyPath.Size = new System.Drawing.Size(403, 21);
            this.AssemblyPath.TabIndex = 0;
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(444, 23);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // AssemblyName
            // 
            this.AssemblyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AssemblyName.BackColor = System.Drawing.SystemColors.Info;
            this.AssemblyName.Location = new System.Drawing.Point(24, 63);
            this.AssemblyName.Multiline = true;
            this.AssemblyName.Name = "AssemblyName";
            this.AssemblyName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AssemblyName.Size = new System.Drawing.Size(403, 173);
            this.AssemblyName.TabIndex = 2;
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyToClipboard.Location = new System.Drawing.Point(444, 63);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(75, 53);
            this.CopyToClipboard.TabIndex = 3;
            this.CopyToClipboard.Text = "Copy To Clipboard";
            this.CopyToClipboard.UseVisualStyleBackColor = true;
            this.CopyToClipboard.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 264);
            this.Controls.Add(this.CopyToClipboard);
            this.Controls.Add(this.AssemblyName);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.AssemblyPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(330, 220);
            this.Name = "MainForm";
            this.Text = "Assembly Name Getter";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog GetAssembly;
        private System.Windows.Forms.TextBox AssemblyPath;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox AssemblyName;
        private System.Windows.Forms.Button CopyToClipboard;
    }
}

