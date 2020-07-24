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
    public partial class demo : Form
    {
        public string n, g;
        public demo(string nombre_materia, string grupo)
        {
            InitializeComponent();
            lblname.Text = nombre_materia + grupo ;
            n = nombre_materia;
            g = grupo;
            Buscar_Semestre();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Demo2 x = new Demo2(n,g);
            x.Show();
            this.Close();

        }

        private void demo_Load(object sender, EventArgs e)
        {
            
           


        }


        public void RefrescarTabla()
        {
            var serv = new Negocio.BloquesServicios();
            var lstBloques = serv.ConsultarBloques();

            dataGridView2.AutoGenerateColumns = false;

            var list = new BindingList<BloquesModelo>(lstBloques);

            dataGridView2.DataSource = list;
            dataGridView2.Refresh();



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id_Bloque = dataGridView2.Rows[e.RowIndex].Cells["A_id_bloque"].Value.ToString();
            if (this.dataGridView2.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                Eliminar_bloque(id_Bloque);
                MessageBox.Show("Se ha Eliminado un Bloque");
                DialogResult = DialogResult.OK;
                demo a = new demo(n, g);
                Hide();
                a.Show();
              

                
            }
          
        }
        public void Buscar_Semestre()
        {


            using (var contexto = new ProyectoEntities())
            {
                var Bloque_materia =
                    from Bloque in contexto.Bloque
                    where Bloque.Grupos == g && Bloque.nombre_materia == n
                    select Bloque;

                foreach (var result in Bloque_materia)
                {
                 
                    dataGridView2.Rows.Add(result.IdBloque,result.Titulo, result.Parcial, result.Porcentaje);
                }
            }
        }

        public void Eliminar_bloque(string id_bloque)
        {
            using (var context = new ProyectoEntities())
            {
                var Bloque_eliminar = context.Bloque.Find(Convert.ToInt32(id_bloque));
                context.Bloque.Remove(Bloque_eliminar);
                context.SaveChanges();
            }
           
        }
        
    }
}
