using Modelos;
using Negocio;
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
    public partial class Agregra_Alumno : Form
    {
        List<AlumnoDTO> listaAlumnos = new List<AlumnoDTO>();
        public Agregra_Alumno()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AlumnoDTO s = new AlumnoDTO
            {
                Nombre = textBox2.Text,
                NumeroControl = textBox2.Text,
                NuevoEliminar = 1
            };



            listaAlumnos.Add(s);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Alumno x = new Alumno();

            x.GuardarAlumnos(listaAlumnos);

        }
    }
}
