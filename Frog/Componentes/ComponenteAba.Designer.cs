namespace Frog.Componentes
{
    partial class ComponenteAba
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            txtArea = new TextBox();
            tabResultados = new TabControl();
            tabPageDados = new TabPage();
            txtGrid = new DataGridView();
            tabPageResultados = new TabPage();
            txtLog = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabResultados.SuspendLayout();
            tabPageDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtGrid).BeginInit();
            tabPageResultados.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtArea);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabResultados);
            splitContainer1.Size = new Size(656, 488);
            splitContainer1.SplitterDistance = 310;
            splitContainer1.TabIndex = 0;
            // 
            // txtArea
            // 
            txtArea.AcceptsTab = true;
            txtArea.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArea.Location = new Point(3, 3);
            txtArea.Multiline = true;
            txtArea.Name = "txtArea";
            txtArea.ScrollBars = ScrollBars.Both;
            txtArea.Size = new Size(650, 304);
            txtArea.TabIndex = 0;
            txtArea.KeyDown += txtArea_KeyDown;
            // 
            // tabResultados
            // 
            tabResultados.Controls.Add(tabPageDados);
            tabResultados.Controls.Add(tabPageResultados);
            tabResultados.Location = new Point(3, 17);
            tabResultados.Name = "tabResultados";
            tabResultados.SelectedIndex = 0;
            tabResultados.Size = new Size(650, 157);
            tabResultados.TabIndex = 0;
            // 
            // tabPageDados
            // 
            tabPageDados.Controls.Add(txtGrid);
            tabPageDados.Location = new Point(4, 24);
            tabPageDados.Name = "tabPageDados";
            tabPageDados.Padding = new Padding(3);
            tabPageDados.Size = new Size(642, 129);
            tabPageDados.TabIndex = 0;
            tabPageDados.Text = "Dados";
            tabPageDados.UseVisualStyleBackColor = true;
            // 
            // txtGrid
            // 
            txtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            txtGrid.EditMode = DataGridViewEditMode.EditOnF2;
            txtGrid.Location = new Point(0, 3);
            txtGrid.Name = "txtGrid";
            txtGrid.Size = new Size(642, 126);
            txtGrid.TabIndex = 0;
            // 
            // tabPageResultados
            // 
            tabPageResultados.Controls.Add(txtLog);
            tabPageResultados.Location = new Point(4, 24);
            tabPageResultados.Name = "tabPageResultados";
            tabPageResultados.Padding = new Padding(3);
            tabPageResultados.Size = new Size(642, 126);
            tabPageResultados.TabIndex = 1;
            tabPageResultados.Text = "Resultado";
            tabPageResultados.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(0, 0);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Both;
            txtLog.Size = new Size(642, 143);
            txtLog.TabIndex = 0;
            // 
            // ComponenteAba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ComponenteAba";
            Size = new Size(656, 488);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabResultados.ResumeLayout(false);
            tabPageDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtGrid).EndInit();
            tabPageResultados.ResumeLayout(false);
            tabPageResultados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtArea;
        private TabControl tabResultados;
        private TabPage tabPageDados;
        private TabPage tabPageResultados;
        private DataGridView txtGrid;
        private TextBox txtLog;
    }
}
