namespace SqlQuerier
{
    partial class ClassesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassesForm));
            this.ClassInput = new ICSharpCode.TextEditor.TextEditorControl();
            this.SuspendLayout();
            // 
            // ClassInput
            // 
            this.ClassInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassInput.Encoding = ((System.Text.Encoding)(resources.GetObject("ClassInput.Encoding")));
            this.ClassInput.Location = new System.Drawing.Point(0, 0);
            this.ClassInput.Name = "ClassInput";
            this.ClassInput.ShowEOLMarkers = true;
            this.ClassInput.ShowInvalidLines = false;
            this.ClassInput.ShowSpaces = true;
            this.ClassInput.ShowTabs = true;
            this.ClassInput.ShowVRuler = true;
            this.ClassInput.Size = new System.Drawing.Size(284, 264);
            this.ClassInput.TabIndex = 1;
            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.ClassInput);
            this.Name = "ClassesForm";
            this.TabText = "Classes";
            this.Text = "Classes";
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl ClassInput;
    }
}