
namespace CensoErgonomia
{
    partial class MenuInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemCadstro = new System.Windows.Forms.ToolStripMenuItem();
            this.ColaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCadstro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemCadstro
            // 
            this.toolStripMenuItemCadstro.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItemCadstro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColaboradorToolStripMenuItem});
            this.toolStripMenuItemCadstro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemCadstro.Name = "toolStripMenuItemCadstro";
            this.toolStripMenuItemCadstro.Size = new System.Drawing.Size(89, 25);
            this.toolStripMenuItemCadstro.Text = "Cadastrar";
            // 
            // ColaboradorToolStripMenuItem
            // 
            this.ColaboradorToolStripMenuItem.Name = "ColaboradorToolStripMenuItem";
            this.ColaboradorToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ColaboradorToolStripMenuItem.Text = "Colaborador";
            this.ColaboradorToolStripMenuItem.Click += new System.EventHandler(this.ColaboradorToolStripMenuItem_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 646);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Censo de Ergonomia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCadstro;
        private System.Windows.Forms.ToolStripMenuItem ColaboradorToolStripMenuItem;
    }
}

