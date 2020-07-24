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
    public partial class Generar_Docificacion : Form
    {
        public string nombre_m;
        public int id_c = 0;
        public Generar_Docificacion(string nombre_materia)
        {
            InitializeComponent();
            nombre_m = nombre_materia;
            cmbCpGenericas.SelectedIndex = 4;
            ListActividad.View = View.Details;
            ListActividad.Columns[3].Width = 0; //oculta la columna 1
        }

        private void Generar_Docificacion_Load(object sender, EventArgs e)
        {
            Actualizar();
            Actualizar_list();
        }

        private void btmPrimer_Click(object sender, EventArgs e)
        {
            Planiacion_por_Parcial planificar = new Planiacion_por_Parcial(nombre_m);
            planificar.Show();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnTercero_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        public void Actualizar()
        {
            var datosConsultados = DocificacionCompetencia.ConsultarPlantelPorId(1, nombre_m);
            if (datosConsultados != null)
            {
                richDisciplinar.Text = datosConsultados.Comp_Dici.ToString();
                richSituacionD.Text = datosConsultados.Situacion.ToString();
                richConflicto.Text = datosConsultados.Conflicto.ToString();
                cmbCpGenericas.SelectedIndex = Convert.ToInt32(datosConsultados.Pocision_list);
                id_c = datosConsultados.Id_planificacion;
            }

        }


        //metodo para consurtar los listview
        public void Actualizar_list()
        {
            var datosConsultados = SecuenciaDidacticaActividades.ConsultarPlantelPorId(1, nombre_m);
            if (datosConsultados != null)
            {
                ListViewItem lista = new ListViewItem(datosConsultados.Tipo);
                lista.SubItems.Add(datosConsultados.T_Activ.ToString());
                lista.SubItems.Add(datosConsultados.sesion.ToString());
                lista.SubItems.Add(Convert.ToString(datosConsultados.Id_Acti));
                // lista.Checked = true;
                ListActividad.Items.Add(lista);
                ListActividad.CheckBoxes = true;

            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var mensaje = "Campos requeridos:";
                bool valido = true;


                if (string.IsNullOrEmpty(richDisciplinar.Text.Trim()))
                {
                    valido = false;
                    mensaje += "-Competencia Disciplinar";
                }



                if (valido == true)
                {
                    //var realizar la edicion o guardado
                    var gudarDatos = new CompetenciaPorParcial
                    {
                        Comp_Dici = richDisciplinar.Text.Trim(),
                        Comp_Ger = cmbCpGenericas.SelectedItem.ToString(),
                        Conflicto = richConflicto.Text.Trim(),
                        Pocision_list = "4",
                        nombre_materia = nombre_m,
                        Parcial = 1,
                        Situacion = richSituacionD.Text.Trim(),
                        Id_planificacion = id_c,


                    };

                    var resultado = DocificacionCompetencia.GuardarEditar(gudarDatos);

                    MessageBox.Show("Los datos se guardaron correctamente");

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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem("Apertura");
            lista.SubItems.Add(TxtActividadAp.Text.Trim().ToString());
            lista.SubItems.Add(TxtSesionAp.Text.Trim().ToString());
            lista.SubItems.Add("0");
            // lista.Checked = true;
            ListActividad.Items.Add(lista);
            ListActividad.CheckBoxes = true;
            TxtActividadAp.Text = "";
            TxtSesionAp.Text = "";
        }

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem("Desarrollo");
            lista.SubItems.Add(TxtActividadD.Text.Trim().ToString());
            lista.SubItems.Add(TxtSesionD.Text.Trim().ToString());

            // lista.Checked = true;
            ListActividad.Items.Add(lista);
            ListActividad.CheckBoxes = true;
            TxtActividadD.Text = "";
            TxtSesionD.Text = "";
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem("Cierre");
            lista.SubItems.Add(TxtActividadC.Text.Trim().ToString());
            lista.SubItems.Add(TxtSesionc.Text.Trim().ToString());

            // lista.Checked = true;
            ListActividad.Items.Add(lista);
            ListActividad.CheckBoxes = true;
            TxtActividadC.Text = "";
            TxtSesionc.Text = "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListActividad.Items.Count; i++)
            {
                try
                {
                    Recorrer_list(ListActividad.Items[i].SubItems[0].Text, ListActividad.Items[i].SubItems[1].Text, ListActividad.Items[i].SubItems[2].Text, ListActividad.Items[i].Checked.ToString(), Convert.ToInt32(ListActividad.Items[i].SubItems[3].Text));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

        public void Recorrer_list(string Sugerencia, string titulo_A, string sesion, string verif, int id)
        {
            try
            {
                var mensaje = "Campos requeridos:";
                bool valido = true;


                if (string.IsNullOrEmpty(titulo_A.Trim()))
                {
                    valido = false;
                    mensaje += "-Competencia Disciplinar";
                }



                if (valido == true)
                {
                    //var realizar la edicion o guardado
                    var gudarDatos = new SecuenciaDidacticaModelo
                    {
                        T_Activ = titulo_A.Trim(),
                        sesion = sesion,
                        checador_act = verif,
                        Materia = nombre_m,
                        Parcial = 1,
                        Id_Acti = id,
                        Tipo = Sugerencia,
                        


                    };

                    var resultado = SecuenciaDidacticaActividades.GuardarEditar(gudarDatos);

                    MessageBox.Show("Los datos se guardaron correctamente");

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
    }
    }

