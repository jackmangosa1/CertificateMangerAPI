﻿// <auto-generated />
using System;
using CertificateMangerAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CertificateMangerAPI.Migrations
{
    [DbContext(typeof(CertificateManagerDbContext))]
    [Migration("20240919135208_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CertificateMangerAPI.Models.Certificate", b =>
                {
                    b.Property<int>("CertificateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CertificateID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CertificateId"));

                    b.Property<int>("CertificateTypeId")
                        .HasColumnType("int")
                        .HasColumnName("CertificateTypeID");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("PdfDocumentUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)")
                        .HasColumnName("PdfDocumentURL");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("SupplierID");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateOnly>("ValidFrom")
                        .HasColumnType("date");

                    b.Property<DateOnly>("ValidTo")
                        .HasColumnType("date");

                    b.HasKey("CertificateId")
                        .HasName("PK__Certific__BBF8A7E193AC33B4");

                    b.HasIndex("CertificateTypeId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.CertificateAssignment", b =>
                {
                    b.Property<int>("CertificateAssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CertificateAssignmentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CertificateAssignmentId"));

                    b.Property<int>("CertificateId")
                        .HasColumnType("int")
                        .HasColumnName("CertificateID");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int")
                        .HasColumnName("ParticipantID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("CertificateAssignmentId")
                        .HasName("PK__Certific__C0E318BD1C73635D");

                    b.HasIndex("CertificateId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("CertificateAssignments");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.CertificateType", b =>
                {
                    b.Property<int>("CertificateTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CertificateTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CertificateTypeId"));

                    b.Property<string>("CertificateTypeName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("CertificateTypeId")
                        .HasName("PK__Certific__78F0E8D98089782E");

                    b.ToTable("CertificateTypes");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CommentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<int>("CertificateId")
                        .HasColumnType("int")
                        .HasColumnName("CertificateID");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("CommentId")
                        .HasName("PK__Comments__C3B4DFAA81EA7E70");

                    b.HasIndex("CertificateId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DepartmentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("DepartmentId")
                        .HasName("PK__Departme__B2079BCD77726975");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ParticipantID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParticipantId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("DepartmentID");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Plant")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("ParticipantId")
                        .HasName("PK__Particip__7227997E79746700");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SupplierID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("SupplierIndex")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("SupplierId")
                        .HasName("PK__Supplier__4BE66694E3917704");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CCAC5B6B3EA7");

                    b.HasIndex(new[] { "Username" }, "UQ__Users__536C85E4CF2B83DF")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "UQ__Users__A9D10534D8CAB45A")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Certificate", b =>
                {
                    b.HasOne("CertificateMangerAPI.Models.CertificateType", "CertificateType")
                        .WithMany("Certificates")
                        .HasForeignKey("CertificateTypeId")
                        .IsRequired()
                        .HasConstraintName("FK__Certifica__Certi__44FF419A");

                    b.HasOne("CertificateMangerAPI.Models.Supplier", "Supplier")
                        .WithMany("Certificates")
                        .HasForeignKey("SupplierId")
                        .IsRequired()
                        .HasConstraintName("FK__Certifica__Suppl__440B1D61");

                    b.Navigation("CertificateType");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.CertificateAssignment", b =>
                {
                    b.HasOne("CertificateMangerAPI.Models.Certificate", "Certificate")
                        .WithMany("CertificateAssignments")
                        .HasForeignKey("CertificateId")
                        .IsRequired()
                        .HasConstraintName("FK__Certifica__Certi__4CA06362");

                    b.HasOne("CertificateMangerAPI.Models.Participant", "Participant")
                        .WithMany("CertificateAssignments")
                        .HasForeignKey("ParticipantId")
                        .IsRequired()
                        .HasConstraintName("FK__Certifica__Parti__4D94879B");

                    b.Navigation("Certificate");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Comment", b =>
                {
                    b.HasOne("CertificateMangerAPI.Models.Certificate", "Certificate")
                        .WithMany("Comments")
                        .HasForeignKey("CertificateId")
                        .IsRequired()
                        .HasConstraintName("FK__Comments__Certif__47DBAE45");

                    b.HasOne("CertificateMangerAPI.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Comments__UserID__48CFD27E");

                    b.Navigation("Certificate");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Participant", b =>
                {
                    b.HasOne("CertificateMangerAPI.Models.Department", "Department")
                        .WithMany("Participants")
                        .HasForeignKey("DepartmentId")
                        .IsRequired()
                        .HasConstraintName("FK__Participa__Depar__398D8EEE");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Certificate", b =>
                {
                    b.Navigation("CertificateAssignments");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.CertificateType", b =>
                {
                    b.Navigation("Certificates");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Department", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Participant", b =>
                {
                    b.Navigation("CertificateAssignments");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.Supplier", b =>
                {
                    b.Navigation("Certificates");
                });

            modelBuilder.Entity("CertificateMangerAPI.Models.User", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
