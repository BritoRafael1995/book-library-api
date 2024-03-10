﻿// <auto-generated />
using System;
using BookLibrary.DataStore.SQLServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookLibrary.DataStore.SQLServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsAuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsAuthorId", "BooksBookId");

                    b.HasIndex("BooksBookId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("BookBookCategory", b =>
                {
                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.HasKey("BooksBookId", "CategoriesCategoryId");

                    b.HasIndex("CategoriesCategoryId");

                    b.ToTable("BookBookCategory");
                });

            modelBuilder.Entity("BookLibrary.Models.Model.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("author_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LasName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookLibrary.Models.Model.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("BookTypeId")
                        .HasColumnType("int")
                        .HasColumnName("book_type_id");

                    b.Property<int>("CopiesInUse")
                        .HasColumnType("int")
                        .HasColumnName("copies_in_use");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TotalCopies")
                        .HasColumnType("int")
                        .HasColumnName("total_copies");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookId");

                    b.HasIndex("BookTypeId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookLibrary.Models.Model.BookCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("BookLibrary.Models.Model.BookType", b =>
                {
                    b.Property<int>("BookTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("book_type_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookTypeId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookTypeId");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("BookLibrary.Models.Model.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLibrary.Models.Model.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookBookCategory", b =>
                {
                    b.HasOne("BookLibrary.Models.Model.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLibrary.Models.Model.BookCategory", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookLibrary.Models.Model.Book", b =>
                {
                    b.HasOne("BookLibrary.Models.Model.BookType", "BookType")
                        .WithMany("Books")
                        .HasForeignKey("BookTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookType");
                });

            modelBuilder.Entity("BookLibrary.Models.Model.BookType", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
