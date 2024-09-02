namespace Comandas
{
    partial class FrmUsuarios
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
            btnNovo = new ReaLTaiizor.Controls.Button();
            btnSalvar = new ReaLTaiizor.Controls.Button();
            btnExcluir = new ReaLTaiizor.Controls.Button();
            thunderGroupBox1 = new ReaLTaiizor.Controls.ThunderGroupBox();
            id = new ReaLTaiizor.Controls.ThunderLabel();
            textSenha = new ReaLTaiizor.Controls.CrownTextBox();
            senha = new ReaLTaiizor.Controls.ThunderLabel();
            email = new ReaLTaiizor.Controls.ThunderLabel();
            nome = new ReaLTaiizor.Controls.ThunderLabel();
            textEmail = new ReaLTaiizor.Controls.CrownTextBox();
            textNome = new ReaLTaiizor.Controls.CrownTextBox();
            textId = new ReaLTaiizor.Controls.CrownTextBox();
            btnEditar = new ReaLTaiizor.Controls.Button();
            btnCancelar = new ReaLTaiizor.Controls.Button();
            dgvUsuarios = new DataGridView();
            btnVoltar = new ReaLTaiizor.Controls.Button();
            thunderGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Transparent;
            btnNovo.BorderColor = Color.FromArgb(32, 34, 37);
            btnNovo.EnteredBorderColor = Color.FromArgb(64, 64, 64);
            btnNovo.EnteredColor = Color.FromArgb(32, 34, 37);
            btnNovo.Font = new Font("Microsoft Sans Serif", 12F);
            btnNovo.Image = null;
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.InactiveColor = Color.FromArgb(32, 34, 37);
            btnNovo.Location = new Point(32, 284);
            btnNovo.Margin = new Padding(2, 4, 2, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.PressedBorderColor = Color.FromArgb(64, 64, 64);
            btnNovo.PressedColor = Color.FromArgb(64, 64, 64);
            btnNovo.Size = new Size(111, 31);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.TextAlignment = StringAlignment.Center;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BorderColor = Color.FromArgb(32, 34, 37);
            btnSalvar.Enabled = false;
            btnSalvar.EnteredBorderColor = Color.FromArgb(64, 64, 64);
            btnSalvar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F);
            btnSalvar.Image = null;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSalvar.Location = new Point(349, 286);
            btnSalvar.Margin = new Padding(2, 4, 2, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.PressedBorderColor = Color.FromArgb(64, 64, 64);
            btnSalvar.PressedColor = Color.FromArgb(64, 64, 64);
            btnSalvar.Size = new Size(111, 31);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlignment = StringAlignment.Center;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.BorderColor = Color.FromArgb(32, 34, 37);
            btnExcluir.Enabled = false;
            btnExcluir.EnteredBorderColor = Color.FromArgb(64, 64, 64);
            btnExcluir.EnteredColor = Color.FromArgb(32, 34, 37);
            btnExcluir.Font = new Font("Microsoft Sans Serif", 12F);
            btnExcluir.Image = null;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.InactiveColor = Color.FromArgb(32, 34, 37);
            btnExcluir.Location = new Point(511, 286);
            btnExcluir.Margin = new Padding(2, 4, 2, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PressedBorderColor = Color.FromArgb(64, 64, 64);
            btnExcluir.PressedColor = Color.FromArgb(64, 64, 64);
            btnExcluir.Size = new Size(111, 31);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlignment = StringAlignment.Center;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // thunderGroupBox1
            // 
            thunderGroupBox1.BackColor = Color.Transparent;
            thunderGroupBox1.BodyColorA = Color.FromArgb(26, 26, 26);
            thunderGroupBox1.BodyColorB = Color.FromArgb(30, 30, 30);
            thunderGroupBox1.BodyColorC = Color.FromArgb(46, 46, 46);
            thunderGroupBox1.BodyColorD = Color.FromArgb(50, 55, 58);
            thunderGroupBox1.Controls.Add(id);
            thunderGroupBox1.Controls.Add(textSenha);
            thunderGroupBox1.Controls.Add(senha);
            thunderGroupBox1.Controls.Add(email);
            thunderGroupBox1.Controls.Add(nome);
            thunderGroupBox1.Controls.Add(textEmail);
            thunderGroupBox1.Controls.Add(textNome);
            thunderGroupBox1.Controls.Add(textId);
            thunderGroupBox1.ForeColor = Color.WhiteSmoke;
            thunderGroupBox1.Location = new Point(11, 11);
            thunderGroupBox1.Margin = new Padding(2, 4, 2, 4);
            thunderGroupBox1.Name = "thunderGroupBox1";
            thunderGroupBox1.Size = new Size(792, 265);
            thunderGroupBox1.TabIndex = 7;
            // 
            // id
            // 
            id.BackColor = Color.Transparent;
            id.ForeColor = Color.WhiteSmoke;
            id.Location = new Point(21, 45);
            id.Margin = new Padding(2, 4, 2, 4);
            id.Name = "id";
            id.Size = new Size(98, 31);
            id.TabIndex = 14;
            id.Text = "Id";
            // 
            // textSenha
            // 
            textSenha.BackColor = Color.FromArgb(69, 73, 74);
            textSenha.BorderStyle = BorderStyle.FixedSingle;
            textSenha.Enabled = false;
            textSenha.ForeColor = Color.FromArgb(220, 220, 220);
            textSenha.Location = new Point(125, 206);
            textSenha.Margin = new Padding(2, 4, 2, 4);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(638, 31);
            textSenha.TabIndex = 13;
            textSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // senha
            // 
            senha.BackColor = Color.Transparent;
            senha.ForeColor = Color.WhiteSmoke;
            senha.Location = new Point(21, 206);
            senha.Margin = new Padding(2, 4, 2, 4);
            senha.Name = "senha";
            senha.Size = new Size(98, 31);
            senha.TabIndex = 12;
            senha.Text = "Senha";
            // 
            // email
            // 
            email.BackColor = Color.Transparent;
            email.ForeColor = Color.WhiteSmoke;
            email.Location = new Point(21, 151);
            email.Margin = new Padding(2, 4, 2, 4);
            email.Name = "email";
            email.Size = new Size(98, 31);
            email.TabIndex = 11;
            email.Text = "Email";
            // 
            // nome
            // 
            nome.BackColor = Color.Transparent;
            nome.ForeColor = Color.WhiteSmoke;
            nome.Location = new Point(21, 95);
            nome.Margin = new Padding(2, 4, 2, 4);
            nome.Name = "nome";
            nome.Size = new Size(98, 31);
            nome.TabIndex = 8;
            nome.Text = "Nome";
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.FromArgb(69, 73, 74);
            textEmail.BorderStyle = BorderStyle.FixedSingle;
            textEmail.Enabled = false;
            textEmail.ForeColor = Color.FromArgb(220, 220, 220);
            textEmail.Location = new Point(124, 151);
            textEmail.Margin = new Padding(2, 4, 2, 4);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(638, 31);
            textEmail.TabIndex = 10;
            textEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // textNome
            // 
            textNome.BackColor = Color.FromArgb(69, 73, 74);
            textNome.BorderStyle = BorderStyle.FixedSingle;
            textNome.Enabled = false;
            textNome.ForeColor = Color.FromArgb(220, 220, 220);
            textNome.Location = new Point(124, 95);
            textNome.Margin = new Padding(2, 4, 2, 4);
            textNome.Name = "textNome";
            textNome.Size = new Size(638, 31);
            textNome.TabIndex = 9;
            textNome.TextAlign = HorizontalAlignment.Center;
            // 
            // textId
            // 
            textId.BackColor = Color.FromArgb(69, 73, 74);
            textId.BorderStyle = BorderStyle.FixedSingle;
            textId.Enabled = false;
            textId.ForeColor = Color.FromArgb(220, 220, 220);
            textId.Location = new Point(124, 45);
            textId.Margin = new Padding(2, 4, 2, 4);
            textId.Name = "textId";
            textId.Size = new Size(638, 31);
            textId.TabIndex = 8;
            textId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BorderColor = Color.FromArgb(32, 34, 37);
            btnEditar.Enabled = false;
            btnEditar.EnteredBorderColor = Color.FromArgb(64, 64, 64);
            btnEditar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnEditar.Font = new Font("Microsoft Sans Serif", 12F);
            btnEditar.Image = null;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnEditar.Location = new Point(193, 284);
            btnEditar.Margin = new Padding(2, 4, 2, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.PressedBorderColor = Color.FromArgb(64, 64, 64);
            btnEditar.PressedColor = Color.FromArgb(64, 64, 64);
            btnEditar.Size = new Size(111, 31);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.TextAlignment = StringAlignment.Center;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BorderColor = Color.FromArgb(32, 34, 37);
            btnCancelar.Enabled = false;
            btnCancelar.EnteredBorderColor = Color.FromArgb(64, 64, 64);
            btnCancelar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Image = null;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnCancelar.Location = new Point(660, 286);
            btnCancelar.Margin = new Padding(2, 4, 2, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PressedBorderColor = Color.FromArgb(64, 64, 64);
            btnCancelar.PressedColor = Color.FromArgb(64, 64, 64);
            btnCancelar.Size = new Size(114, 31);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.FromArgb(69, 73, 74);
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.GridColor = SystemColors.ControlDark;
            dgvUsuarios.Location = new Point(32, 325);
            dgvUsuarios.Margin = new Padding(2, 4, 2, 4);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(741, 176);
            dgvUsuarios.TabIndex = 8;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(99, 103, 104);
            btnVoltar.BorderColor = Color.FromArgb(99, 103, 104);
            btnVoltar.EnteredBorderColor = Color.Black;
            btnVoltar.EnteredColor = Color.FromArgb(99, 103, 104);
            btnVoltar.Font = new Font("Microsoft Sans Serif", 12F);
            btnVoltar.Image = null;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.InactiveColor = Color.FromArgb(99, 103, 104);
            btnVoltar.Location = new Point(11, 544);
            btnVoltar.Margin = new Padding(2, 4, 2, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PressedBorderColor = Color.Black;
            btnVoltar.PressedColor = Color.Black;
            btnVoltar.Size = new Size(89, 30);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlignment = StringAlignment.Center;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 103, 104);
            ClientSize = new Size(818, 586);
            Controls.Add(btnEditar);
            Controls.Add(btnVoltar);
            Controls.Add(btnCancelar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnSalvar);
            Controls.Add(thunderGroupBox1);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            Load += FrmUsuarios_Load;
            thunderGroupBox1.ResumeLayout(false);
            thunderGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Button btnNovo;
        private ReaLTaiizor.Controls.Button btnSalvar;
        private ReaLTaiizor.Controls.Button btnExcluir;
        private ReaLTaiizor.Controls.ThunderGroupBox thunderGroupBox1;
        private ReaLTaiizor.Controls.CrownTextBox textEmail;
        private ReaLTaiizor.Controls.CrownTextBox textNome;
        private ReaLTaiizor.Controls.CrownTextBox textId;
        private ReaLTaiizor.Controls.ThunderLabel nome;
        private ReaLTaiizor.Controls.ThunderLabel senha;
        private ReaLTaiizor.Controls.ThunderLabel email;
        private ReaLTaiizor.Controls.ThunderLabel id;
        private ReaLTaiizor.Controls.CrownTextBox textSenha;
        private DataGridView dgvUsuarios;
        private ReaLTaiizor.Controls.Button btnVoltar;
        private ReaLTaiizor.Controls.Button btnCancelar;
        private ReaLTaiizor.Controls.Button btnEditar;
    }
}