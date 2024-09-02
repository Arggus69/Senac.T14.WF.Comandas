using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas
{
    public class Usuario
    {
        // propriedades da classe
        //são as colunas da tabela Usuario
        //"set": permite mudar o valor da propriedae
        //"get": permite conseguir a propriedade no projeto inteiro
        //';': usar quando n se tem corpo/{}
        [Key]//: torna a propriedade como primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // : torna a chave auto-encremento
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}
