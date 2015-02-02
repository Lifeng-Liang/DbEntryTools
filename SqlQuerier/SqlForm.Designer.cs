namespace SqlQuerier
{
    partial class SqlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlForm));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ResultTab = new System.Windows.Forms.TabControl();
            this.Result = new System.Windows.Forms.TabPage();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.Messages = new System.Windows.Forms.TabPage();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BottomSplitter = new System.Windows.Forms.Splitter();
            this.SqlInput = new ICSharpCode.TextEditor.TextEditorControl();
            this.BottomPanel.SuspendLayout();
            this.ResultTab.SuspendLayout();
            this.Result.SuspendLayout();
            this.Messages.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.ResultTab);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 209);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(498, 162);
            this.BottomPanel.TabIndex = 9;
            // 
            // ResultTab
            // 
            this.ResultTab.Controls.Add(this.Result);
            this.ResultTab.Controls.Add(this.Messages);
            this.ResultTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTab.ImageList = this.imageList1;
            this.ResultTab.Location = new System.Drawing.Point(0, 0);
            this.ResultTab.Name = "ResultTab";
            this.ResultTab.SelectedIndex = 0;
            this.ResultTab.Size = new System.Drawing.Size(498, 162);
            this.ResultTab.TabIndex = 1;
            this.ResultTab.TabStop = false;
            // 
            // Result
            // 
            this.Result.Controls.Add(this.ViewPanel);
            this.Result.ImageIndex = 0;
            this.Result.Location = new System.Drawing.Point(4, 23);
            this.Result.Name = "Result";
            this.Result.Padding = new System.Windows.Forms.Padding(3);
            this.Result.Size = new System.Drawing.Size(490, 135);
            this.Result.TabIndex = 0;
            this.Result.Text = "Result";
            this.Result.UseVisualStyleBackColor = true;
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(3, 3);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(484, 129);
            this.ViewPanel.TabIndex = 0;
            // 
            // Messages
            // 
            this.Messages.Controls.Add(this.ResultText);
            this.Messages.ImageIndex = 1;
            this.Messages.Location = new System.Drawing.Point(4, 23);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(490, 135);
            this.Messages.TabIndex = 1;
            this.Messages.Text = "Messages";
            this.Messages.UseVisualStyleBackColor = true;
            // 
            // ResultText
            // 
            this.ResultText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultText.Location = new System.Drawing.Point(3, 3);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultText.Size = new System.Drawing.Size(484, 129);
            this.ResultText.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "table.bmp");
            this.imageList1.Images.SetKeyName(1, "message.bmp");
            // 
            // BottomSplitter
            // 
            this.BottomSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomSplitter.Location = new System.Drawing.Point(0, 206);
            this.BottomSplitter.Name = "BottomSplitter";
            this.BottomSplitter.Size = new System.Drawing.Size(498, 3);
            this.BottomSplitter.TabIndex = 10;
            this.BottomSplitter.TabStop = false;
            // 
            // SqlInput
            // 
            this.SqlInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SqlInput.Encoding = ((System.Text.Encoding)(resources.GetObject("SqlInput.Encoding")));
            this.SqlInput.Location = new System.Drawing.Point(0, 0);
            this.SqlInput.Name = "SqlInput";
            this.SqlInput.ShowEOLMarkers = true;
            this.SqlInput.ShowInvalidLines = false;
            this.SqlInput.ShowSpaces = true;
            this.SqlInput.ShowTabs = true;
            this.SqlInput.ShowVRuler = true;
            this.SqlInput.Size = new System.Drawing.Size(498, 206);
            this.SqlInput.TabIndex = 0;
            // 
            // SqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 371);
            this.Controls.Add(this.SqlInput);
            this.Controls.Add(this.BottomSplitter);
            this.Controls.Add(this.BottomPanel);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Name = "SqlForm";
            this.TabText = "Sql";
            this.Text = "Sql";
            this.BottomPanel.ResumeLayout(false);
            this.ResultTab.ResumeLayout(false);
            this.Result.ResumeLayout(false);
            this.Messages.ResumeLayout(false);
            this.Messages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.TabControl ResultTab;
        private System.Windows.Forms.TabPage Result;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.TabPage Messages;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Splitter BottomSplitter;
        private System.Windows.Forms.ImageList imageList1;
        private ICSharpCode.TextEditor.TextEditorControl SqlInput;


    }
}