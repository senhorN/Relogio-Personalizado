
namespace Despertador
{
    partial class forms
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.tmrAtual = new System.Windows.Forms.Timer(this.components);
            this.mskDespertar = new System.Windows.Forms.MaskedTextBox();
            this.chkAtivar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraAtual.Location = new System.Drawing.Point(310, 133);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(203, 47);
            this.lblHoraAtual.TabIndex = 0;
            this.lblHoraAtual.Text = "00:00:00";
            this.lblHoraAtual.Click += new System.EventHandler(this.label1_Click);
            // 
            // tmrAtual
            // 
            this.tmrAtual.Enabled = true;
            this.tmrAtual.Interval = 1000;
            this.tmrAtual.Tick += new System.EventHandler(this.tmrAtual_Tick);
            // 
            // mskDespertar
            // 
            this.mskDespertar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mskDespertar.Font = new System.Drawing.Font("DS-Digital", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDespertar.Location = new System.Drawing.Point(310, 183);
            this.mskDespertar.Mask = "00:00:00";
            this.mskDespertar.Name = "mskDespertar";
            this.mskDespertar.Size = new System.Drawing.Size(180, 31);
            this.mskDespertar.TabIndex = 1;
            this.mskDespertar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDespertar.ValidatingType = typeof(System.DateTime);
            this.mskDespertar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDespertar_MaskInputRejected);
            // 
            // chkAtivar
            // 
            this.chkAtivar.AutoSize = true;
            this.chkAtivar.Location = new System.Drawing.Point(438, 220);
            this.chkAtivar.Name = "chkAtivar";
            this.chkAtivar.Size = new System.Drawing.Size(52, 17);
            this.chkAtivar.TabIndex = 2;
            this.chkAtivar.Text = "ativar";
            this.chkAtivar.UseVisualStyleBackColor = true;
            // 
            // forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkAtivar);
            this.Controls.Add(this.mskDespertar);
            this.Controls.Add(this.lblHoraAtual);
            this.Name = "forms";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Timer tmrAtual;
        private System.Windows.Forms.MaskedTextBox mskDespertar;
        private System.Windows.Forms.CheckBox chkAtivar;
    }
}

