namespace TemplateBuilder
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
            this.AssemblyFileName = new System.Windows.Forms.TextBox();
            this.LoadAssembly = new System.Windows.Forms.Button();
            this.TypeSelector = new System.Windows.Forms.ComboBox();
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.openDllDialog = new System.Windows.Forms.OpenFileDialog();
            this.status = new System.Windows.Forms.StatusStrip();
            this.msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.ResultText = new ICSharpCode.TextEditor.TextEditorControl();
            this.ModeSelector = new System.Windows.Forms.ComboBox();
            this.ActionSelector = new System.Windows.Forms.ComboBox();
            this.Generate = new System.Windows.Forms.Button();
            this.MasterName = new System.Windows.Forms.ComboBox();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssemblyFileName
            // 
            this.AssemblyFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AssemblyFileName.BackColor = System.Drawing.SystemColors.Info;
            this.AssemblyFileName.Location = new System.Drawing.Point(141, 12);
            this.AssemblyFileName.Name = "AssemblyFileName";
            this.AssemblyFileName.ReadOnly = true;
            this.AssemblyFileName.Size = new System.Drawing.Size(373, 21);
            this.AssemblyFileName.TabIndex = 0;
            // 
            // LoadAssembly
            // 
            this.LoadAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadAssembly.Location = new System.Drawing.Point(520, 10);
            this.LoadAssembly.Name = "LoadAssembly";
            this.LoadAssembly.Size = new System.Drawing.Size(119, 23);
            this.LoadAssembly.TabIndex = 1;
            this.LoadAssembly.Text = "Load Assembly";
            this.LoadAssembly.UseVisualStyleBackColor = true;
            this.LoadAssembly.Click += new System.EventHandler(this.LoadAssembly_Click);
            // 
            // TypeSelector
            // 
            this.TypeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSelector.FormattingEnabled = true;
            this.TypeSelector.Location = new System.Drawing.Point(141, 39);
            this.TypeSelector.Name = "TypeSelector";
            this.TypeSelector.Size = new System.Drawing.Size(373, 20);
            this.TypeSelector.TabIndex = 2;
            this.TypeSelector.SelectedIndexChanged += new System.EventHandler(this.TypeSelector_SelectedIndexChanged);
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.Location = new System.Drawing.Point(12, 65);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(119, 23);
            this.CopyToClipboard.TabIndex = 4;
            this.CopyToClipboard.Text = "Copy To Clipboard";
            this.CopyToClipboard.UseVisualStyleBackColor = true;
            this.CopyToClipboard.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // openDllDialog
            // 
            this.openDllDialog.Filter = "DLL Files|*.dll|All Files|*.*";
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msg});
            this.status.Location = new System.Drawing.Point(0, 349);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(652, 22);
            this.status.TabIndex = 5;
            // 
            // msg
            // 
            this.msg.ForeColor = System.Drawing.Color.Green;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(26, 17);
            this.msg.Text = "OK";
            // 
            // ResultText
            // 
            this.ResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultText.Encoding = ((System.Text.Encoding)(resources.GetObject("ResultText.Encoding")));
            this.ResultText.IsIconBarVisible = false;
            this.ResultText.Location = new System.Drawing.Point(12, 94);
            this.ResultText.Name = "ResultText";
            this.ResultText.ShowEOLMarkers = true;
            this.ResultText.ShowInvalidLines = false;
            this.ResultText.ShowSpaces = true;
            this.ResultText.ShowTabs = true;
            this.ResultText.ShowVRuler = true;
            this.ResultText.Size = new System.Drawing.Size(627, 241);
            this.ResultText.TabIndex = 6;
            this.ResultText.VRulerRow = 20;
            // 
            // ModeSelector
            // 
            this.ModeSelector.BackColor = System.Drawing.SystemColors.Window;
            this.ModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelector.FormattingEnabled = true;
            this.ModeSelector.Items.AddRange(new object[] {
            "Asp.Net",
            "Rails actions",
            "Rails views"});
            this.ModeSelector.Location = new System.Drawing.Point(13, 12);
            this.ModeSelector.Name = "ModeSelector";
            this.ModeSelector.Size = new System.Drawing.Size(122, 20);
            this.ModeSelector.TabIndex = 7;
            this.ModeSelector.SelectedIndexChanged += new System.EventHandler(this.ModeSelector_SelectedIndexChanged);
            // 
            // ActionSelector
            // 
            this.ActionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionSelector.FormattingEnabled = true;
            this.ActionSelector.Location = new System.Drawing.Point(13, 38);
            this.ActionSelector.Name = "ActionSelector";
            this.ActionSelector.Size = new System.Drawing.Size(121, 20);
            this.ActionSelector.TabIndex = 8;
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate.Location = new System.Drawing.Point(520, 65);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(119, 23);
            this.Generate.TabIndex = 10;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // MasterName
            // 
            this.MasterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterName.FormattingEnabled = true;
            this.MasterName.Items.AddRange(new object[] {
            "~/main.master"});
            this.MasterName.Location = new System.Drawing.Point(521, 39);
            this.MasterName.Name = "MasterName";
            this.MasterName.Size = new System.Drawing.Size(118, 20);
            this.MasterName.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 371);
            this.Controls.Add(this.MasterName);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.ActionSelector);
            this.Controls.Add(this.ModeSelector);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.status);
            this.Controls.Add(this.CopyToClipboard);
            this.Controls.Add(this.TypeSelector);
            this.Controls.Add(this.LoadAssembly);
            this.Controls.Add(this.AssemblyFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Template Builder for DbEntry.Net";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AssemblyFileName;
        private System.Windows.Forms.Button LoadAssembly;
        private System.Windows.Forms.ComboBox TypeSelector;
        private System.Windows.Forms.Button CopyToClipboard;
        private System.Windows.Forms.OpenFileDialog openDllDialog;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel msg;
        private ICSharpCode.TextEditor.TextEditorControl ResultText;
        private System.Windows.Forms.ComboBox ModeSelector;
        private System.Windows.Forms.ComboBox ActionSelector;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ComboBox MasterName;
    }
}

