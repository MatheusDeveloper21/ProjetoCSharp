using System.ComponentModel;

namespace BeepSystems.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [DisplayName("Código de Barras")]
        public string CodigoDeBarra { get; set; }
        public string Quantidade { get; set; }
        [DisplayName("Preço de Venda")]
        public string PrecoVenda { get; set; }
        [DisplayName("Preço de Compra")]
        public string PrecoCompra { get; set; }
        public string Categoria { get; set; }
    }
}
