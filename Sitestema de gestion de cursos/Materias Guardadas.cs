using Datos;
using Modelos;
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
    public partial class Materias_Guardadas : Form
    {
        public Materias_Guardadas()
        {
            InitializeComponent();

        }

        private void Materias_Guardadas_Load(object sender, EventArgs e)
        {
            var serv = new Negocio.BloqueMateria();
            var lstBloques = serv.ConsultarBloques();

                dataGridView1.AutoGenerateColumns = false;

                var list = new BindingList<AgregarMateria>(lstBloques);

            // dataGridView1.DataSource = list;
            dataGridView1.Refresh();
            foreach (var result in list)
            {
                try
                {
                    dataGridView1.Rows.Add(result.Nombre_materia, result.Semestre, result.Grupo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //Console.WriteLine("{0} {1} ", result.Id_materia, result.LastName);
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_Materia materia = new Agregar_Materia();

            materia.Show();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var name_materia = dataGridView1.Rows[e.RowIndex].Cells["nombre_materia"].Value.ToString();
            var grupo = dataGridView1.Rows[e.RowIndex].Cells["Grupo"].Value.ToString();

            if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("Docificacion"))
            {
                demo añadir_bloque = new demo(name_materia, grupo);
                añadir_bloque.Show();
                // this.Close();
               
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("P1"))
            {
                Generar_Docificacion planiacion = new Generar_Docificacion(name_materia);
                planiacion.Show();
                
            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("P2"))
            {
                Generar_Docificacion planiacion = new Generar_Docificacion(name_materia);
                planiacion.Show();
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("P3")){
                Generar_Docificacion planiacion = new Generar_Docificacion(name_materia);
                planiacion.Show();
            }
            //this.Close();




        }
    }

}
