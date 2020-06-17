namespace Avalia_Desktop
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_confirmarsenha = new System.Windows.Forms.TextBox();
            this.tb_us = new System.Windows.Forms.TextBox();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_n = new System.Windows.Forms.TextBox();
            this.tb_alterar = new System.Windows.Forms.Button();
            this.tb_deletar = new System.Windows.Forms.Button();
            this.cb_adm = new System.Windows.Forms.CheckBox();
            this.img_perfil = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(158, 362);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(89, 32);
            this.btn_cadastrar.TabIndex = 7;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(127, 51);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(213, 26);
            this.tb_nome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // tb_sobrenome
            // 
            this.tb_sobrenome.Location = new System.Drawing.Point(127, 89);
            this.tb_sobrenome.Name = "tb_sobrenome";
            this.tb_sobrenome.Size = new System.Drawing.Size(213, 26);
            this.tb_sobrenome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Endereco";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nascimento";
            // 
            // tb_usuario
            // 
            this.tb_usuario.AutoSize = true;
            this.tb_usuario.Location = new System.Drawing.Point(29, 207);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(64, 20);
            this.tb_usuario.TabIndex = 5;
            this.tb_usuario.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Senha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirmar senha";
            // 
            // tb_senha
            // 
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(127, 248);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(213, 35);
            this.tb_senha.TabIndex = 6;
            this.tb_senha.TextChanged += new System.EventHandler(this.tb_senha_TextChanged);
            // 
            // tb_confirmarsenha
            // 
            this.tb_confirmarsenha.Location = new System.Drawing.Point(161, 303);
            this.tb_confirmarsenha.Name = "tb_confirmarsenha";
            this.tb_confirmarsenha.PasswordChar = '*';
            this.tb_confirmarsenha.Size = new System.Drawing.Size(213, 26);
            this.tb_confirmarsenha.TabIndex = 6;
            this.tb_confirmarsenha.TextChanged += new System.EventHandler(this.tb_confirmarsenha_TextChanged);
            // 
            // tb_us
            // 
            this.tb_us.Location = new System.Drawing.Point(127, 203);
            this.tb_us.Name = "tb_us";
            this.tb_us.Size = new System.Drawing.Size(213, 26);
            this.tb_us.TabIndex = 6;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(127, 134);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(213, 26);
            this.tb_endereco.TabIndex = 6;
            this.tb_endereco.TextChanged += new System.EventHandler(this.tb_endereco_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "N";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_n
            // 
            this.tb_n.Location = new System.Drawing.Point(395, 137);
            this.tb_n.Name = "tb_n";
            this.tb_n.Size = new System.Drawing.Size(56, 26);
            this.tb_n.TabIndex = 6;
            // 
            // tb_alterar
            // 
            this.tb_alterar.Location = new System.Drawing.Point(566, 287);
            this.tb_alterar.Name = "tb_alterar";
            this.tb_alterar.Size = new System.Drawing.Size(89, 32);
            this.tb_alterar.TabIndex = 7;
            this.tb_alterar.Text = "Alterar  ";
            this.tb_alterar.UseVisualStyleBackColor = true;
            this.tb_alterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_deletar
            // 
            this.tb_deletar.Location = new System.Drawing.Point(683, 287);
            this.tb_deletar.Name = "tb_deletar";
            this.tb_deletar.Size = new System.Drawing.Size(89, 32);
            this.tb_deletar.TabIndex = 7;
            this.tb_deletar.Text = "Deletar";
            this.tb_deletar.UseVisualStyleBackColor = true;
            this.tb_deletar.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_adm
            // 
            this.cb_adm.Location = new System.Drawing.Point(619, 344);
            this.cb_adm.Name = "cb_adm";
            this.cb_adm.Size = new System.Drawing.Size(113, 24);
            this.cb_adm.TabIndex = 0;
            this.cb_adm.Text = "É admin";
            this.cb_adm.UseVisualStyleBackColor = true;
            this.cb_adm.CheckedChanged += new System.EventHandler(this.tb_cb_CheckedChanged);
            // 
            // img_perfil
            // 
            this.img_perfil.Location = new System.Drawing.Point(582, 51);
            this.img_perfil.Name = "img_perfil";
            this.img_perfil.Size = new System.Drawing.Size(175, 210);
            this.img_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_perfil.TabIndex = 9;
            this.img_perfil.TabStop = false;
            this.img_perfil.Click += new System.EventHandler(this.img_perfil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sobrenome";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_adm);
            this.Controls.Add(this.img_perfil);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_deletar);
            this.Controls.Add(this.tb_alterar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.tb_n);
            this.Controls.Add(this.tb_sobrenome);
            this.Controls.Add(this.tb_confirmarsenha);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_us);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_perfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_sobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tb_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_confirmarsenha;
        private System.Windows.Forms.TextBox tb_us;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_n;
        private System.Windows.Forms.PictureBox img_perfil;
        private System.Windows.Forms.Button tb_alterar;
        private System.Windows.Forms.Button tb_deletar;
        private System.Windows.Forms.CheckBox cb_adm;
        private System.Windows.Forms.Label label4;
    }
}