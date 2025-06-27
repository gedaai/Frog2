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
            tabControl1 = new TabControl();
            tabPageCodigo = new TabPage();
            tabPageErros = new TabPage();
            dataGridErros = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageCodigo.SuspendLayout();
            tabPageErros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridErros).BeginInit();
            SuspendLayout();
            // 
            // rtSource
            // 
            rtSource.Location = new Point(0, 0);
            rtSource.Name = "rtSource";
            rtSource.Size = new Size(801, 563);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCodigo);
            tabControl1.Controls.Add(tabPageErros);
            tabControl1.Location = new Point(13, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(809, 591);
            tabControl1.TabIndex = 3;
            // 
            // tabPageCodigo
            // 
            tabPageCodigo.Controls.Add(rtSource);
            tabPageCodigo.Location = new Point(4, 24);
            tabPageCodigo.Name = "tabPageCodigo";
            tabPageCodigo.Padding = new Padding(3);
            tabPageCodigo.Size = new Size(801, 563);
            tabPageCodigo.TabIndex = 0;
            tabPageCodigo.Text = "Código";
            tabPageCodigo.UseVisualStyleBackColor = true;
            // 
            // tabPageErros
            // 
            tabPageErros.Controls.Add(dataGridErros);
            tabPageErros.Location = new Point(4, 24);
            tabPageErros.Name = "tabPageErros";
            tabPageErros.Padding = new Padding(3);
            tabPageErros.Size = new Size(801, 563);
            tabPageErros.TabIndex = 1;
            tabPageErros.Text = "Erros";
            tabPageErros.UseVisualStyleBackColor = true;
            // 
            // dataGridErros
            // 
            dataGridErros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridErros.Location = new Point(0, 0);
            dataGridErros.Name = "dataGridErros";
            dataGridErros.ReadOnly = true;
            dataGridErros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridErros.Size = new Size(805, 567);
            dataGridErros.TabIndex = 0;
            // 
            // WinObjetos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 634);
            Controls.Add(tabControl1);
            Controls.Add(btnSpecBody);
            KeyPreview = true;
            Name = "WinObjetos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Package";
            Load += WinPackage_Load;
            KeyDown += WinObjetos_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPageCodigo.ResumeLayout(false);
            tabPageErros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridErros).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rtSource;
        private Button btnSpecBody;
        private TabControl tabControl1;
        private TabPage tabPageCodigo;
        private TabPage tabPageErros;
        private DataGridView dataGridErros;
    }
}