namespace Sitestema_de_gestion_de_cursos
{
    partial class Materias_Guardadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias_Guardadas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docificacion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.P1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.P2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.P3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_materia,
            this.Semestre,
            this.Grupo,
            this.Docificacion,
            this.P1,
            this.P2,
            this.P3});
            this.dataGridView1.Location = new System.Drawing.Point(33, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombre_materia
            // 
            this.nombre_materia.HeaderText = "Nombre de la Materia";
            this.nombre_materia.Name = "nombre_materia";
            this.nombre_materia.ReadOnly = true;
            this.nombre_materia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Semestre
            // 
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.Name = "Semestre";
            this.Semestre.ReadOnly = true;
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupos";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            // 
            // Docificacion
            // 
            this.Docificacion.HeaderText = "Añadir Bloques";
            this.Docificacion.Name = "Docificacion";
            this.Docificacion.ReadOnly = true;
            // 
            // P1
            // 
            this.P1.HeaderText = "Parcial 1";
            this.P1.Name = "P1";
            this.P1.ReadOnly = true;
            this.P1.Text = "Parcial 1";
            this.P1.UseColumnTextForButtonValue = true;
            // 
            // P2
            // 
            this.P2.HeaderText = "Parcial 2";
            this.P2.Name = "P2";
            this.P2.ReadOnly = true;
            // 
            // P3
            // 
            this.P3.HeaderText = "Parcial 3";
            this.P3.Name = "P3";
            this.P3.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(631, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Materia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 35);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materias Guardadas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 24);
            this.panel2.TabIndex = 3;
            // 
            // Materias_Guardadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Materias_Guardadas";
            this.Opacity = 0.9D;
            this.Load += new System.EventHandler(this.Materias_Guardadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewButtonColumn Docificacion;
        private System.Windows.Forms.DataGridViewButtonColumn P1;
        private System.Windows.Forms.DataGridViewButtonColumn P2;
        private System.Windows.Forms.DataGridViewButtonColumn P3;
    }
}