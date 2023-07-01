using SistemaDeVendas.Enums;
using SistemaDeVendas.Models.FornecedorModels;
using SistemaDeVendas.Models.ProdutoModels.TiposProdutoModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models.ProdutoModels
{
    [Table("produto")]
    public class ProdutoModelBase1
    {
    }

    [Table("produto")]
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public decimal CodigoDeBarras { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public string Descricao { get; set; }
        public float PrecoDeCusto { get; set; }
        public float PrecoVendaVarejo { get; set; }
        public float PrecoVendaAtacado { get; set; }
        public UnidadeProdutoModel Unidade { get; set; }
        public bool Ativo { get; set; }
        public FornecedorModel Fornecedor { get; set; }
        public CategoriaProduto CategoriaProduto { get; set; }
        public CategoriaProduto SubcategoriaProduto { get; set; }
        public bool MovimentaEstoque { get; set; }
        public int EstoqueMinimo { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public MarcaProdutoModel MarcaProduto { get; set; }
        public string Modelo { get; set; }
        public decimal CodigoBalanca { get; set; }
        public decimal CodigoInterno { get; set; }
        public FinalidadeProduto FinalidadeProduto { get; set; }
        public RCMProduto RCM { get; set; }
        public int Garantia { get; set; }


        public ProdutoModel() 
        {
            Fornecedor = new FornecedorModel();
            Nome = string.Empty;
        }
    }
}
