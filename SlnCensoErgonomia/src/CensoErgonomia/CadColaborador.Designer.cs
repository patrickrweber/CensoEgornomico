
namespace CensoErgonomia
{
    partial class CadColaborador
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
            this.labelCadastro = new System.Windows.Forms.Label();
            this.labelTurno = new System.Windows.Forms.Label();
            this.labelSetor = new System.Windows.Forms.Label();
            this.labelFuncao = new System.Windows.Forms.Label();
            this.TxtCadastro = new System.Windows.Forms.TextBox();
            this.ListBoxSetor = new System.Windows.Forms.ListBox();
            this.ListBoxFuncao = new System.Windows.Forms.ListBox();
            this.LbTurno = new System.Windows.Forms.ListBox();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastro.Location = new System.Drawing.Point(13, 32);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(89, 24);
            this.labelCadastro.TabIndex = 0;
            this.labelCadastro.Text = "Cadastro:";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurno.Location = new System.Drawing.Point(13, 95);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(66, 24);
            this.labelTurno.TabIndex = 1;
            this.labelTurno.Text = "Turno:";
            // 
            // labelSetor
            // 
            this.labelSetor.AutoSize = true;
            this.labelSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetor.Location = new System.Drawing.Point(13, 213);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(59, 24);
            this.labelSetor.TabIndex = 2;
            this.labelSetor.Text = "Setor:";
            // 
            // labelFuncao
            // 
            this.labelFuncao.AutoSize = true;
            this.labelFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncao.Location = new System.Drawing.Point(298, 213);
            this.labelFuncao.Name = "labelFuncao";
            this.labelFuncao.Size = new System.Drawing.Size(80, 24);
            this.labelFuncao.TabIndex = 3;
            this.labelFuncao.Text = "Função:";
            // 
            // TxtCadastro
            // 
            this.TxtCadastro.Location = new System.Drawing.Point(109, 35);
            this.TxtCadastro.Name = "TxtCadastro";
            this.TxtCadastro.Size = new System.Drawing.Size(167, 20);
            this.TxtCadastro.TabIndex = 4;
            // 
            // ListBoxSetor
            // 
            this.ListBoxSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxSetor.FormattingEnabled = true;
            this.ListBoxSetor.ItemHeight = 20;
            this.ListBoxSetor.Items.AddRange(new object[] {
            "Fiacao",
            "Tecelagem",
            "Preparacao Tecelagem",
            "Confeccao Felpudo",
            "Confeccao Cama",
            "Beneficiamento"});
            this.ListBoxSetor.Location = new System.Drawing.Point(109, 213);
            this.ListBoxSetor.Name = "ListBoxSetor";
            this.ListBoxSetor.Size = new System.Drawing.Size(183, 184);
            this.ListBoxSetor.TabIndex = 6;
            this.ListBoxSetor.SelectedIndexChanged += new System.EventHandler(this.ListBoxSetor_SelectedIndexChanged);
            // 
            // ListBoxFuncao
            // 
            this.ListBoxFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxFuncao.FormattingEnabled = true;
            this.ListBoxFuncao.ItemHeight = 20;
            this.ListBoxFuncao.Location = new System.Drawing.Point(414, 213);
            this.ListBoxFuncao.Name = "ListBoxFuncao";
            this.ListBoxFuncao.Size = new System.Drawing.Size(239, 184);
            this.ListBoxFuncao.TabIndex = 7;
            // 
            // LbTurno
            // 
            this.LbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTurno.FormattingEnabled = true;
            this.LbTurno.ItemHeight = 20;
            this.LbTurno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "Geral"});
            this.LbTurno.Location = new System.Drawing.Point(109, 95);
            this.LbTurno.Name = "LbTurno";
            this.LbTurno.Size = new System.Drawing.Size(75, 84);
            this.LbTurno.TabIndex = 8;
            // 
            // BtnProximo
            // 
            this.BtnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProximo.Location = new System.Drawing.Point(623, 413);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(116, 32);
            this.BtnProximo.TabIndex = 9;
            this.BtnProximo.Text = "Próximo";
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(-1, 413);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(116, 32);
            this.BtnVoltar.TabIndex = 10;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // CadColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 445);
            this.ControlBox = false;
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.LbTurno);
            this.Controls.Add(this.ListBoxFuncao);
            this.Controls.Add(this.ListBoxSetor);
            this.Controls.Add(this.TxtCadastro);
            this.Controls.Add(this.labelFuncao);
            this.Controls.Add(this.labelSetor);
            this.Controls.Add(this.labelTurno);
            this.Controls.Add(this.labelCadastro);
            this.Name = "CadColaborador";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Colaborador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.Label labelTurno;
        private System.Windows.Forms.Label labelSetor;
        private System.Windows.Forms.Label labelFuncao;
        private System.Windows.Forms.TextBox TxtCadastro;
        private System.Windows.Forms.ListBox ListBoxSetor;
        private System.Windows.Forms.ListBox ListBoxFuncao;
        private System.Windows.Forms.ListBox LbTurno;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnVoltar;
    }
}