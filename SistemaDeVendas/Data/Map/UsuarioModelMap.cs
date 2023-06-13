using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.GeralModels;
using SistemaDeVendas.Models.Permissoes;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data.Map
{
    public class UsuarioModelMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {

            builder.ToTable("usuario");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnName("id");

            builder.Property(u => u.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            builder.Property(u => u.Email).HasColumnName("email").HasMaxLength(150).IsRequired();
            builder.Property(u => u.Usuario).HasColumnName("usuario").HasMaxLength(30).IsRequired();
            builder.Property(u => u.Senha).HasColumnName("senha").HasMaxLength(20).IsRequired();
            builder.Property(u => u.Sexo).HasColumnName("sexo").IsRequired();
            builder.Property(u => u.DataNascimento).HasColumnName("data_nascimento").IsRequired();
            builder.Property(u => u.Site).HasColumnName("site");
            builder.Property(u => u.Observacao).HasColumnName("observacao");
            builder.Property(u => u.Ativo).HasColumnName("ativo").HasDefaultValue(true);
            builder.Property(u => u.Master).HasColumnName("master").HasDefaultValue(false);
            builder.Property(u => u.OperadorPDV).HasColumnName("operador_pdv").HasDefaultValue(false);
            builder.Property(u => u.ADMPDV).HasColumnName("adm_pdv").HasDefaultValue(false);
            builder.Property(u => u.Vendedor).HasColumnName("vendedor").HasDefaultValue(false);
            builder.Property(u => u.Comprador).HasColumnName("comprador").HasDefaultValue(false);
            builder.Property(u => u.Comissao).HasColumnName("comissao");
            builder.Property(u => u.Telefone).HasColumnName("telefone");
            builder.Property(u => u.Celular).HasColumnName("celular");
            builder.Property(u => u.TipoPessoa).HasColumnName("tipo_pessoa").IsRequired();
            builder.Property(u => u.CPF).HasColumnName("cpf");
            builder.Property(u => u.CNPJ).HasColumnName("cnpj");
            builder.Property(u => u.IE).HasColumnName("ie");
            builder.Property(u => u.RG).HasColumnName("rg");
            builder.Property(u => u.Foto).HasColumnName("foto");

            builder.Ignore(u => u.Empresa);

            builder.HasOne(u => u.Endereco).WithMany().HasForeignKey(u => u.EnderecoId);
            builder.HasMany(u => u.DadosBancarios).WithOne().HasForeignKey("UsuarioId").IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.Documentos).WithOne().HasForeignKey(d => d.UsuarioId);
            builder.HasMany(u => u.Empresas).WithMany(e => e.Usuarios).UsingEntity<Dictionary<string, object>>(
                "UsuarioEmpresa",
                uj => uj.HasOne<EmpresaModel>().WithMany().HasForeignKey("EmpresaId").OnDelete(DeleteBehavior.Cascade),
                ej => ej.HasOne<UsuarioModel>().WithMany().HasForeignKey("UsuarioId").OnDelete(DeleteBehavior.Cascade),
                uej =>
                {
                    uej.HasKey("UsuarioId", "EmpresaId");
                    uej.HasIndex("EmpresaId", "UsuarioId").IsUnique();
                    uej.ToTable("usuario_empresa");
                });

            builder.HasOne(u => u.Grupo).WithMany().HasForeignKey(u => u.GrupoId);
            builder.HasKey(u => u.Id);

        }
    }
}