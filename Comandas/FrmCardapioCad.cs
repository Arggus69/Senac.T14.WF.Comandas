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
    public partial class FrmCardapioCad : Form
    {
        bool ehNovo = false;

        public FrmCardapioCad(bool acao)
        {
            ehNovo = acao;

            InitializeComponent();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovo)
            {
                AdicionarCardapio();
            }
            else
            {
                AtualizarCardapio();
            }
        }

        private void AtualizarCardapio()
        {
               using (var banco = new AppDbContext()) 
               {
                    var cardapio = banco.Cardapios.FirstOrDefault(f => f.Id == int.Parse(txtId.Text));

                    cardapio.Titulo = txtTitulo.Text;
                    cardapio.Descricao = txtDescricao.Text;
                    cardapio.Preco = decimal.Parse(txtPreco.Text);
                    cardapio.PossuiPreparo = chkPreparo.Checked;
                    banco.SaveChanges();
               }            
        }

        private void AdicionarCardapio()
        {
            using (var banco = new AppDbContext())
            {
                var novoCardapio = new Cardapio()
                {
                    Titulo = txtTitulo.Text,
                    Descricao = txtDescricao.Text,
                    Preco = decimal.Parse(txtPreco.Text),
                    PossuiPreparo = chkPreparo.Checked
                };
                banco.Cardapios.Add(novoCardapio);
                banco.SaveChanges();
            }
        }
    }
}
