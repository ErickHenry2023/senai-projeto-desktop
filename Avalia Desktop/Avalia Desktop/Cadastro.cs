using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalia_Desktop
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add img
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivo de Img(*.jpg;*.png)|*.jpg;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                img_perfil.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "")
            {
                MessageBox.Show("Digite um nome");
                tb_nome.Focus();
                return;
            }


            if (tb_sobrenome.Text == "")
            {
                MessageBox.Show("Digite um sobrenome");
                tb_sobrenome.Focus();
                return;
            }


            if (tb_endereco.Text == "")
            {
                MessageBox.Show("Digite um endereco");
                tb_endereco.Focus();
                return;
            }

            if (tb_n.Text == "")
            {
                MessageBox.Show("Digite um numero");
                tb_n.Focus();
                return;
            }

            if (tb_us.Text == "")
            {
                MessageBox.Show("Digite um usuario");
                tb_us.Focus();
                return;
            }


            if (tb_senha.Text == "")
            {
                MessageBox.Show("Digite uma senha");
                tb_senha.Focus();
                return;
            }

            if (tb_confirmarsenha.Text == "")
            {
                MessageBox.Show("Confirme a sua senha");
                tb_confirmarsenha.Focus();
                return;
            }

            new Telausu().ShowDialog();
        }

        private void tb_confirmarsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void img_perfil_Click(object sender, EventArgs e)
        {
           
        }

        private void tb_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_adm.Checked)
            {
                MessageBox.Show("Cadastro de um novo administrador");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_endereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
