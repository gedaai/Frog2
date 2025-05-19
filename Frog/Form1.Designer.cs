namespace Frog
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
            txtArea = new TextBox();
            btnExecutar = new Button();
            txtConexaoBanco = new TextBox();
            btnConectar = new Button();
            txtGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)txtGrid).BeginInit();
            SuspendLayout();
            // 
            // txtArea
            // 
            txtArea.Location = new Point(12, 42);
            txtArea.Multiline = true;
            txtArea.Name = "txtArea";
            txtArea.ScrollBars = ScrollBars.Both;
            txtArea.Size = new Size(486, 107);
            txtArea.TabIndex = 0;
            txtArea.Text = "select iduc, idregiao from uc_mig where rownum <= 2";
            txtArea.WordWrap = false;
            txtArea.TextChanged += textBox1_TextChanged;
            txtArea.KeyDown += txtArea_KeyDown;
            // 
            // btnExecutar
            // 
            btnExecutar.Enabled = false;
            btnExecutar.Location = new Point(14, 367);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(75, 23);
            btnExecutar.TabIndex = 1;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // txtConexaoBanco
            // 
            txtConexaoBanco.Location = new Point(12, 13);
            txtConexaoBanco.Name = "txtConexaoBanco";
            txtConexaoBanco.Size = new Size(403, 23);
            txtConexaoBanco.TabIndex = 2;
            txtConexaoBanco.Text = "User Id=e2desenv;Password=usetudo;Data Source=192.168.0.2:1521/desenve2";
            txtConexaoBanco.TextChanged += textBox2_TextChanged;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(421, 12);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 3;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtGrid
            // 
            txtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            txtGrid.EditMode = DataGridViewEditMode.EditOnF2;
            txtGrid.Location = new Point(12, 155);
            txtGrid.Name = "txtGrid";
            txtGrid.Size = new Size(484, 206);
            txtGrid.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 397);
            Controls.Add(txtGrid);
            Controls.Add(btnConectar);
            Controls.Add(txtConexaoBanco);
            Controls.Add(btnExecutar);
            Controls.Add(txtArea);
            Name = "Form1";
            Text = "Frog 1.1.1.0";
            ((System.ComponentModel.ISupportInitialize)txtGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArea;
        private Button btnExecutar;
        private TextBox txtConexaoBanco;
        private Button btnConectar;
        private DataGridView txtGrid;
    }
}
