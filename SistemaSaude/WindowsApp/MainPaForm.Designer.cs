namespace WindowsApp
{
    partial class MainPaForm
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
            this.btAgendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAgendar
            // 
            this.btAgendar.Location = new System.Drawing.Point(57, 186);
            this.btAgendar.Name = "btAgendar";
            this.btAgendar.Size = new System.Drawing.Size(101, 23);
            this.btAgendar.TabIndex = 0;
            this.btAgendar.Text = "Agendar Consulta";
            this.btAgendar.UseVisualStyleBackColor = true;
            this.btAgendar.Click += new System.EventHandler(this.btAgendar_Click);
            // 
            // MainPaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAgendar);
            this.Name = "MainPaForm";
            this.Text = "MainPaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btAgendar;
    }
}