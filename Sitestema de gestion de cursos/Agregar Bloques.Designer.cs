namespace Sitestema_de_gestion_de_cursos
{
    partial class demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(demo));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.A_id_bloque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloBloque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A_id_bloque,
            this.TituloBloque,
            this.Parcial,
            this.Porcentaje,
            this.Column4,
            this.Eliminar,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(12, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(809, 230);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // A_id_bloque
            // 
            this.A_id_bloque.HeaderText = "Intificador";
            this.A_id_bloque.Name = "A_id_bloque";
            this.A_id_bloque.ReadOnly = true;
            this.A_id_bloque.Visible = false;
            // 
            // TituloBloque
            // 
            this.TituloBloque.DataPropertyName = "TituloBloque";
            this.TituloBloque.HeaderText = "Titulo";
            this.TituloBloque.Name = "TituloBloque";
            this.TituloBloque.ReadOnly = true;
            // 
            // Parcial
            // 
            this.Parcial.DataPropertyName = "Parcial";
            this.Parcial.HeaderText = "Parcial";
            this.Parcial.Name = "Parcial";
            this.Parcial.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "Porcentaje";
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Editar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ver actividades";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(700, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblname.Location = new System.Drawing.Point(25, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 33);
            this.panel1.TabIndex = 7;
            // 
            // demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "demo";
            this.Text = "BLOQUES";
            this.Load += new System.EventHandler(this.demo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_id_bloque;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloBloque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}