using System;
using System.Windows.Forms;


namespace Sitestema_de_gestion_de_cursos

{
    public partial class inicio_login : Form
    {
        public inicio_login()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtContraseña.Text == "")
                {
                    MessageBox.Show("Error Te falta un Dato");
                }
                else if (txtusuario.Text == "")
                {
                    MessageBox.Show("Error Te falta un Dato de usuario");


                }
                else
                {
                    VerificarUsuario();

                }

                /* Menu inicio = new Menu();
                 inicio.Show();*/
            }
            else
            {

            }

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
        public void VerificarUsuario()
        {
            if ((txtusuario.Text == "Maestro") && (txtContraseña.Text == "123demo"))
            {
                Menu inicio = new Menu();
                inicio.Show();
                this.Hide();

            } else
            {
                MessageBox.Show("Error usuario/contraseña Son incorrectos");
            }
           


        }
        public void Cerrar()
        {
            
                this.Close();
            

        }

        private void inicio_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((txtusuario.Text == "Maestro") && (txtContraseña.Text == "123demo"))
            {
                Menu inicio = new Menu();
                inicio.ShowDialog();
               
               


            }
            else
            {
                MessageBox.Show("Error usuario/contraseña Son incorrectos");
            }

            

        }

    }
}
