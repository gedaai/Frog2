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
            txtGrid = new DataGridView();
            lblStatus = new Label();
            txtArea = new TextBox();
            btnCommit = new Button();
            btnRollback = new Button();
            tabResultados = new TabControl();
            tabPageDados = new TabPage();
            lblConsultaQtde = new Label();
            tabPageResultados = new TabPage();
            txtLog = new TextBox();
            panel1 = new Panel();
            panelMenu = new Panel();
            ((System.ComponentModel.ISupportInitialize)txtGrid).BeginInit();
            tabResultados.SuspendLayout();
            tabPageDados.SuspendLayout();
            tabPageResultados.SuspendLayout();
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
            btnExecutar.Click += btnExecutar_Click;
            // 
            // txtConexaoBanco
            // 
            txtConexaoBanco.Location = new Point(12, 8);
            txtConexaoBanco.Name = "txtConexaoBanco";
            txtConexaoBanco.Size = new Size(469, 23);
            txtConexaoBanco.TabIndex = 2;
            txtConexaoBanco.Text = "User Id=e2desenv;Password=usetudo;Data Source=192.168.0.2:1521/desenve2";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(487, 7);
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
            txtGrid.Location = new Point(0, 0);
            txtGrid.Name = "txtGrid";
            txtGrid.Size = new Size(235, 213);
            txtGrid.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(569, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Não conectado";
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(694, 57);
            txtArea.Multiline = true;
            txtArea.Name = "txtArea";
            txtArea.ScrollBars = ScrollBars.Both;
            txtArea.Size = new Size(167, 151);
            txtArea.TabIndex = 6;
            txtArea.Text = resources.GetString("txtArea.Text");
            txtArea.WordWrap = false;
            txtArea.KeyDown += txtArea_KeyDown;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(104, 535);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 7;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
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
            btnRollback.Click += btnRollback_Click;
            // 
            // tabResultados
            // 
            tabResultados.Controls.Add(tabPageDados);
            tabResultados.Controls.Add(tabPageResultados);
            tabResultados.Location = new Point(684, 214);
            tabResultados.Name = "tabResultados";
            tabResultados.SelectedIndex = 0;
            tabResultados.Size = new Size(243, 237);
            tabResultados.TabIndex = 9;
            // 
            // tabPageDados
            // 
            tabPageDados.Controls.Add(lblConsultaQtde);
            tabPageDados.Controls.Add(txtGrid);
            tabPageDados.Location = new Point(4, 24);
            tabPageDados.Name = "tabPageDados";
            tabPageDados.Padding = new Padding(3);
            tabPageDados.Size = new Size(235, 209);
            tabPageDados.TabIndex = 0;
            tabPageDados.Text = "Dados";
            tabPageDados.UseVisualStyleBackColor = true;
            // 
            // lblConsultaQtde
            // 
            lblConsultaQtde.AutoSize = true;
            lblConsultaQtde.Font = new Font("Segoe UI", 8F);
            lblConsultaQtde.Location = new Point(0, 194);
            lblConsultaQtde.Name = "lblConsultaQtde";
            lblConsultaQtde.Size = new Size(0, 13);
            lblConsultaQtde.TabIndex = 5;
            // 
            // tabPageResultados
            // 
            tabPageResultados.Controls.Add(txtLog);
            tabPageResultados.Location = new Point(4, 24);
            tabPageResultados.Name = "tabPageResultados";
            tabPageResultados.Padding = new Padding(3);
            tabPageResultados.Size = new Size(235, 209);
            tabPageResultados.TabIndex = 1;
            tabPageResultados.Text = "Resultados";
            tabPageResultados.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(0, 45);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Both;
            txtLog.Size = new Size(641, 164);
            txtLog.TabIndex = 0;
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 564);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Controls.Add(tabResultados);
            Controls.Add(btnRollback);
            Controls.Add(btnCommit);
            Controls.Add(txtArea);
            Controls.Add(lblStatus);
            Controls.Add(btnConectar);
            Controls.Add(txtConexaoBanco);
            Controls.Add(btnExecutar);
            Name = "Form1";
            Text = "Frog 1.1.1.0";
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)txtGrid).EndInit();
            tabResultados.ResumeLayout(false);
            tabPageDados.ResumeLayout(false);
            tabPageDados.PerformLayout();
            tabPageResultados.ResumeLayout(false);
            tabPageResultados.PerformLayout();
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
        private Button btnCommit;
        private Button btnRollback;
        private TabControl tabResultados;
        private TabPage tabPageDados;
        private TabPage tabPageResultados;
        private TextBox txtLog;
        private Label lblConsultaQtde;
        private Panel panel1;
        private Panel panelMenu;
    }
}
