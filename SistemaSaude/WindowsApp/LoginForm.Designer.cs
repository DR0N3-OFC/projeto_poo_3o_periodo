namespace WindowsApp
{
    partial class LoginForm
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btEntrar = new System.Windows.Forms.Button();
            this.cbSouMedico = new System.Windows.Forms.CheckBox();
            this.lblCriarConta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCriarConta = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(291, 69);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(309, 93);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "Seu e-mail";
            this.tbEmail.Size = new System.Drawing.Size(196, 23);
            this.tbEmail.TabIndex = 1;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(309, 158);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PlaceholderText = "Sua senha";
            this.tbSenha.Size = new System.Drawing.Size(196, 23);
            this.tbSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(291, 134);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 15);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // btEntrar
            // 
            this.btEntrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEntrar.Location = new System.Drawing.Point(440, 198);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(64, 23);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // cbSouMedico
            // 
            this.cbSouMedico.AutoSize = true;
            this.cbSouMedico.Location = new System.Drawing.Point(309, 201);
            this.cbSouMedico.Name = "cbSouMedico";
            this.cbSouMedico.Size = new System.Drawing.Size(89, 19);
            this.cbSouMedico.TabIndex = 5;
            this.cbSouMedico.Text = "Sou médico";
            this.cbSouMedico.UseVisualStyleBackColor = true;
            // 
            // lblCriarConta
            // 
            this.lblCriarConta.AutoSize = true;
            this.lblCriarConta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCriarConta.Location = new System.Drawing.Point(39, 99);
            this.lblCriarConta.Name = "lblCriarConta";
            this.lblCriarConta.Size = new System.Drawing.Size(214, 20);
            this.lblCriarConta.TabIndex = 6;
            this.lblCriarConta.Text = "Ainda não possui uma conta?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Crie uma clicando no botão abaixo:";
            // 
            // btCriarConta
            // 
            this.btCriarConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCriarConta.Location = new System.Drawing.Point(106, 162);
            this.btCriarConta.Name = "btCriarConta";
            this.btCriarConta.Size = new System.Drawing.Size(78, 27);
            this.btCriarConta.TabIndex = 8;
            this.btCriarConta.Text = "Criar conta";
            this.btCriarConta.UseVisualStyleBackColor = true;
            this.btCriarConta.Click += new System.EventHandler(this.btCriarConta_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(141, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(373, 19);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Sistema de Atendimento Remoto do Serviço de Saúde";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsApp.Properties.Resources.logosus;
            this.pictureBox1.Location = new System.Drawing.Point(26, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(526, 240);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCriarConta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCriarConta);
            this.Controls.Add(this.cbSouMedico);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Único de Saúde - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmail;
        private TextBox tbEmail;
        private TextBox tbSenha;
        private Label lblSenha;
        private Button btEntrar;
        private CheckBox cbSouMedico;
        private Label lblCriarConta;
        private Label label1;
        private Button btCriarConta;
        private Label lblTitulo;
        private PictureBox pictureBox1;
    }
}