using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Modelos;

namespace Sitestema_de_gestion_de_cursos
{
    public partial class Plantel : Form
    {
        public Plantel()
        {
            InitializeComponent();
        }

        private void Plantel_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
            LimpiarCampos();
        }

        private void ActualizarGrid()
        {
            var lstDePlanteles = DatosPlantel.ConsultarPlanteles();

            DGWPlanteles.AutoGenerateColumns = false;

            var list = new BindingList<Datos_PlantelModel>(lstDePlanteles);
            DGWPlanteles.DataSource = list;
        }
        private void LimpiarCampos()
        {
            TxtIdPlantel.Text = "0";
            TxtCorreo.Text = "";
            TxtDepartamento.Text = "";
            TxtDireccion.Text = "";
            TxtNombreCorto.Text = "";
            TxtNombrePlantel.Text = "";
            TxtTelefono.Text = "";
        }

        private void DGWPlanteles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DGWPlanteles.Columns[e.ColumnIndex].Name.Equals("Editar"))
            {
                var datosConsultados = DatosPlantel.ConsultarPlantelPorId((int)DGWPlanteles.Rows[e.RowIndex].Cells[0].Value);

                TxtIdPlantel.Text = datosConsultados.Id_Plantel.ToString();
                TxtCorreo.Text = datosConsultados.Correo.ToString();
                TxtDepartamento.Text = datosConsultados.Departamento.ToString();
                TxtDireccion.Text = datosConsultados.Direccion.ToString();
                TxtNombreCorto.Text = datosConsultados.Nombre_corto.ToString();
                TxtNombrePlantel.Text = datosConsultados.Nombre_plantel.ToString();
                TxtTelefono.Text = datosConsultados.Telefono.ToString();

            }



        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // comprobar si las cajas vienen llenas 

            try
            {
                var mensaje = "Campos requeridos:";
                bool valido = true;


                if (string.IsNullOrEmpty(TxtNombrePlantel.Text.Trim()))
                {
                    valido = false;
                    mensaje += "-Nombre del plantel";
                }
                if (string.IsNullOrEmpty(TxtNombreCorto.Text.Trim()))
                {
                    valido = false;
                    mensaje += "-Nombre corto del plantel";
                }
                if (string.IsNullOrEmpty(TxtDepartamento.Text.Trim()))
                {
                    valido = false;
                    mensaje += "-Departamento del plantel";
                }
                if (string.IsNullOrEmpty(TxtDireccion.Text.Trim()))
                {
                    valido = false;
                    mensaje += "-Direccion del plantel";
                }
                if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
                {
                    valido = false;
                    mensaje += "-Telefono del plantel";
                }
                if (string.IsNullOrEmpty(TxtCorreo.Text.Trim()))
                {
                    valido = false;
                    mensaje += "-Correo del plantel";
                }


                if (valido == true)
                {
                    //var realizar la edicion o guardado
                    var gudarDatos = new Datos_PlantelModel
                    {
                        Correo = TxtCorreo.Text.Trim(),
                        Departamento = TxtDepartamento.Text.Trim(),
                        Direccion = TxtDireccion.Text.Trim(),
                        Nombre_corto = TxtNombreCorto.Text.Trim(),
                        Nombre_plantel = TxtNombrePlantel.Text.Trim(),
                        Telefono = TxtTelefono.Text.Trim(),
                        Id_Plantel = Convert.ToInt32(TxtIdPlantel.Text.Trim())

                    };

                    var resultado = DatosPlantel.GuardarEditar(gudarDatos);

                    MessageBox.Show("Los datos se guardaron correctamente");
                    LimpiarCampos();
                    ActualizarGrid();
                }
                else
                {
                    //no esta valido
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            var ssss = Guid.NewGuid();

            MessageBox.Show(ssss.ToString());
        }
    }
}
