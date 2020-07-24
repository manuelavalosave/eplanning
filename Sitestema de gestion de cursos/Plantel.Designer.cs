namespace Sitestema_de_gestion_de_cursos
{
    partial class Plantel
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
            this.lblname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DGWPlanteles = new System.Windows.Forms.DataGridView();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDepartamento = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.txtplantel = new System.Windows.Forms.TextBox();
            this.plante = new System.Windows.Forms.Label();
            this.TxtNombrePlantel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombreCorto = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCorto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtIdPlantel = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWPlanteles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(25, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(140, 13);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "DATOS DEL PLANTEL ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 33);
            this.panel1.TabIndex = 11;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(625, 50);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(96, 23);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DGWPlanteles
            // 
            this.DGWPlanteles.AllowUserToAddRows = false;
            this.DGWPlanteles.AllowUserToDeleteRows = false;
            this.DGWPlanteles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGWPlanteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWPlanteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.plant,
            this.NombreCorto,
            this.departamento,
            this.direccion,
            this.telefono,
            this.correo,
            this.Editar});
            this.DGWPlanteles.Location = new System.Drawing.Point(28, 229);
            this.DGWPlanteles.Name = "DGWPlanteles";
            this.DGWPlanteles.ReadOnly = true;
            this.DGWPlanteles.Size = new System.Drawing.Size(721, 144);
            this.DGWPlanteles.TabIndex = 22;
            this.DGWPlanteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWPlanteles_CellContentClick);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(229, 183);
            this.TxtCorreo.MaxLength = 100;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(303, 20);
            this.TxtCorreo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "DEPEARTAMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "DIRECCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "TELEFONO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "CORREO";
            // 
            // TxtDepartamento
            // 
            this.TxtDepartamento.Location = new System.Drawing.Point(229, 105);
            this.TxtDepartamento.MaxLength = 100;
            this.TxtDepartamento.Name = "TxtDepartamento";
            this.TxtDepartamento.Size = new System.Drawing.Size(303, 20);
            this.TxtDepartamento.TabIndex = 16;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(229, 131);
            this.TxtDireccion.MaxLength = 100;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(303, 20);
            this.TxtDireccion.TabIndex = 15;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(229, 157);
            this.TxtTelefono.MaxLength = 12;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(303, 20);
            this.TxtTelefono.TabIndex = 14;
            // 
            // txtplantel
            // 
            this.txtplantel.Location = new System.Drawing.Point(216, -34);
            this.txtplantel.Name = "txtplantel";
            this.txtplantel.Size = new System.Drawing.Size(303, 20);
            this.txtplantel.TabIndex = 13;
            // 
            // plante
            // 
            this.plante.AutoSize = true;
            this.plante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plante.Location = new System.Drawing.Point(148, -34);
            this.plante.Name = "plante";
            this.plante.Size = new System.Drawing.Size(62, 13);
            this.plante.TabIndex = 12;
            this.plante.Text = "PLANTEL";
            // 
            // TxtNombrePlantel
            // 
            this.TxtNombrePlantel.Location = new System.Drawing.Point(229, 50);
            this.TxtNombrePlantel.MaxLength = 100;
            this.TxtNombrePlantel.Name = "TxtNombrePlantel";
            this.TxtNombrePlantel.Size = new System.Drawing.Size(303, 20);
            this.TxtNombrePlantel.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "NOMBRE DEL PLANTEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "NOMBRE CORTO";
            // 
            // TxtNombreCorto
            // 
            this.TxtNombreCorto.Location = new System.Drawing.Point(229, 79);
            this.TxtNombreCorto.MaxLength = 50;
            this.TxtNombreCorto.Name = "TxtNombreCorto";
            this.TxtNombreCorto.Size = new System.Drawing.Size(303, 20);
            this.TxtNombreCorto.TabIndex = 25;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_Plantel";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // plant
            // 
            this.plant.DataPropertyName = "Nombre_plantel";
            this.plant.HeaderText = "PLANTEL";
            this.plant.Name = "plant";
            this.plant.ReadOnly = true;
            // 
            // NombreCorto
            // 
            this.NombreCorto.DataPropertyName = "Nombre_corto";
            this.NombreCorto.HeaderText = "NOMBRECORTO";
            this.NombreCorto.Name = "NombreCorto";
            this.NombreCorto.ReadOnly = true;
            // 
            // departamento
            // 
            this.departamento.DataPropertyName = "Departamento";
            this.departamento.HeaderText = "DEPARTAMENTO";
            this.departamento.Name = "departamento";
            this.departamento.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "Correo";
            this.correo.HeaderText = "CORREO";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "EDITAR";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "EDITAR";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // TxtIdPlantel
            // 
            this.TxtIdPlantel.Location = new System.Drawing.Point(642, 123);
            this.TxtIdPlantel.Name = "TxtIdPlantel";
            this.TxtIdPlantel.Size = new System.Drawing.Size(100, 20);
            this.TxtIdPlantel.TabIndex = 26;
            this.TxtIdPlantel.Visible = false;
            // 
            // Plantel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 385);
            this.Controls.Add(this.TxtIdPlantel);
            this.Controls.Add(this.TxtNombreCorto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNombrePlantel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DGWPlanteles);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDepartamento);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.txtplantel);
            this.Controls.Add(this.plante);
            this.Controls.Add(this.panel1);
            this.Name = "Plantel";
            this.Text = "Plantel";
            this.Load += new System.EventHandler(this.Plantel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWPlanteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DGWPlanteles;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDepartamento;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox txtplantel;
        private System.Windows.Forms.Label plante;
        private System.Windows.Forms.TextBox TxtNombrePlantel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNombreCorto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCorto;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.TextBox TxtIdPlantel;
    }
}