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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnExecutar = new Button();
            txtConexaoBanco = new TextBox();
            btnConectar = new Button();
            lblStatus = new Label();
            btnCommit = new Button();
            btnRollback = new Button();
            panel1 = new Panel();
            panelMenu = new Panel();
            comboConexoes = new ComboBox();
            SuspendLayout();
            // 
            // btnExecutar
            // 
            btnExecutar.Enabled = false;
            btnExecutar.Location = new Point(14, 535);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(88, 23);
            btnExecutar.TabIndex = 1;
            btnExecutar.Text = "Executar (F9)";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Visible = false;
            // 
            // txtConexaoBanco
            // 
            txtConexaoBanco.Location = new Point(185, 8);
            txtConexaoBanco.Name = "txtConexaoBanco";
            txtConexaoBanco.Size = new Size(469, 23);
            txtConexaoBanco.TabIndex = 2;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(660, 7);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(82, 23);
            btnConectar.TabIndex = 3;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(742, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Não conectado";
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(104, 535);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 7;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Visible = false;
            btnCommit.Click += btnCommit_Click;
            // 
            // btnRollback
            // 
            btnRollback.Location = new Point(182, 535);
            btnRollback.Name = "btnRollback";
            btnRollback.Size = new Size(75, 23);
            btnRollback.TabIndex = 8;
            btnRollback.Text = "Rollback";
            btnRollback.UseVisualStyleBackColor = true;
            btnRollback.Visible = false;
            btnRollback.Click += btnRollback_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 463);
            panel1.TabIndex = 10;
            // 
            // panelMenu
            // 
            panelMenu.Location = new Point(12, 37);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(645, 25);
            panelMenu.TabIndex = 11;
            panelMenu.Visible = false;
            // 
            // comboConexoes
            // 
            comboConexoes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboConexoes.FormattingEnabled = true;
            comboConexoes.Location = new Point(12, 8);
            comboConexoes.Name = "comboConexoes";
            comboConexoes.Size = new Size(167, 23);
            comboConexoes.TabIndex = 12;
            comboConexoes.SelectedValueChanged += comboConexoes_SelectedValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 564);
            Controls.Add(comboConexoes);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Controls.Add(btnRollback);
            Controls.Add(btnCommit);
            Controls.Add(lblStatus);
            Controls.Add(btnConectar);
            Controls.Add(txtConexaoBanco);
            Controls.Add(btnExecutar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frog 1.1.1.0";
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExecutar;
        private TextBox txtConexaoBanco;
        private Button btnConectar;
        private Label lblStatus;
        private Button btnCommit;
        private Button btnRollback;
        private Panel panel1;
        private Panel panelMenu;
        private ComboBox comboConexoes;
    }
}
