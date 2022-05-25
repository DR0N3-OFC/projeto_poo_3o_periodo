namespace WindowsApp
{
    partial class CadastroFormMe
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.dtDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDados2 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDados1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCRM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDados3 = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitulo.Location = new System.Drawing.Point(18, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(164, 16);
            this.lblTitulo.TabIndex = 65;
            this.lblTitulo.Text = "Cadastro de profissional";
            // 
            // btCadastrar
            // 
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadastrar.Location = new System.Drawing.Point(304, 324);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 64;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(468, 210);
            this.tbTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.PlaceholderText = "(45) 1234-5678";
            this.tbTelefone.Size = new System.Drawing.Size(242, 23);
            this.tbTelefone.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "Telefone";
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(254, 210);
            this.tbRG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbRG.Name = "tbRG";
            this.tbRG.PlaceholderText = "12.345.678-9";
            this.tbRG.Size = new System.Drawing.Size(151, 23);
            this.tbRG.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "RG";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(69, 210);
            this.tbCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.PlaceholderText = "123.456.789-00";
            this.tbCPF.Size = new System.Drawing.Size(151, 23);
            this.tbCPF.TabIndex = 46;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(18, 213);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(28, 15);
            this.labelCPF.TabIndex = 45;
            this.labelCPF.Text = "CPF";
            // 
            // dtDataDeNascimento
            // 
            this.dtDataDeNascimento.Location = new System.Drawing.Point(474, 168);
            this.dtDataDeNascimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtDataDeNascimento.Name = "dtDataDeNascimento";
            this.dtDataDeNascimento.Size = new System.Drawing.Size(237, 23);
            this.dtDataDeNascimento.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Data de Nascimento";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(69, 168);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNome.Name = "tbNome";
            this.tbNome.PlaceholderText = "Juca Oliveira";
            this.tbNome.Size = new System.Drawing.Size(278, 23);
            this.tbNome.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nome";
            // 
            // lblDados2
            // 
            this.lblDados2.AutoSize = true;
            this.lblDados2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDados2.Location = new System.Drawing.Point(15, 132);
            this.lblDados2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDados2.Name = "lblDados2";
            this.lblDados2.Size = new System.Drawing.Size(94, 13);
            this.lblDados2.TabIndex = 40;
            this.lblDados2.Text = "Dados pessoais";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(406, 92);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PlaceholderText = "Usuario123";
            this.tbSenha.Size = new System.Drawing.Size(304, 23);
            this.tbSenha.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Senha";
            // 
            // lblDados1
            // 
            this.lblDados1.AutoSize = true;
            this.lblDados1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDados1.Location = new System.Drawing.Point(18, 55);
            this.lblDados1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDados1.Name = "lblDados1";
            this.lblDados1.Size = new System.Drawing.Size(89, 13);
            this.lblDados1.TabIndex = 37;
            this.lblDados1.Text = "Dados de login";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(69, 92);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "emaildousuario@provedor.com";
            this.tbEmail.Size = new System.Drawing.Size(278, 23);
            this.tbEmail.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "E-mail";
            // 
            // tbCRM
            // 
            this.tbCRM.Location = new System.Drawing.Point(393, 286);
            this.tbCRM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCRM.Name = "tbCRM";
            this.tbCRM.PlaceholderText = "1234567-8/BR";
            this.tbCRM.Size = new System.Drawing.Size(316, 23);
            this.tbCRM.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 69;
            this.label1.Text = "CRM";
            // 
            // lblDados3
            // 
            this.lblDados3.AutoSize = true;
            this.lblDados3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDados3.Location = new System.Drawing.Point(15, 249);
            this.lblDados3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDados3.Name = "lblDados3";
            this.lblDados3.Size = new System.Drawing.Size(116, 13);
            this.lblDados3.TabIndex = 68;
            this.lblDados3.Text = "Dados profissionais";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(15, 288);
            this.lblEspecialidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(78, 15);
            this.lblEspecialidade.TabIndex = 66;
            this.lblEspecialidade.Text = "Especialidade";
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Location = new System.Drawing.Point(105, 285);
            this.cbEspecialidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(240, 23);
            this.cbEspecialidade.TabIndex = 71;
            // 
            // CadastroFormMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 353);
            this.Controls.Add(this.cbEspecialidade);
            this.Controls.Add(this.tbCRM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDados3);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbRG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.dtDataDeNascimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDados2);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDados1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "CadastroFormMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroFormMe";
            this.Deactivate += new System.EventHandler(this.CadastroFormMe_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Button btCadastrar;
        private TextBox tbTelefone;
        private Label label9;
        private TextBox tbRG;
        private Label label8;
        private TextBox tbCPF;
        private Label labelCPF;
        private DateTimePicker dtDataDeNascimento;
        private Label label7;
        private TextBox tbNome;
        private Label label6;
        private Label lblDados2;
        private TextBox tbSenha;
        private Label label4;
        private Label lblDados1;
        private TextBox tbEmail;
        private Label label2;
        private TextBox tbCRM;
        private Label label1;
        private Label lblDados3;
        private Label lblEspecialidade;
        private ComboBox cbEspecialidade;
    }
}