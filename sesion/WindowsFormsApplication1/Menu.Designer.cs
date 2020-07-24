namespace WindowsFormsApplication1
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.agregarMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosificaciónDeContenidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiAgregarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiImportarListaDeAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.Ph1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeslizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.Ph1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton5,
            this.toolStripSplitButton1,
            this.toolStripSeparator2,
            this.toolStripSplitButton2,
            this.toolStripSeparator1,
            this.toolStripSplitButton3,
            this.toolStripSeparator3,
            this.toolStripSplitButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(860, 125);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton5
            // 
            this.toolStripSplitButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripSplitButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton5.Image")));
            this.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton5.Name = "toolStripSplitButton5";
            this.toolStripSplitButton5.Size = new System.Drawing.Size(193, 122);
            this.toolStripSplitButton5.Text = "Configurar";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(194, 122);
            this.toolStripSplitButton1.Text = "Docentes";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 125);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMateriaToolStripMenuItem,
            this.dosificaciónDeContenidosToolStripMenuItem});
            this.toolStripSplitButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(203, 122);
            this.toolStripSplitButton2.Text = "Planeación";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // agregarMateriaToolStripMenuItem
            // 
            this.agregarMateriaToolStripMenuItem.Name = "agregarMateriaToolStripMenuItem";
            this.agregarMateriaToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.agregarMateriaToolStripMenuItem.Text = "Agregar Materia";
            this.agregarMateriaToolStripMenuItem.Click += new System.EventHandler(this.agregarMateriaToolStripMenuItem_Click);
            // 
            // dosificaciónDeContenidosToolStripMenuItem
            // 
            this.dosificaciónDeContenidosToolStripMenuItem.Name = "dosificaciónDeContenidosToolStripMenuItem";
            this.dosificaciónDeContenidosToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.dosificaciónDeContenidosToolStripMenuItem.Text = "Dosificación de contenidos";
            this.dosificaciónDeContenidosToolStripMenuItem.Click += new System.EventHandler(this.dosificaciónDeContenidosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 125);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAgregarAlumno,
            this.TsmiImportarListaDeAlumnos});
            this.toolStripSplitButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(182, 122);
            this.toolStripSplitButton3.Text = "Alumnos";
            this.toolStripSplitButton3.ButtonClick += new System.EventHandler(this.toolStripSplitButton3_ButtonClick);
            // 
            // TsmiAgregarAlumno
            // 
            this.TsmiAgregarAlumno.Name = "TsmiAgregarAlumno";
            this.TsmiAgregarAlumno.Size = new System.Drawing.Size(248, 22);
            this.TsmiAgregarAlumno.Text = "Agregar Alumno";
            this.TsmiAgregarAlumno.Click += new System.EventHandler(this.TsmiAgregarAlumno_Click);
            // 
            // TsmiImportarListaDeAlumnos
            // 
            this.TsmiImportarListaDeAlumnos.Name = "TsmiImportarListaDeAlumnos";
            this.TsmiImportarListaDeAlumnos.Size = new System.Drawing.Size(248, 22);
            this.TsmiImportarListaDeAlumnos.Text = "Importar Lista de Alumnos";
            this.TsmiImportarListaDeAlumnos.Click += new System.EventHandler(this.TsmiImportarListaDeAlumnos_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 125);
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(164, 122);
            this.toolStripSplitButton4.Text = "Expediente Curricular";
            this.toolStripSplitButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Ph1
            // 
            this.Ph1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Ph1.Controls.Add(this.button2);
            this.Ph1.Controls.Add(this.button1);
            this.Ph1.Controls.Add(this.btnDeslizar);
            this.Ph1.Controls.Add(this.pictureBox1);
            this.Ph1.Location = new System.Drawing.Point(1, 127);
            this.Ph1.Name = "Ph1";
            this.Ph1.Size = new System.Drawing.Size(174, 718);
            this.Ph1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Contáctanos";
            this.toolTip1.SetToolTip(this.button2, "Minimizar");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Configurar ";
            this.toolTip1.SetToolTip(this.button1, "Minimizar");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDeslizar
            // 
            this.btnDeslizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeslizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeslizar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeslizar.Image")));
            this.btnDeslizar.Location = new System.Drawing.Point(3, 4);
            this.btnDeslizar.Name = "btnDeslizar";
            this.btnDeslizar.Size = new System.Drawing.Size(34, 34);
            this.btnDeslizar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnDeslizar, "Minimizar");
            this.btnDeslizar.UseVisualStyleBackColor = false;
            this.btnDeslizar.Click += new System.EventHandler(this.btnDeslizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 39);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Planning ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(304, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(556, 354);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 518);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Ph1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Ph1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel Ph1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeslizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem agregarMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosificaciónDeContenidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmiAgregarAlumno;
        private System.Windows.Forms.ToolStripMenuItem TsmiImportarListaDeAlumnos;
    }
}

