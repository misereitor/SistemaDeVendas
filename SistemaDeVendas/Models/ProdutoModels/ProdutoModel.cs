using SistemaDeVendas.Models.FornecedorModels;
using SistemaDeVendas.Models.ProdutoModels.PartesProdutoModel;
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
        public TipoProdutoModel TipoProduto { get; set; }
        public string Descricao { get; set; }
        public float PrecoDeCusto { get; set; }
        public float PrecoVendaVarejo { get; set; }
        public float PrecoVendaAtacado { get; set; }
        public UnidadeProdutoModel Unidade { get; set; }
        public bool Ativo { get; set; }
        public FornecedorModel Fornecedor { get; set; }
        public CategoriaProdutoModel CategoriaProduto { get; set; }
        public bool MovimentaEstoque { get; set; }
        public int EstoqueMinimo { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public MarcaProdutoModel MarcaProduto { get; set; }
        public string Modelo { get; set; }
        public decimal CodigoBalanca { get; set; }
        public decimal CodigoInterno { get; set; }
        public FinalidadeProdutoModel FinalidadeProduto { get; set; }
        public RCMProdutoModel RCM { get; set; }
        public DateOnly DataValidade { get; set; }
        public DateTimeOffset DataCriacao { get; set; } = DateTimeOffset.UtcNow;
        public int Garantia { get; set; }


        public ProdutoModel() 
        {
            Fornecedor = new FornecedorModel();
            TipoProduto = new TipoProdutoModel();
            Unidade = new UnidadeProdutoModel();
            CategoriaProduto = new CategoriaProdutoModel();
            MarcaProduto = new MarcaProdutoModel();
            FinalidadeProduto = new FinalidadeProdutoModel();
            RCM = new RCMProdutoModel();

            Nome = string.Empty;
            Descricao = string.Empty;
            Modelo = string.Empty;
        }
    }
}
