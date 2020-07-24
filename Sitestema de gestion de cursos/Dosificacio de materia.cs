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
using Datos;

namespace Sitestema_de_gestion_de_cursos
{
  
    public partial class Demo2 : Form
    {
        public BloquesModelo bloque = new BloquesModelo();
          public string nom,  g;

        public Demo2(string nombre_materia, string grupo)
        {
            InitializeComponent();
            bloque.LstBloques = new List<BloquesCompetenciasModel>();
            var lstCombox = new List<DatosComboxModel>();
            lstCombox.Add(new DatosComboxModel { Codigo = "-1", Descripcion = "--Seleccionar--" });
            lstCombox.Add(new DatosComboxModel { Codigo = "1", Descripcion = "Primer" });
            lstCombox.Add(new DatosComboxModel { Codigo = "2", Descripcion = "Segundo" });
            lstCombox.Add(new DatosComboxModel { Codigo = "3", Descripcion = "Tercero" });
            cmbParcial.DisplayMember = "Descripcion";
            cmbParcial.ValueMember = "Codigo";
            cmbParcial.DataSource = lstCombox;
            nom = nombre_materia;
            g = grupo;
            lblmateria.Text = nom + g;
        }

        private void button2_Click(object sender, EventArgs e)

        {
         

            foreach (DataGridViewRow fila in dtbDatos.Rows)
            {
                using (var contexto = new ProyectoEntities())
                {
                    //guardar  Idbloque=0
                    var nuevoBloque = new Bloque
                    {
                        Parcial = Convert.ToByte(fila.Cells["dtParcial"].Value),
                        Porcentaje = Convert.ToDouble(fila.Cells["dtPorcentaje"].Value),
                        Titulo = Convert.ToString(fila.Cells["dtgNombre_bloque"].Value),
                        Grupos = g,
                        nombre_materia = nom,
                       Pre_competencia = Convert.ToString(fila.Cells["Competencia"].Value)


                    };

                    contexto.Bloque.Add(nuevoBloque);
                    contexto.SaveChanges();
                }
            }

            demo a = new demo(nom,g);
            Hide();
            a.Show();

               
        }

        private void Demo2_Load(object sender, EventArgs e)
        {
            var lstCombox = new List<DatosComboxModel>();
            lstCombox.Add(new DatosComboxModel { Codigo = "-1", Descripcion = "--Seleccionar--" });
            lstCombox.Add(new DatosComboxModel { Codigo = "1", Descripcion = "Primer" });
            lstCombox.Add(new DatosComboxModel { Codigo = "2", Descripcion = "Segundo" });
            lstCombox.Add(new DatosComboxModel { Codigo = "3", Descripcion = "Tercero" });
            cmbParcial.DisplayMember = "Descripcion";
            cmbParcial.ValueMember = "Codigo";
           cmbParcial.DataSource = lstCombox;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var datosAgregarCompetencia = new BloquesCompetenciasModel
            {

                Numero = bloque.LstBloques.Count + 1,

            };
            bloque.LstBloques.Add(datosAgregarCompetencia);

            RefrescarTablaBloquesCompetencia();


        }
        public void RefrescarTablaBloquesCompetencia()
        {



            var list = new BindingList<BloquesCompetenciasModel>(bloque.LstBloques);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dtbDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (this.dtbDatos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                Planiacion_por_Parcial planiacion = new Planiacion_por_Parcial(Convert.ToString("hola"));
                planiacion.Show();
                this.Close();
            }
        }

        private void txtporcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtporcentaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dtbDatos.Rows.Add(txtTituloBloque.Text, cmbParcial.SelectedValue, txtporcentaje.Text, ricDesempeño.Text);
            txtTituloBloque.Text = "";
            txtporcentaje.Text = "";
            cmbParcial.SelectedValue = "-1";
            ricDesempeño.Text = "";
    }
}
    }
