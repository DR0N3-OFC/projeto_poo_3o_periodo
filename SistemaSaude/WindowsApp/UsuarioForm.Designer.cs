namespace WindowsApp
{
    partial class UsuarioForm
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btCriarConta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblSenhaTitle = new System.Windows.Forms.Label();
            this.lblDataCadastroTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(56, 15);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(290, 21);
            this.tbNome.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(56, 55);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(290, 21);
            this.tbEmail.TabIndex = 3;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(54, 94);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(292, 21);
            this.tbLogin.TabIndex = 5;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(54, 133);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(207, 21);
            this.tbSenha.TabIndex = 7;
            // 
            // btCriarConta
            // 
            this.btCriarConta.Location = new System.Drawing.Point(271, 131);
            this.btCriarConta.Name = "btCriarConta";
            this.btCriarConta.Size = new System.Drawing.Size(75, 23);
            this.btCriarConta.TabIndex = 8;
            this.btCriarConta.Text = "Criar conta";
            this.btCriarConta.UseVisualStyleBackColor = true;
            this.btCriarConta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha:";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(12, 176);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(86, 13);
            this.lblDados.TabIndex = 13;
            this.lblDados.Text = "Dados da conta:";
            this.lblDados.Visible = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(104, 200);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 13);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "texto do login";
            this.lblLogin.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(109, 225);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(80, 13);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "texto da senha";
            this.lblSenha.Visible = false;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(162, 247);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(89, 13);
            this.lblDataCadastro.TabIndex = 16;
            this.lblDataCadastro.Text = "data do cadastro";
            this.lblDataCadastro.Visible = false;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Location = new System.Drawing.Point(62, 200);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(36, 13);
            this.lblLoginTitle.TabIndex = 17;
            this.lblLoginTitle.Text = "Login:";
            this.lblLoginTitle.Visible = false;
            // 
            // lblSenhaTitle
            // 
            this.lblSenhaTitle.AutoSize = true;
            this.lblSenhaTitle.Location = new System.Drawing.Point(62, 225);
            this.lblSenhaTitle.Name = "lblSenhaTitle";
            this.lblSenhaTitle.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaTitle.TabIndex = 18;
            this.lblSenhaTitle.Text = "Senha:";
            this.lblSenhaTitle.Visible = false;
            // 
            // lblDataCadastroTitle
            // 
            this.lblDataCadastroTitle.AutoSize = true;
            this.lblDataCadastroTitle.Location = new System.Drawing.Point(62, 247);
            this.lblDataCadastroTitle.Name = "lblDataCadastroTitle";
            this.lblDataCadastroTitle.Size = new System.Drawing.Size(94, 13);
            this.lblDataCadastroTitle.TabIndex = 19;
            this.lblDataCadastroTitle.Text = "Data do cadastro:";
            this.lblDataCadastroTitle.Visible = false;
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 281);
            this.Controls.Add(this.lblDataCadastroTitle);
            this.Controls.Add(this.lblSenhaTitle);
            this.Controls.Add(this.lblLoginTitle);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCriarConta);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNome);
            this.Name = "UsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbNome;
        private TextBox tbEmail;
        private TextBox tbLogin;
        private TextBox tbSenha;
        private Button btCriarConta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblDados;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblDataCadastro;
        private Label lblLoginTitle;
        private Label lblSenhaTitle;
        private Label lblDataCadastroTitle;
    }
}