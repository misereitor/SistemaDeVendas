using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Models.EmpresaModels;
using SistemaDeVendas.Models.UsuariosModels;

namespace SistemaDeVendas.Data.Map
{
    public class EmpresaMap : IEntityTypeConfiguration<EmpresaModel>
    {
        public void Configure(EntityTypeBuilder<EmpresaModel> builder)
        {
            builder.ToTable("empresa"); // Define o nome da tabela

            builder.HasKey(e => e.Id); // Define a chave primária

            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.NomeFantasia).HasColumnName("NomeFantasia").IsRequired();
            builder.Property(e => e.RazaoSocial).HasColumnName("RazaoSocial").IsRequired();
            builder.Property(e => e.Logo).HasColumnName("Logo").IsRequired();
            builder.Property(e => e.CNPJ).HasColumnName("CNPJ").IsRequired();
            builder.Property(e => e.Ativo).HasColumnName("Ativo").IsRequired();
            builder.Property(e => e.AreaDeAtuacao).HasColumnName("AreaDeAtuacao").IsRequired();
            builder.Property(e => e.Telefone).HasColumnName("Telefone").IsRequired();
            builder.Property(e => e.Email).HasColumnName("Email").IsRequired();
            builder.Property(e => e.IE).HasColumnName("IE").IsRequired();
            builder.Property(e => e.IM).HasColumnName("IM").IsRequired();
            builder.Property(e => e.EnderecoEntregaId).HasColumnName("EnderecoEntregaId").IsRequired();
            builder.Property(e => e.EnderecoFaturamentoId).HasColumnName("EnderecoFaturamentoId").IsRequired();
            builder.Property(e => e.EnderecoCorrespondenciaId).HasColumnName("EnderecoCorrespondenciaId").IsRequired();

            builder.HasMany(e => e.Usuarios)
                .WithMany(u => u.Empresas)
                .UsingEntity<Dictionary<string, object>>(
                    "EmpresaUsuario",
                    j => j
                        .HasOne<UsuarioModel>()
                        .WithMany()
                        .HasForeignKey("Usuarios")
                        .OnDelete(DeleteBehavior.Cascade),
                    j => j
                        .HasOne<EmpresaModel>()
                        .WithMany()
                        .HasForeignKey("Empresas")
                        .OnDelete(DeleteBehavior.Cascade),
                    j =>
                    {
                        j.HasKey("Usuarios", "Empresas");
                        j.HasData(new { Usuarios = 1, Empresas = 1 });
                    });

            builder.HasOne(e => e.EnderecoEntrega)
                .WithOne()
                .HasForeignKey<EmpresaModel>(e => e.EnderecoEntregaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.EnderecoFaturamento)
                .WithOne()
                .HasForeignKey<EmpresaModel>(e => e.EnderecoFaturamentoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.EnderecoCorrespondencia)
                .WithOne()
                .HasForeignKey<EmpresaModel>(e => e.EnderecoCorrespondenciaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}