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
    public partial class Planiacion_por_Parcial : Form
    {
        public string t_materia = "";
        public int ident = 0;
        public Planiacion_por_Parcial(string Materia1)
        {
            InitializeComponent();
            t_materia = Materia1;
            label5.Text = label5.Text + Materia1;
            cmbCpGenericas.SelectedIndex = 4;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           if(ident == 1)
            {
                MessageBox.Show("Actualizar Datos");
            }
            else
            {
                insertar();
            }
        }

        public void insertar()
        {
         
            if (richDisciplinar.Text != "")
            {
                Guardar(t_materia);
            }
            else
            {
                MessageBox.Show("ERROR DEBE INTRODUCIR TEXTO EN CONFLICTO DISCIPLINARES");
            }
        }
        public void Guardar(string titulo_materia)
        {
            try
            {
                using (var contexto = new ProyectoEntities())
                {
                    //guardar  Idbloque=0

                    var nuevoBloque = new Plani_por_parcial
                    {
                        Comp_Ger = cmbCpGenericas.SelectedItem.ToString(),
                        Comp_Dici = richDisciplinar.Text,
                        Conflicto = richConflicto.Text,
                        Situacion = richSituacionD.Text,
                        Parcial = 1,
                        nombre_materia = titulo_materia
                        



                    };

                    contexto.Plani_por_parcial.Add(nuevoBloque);
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Buscar_inf()
        {

            if (ident == 0)
            {
                using (var contexto = new ProyectoEntities())
                {
                    var Actualizar =
                        from Plani_por_parcial in contexto.Plani_por_parcial
                        where Plani_por_parcial.nombre_materia == t_materia && Plani_por_parcial.Parcial == 1
                        select Plani_por_parcial;

                    foreach (var result in Actualizar)
                    {
                        richConflicto.Text = result.Conflicto;
                        richDisciplinar.Text = result.Comp_Dici;
                        richSituacionD.Text = result.Conflicto;
                        cmbCpGenericas.SelectedIndex = Convert.ToInt32(result.Posicion_list);

                    }

                }
            }
           
        }

        private void Planiacion_por_Parcial_Load(object sender, EventArgs e)
        {
            Buscar_inf();
        }

        private void btmPrimer_Click(object sender, EventArgs e)
        {
            Planificacion pla = new Planificacion(t_materia);
            pla.Show();
            this.Close();

        }
    }
}
