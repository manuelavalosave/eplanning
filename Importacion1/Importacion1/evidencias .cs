using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importacion1
{
    public partial class Frm1 : Form
    {
        public Frm1()
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
