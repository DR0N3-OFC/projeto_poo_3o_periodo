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
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(340, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(360, 107);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(228, 23);
            this.tbEmail.TabIndex = 1;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(360, 182);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(228, 23);
            this.tbSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(340, 155);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 15);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(513, 229);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(75, 23);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 361);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmail;
        private TextBox tbEmail;
        private TextBox tbSenha;
        private Label lblSenha;
        private Button btEntrar;
    }
}