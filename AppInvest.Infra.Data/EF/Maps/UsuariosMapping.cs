using AppInvest.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace AppInvest.Infra.Data.EF.Maps;

public class UsuariosMapping : IEntityTypeConfiguration<UsuariosInvest>
{

    public void Configure(EntityTypeBuilder<UsuariosInvest> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Email)
         .HasMaxLength(100)
            .IsRequired();


    }

}
