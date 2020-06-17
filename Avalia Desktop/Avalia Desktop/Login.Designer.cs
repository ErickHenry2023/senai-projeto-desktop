using System;
using System.Media;
using System.Windows.Forms;


namespace Avalia_Desktop
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_cadastro = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Label();
            this.tb_idioma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tb_sair = new System.Windows.Forms.Button();
            this.tb_entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Avalia_Desktop.Properties.Resources.M_Music_removebg_preview;
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(659, 43);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(239, 177);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.Color.PeachPuff;
            this.Banner.Image = global::Avalia_Desktop.Properties.Resources.cartaz;
            this.Banner.InitialImage = null;
            this.Banner.Location = new System.Drawing.Point(12, 12);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(380, 518);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banner.TabIndex = 0;
            this.Banner.TabStop = false;
            this.Banner.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(643, 270);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(213, 26);
            this.tb_usuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(643, 331);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(213, 26);
            this.tb_senha.TabIndex = 3;
            this.tb_senha.TextChanged += new System.EventHandler(this.tb_senha_TextChanged);
            // 
            // tb_cadastro
            // 
            this.tb_cadastro.Location = new System.Drawing.Point(692, 480);
            this.tb_cadastro.Name = "tb_cadastro";
            this.tb_cadastro.Size = new System.Drawing.Size(119, 52);
            this.tb_cadastro.TabIndex = 4;
            this.tb_cadastro.Text = "Novo Usuario";
            this.tb_cadastro.UseVisualStyleBackColor = true;
            this.tb_cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(281, 279);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(225, 35);
            this.btnEntrar.TabIndex = 11;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(0, 0);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(100, 26);
            this.tbxUsuario.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrar.TabIndex = 0;
            // 
            // tb_idioma
            // 
            this.tb_idioma.FormattingEnabled = true;
            this.tb_idioma.Items.AddRange(new object[] {
            "Ingles",
            "Portugues"});
            this.tb_idioma.Location = new System.Drawing.Point(643, 401);
            this.tb_idioma.Name = "tb_idioma";
            this.tb_idioma.Size = new System.Drawing.Size(188, 28);
            this.tb_idioma.TabIndex = 6;
            this.tb_idioma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Idioma";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tb_sair
            // 
            this.tb_sair.Location = new System.Drawing.Point(769, 443);
            this.tb_sair.Name = "tb_sair";
            this.tb_sair.Size = new System.Drawing.Size(87, 31);
            this.tb_sair.TabIndex = 7;
            this.tb_sair.Text = "Sair";
            this.tb_sair.UseVisualStyleBackColor = true;
            this.tb_sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // tb_entrar
            // 
            this.tb_entrar.Location = new System.Drawing.Point(644, 442);
            this.tb_entrar.Name = "tb_entrar";
            this.tb_entrar.Size = new System.Drawing.Size(82, 32);
            this.tb_entrar.TabIndex = 8;
            this.tb_entrar.Text = "Entrar";
            this.tb_entrar.UseVisualStyleBackColor = true;
            this.tb_entrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(968, 542);
            this.Controls.Add(this.tb_entrar);
            this.Controls.Add(this.tb_sair);
            this.Controls.Add(this.tb_idioma);
            this.Controls.Add(this.tb_cadastro);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void Login(object sender, EventArgs e)
        //{
        //   throw new NotImplementedException();
        //}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new Cadastro().ShowDialog();     
        }


        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button tb_cadastro;


        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnCadastrar;
        private ComboBox tb_idioma;
        private Label label4;
        private Timer timer;
        private Button tb_sair;
        private Button tb_entrar;
    }
}

