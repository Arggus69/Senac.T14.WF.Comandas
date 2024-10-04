using Microsoft.VisualBasic;
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
    public partial class FrmCardapio : Form
    {
        public int ID { get; private set; }
        public string? TITULO { get; private set; }
        public string? DESCRICAO { get; private set; }
        public decimal PRECO { get; private set; }
        public bool POSSUI_PREPARO { get; private set; }

        public FrmCardapio()
        {
            InitializeComponent();
            ListarCardapios();
        }

        public void ListarCardapios()
        {
            using (var banco = new AppDbContext())
            {
                var cardapios = banco.Cardapios.ToList();
                dgvCardapio.DataSource = cardapios;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            var ehNovo = true;

            new FrmCardapioCad(ehNovo, this).ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //exibe msg de confirmação
            var result = MessageBox.Show($"Tem Certexa que deseja excluir o item {TITULO}? '-'", "Excluir Cardapio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // se o usuario clicou em n
            if (result == DialogResult.No) 
            { 
                //para o metodo
                return; 
            }
             
            if (ExcluirCardapio(ID))
            {
                ListarCardapios();
                MessageBox.Show($"Item {TITULO} Excluido com Sucesso! ;)");

                btnExcluir.Enabled = false;
            }
        }

        private bool ExcluirCardapio(int ID)
        {
            using (var banco = new AppDbContext())
            {
                var card = banco.Cardapios.FirstOrDefault(c => c.Id == ID );
                banco.Cardapios.Remove(card);
                banco.SaveChanges();
            }
            return true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ehNovo = false;
            new FrmCardapioCad(ehNovo, ID, TITULO, DESCRICAO, PRECO, POSSUI_PREPARO, this).ShowDialog();
        }

        private void dgvCardapio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var numeroLinha = e.RowIndex;

            if (numeroLinha >= 0)
            {
                var id = dgvCardapio.Rows[numeroLinha].Cells["Id"].Value.ToString();
                var titulo = dgvCardapio.Rows[numeroLinha].Cells["Titulo"].Value.ToString();
                var descricao = dgvCardapio.Rows[numeroLinha].Cells["Descricao"].Value.ToString();
                var preco = dgvCardapio.Rows[numeroLinha].Cells["Preco"].Value.ToString();
                var possuiPreparo = dgvCardapio.Rows[numeroLinha].Cells["PossuiPreparo"].Value.ToString();

                //converter para os tipos corretos
                ID = int.Parse(id);
                TITULO = titulo;
                DESCRICAO = descricao;
                PRECO = decimal.Parse(preco);
                POSSUI_PREPARO = bool.Parse(possuiPreparo);

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}
