using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.OleDb;

    
 namespace Importacion1
{
    public partial class importarcv : Form
    {
        OleDbConnection conectar;
        OleDbDataAdapter dat;
        DataTable Dt;
        public importarcv()
        {
            InitializeComponent();
        }
        public void importExcel(DataGridView DTGV)
        {
            string Ruta = "";
            string hoja = "";

            
                OpenFileDialog abrirArchivo = new OpenFileDialog();
                abrirArchivo.Filter = "Excel Files |*.xlsx";
                abrirArchivo.Title = "Seleccionar archivo de Excel";


            if (abrirArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (abrirArchivo.FileName.Equals("") == false)
                {
                    Ruta = abrirArchivo.FileName;
                }
                try
                {

                    hoja = Microsoft.VisualBasic.Interaction.InputBox("Escriba El Nombre de La Hoja Que Desea Inportar", "Completar");
                    conectar = new OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;data source =" + Ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes' ");
                    dat = new OleDbDataAdapter("Select * From [" + hoja + "$]", conectar);
                    Dt = new DataTable();
                    dat.Fill(Dt);
                    DTGV.DataSource = Dt;
                    MessageBox.Show("DATOS CARGADOS CORRECTAMENTE","EXCELENTE",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("INGRESE UN NOMBRE DE LA HOJA CORRECTO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    conectar.Close();
                }
            }
        
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            new importarcv().importExcel(dgv);
        }
    }
}
