namespace WindowsApp
{
    partial class ReservaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btReservar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.dgvReservados = new System.Windows.Forms.DataGridView();
            this.lblReservas = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservados)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 349F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvMedicamentos, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblData, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtData, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btReservar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbTipo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btVoltar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEspecialidade, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvReservados, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblReservas, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCancelar, 5, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 386);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.AllowUserToDeleteRows = false;
            this.dgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvMedicamentos, 3);
            this.dgvMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicamentos.EnableHeadersVisualStyles = false;
            this.dgvMedicamentos.Location = new System.Drawing.Point(10, 81);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.ReadOnly = true;
            this.dgvMedicamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMedicamentos.RowTemplate.Height = 25;
            this.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamentos.Size = new System.Drawing.Size(711, 274);
            this.dgvMedicamentos.TabIndex = 3;
            this.dgvMedicamentos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_RowEnter);
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(10, 52);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(99, 26);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data de Retirada";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtData
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dtData, 2);
            this.dtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(115, 55);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(606, 21);
            this.dtData.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitulo, 4);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(3, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(718, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reserva de Medicamentos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btReservar
            // 
            this.btReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btReservar, 2);
            this.btReservar.Location = new System.Drawing.Point(10, 361);
            this.btReservar.Name = "btReservar";
            this.btReservar.Size = new System.Drawing.Size(362, 19);
            this.btReservar.TabIndex = 6;
            this.btReservar.Text = "Reservar";
            this.btReservar.UseVisualStyleBackColor = true;
            this.btReservar.Click += new System.EventHandler(this.btReservar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cbTipo, 2);
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(115, 29);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(606, 21);
            this.cbTipo.TabIndex = 2;
            this.cbTipo.SelectedValueChanged += new System.EventHandler(this.cbTipo_SelectedValueChanged);
            // 
            // btVoltar
            // 
            this.btVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btVoltar.Location = new System.Drawing.Point(378, 361);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(343, 19);
            this.btVoltar.TabIndex = 7;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspecialidade.Location = new System.Drawing.Point(10, 30);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(99, 17);
            this.lblEspecialidade.TabIndex = 1;
            this.lblEspecialidade.Text = "Tipo";
            this.lblEspecialidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvReservados
            // 
            this.dgvReservados.AllowUserToAddRows = false;
            this.dgvReservados.AllowUserToDeleteRows = false;
            this.dgvReservados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservados.Location = new System.Drawing.Point(734, 29);
            this.dgvReservados.Name = "dgvReservados";
            this.dgvReservados.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvReservados, 3);
            this.dgvReservados.RowTemplate.Height = 23;
            this.dgvReservados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservados.Size = new System.Drawing.Size(294, 326);
            this.dgvReservados.TabIndex = 8;
            this.dgvReservados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservados_RowEnter);
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReservas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReservas.Location = new System.Drawing.Point(734, 0);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(294, 26);
            this.lblReservas.TabIndex = 9;
            this.lblReservas.Text = "Reservas";
            this.lblReservas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(734, 361);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(294, 19);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar Reserva";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReservaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservaForm_FormClosed);
            this.Load += new System.EventHandler(this.ReservaForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvMedicamentos;
        private Label lblData;
        private DateTimePicker dtData;
        private Label lblTitulo;
        private Button btReservar;
        private ComboBox cbTipo;
        private Button btVoltar;
        private Label lblEspecialidade;
        private DataGridView dgvReservados;
        private Button btCancelar;
        private Label lblReservas;
    }
}