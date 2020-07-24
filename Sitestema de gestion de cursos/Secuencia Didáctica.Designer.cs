namespace Sitestema_de_gestion_de_cursos
{
    partial class Planificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planificacion));
            this.TxtActividad = new System.Windows.Forms.TextBox();
            this.TxtSesion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sesiones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.lblTituloBloque = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblApertura = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnagregarD = new System.Windows.Forms.Button();
            this.lblDesarrollo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtActivD = new System.Windows.Forms.TextBox();
            this.txtsesiond = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.lblCierre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtactividadC = new System.Windows.Forms.TextBox();
            this.txtsesionc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtActividad
            // 
            this.TxtActividad.Location = new System.Drawing.Point(122, 61);
            this.TxtActividad.Name = "TxtActividad";
            this.TxtActividad.Size = new System.Drawing.Size(199, 25);
            this.TxtActividad.TabIndex = 1;
            // 
            // TxtSesion
            // 
            this.TxtSesion.Location = new System.Drawing.Point(122, 89);
            this.TxtSesion.Name = "TxtSesion";
            this.TxtSesion.Size = new System.Drawing.Size(100, 25);
            this.TxtSesion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Evalucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actividad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sesion";
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.Sesiones});
            this.listView1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(46, 461);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(629, 137);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sugerencia Didactica";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Actividad";
            this.columnHeader2.Width = 300;
            // 
            // Sesiones
            // 
            this.Sesiones.Text = "Sesion";
            this.Sesiones.Width = 75;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Red;
            this.BtnGuardar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Location = new System.Drawing.Point(568, 616);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(97, 36);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // lblTituloBloque
            // 
            this.lblTituloBloque.AutoSize = true;
            this.lblTituloBloque.Location = new System.Drawing.Point(76, 9);
            this.lblTituloBloque.Name = "lblTituloBloque";
            this.lblTituloBloque.Size = new System.Drawing.Size(0, 13);
            this.lblTituloBloque.TabIndex = 8;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregar.Location = new System.Drawing.Point(504, 58);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(87, 28);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblApertura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtActividad);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.TxtSesion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 122);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Apertura";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(132, 27);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(77, 17);
            this.lblApertura.TabIndex = 6;
            this.lblApertura.Text = "Apertura";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.btnagregarD);
            this.groupBox2.Controls.Add(this.lblDesarrollo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtActivD);
            this.groupBox2.Controls.Add(this.txtsesiond);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(46, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 122);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Desarrollo";
            // 
            // btnagregarD
            // 
            this.btnagregarD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagregarD.Location = new System.Drawing.Point(504, 64);
            this.btnagregarD.Name = "btnagregarD";
            this.btnagregarD.Size = new System.Drawing.Size(75, 23);
            this.btnagregarD.TabIndex = 10;
            this.btnagregarD.Text = "Agregar";
            this.btnagregarD.UseVisualStyleBackColor = false;
            this.btnagregarD.Click += new System.EventHandler(this.btnagregarD_Click);
            // 
            // lblDesarrollo
            // 
            this.lblDesarrollo.AutoSize = true;
            this.lblDesarrollo.Location = new System.Drawing.Point(132, 27);
            this.lblDesarrollo.Name = "lblDesarrollo";
            this.lblDesarrollo.Size = new System.Drawing.Size(78, 15);
            this.lblDesarrollo.TabIndex = 6;
            this.lblDesarrollo.Text = "Desarrollo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo de Evalucion";
            // 
            // txtActivD
            // 
            this.txtActivD.Location = new System.Drawing.Point(122, 61);
            this.txtActivD.Name = "txtActivD";
            this.txtActivD.Size = new System.Drawing.Size(199, 23);
            this.txtActivD.TabIndex = 1;
            // 
            // txtsesiond
            // 
            this.txtsesiond.Location = new System.Drawing.Point(122, 89);
            this.txtsesiond.Name = "txtsesiond";
            this.txtsesiond.Size = new System.Drawing.Size(100, 23);
            this.txtsesiond.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Actividad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sesion";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.btnAgregarC);
            this.groupBox3.Controls.Add(this.lblCierre);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtactividadC);
            this.groupBox3.Controls.Add(this.txtsesionc);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(46, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 122);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Cierre";
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarC.Location = new System.Drawing.Point(504, 59);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarC.TabIndex = 10;
            this.btnAgregarC.Text = "Agregar";
            this.btnAgregarC.UseVisualStyleBackColor = false;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // lblCierre
            // 
            this.lblCierre.AutoSize = true;
            this.lblCierre.Location = new System.Drawing.Point(132, 27);
            this.lblCierre.Name = "lblCierre";
            this.lblCierre.Size = new System.Drawing.Size(49, 15);
            this.lblCierre.TabIndex = 6;
            this.lblCierre.Text = "Cierre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tipo de Evalucion";
            // 
            // txtactividadC
            // 
            this.txtactividadC.Location = new System.Drawing.Point(122, 61);
            this.txtactividadC.Name = "txtactividadC";
            this.txtactividadC.Size = new System.Drawing.Size(199, 23);
            this.txtactividadC.TabIndex = 1;
            // 
            // txtsesionc
            // 
            this.txtsesionc.Location = new System.Drawing.Point(122, 89);
            this.txtsesionc.Name = "txtsesionc";
            this.txtsesionc.Size = new System.Drawing.Size(100, 23);
            this.txtsesionc.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Actividad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Sesion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 34);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Secuencia Didáctica";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Location = new System.Drawing.Point(660, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 34);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(692, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 15);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 658);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(724, 22);
            this.panel3.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(43, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Evidencias del logro de Competencias";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Planificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(724, 680);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTituloBloque);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "Planificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Secuencia Didáctica";
            this.Load += new System.EventHandler(this.Planificacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtActividad;
        private System.Windows.Forms.TextBox TxtSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader Sesiones;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label lblTituloBloque;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDesarrollo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtActivD;
        private System.Windows.Forms.TextBox txtsesiond;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCierre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtactividadC;
        private System.Windows.Forms.TextBox txtsesionc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnagregarD;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}