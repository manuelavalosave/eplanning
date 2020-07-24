namespace Sitestema_de_gestion_de_cursos
{
    partial class Demo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo2));
            this.ricDesempeño = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtporcentaje = new System.Windows.Forms.TextBox();
            this.cmbParcial = new System.Windows.Forms.ComboBox();
            this.txtTituloBloque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblmateria = new System.Windows.Forms.Label();
            this.dtbDatos = new System.Windows.Forms.DataGridView();
            this.dtgNombre_bloque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desempeño = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ricDesempeño
            // 
            this.ricDesempeño.Location = new System.Drawing.Point(58, 157);
            this.ricDesempeño.Name = "ricDesempeño";
            this.ricDesempeño.Size = new System.Drawing.Size(519, 114);
            this.ricDesempeño.TabIndex = 3;
            this.ricDesempeño.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ricDesempeño);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtporcentaje);
            this.groupBox1.Controls.Add(this.cmbParcial);
            this.groupBox1.Controls.Add(this.txtTituloBloque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Desempeños del estudiante/Resultado de aprendizaje ";
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.Location = new System.Drawing.Point(123, 92);
            this.txtporcentaje.MaxLength = 2;
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(100, 20);
            this.txtporcentaje.TabIndex = 4;
            this.txtporcentaje.TextChanged += new System.EventHandler(this.txtporcentaje_TextChanged);
            this.txtporcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtporcentaje_KeyPress);
            // 
            // cmbParcial
            // 
            this.cmbParcial.FormattingEnabled = true;
            this.cmbParcial.Location = new System.Drawing.Point(123, 64);
            this.cmbParcial.Name = "cmbParcial";
            this.cmbParcial.Size = new System.Drawing.Size(217, 22);
            this.cmbParcial.TabIndex = 3;
            // 
            // txtTituloBloque
            // 
            this.txtTituloBloque.Location = new System.Drawing.Point(123, 36);
            this.txtTituloBloque.Name = "txtTituloBloque";
            this.txtTituloBloque.Size = new System.Drawing.Size(383, 20);
            this.txtTituloBloque.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Porcentaje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parcial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo Del Bloque:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(587, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(688, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblmateria
            // 
            this.lblmateria.AutoSize = true;
            this.lblmateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblmateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmateria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmateria.Location = new System.Drawing.Point(0, 0);
            this.lblmateria.Name = "lblmateria";
            this.lblmateria.Size = new System.Drawing.Size(169, 20);
            this.lblmateria.TabIndex = 8;
            this.lblmateria.Text = "Nombre De La Materia";
            // 
            // dtbDatos
            // 
            this.dtbDatos.AllowUserToAddRows = false;
            this.dtbDatos.AllowUserToDeleteRows = false;
            this.dtbDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtbDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgNombre_bloque,
            this.dtParcial,
            this.dtPorcentaje,
            this.Competencia,
            this.desempeño,
            this.Eliminar});
            this.dtbDatos.Location = new System.Drawing.Point(32, 372);
            this.dtbDatos.Name = "dtbDatos";
            this.dtbDatos.ReadOnly = true;
            this.dtbDatos.Size = new System.Drawing.Size(549, 150);
            this.dtbDatos.TabIndex = 9;
            this.dtbDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtbDatos_CellContentClick);
            // 
            // dtgNombre_bloque
            // 
            this.dtgNombre_bloque.HeaderText = "Nombre Del Bloque";
            this.dtgNombre_bloque.Name = "dtgNombre_bloque";
            this.dtgNombre_bloque.ReadOnly = true;
            // 
            // dtParcial
            // 
            this.dtParcial.HeaderText = "Parcial";
            this.dtParcial.Name = "dtParcial";
            this.dtParcial.ReadOnly = true;
            // 
            // dtPorcentaje
            // 
            this.dtPorcentaje.HeaderText = "Porcentaje";
            this.dtPorcentaje.Name = "dtPorcentaje";
            this.dtPorcentaje.ReadOnly = true;
            // 
            // Competencia
            // 
            this.Competencia.HeaderText = "dtgPrecompetencia";
            this.Competencia.Name = "Competencia";
            this.Competencia.ReadOnly = true;
            // 
            // desempeño
            // 
            this.desempeño.HeaderText = "Desempeños";
            this.desempeño.Name = "desempeño";
            this.desempeño.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblmateria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 33);
            this.panel1.TabIndex = 10;
            // 
            // Demo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtbDatos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Demo2";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dosificación de contenidos ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtporcentaje;
        private System.Windows.Forms.ComboBox cmbParcial;
        private System.Windows.Forms.TextBox txtTituloBloque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox ricDesempeño;
        private System.Windows.Forms.Label lblmateria;
        private System.Windows.Forms.DataGridView dtbDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNombre_bloque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competencia;
        private System.Windows.Forms.DataGridViewButtonColumn desempeño;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}