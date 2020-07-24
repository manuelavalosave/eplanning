using System;
using System.Windows.Forms;

namespace Sitestema_de_gestion_de_cursos
{
    public partial class Evidencias_del_logro_de_Competencias : Form
    {
        public Evidencias_del_logro_de_Competencias()
        {
            InitializeComponent();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            Inst.Items.Add("Prueba objetiva");
            Inst.Items.Add("Registro Anecdótico");
            Inst.Items.Add("Lista de cotejo");
            Inst.Items.Add("Rubrica Holística");

            criterio.Items.Add("Individual");
            criterio.Items.Add("Grupal");
            criterio.Items.Add("Equipo");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
