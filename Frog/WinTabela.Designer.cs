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
            panel1 = new Panel();
            tabControlPrincipal = new TabControl();
            tabPagecolunas = new TabPage();
            tabPageTriggers = new TabPage();
            splitContainerTriggers = new SplitContainer();
            dataGridTriggers = new DataGridView();
            txtTriggerSource = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgTabela).BeginInit();
            panel1.SuspendLayout();
            tabControlPrincipal.SuspendLayout();
            tabPagecolunas.SuspendLayout();
            tabPageTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTriggers).BeginInit();
            splitContainerTriggers.Panel1.SuspendLayout();
            splitContainerTriggers.Panel2.SuspendLayout();
            splitContainerTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTriggers).BeginInit();
            SuspendLayout();
            // 
            // dgTabela
            // 
            dgTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTabela.EditMode = DataGridViewEditMode.EditOnF2;
            dgTabela.Location = new Point(0, 0);
            dgTabela.Name = "dgTabela";
            dgTabela.Size = new Size(657, 395);
            dgTabela.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlPrincipal);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 426);
            panel1.TabIndex = 1;
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabPagecolunas);
            tabControlPrincipal.Controls.Add(tabPageTriggers);
            tabControlPrincipal.Location = new Point(3, 3);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(668, 423);
            tabControlPrincipal.TabIndex = 0;
            // 
            // tabPagecolunas
            // 
            tabPagecolunas.Controls.Add(dgTabela);
            tabPagecolunas.Location = new Point(4, 24);
            tabPagecolunas.Name = "tabPagecolunas";
            tabPagecolunas.Padding = new Padding(3);
            tabPagecolunas.Size = new Size(660, 395);
            tabPagecolunas.TabIndex = 0;
            tabPagecolunas.Text = "Colunas";
            tabPagecolunas.UseVisualStyleBackColor = true;
            // 
            // tabPageTriggers
            // 
            tabPageTriggers.Controls.Add(splitContainerTriggers);
            tabPageTriggers.Location = new Point(4, 24);
            tabPageTriggers.Name = "tabPageTriggers";
            tabPageTriggers.Padding = new Padding(3);
            tabPageTriggers.Size = new Size(660, 395);
            tabPageTriggers.TabIndex = 1;
            tabPageTriggers.Text = "Triggers";
            tabPageTriggers.UseVisualStyleBackColor = true;
            // 
            // splitContainerTriggers
            // 
            splitContainerTriggers.Dock = DockStyle.Fill;
            splitContainerTriggers.Location = new Point(3, 3);
            splitContainerTriggers.Name = "splitContainerTriggers";
            splitContainerTriggers.Orientation = Orientation.Horizontal;
            // 
            // splitContainerTriggers.Panel1
            // 
            splitContainerTriggers.Panel1.Controls.Add(dataGridTriggers);
            // 
            // splitContainerTriggers.Panel2
            // 
            splitContainerTriggers.Panel2.Controls.Add(txtTriggerSource);
            splitContainerTriggers.Size = new Size(654, 389);
            splitContainerTriggers.SplitterDistance = 118;
            splitContainerTriggers.TabIndex = 0;
            // 
            // dataGridTriggers
            // 
            dataGridTriggers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTriggers.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridTriggers.Location = new Point(0, 0);
            dataGridTriggers.Name = "dataGridTriggers";
            dataGridTriggers.ReadOnly = true;
            dataGridTriggers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTriggers.Size = new Size(654, 115);
            dataGridTriggers.TabIndex = 0;
            dataGridTriggers.CellClick += dataGridTriggers_CellClick;
            // 
            // txtTriggerSource
            // 
            txtTriggerSource.Location = new Point(0, -1);
            txtTriggerSource.Name = "txtTriggerSource";
            txtTriggerSource.ReadOnly = true;
            txtTriggerSource.Size = new Size(654, 271);
            txtTriggerSource.TabIndex = 0;
            txtTriggerSource.Text = "";
            txtTriggerSource.WordWrap = false;
            // 
            // WinTabela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 688);
            Controls.Add(panel1);
            Name = "WinTabela";
            Text = "Tabela";
            Load += WinTabela_Load;
            Resize += WinTabela_Resize;
            ((System.ComponentModel.ISupportInitialize)dgTabela).EndInit();
            panel1.ResumeLayout(false);
            tabControlPrincipal.ResumeLayout(false);
            tabPagecolunas.ResumeLayout(false);
            tabPageTriggers.ResumeLayout(false);
            splitContainerTriggers.Panel1.ResumeLayout(false);
            splitContainerTriggers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerTriggers).EndInit();
            splitContainerTriggers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridTriggers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgTabela;
        private Panel panel1;
        private TabControl tabControlPrincipal;
        private TabPage tabPagecolunas;
        private TabPage tabPageTriggers;
        private SplitContainer splitContainerTriggers;
        private DataGridView dataGridTriggers;
        private RichTextBox txtTriggerSource;
    }
}