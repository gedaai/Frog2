namespace Frog.Componentes
{
    partial class ComponenteBarraMenus
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
            btnExecutar = new Button();
            btnCommit = new Button();
            btnRollback = new Button();
            SuspendLayout();
            // 
            // btnExecutar
            // 
            btnExecutar.Image = Properties.Resources.raio_preto;
            btnExecutar.Location = new Point(0, 0);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(33, 26);
            btnExecutar.TabIndex = 0;
            btnExecutar.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            btnCommit.Image = Properties.Resources.commit;
            btnCommit.Location = new Point(30, 0);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(33, 26);
            btnCommit.TabIndex = 1;
            btnCommit.UseVisualStyleBackColor = true;
            // 
            // btnRollback
            // 
            btnRollback.Image = Properties.Resources.raio_preto;
            btnRollback.Location = new Point(60, 0);
            btnRollback.Name = "btnRollback";
            btnRollback.Size = new Size(33, 26);
            btnRollback.TabIndex = 2;
            btnRollback.UseVisualStyleBackColor = true;
            // 
            // ComponenteBarraMenus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRollback);
            Controls.Add(btnCommit);
            Controls.Add(btnExecutar);
            Name = "ComponenteBarraMenus";
            Size = new Size(496, 26);
            ResumeLayout(false);
        }

        #endregion

        private Button btnExecutar;
        private Button btnCommit;
        private Button btnRollback;
    }
}
