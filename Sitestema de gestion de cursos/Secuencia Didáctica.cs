using Datos;
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
    public partial class Planificacion : Form
    {
        public string t;
        public Planificacion(string titulo)
        {
            InitializeComponent();
           
            lblTituloBloque.Text = titulo;
            t = titulo;

            ListViewItem lista = new ListViewItem("Apertura");
            lista.SubItems.Add("El docente presenta el encuadre correspondiente a la UAC: Informática II y su interrelación con otras asignaturas. Describiendo los contenidos y su dosificación (incluyendo porcentajes por parcial), competencias a lograr, la forma de trabajar haciendo énfasis en los criterios de evaluación del primer parcial.");
            lista.SubItems.Add("2");

            // lista.Checked = true;
            listView1.Items.Add(lista);
            listView1.CheckBoxes = true;
            ListViewItem lista1 = new ListViewItem("Desarrollo");
            lista1.SubItems.Add("El estudiante participa en una lluvia de ideas para generar los conceptos de problema, algoritmo, diagrama de flujo, pseudocódigo y código de programación.");
            lista1.SubItems.Add("2");

            // lista.Checked = true;
            listView1.Items.Add(lista1);
            listView1.CheckBoxes = true;
            ListViewItem lista12 = new ListViewItem("Cierre");
            lista12.SubItems.Add("19.	El docente retroalimenta el parcial desarrollado y da a conocer los niveles de dominio alcanzado por los estudiantes de acuerdo con el plan de evaluación acordado");
            lista12.SubItems.Add("2");

            // lista.Checked = true;
            listView1.Items.Add(lista12);
            listView1.CheckBoxes = true;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                try
                {
                    Guardar("3", t, listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text, listView1.Items[i].SubItems[2].Text);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

         
            

            

           
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem("Apertura");
            lista.SubItems.Add(TxtActividad.Text.ToString());
            lista.SubItems.Add(TxtSesion.Text.ToString());

            // lista.Checked = true;
            listView1.Items.Add(lista);
            listView1.CheckBoxes = true;

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //TxtSesion.Text = listView1.SelectedItems[0].Checked.ToString();

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            TxtSesion.Text = listView1.SelectedItems[0].Checked.ToString();
           
        }

        private void btnagregarD_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem("Desarrollo");
            lista.SubItems.Add(txtActivD.Text.ToString());
            lista.SubItems.Add(txtsesiond.Text.ToString());

            // lista.Checked = true;
            listView1.Items.Add(lista);
            listView1.CheckBoxes = true;
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem("Cierre");
            lista.SubItems.Add(txtactividadC.Text.ToString());
            lista.SubItems.Add(txtsesionc.Text.ToString());

            // lista.Checked = true;
            listView1.Items.Add(lista);
            listView1.CheckBoxes = true;
        }


        public void Guardar(string g, string name, string Secuencia, string acti, string sesion)
        {
          /*  try
            {
                using (var contexto = new ProyectoEntities())
                {
                    //guardar  Idbloque=0
                    //int num = CmbSemestre.SelectedIndex + 1;
                    var nuevoBloque = new SecuenciaDidactica
                    {
                        TipoDeSecuencia = Secuencia,
                        Nombre_Materia = name,
                        grupo = g,
                        Parcial = 1,
                        Actividad = "hola",
                        Secion = sesion
                        

                    };

                    contexto.SecuenciaDidactica.Add(nuevoBloque);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Evidencias_del_logro_de_Competencias Evid = new Evidencias_del_logro_de_Competencias();
            Evid.Show();
            this.Close();
        }

        private void Planificacion_Load(object sender, EventArgs e)
        {

        }
    }
}

