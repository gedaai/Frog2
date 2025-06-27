namespace Frog
{
    partial class WinObjetos
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
            rtSource = new RichTextBox();
            btnSpecBody = new Button();
            SuspendLayout();
            // 
            // rtSource
            // 
            rtSource.Location = new Point(10, 36);
            rtSource.Name = "rtSource";
            rtSource.Size = new Size(804, 586);
            rtSource.TabIndex = 1;
            rtSource.Text = "";
            rtSource.WordWrap = false;
            // 
            // btnSpecBody
            // 
            btnSpecBody.Location = new Point(8, 10);
            btnSpecBody.Name = "btnSpecBody";
            btnSpecBody.Size = new Size(75, 23);
            btnSpecBody.TabIndex = 2;
            btnSpecBody.Text = "Spec/Body";
            btnSpecBody.UseVisualStyleBackColor = true;
            btnSpecBody.Click += btnSpecBody_Click;
            // 
            // WinObjetos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 634);
            Controls.Add(btnSpecBody);
            Controls.Add(rtSource);
            KeyPreview = true;
            Name = "WinObjetos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Package";
            Load += WinPackage_Load;
            KeyDown += WinObjetos_KeyDown;
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rtSource;
        private Button btnSpecBody;
    }
}