using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmUsuarios : Form
    {
        private bool ehNovo;

        public FrmUsuarios()
        {
            InitializeComponent();
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            // Conectar ao banco
            using (var banco = new AppDbContext())
            {
                // SELECT * FROM usuarios;
                var Usuarios = banco.Usuarios.ToList();
                // Popular a tabela na tela DataGrind
                dgvUsuarios.DataSource = Usuarios;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovo)
                CriarUsuario();
            else
                AtualizarUsuario();

            desabilitarCampos();
            ListarUsuarios();
            limparCampos();

            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void desabilitarCampos()
        {
            textNome.Enabled = false;
            textEmail.Enabled = false;
            textSenha.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
            habilitarCampos();
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void habilitarCampos()
        {
            textNome.Enabled = true;
            textEmail.Enabled = true;
            textSenha.Enabled = true;
        }

        // metodo para atualizar um usuario no banco
        private void AtualizarUsuario()
        {
            using (var banco = new AppDbContext())
            {
                //consulta um usuario na tebela usando o Id da tela
                var usuario = banco
                    .Usuarios
                    .Where(e => e.Id == int.Parse(textId.Text))
                    .FirstOrDefault();

                usuario.Nome = textNome.Text;
                usuario.Email = textEmail.Text;
                usuario.Senha = textSenha.Text;
                banco.SaveChanges();
            }
        }
        //metodo para inserir usuario no banco
        private void CriarUsuario()
        {
            //acessar o banco
            using (var banco = new AppDbContext())
            {
                //criar um novo usuario
                var novoUsuario = new Usuario();
                //atribui as propriedades do usuario
                novoUsuario.Nome = textNome.Text;
                novoUsuario.Email = textEmail.Text;
                novoUsuario.Senha = textSenha.Text;

                //salvar as alterações(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();

                MessageBox.Show("Usuário Casdastrado com sucesso.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //indica que está editando um usuario
            ehNovo = false;
            habilitarCampos();
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void limparCampos()
        {
            textId.Text = string.Empty;
            textNome.Text = string.Empty;
            textEmail.Text = string.Empty;
            textSenha.Text = string.Empty;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            //conectar no banco
            using (var banco = new AppDbContext())
            {
                //realizar uma cinsulta na tabela usuarios
                var usuarios = banco.Usuarios.ToList();
                //popular os dados do grid(dataGridView)
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica se o indice da linha é > ou = a 0
            if (e.RowIndex >= 0)
            {
                // msg = "Linha selecionada 1"
                //MessageBox.Show("linha " + (e.RowIndex + 1) + " Selecionada");

                //obter dados da lista
                var id = dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var nome = dgvUsuarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                var email = dgvUsuarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var senha = dgvUsuarios.Rows[e.RowIndex].Cells["Senha"].Value.ToString();

                textId.Text = id;
                textNome.Text = nome;
                textEmail.Text = email;
                textSenha.Text = senha;

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //obtem o id do usuario na tela
            var idUsuario = Convert.ToInt32(textId.Text);
            // chama o metodo que excluir da tabela usuario
            ExcluirUsuario(idUsuario);
            ListarUsuarios();
            limparCampos();
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            MessageBox.Show("Usuario excluido com sucesso");
        }

        private void ExcluirUsuario(int idUsuario)
        {
            // conectar no banco de dados
            using (var banco = new AppDbContext())
            {
                //SELECT * FROM usuarios WHERE id = ?
                // consultar o usuario
                var usuario = banco
                                .Usuarios
                                    .First(u => u.Id
                                           .Equals(idUsuario)
                                       );
            //avisar o banco q estou excluindo
            //DELETE FROM usuario WHERE id = ?
            banco.Usuarios.Remove(usuario);

            //confirmar a exclusao
            //COMMIT
            banco.SaveChanges();
            }
        }
    }
}