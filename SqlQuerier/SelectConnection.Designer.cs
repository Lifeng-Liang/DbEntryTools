namespace SqlQuerier
{
    partial class SelectConnection
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataBaseText = new System.Windows.Forms.TextBox();
            this.PreviewText = new System.Windows.Forms.TextBox();
            this.DbProviderFactoryText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DbDriverText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SavedName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataBase:";
            // 
            // DataBaseText
            // 
            this.DataBaseText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBaseText.Location = new System.Drawing.Point(135, 50);
            this.DataBaseText.Name = "DataBaseText";
            this.DataBaseText.Size = new System.Drawing.Size(415, 21);
            this.DataBaseText.TabIndex = 1;
            this.DataBaseText.TextChanged += new System.EventHandler(this.DataBaseText_TextChanged);
            // 
            // PreviewText
            // 
            this.PreviewText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewText.Location = new System.Drawing.Point(35, 165);
            this.PreviewText.Multiline = true;
            this.PreviewText.Name = "PreviewText";
            this.PreviewText.ReadOnly = true;
            this.PreviewText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PreviewText.Size = new System.Drawing.Size(515, 101);
            this.PreviewText.TabIndex = 2;
            // 
            // DbProviderFactoryText
            // 
            this.DbProviderFactoryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DbProviderFactoryText.Location = new System.Drawing.Point(135, 86);
            this.DbProviderFactoryText.Name = "DbProviderFactoryText";
            this.DbProviderFactoryText.Size = new System.Drawing.Size(415, 21);
            this.DbProviderFactoryText.TabIndex = 8;
            this.DbProviderFactoryText.TextChanged += new System.EventHandler(this.DbProviderFactoryText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "DbProviderFactory:";
            // 
            // DbDriverText
            // 
            this.DbDriverText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DbDriverText.Location = new System.Drawing.Point(135, 122);
            this.DbDriverText.Name = "DbDriverText";
            this.DbDriverText.Size = new System.Drawing.Size(415, 21);
            this.DbDriverText.TabIndex = 10;
            this.DbDriverText.TextChanged += new System.EventHandler(this.DbDriverText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "DbDriver:";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonOK.Location = new System.Drawing.Point(205, 281);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 11;
            this.ButtonOK.Text = "&OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(314, 281);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "&CANCEL";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // SavedName
            // 
            this.SavedName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SavedName.FormattingEnabled = true;
            this.SavedName.Location = new System.Drawing.Point(135, 15);
            this.SavedName.Name = "SavedName";
            this.SavedName.Size = new System.Drawing.Size(304, 20);
            this.SavedName.TabIndex = 13;
            this.SavedName.SelectedIndexChanged += new System.EventHandler(this.SavedName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Property Name:";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.Location = new System.Drawing.Point(451, 13);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(99, 23);
            this.ButtonDelete.TabIndex = 15;
            this.ButtonDelete.Text = "&Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // SelectConnection
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(588, 316);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SavedName);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.DbDriverText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DbProviderFactoryText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PreviewText);
            this.Controls.Add(this.DataBaseText);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(480, 350);
            this.Name = "SelectConnection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SelectConnection";
            this.Load += new System.EventHandler(this.SelectConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DataBaseText;
        private System.Windows.Forms.TextBox PreviewText;
        private System.Windows.Forms.TextBox DbProviderFactoryText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DbDriverText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox SavedName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonDelete;
    }
}