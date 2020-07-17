namespace SistemaHorariosHESAR
{
    partial class FrmRegistro
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
            this.cbxtipousu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnatras = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtconpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxtipousu
            // 
            this.cbxtipousu.FormattingEnabled = true;
            this.cbxtipousu.Location = new System.Drawing.Point(172, 222);
            this.cbxtipousu.Name = "cbxtipousu";
            this.cbxtipousu.Size = new System.Drawing.Size(191, 21);
            this.cbxtipousu.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tipo de usuario";
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(79, 296);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(87, 38);
            this.btnatras.TabIndex = 20;
            this.btnatras.Text = "Atrás";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(172, 87);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(191, 20);
            this.txtpassword.TabIndex = 13;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(71, 87);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(61, 13);
            this.lblpassword.TabIndex = 19;
            this.lblpassword.Text = "Contraseña";
            // 
            // txtconpassword
            // 
            this.txtconpassword.Location = new System.Drawing.Point(172, 130);
            this.txtconpassword.Name = "txtconpassword";
            this.txtconpassword.PasswordChar = '*';
            this.txtconpassword.Size = new System.Drawing.Size(191, 20);
            this.txtconpassword.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Repetir Contaseña";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(172, 183);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(191, 20);
            this.txtmail.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "E-Mail";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(172, 44);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(191, 20);
            this.txtusuario.TabIndex = 11;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(172, 296);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(196, 38);
            this.btnregistrar.TabIndex = 17;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(71, 44);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 12;
            this.lblusuario.Text = "Usuario";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 386);
            this.Controls.Add(this.cbxtipousu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtconpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lblusuario);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxtipousu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtconpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label lblusuario;
    }
}