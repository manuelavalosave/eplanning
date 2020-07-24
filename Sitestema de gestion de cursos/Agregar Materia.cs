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
using Modelos;
using Negocio;
using System.Drawing.Drawing2D;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sitestema_de_gestion_de_cursos
{
    public partial class Agregar_Materia : Form
    {
        
        public AgregarMateria Materia2 = new AgregarMateria();
        public Agregar_Materia()
        {
            InitializeComponent();
            Materias_Guardadas actual = new Materias_Guardadas();
            actual.Hide();
            CmbSemestre.Text = "Elegir una opcion";


    }

        private void Agregar_Materia_Load(object sender, EventArgs e)
        {
            /*int num = CmbSemestre.SelectedIndex;
            switch(num)
            {
                case 0:
                    cmbMateria.Items.Add("Etica Valores I");
                    cmbMateria.Items.Add("Informatica I");
                    cmbMateria.Items.Add("Introduccion Ala ciencias Sociales");
                    cmbMateria.Items.Add("Lengua adicional al Español 1");
                    cmbMateria.Items.Add("Matematica I");
                    cmbMateria.Items.Add("Quimica I");
                    cmbMateria.Items.Add("Taller de lectura y redacción I");







                    break;
                default:
                    cmbMateria.Items.Add("No hay materia");

                    break;
                    

                    
            }
            lblnum.Text = num.ToString();*/
        }

        private void CmbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = CmbSemestre.SelectedIndex;
            switch (num)
            {
                case 0:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Etica Valores I");
                    cmbMateria.Rows.Add("Informatica I");
                    cmbMateria.Rows.Add("Introduccion Ala ciencias Sociales");
                    cmbMateria.Rows.Add("Lengua adicional al Español I");
                    cmbMateria.Rows.Add("Matematica I");
                    cmbMateria.Rows.Add("Quimica I");
                    cmbMateria.Rows.Add("Taller de lectura y redacción I");


                    cmbMateria.AutoGenerateColumns = false;
                    
                    break;
                case 1:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Etica Valores II");
                    cmbMateria.Rows.Add("Historia I");
                    cmbMateria.Rows.Add("Informatica II");
                    cmbMateria.Rows.Add("Lengua adicional al Español II");
                    cmbMateria.Rows.Add("Matematica II");
                    cmbMateria.Rows.Add("Quimica II");
                    cmbMateria.Rows.Add("Taller de lectura y redacción II");


                    break;
                case 2:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Biología I");
                    cmbMateria.Rows.Add("Física I");
                    cmbMateria.Rows.Add("Historia II");
                    cmbMateria.Rows.Add("Lengua adicional al Español III");
                    cmbMateria.Rows.Add("Literatura I");
                    cmbMateria.Rows.Add("Matematica III");

                    break;
                case 3:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Biología II");
                    cmbMateria.Rows.Add("Esemex");
                    cmbMateria.Rows.Add("Física II");
                    cmbMateria.Rows.Add("Lengua adicional al Español IV");
                    cmbMateria.Rows.Add("Literatura II");
                    cmbMateria.Rows.Add("Matematica IV");

                    break;
                case 4:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Geografía");
                    cmbMateria.Rows.Add("Historia Universal Conteporanea");

                    break;
                case 5:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Ecologia y Medio ambiente");
                    cmbMateria.Rows.Add("Filosofia");
                    cmbMateria.Rows.Add("Metodologia de la investigacion");



                    break;

                default:
                    cmbMateria.Rows.Add("No hay materia");

                    break;




            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int contar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (contar == 0)
            {
               foreach (DataGridViewRow fila in cmbMateria.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells["seleccionar"].Value))
                    {

                        String s = fila.Cells["grupo"].Value.ToString();
                        var chars = s.ToCharArray();

                  

string[] abc = s.Split('-');

                        for(int i = 0; i < abc.Count(); i++)
                        {
                          
                           Guardar(abc[i], fila.Cells["nmbredelamateria"].Value.ToString());
                           
                        }
                 
                         MessageBox.Show("GUARDADO");
                        Actualizar();
                       

                    }

                    contar = 1;
                    cmbMateria.Refresh();
                 

       
                }
            }
            else
            {
                contar = 0;
               
                foreach (DataGridViewRow fila in cmbMateria.Rows)
                {
                    if (Convert.ToBoolean(fila.Cells["seleccionar"].Value))
                    {

                        String s = fila.Cells["grupo"].Value.ToString();
                        var chars = s.ToCharArray();



                        string[] abc = s.Split('-');

                        for (int i = 0; i < abc.Count(); i++)
                        {
                           
                            Guardar(abc[i], fila.Cells["nmbredelamateria"].Value.ToString());
                        }

                        MessageBox.Show("GUARDADO");
                        Actualizar();



                    }
                    contar = 1;

                }
            }
        }

       
        public void Guardar (string g, string name)
        {
             try
                        {
                            using (var contexto = new ProyectoEntities())
                            {
                                //guardar  Idbloque=0
                                int num = CmbSemestre.SelectedIndex + 1;
                                var nuevoBloque = new Materia_t
                                {
                                  
                                
                                    Nombre_materia = Convert.ToString(name),
                                    Semestre = Convert.ToString(num),
                                    Grupo = Convert.ToString(g)

                                };

                                contexto.Materia_t.Add(nuevoBloque);
                                contexto.SaveChanges();
                            }
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
        }
        private void cmbMateria_SelectionChanged(object sender, EventArgs e)
        {

           


          }


        public void Actualizar()
        {
            int num = CmbSemestre.SelectedIndex;
            switch (num)
            {
                case 0:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Etica Valores I");
                    cmbMateria.Rows.Add("Informatica I");
                    cmbMateria.Rows.Add("Introduccion Ala ciencias Sociales");
                    cmbMateria.Rows.Add("Lengua adicional al Español I");
                    cmbMateria.Rows.Add("Matematica I");
                    cmbMateria.Rows.Add("Quimica I");
                    cmbMateria.Rows.Add("Taller de lectura y redacción I");


                    cmbMateria.AutoGenerateColumns = false;

                    break;
                case 1:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Etica Valores II");
                    cmbMateria.Rows.Add("Historia I");
                    cmbMateria.Rows.Add("Informatica II");
                    cmbMateria.Rows.Add("Lengua adicional al Español II");
                    cmbMateria.Rows.Add("Matematica II");
                    cmbMateria.Rows.Add("Quimica II");
                    cmbMateria.Rows.Add("Taller de lectura y redacción II");


                    break;
                case 2:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Biología I");
                    cmbMateria.Rows.Add("Física I");
                    cmbMateria.Rows.Add("Historia II");
                    cmbMateria.Rows.Add("Lengua adicional al Español III");
                    cmbMateria.Rows.Add("Literatura I");
                    cmbMateria.Rows.Add("Matematica III");

                    break;
                case 3:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Biología II");
                    cmbMateria.Rows.Add("Esemex");
                    cmbMateria.Rows.Add("Física II");
                    cmbMateria.Rows.Add("Lengua adicional al Español IV");
                    cmbMateria.Rows.Add("Literatura II");
                    cmbMateria.Rows.Add("Matematica IV");

                    break;
                case 4:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Geografía");
                    cmbMateria.Rows.Add("Historia Universal Conteporanea");

                    break;
                case 5:
                    cmbMateria.Rows.Clear();
                    cmbMateria.Rows.Add("Ecologia y Medio ambiente");
                    cmbMateria.Rows.Add("Filosofia");
                    cmbMateria.Rows.Add("Metodologia de la investigacion");



                    break;

                default:
                    cmbMateria.Rows.Add("No hay materia");

                    break;




            }
        }
          
        }
    }

