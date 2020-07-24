using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sitestema_de_gestion_de_cursos
{
    public partial class Menu : Form
    {
        inicio_login login = new inicio_login();
     
        public Menu()
        {
            InitializeComponent();
            
        }

      

        private void btnDeslizar_Click(object sender, EventArgs e)
        {
            if (Ph1.Height == 718 & Ph1.Width == 174)
            {
                
                Ph1.Height = 718;
                Ph1.Width = 39;
                pictureBox1.Visible = false;
            }
            else
            {
                Ph1.Height = 718;
                Ph1.Width = 174;
                pictureBox1.Visible = true;
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login.Close();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maestro m = new Maestro();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void agregarMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Materia materia = new Agregar_Materia();

            materia.Show();

        }

        private void dosificaciónDeContenidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias_Guardadas dem = new Materias_Guardadas();
            dem.Show();

           
        }

        private void TsmiAgregarAlumno_Click(object sender, EventArgs e)
        {
            Agregra_Alumno alum = new Agregra_Alumno();
            alum.Show();
        }

        private void TsmiImportarListaDeAlumnos_Click(object sender, EventArgs e)
        {
            Importacion1.importarcv d = new Importacion1.importarcv();
            d.Show();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton5_ButtonClick(object sender, EventArgs e)
        {
            Plantel plantel = new Plantel();
            plantel.Show();
        }
    }
}
