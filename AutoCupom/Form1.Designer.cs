namespace AutoCupom
{
    partial class AutoCupom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoCupom));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblAtiva_Desativa = new System.Windows.Forms.Label();
            this.txtTeclaAtivacao = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lnkOngameCupom = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(13, 42);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Start";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(107, 42);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Stop";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // lblAtiva_Desativa
            // 
            this.lblAtiva_Desativa.AutoSize = true;
            this.lblAtiva_Desativa.Location = new System.Drawing.Point(12, 19);
            this.lblAtiva_Desativa.Name = "lblAtiva_Desativa";
            this.lblAtiva_Desativa.Size = new System.Drawing.Size(37, 13);
            this.lblAtiva_Desativa.TabIndex = 4;
            this.lblAtiva_Desativa.Text = "Tecla:";
            // 
            // txtTeclaAtivacao
            // 
            this.txtTeclaAtivacao.Location = new System.Drawing.Point(61, 16);
            this.txtTeclaAtivacao.Name = "txtTeclaAtivacao";
            this.txtTeclaAtivacao.Size = new System.Drawing.Size(121, 20);
            this.txtTeclaAtivacao.TabIndex = 5;
            this.txtTeclaAtivacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTeclaAtivacao_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(119, 74);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status: OFF";
            // 
            // lnkOngameCupom
            // 
            this.lnkOngameCupom.AutoSize = true;
            this.lnkOngameCupom.Location = new System.Drawing.Point(10, 74);
            this.lnkOngameCupom.Name = "lnkOngameCupom";
            this.lnkOngameCupom.Size = new System.Drawing.Size(68, 13);
            this.lnkOngameCupom.TabIndex = 7;
            this.lnkOngameCupom.TabStop = true;
            this.lnkOngameCupom.Text = "Acesse aqui!";
            this.lnkOngameCupom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOngameCupom_LinkClicked);
            // 
            // AutoCupom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 96);
            this.Controls.Add(this.lnkOngameCupom);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtTeclaAtivacao);
            this.Controls.Add(this.lblAtiva_Desativa);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoCupom";
            this.ShowIcon = false;
            this.Text = "by: Pixell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblAtiva_Desativa;
        private System.Windows.Forms.TextBox txtTeclaAtivacao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.LinkLabel lnkOngameCupom;
    }
}

