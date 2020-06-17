using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia_Desktop
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Login | Login";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new Cadastro().ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text.Trim().Length != 0)
            {
                
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário.", "Erro");
            }
            else
            {
                MessageBox.Show("Bem Vindo", "Entrada");
            }
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("osk.exe");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            
            //new Login().ShowDialog();
            //this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tb_idioma.Text == "")
            //{
            //    MessageBox.Show("Selecione um idioma");
            //    tb_idioma.Focus();
            //    return;
            //}
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
          
            //timer.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Validar usuario
            if (tb_usuario.Text=="Erick" && tb_senha.Text == "1234")
            {
                MessageBox.Show("Seja bem vindo, Erick");
            }
            else
            {
                MessageBox.Show("Login ou Senha invalida!");
            }
        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}