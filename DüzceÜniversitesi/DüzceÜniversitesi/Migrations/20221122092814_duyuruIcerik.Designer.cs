// <auto-generated />
using DüzceÜniversitesi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DüzceÜniversitesi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221122092814_duyuruIcerik")]
    partial class duyuruIcerik
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DüzceÜniversitesi.Models.Announcement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DuyuruBasligi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DuyuruIcerigi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("announcements");
                });
#pragma warning restore 612, 618
        }
    }
}
