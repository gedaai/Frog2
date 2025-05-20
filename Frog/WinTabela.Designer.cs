namespace Frog
{
    partial class WinTabela
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
            dgTabela = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgTabela).BeginInit();
            SuspendLayout();
            // 
            // dgTabela
            // 
            dgTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTabela.EditMode = DataGridViewEditMode.EditOnF2;
            dgTabela.Location = new Point(8, 20);
            dgTabela.Name = "dgTabela";
            dgTabela.Size = new Size(780, 418);
            dgTabela.TabIndex = 0;
            // 
            // WinTabela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgTabela);
            Name = "WinTabela";
            Text = "Tabela";
            Load += WinTabela_Load;
            ((System.ComponentModel.ISupportInitialize)dgTabela).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgTabela;
    }
}