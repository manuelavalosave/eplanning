namespace Sitestema_de_gestion_de_cursos
{
    partial class Agregar_Materia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Materia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMateria = new System.Windows.Forms.DataGridView();
            this.nmbredelamateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbSemestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMateria)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cmbMateria);
            this.groupBox1.Controls.Add(this.CmbSemestre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(57, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materia";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbMateria
            // 
            this.cmbMateria.AllowUserToDeleteRows = false;
            this.cmbMateria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cmbMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nmbredelamateria,
            this.seleccionar,
            this.grupo});
            this.cmbMateria.Location = new System.Drawing.Point(43, 88);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(346, 173);
            this.cmbMateria.TabIndex = 7;
            // 
            // nmbredelamateria
            // 
            this.nmbredelamateria.HeaderText = "Nombre De La Materia";
            this.nmbredelamateria.Name = "nmbredelamateria";
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            // 
            // grupo
            // 
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            // 
            // CmbSemestre
            // 
            this.CmbSemestre.FormattingEnabled = true;
            this.CmbSemestre.Items.AddRange(new object[] {
            "SEMESTRE 1",
            "SEMESTRE 2",
            "SEMESTRE 3",
            "SEMESTRE 4",
            "SEMESTRE 5",
            "SEMESTRE 6"});
            this.CmbSemestre.Location = new System.Drawing.Point(192, 12);
            this.CmbSemestre.Name = "CmbSemestre";
            this.CmbSemestre.Size = new System.Drawing.Size(166, 21);
            this.CmbSemestre.TabIndex = 3;
            this.CmbSemestre.SelectedIndexChanged += new System.EventHandler(this.CmbSemestre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione Semestre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar la Materia";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(373, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 33);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Agregar Materia";
            // 
            // Agregar_Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Agregar_Materia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Agregar_Materia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMateria)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.ComboBox CmbSemestre;
        private System.Windows.Forms.DataGridView cmbMateria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmbredelamateria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}