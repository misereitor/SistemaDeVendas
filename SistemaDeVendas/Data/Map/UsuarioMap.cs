using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.ToTable("usuario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Funcao).IsRequired();
            builder.Property(x => x.Perfil).IsRequired();
            builder.Property(x => x.PDV).IsRequired();
            builder.Property(x => x.ADMPDV).IsRequired();
            builder.Property(x => x.Vendedor).IsRequired();
            builder.Property(x => x.Comissao);
            builder.Property(x => x.Telefone);
            builder.Property(x => x.CPF).IsRequired();
            builder.Property(x => x.Foto);

            builder.HasMany(x => x.Empresas)
                .WithMany(x => x.Usuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioEmpresa",
                    j => j
                        .HasOne<EmpresaModel>()
                        .WithMany()
                        .HasForeignKey("Empresas")
                        .OnDelete(DeleteBehavior.Cascade),
                    j => j
                        .HasOne<UsuarioModel>()
                        .WithMany()
                        .HasForeignKey("Usuarios")
                        .OnDelete(DeleteBehavior.Cascade),
                    j =>
                    {
                        j.HasKey("Empresas", "Usuarios");
                        j.HasData(new { Empresas = 1, Usuarios = 1 });
                    });
        }
    }
}