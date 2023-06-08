using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.GeralModel;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(u => u.Id);

            // Relacionamento 1 para 1 com EnderecoModel
            builder.HasOne(u => u.Endereco)
                .WithOne()
                .HasForeignKey<UsuarioModel>("EnderecoId");

            // Relacionamento N:N entre UsuarioModel e EmpresaModel
            builder.HasMany(u => u.Empresas)
                .WithMany(e => e.Usuarios)
                .UsingEntity(j => j.ToTable("EmpresaUsuario"));

            // Relacionamento 1:N entre UsuarioModel e DadosBancariosModel
            builder.HasMany(u => u.DadosBancarios)
                .WithOne()
                .HasForeignKey("UsuarioModel_DadosBancariosId")
                .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento 1:N entre UsuarioModel e DocumentoUsuariosModel
            builder.HasMany(u => u.Documentos)
                .WithOne()
                .HasForeignKey("UsuarioModel_DocumentosId")
                .OnDelete(DeleteBehavior.Cascade);

            // Configurações das colunas
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(255);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(150);
            builder.Property(u => u.Usuario).IsRequired().HasMaxLength(64);
            builder.Property(u => u.Senha).IsRequired().HasMaxLength(64);
            builder.Property(u => u.Sexo);
            builder.Property(u => u.DataNascimento);
            builder.Property(u => u.Site);
            builder.Property(u => u.Observacao);
            builder.Property(u => u.Ativo).HasDefaultValue(true);
            builder.Property(u => u.Master).HasDefaultValue(false);
            builder.Property(u => u.OperadorPDV).HasDefaultValue(false);
            builder.Property(u => u.ADMPDV).HasDefaultValue(false);
            builder.Property(u => u.Vendedor).HasDefaultValue(false);
            builder.Property(u => u.Comprador).HasDefaultValue(false);
            builder.Property(u => u.Comissao);
            builder.Property(u => u.Telefone);
            builder.Property(u => u.Celular);
            builder.Property(u => u.CPF);
            builder.Property(u => u.CNPJ);
            builder.Property(u => u.RG);
            builder.Property(u => u.Foto);
            builder.Property<int?>("EnderecoId");
        }
    }
}