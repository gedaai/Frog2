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
            btnExecutar = new Button();
            txtConexaoBanco = new TextBox();
            btnConectar = new Button();
            txtGrid = new DataGridView();
            lblStatus = new Label();
            txtArea = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtGrid).BeginInit();
            SuspendLayout();
            // 
            // btnExecutar
            // 
            btnExecutar.Enabled = false;
            btnExecutar.Location = new Point(14, 443);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(88, 23);
            btnExecutar.TabIndex = 1;
            btnExecutar.Text = "Executar (F9)";
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
            txtGrid.Location = new Point(12, 231);
            txtGrid.Name = "txtGrid";
            txtGrid.Size = new Size(577, 206);
            txtGrid.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(503, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Não conectado";
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(12, 46);
            txtArea.Multiline = true;
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(577, 179);
            txtArea.TabIndex = 6;
            txtArea.Text = "select iduc, idregiao \r\n  from uc_mig \r\nwhere rownum <= 2\r\n\r\nselect sysdate\r\n  from dual\r\n\r\npkg_mig_uc\r\npkg_mig_pontosc\r\n\r\ntbi_uc_mig\r\ntbi_pontosc";
            txtArea.WordWrap = false;
            txtArea.KeyDown += txtArea_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 473);
            Controls.Add(txtArea);
            Controls.Add(lblStatus);
            Controls.Add(txtGrid);
            Controls.Add(btnConectar);
            Controls.Add(txtConexaoBanco);
            Controls.Add(btnExecutar);
            Name = "Form1";
            Text = "Frog 1.1.1.0";
            ((System.ComponentModel.ISupportInitialize)txtGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExecutar;
        private TextBox txtConexaoBanco;
        private Button btnConectar;
        private DataGridView txtGrid;
        private Label lblStatus;
        private TextBox txtArea;
    }
}
