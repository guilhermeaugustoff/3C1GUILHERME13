namespace _3C1GUILHERME13.Ui
{
    partial class Frm_Login
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnklabesqueceu = new System.Windows.Forms.LinkLabel();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(328, 40);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(331, 56);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(169, 20);
            this.txt_email.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 229);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lnklabesqueceu
            // 
            this.lnklabesqueceu.AutoSize = true;
            this.lnklabesqueceu.Location = new System.Drawing.Point(360, 196);
            this.lnklabesqueceu.Name = "lnklabesqueceu";
            this.lnklabesqueceu.Size = new System.Drawing.Size(109, 13);
            this.lnklabesqueceu.TabIndex = 3;
            this.lnklabesqueceu.TabStop = true;
            this.lnklabesqueceu.Text = "Esqueceu sua Senha";
            this.lnklabesqueceu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklabesqueceu_LinkClicked);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(328, 97);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(331, 113);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(169, 20);
            this.txt_senha.TabIndex = 5;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(331, 139);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(169, 44);
            this.btn_entrar.TabIndex = 6;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 250);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lnklabesqueceu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnklabesqueceu;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_entrar;
    }
}