namespace WindowsApp
{
    partial class MainMeForm
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
            this.btConsultasAgendadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConsultasAgendadas
            // 
            this.btConsultasAgendadas.Location = new System.Drawing.Point(107, 198);
            this.btConsultasAgendadas.Name = "btConsultasAgendadas";
            this.btConsultasAgendadas.Size = new System.Drawing.Size(75, 23);
            this.btConsultasAgendadas.TabIndex = 0;
            this.btConsultasAgendadas.Text = "Entrar";
            this.btConsultasAgendadas.UseVisualStyleBackColor = true;
            this.btConsultasAgendadas.Click += new System.EventHandler(this.btConsultasAgendadas_Click);
            // 
            // MainMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btConsultasAgendadas);
            this.Name = "MainMeForm";
            this.Text = "MainMeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btConsultasAgendadas;
    }
}