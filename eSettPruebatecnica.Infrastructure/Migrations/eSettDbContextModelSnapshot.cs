﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eSettPruebatecnica.Infrastructure.Persistence;

#nullable disable

namespace eSettPruebatecnica.Infrastructure.Migrations
{
    [DbContext(typeof(eSettDbContext))]
    partial class eSettDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eSettPruebatecnica.Domain.Entities.BalanceResponsiblePartie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("brpCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("brpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("businessId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codingScheme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("validityEnd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("validityStart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("BalanceResponsibleParties");
                });

            modelBuilder.Entity("eSettPruebatecnica.Domain.Entities.BalanceServiceProvider", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("bspCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bspName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("businessId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codingScheme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("BalanceServiceProviders");
                });

            modelBuilder.Entity("eSettPruebatecnica.Domain.Entities.DistributionSystemOperator", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("codingScheme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsoCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("DistributionSystemOperators");
                });

            modelBuilder.Entity("eSettPruebatecnica.Domain.Entities.Retailer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("codingScheme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Retailers");
                });
#pragma warning restore 612, 618
        }
    }
}
