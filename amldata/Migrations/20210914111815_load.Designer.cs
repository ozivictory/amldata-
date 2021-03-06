// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using amldata.Data;

namespace amldata.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210914111815_load")]
    partial class load
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("amldata.Models.AirbyteData", b =>
                {
                    b.Property<string>("_airbyte_ab_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("_airbyte_data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("_airbyte_emitted_at")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("_airbyte_ab_id");

                    b.ToTable("_airbyte_raw_ctr11");
                });
#pragma warning restore 612, 618
        }
    }
}
