﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewQuizApp.Data;

#nullable disable

namespace NewQuizApp.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    partial class QuizContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NewQuizApp.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerOptions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CorrectAnswer")
                        .HasColumnType("int");

                    b.Property<string>("ImageSource")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnswerOptions = "[\"Overdose\",\"Stabbing\",\"Car accident\",\"Drowning\"]",
                            CorrectAnswer = 2,
                            ImageSource = "https://assets.mycast.io/actor_images/actor-alaska-young-461105_large.jpg?1655621246",
                            QuizId = 1,
                            Text = "How does Alaska die?"
                        },
                        new
                        {
                            Id = 2,
                            AnswerOptions = "[\"Room 56\",\"Room 18\",\"Room 42\",\"Room 43\"]",
                            CorrectAnswer = 3,
                            ImageSource = "https://www.refinery29.com/images/8598766.jpg",
                            QuizId = 1,
                            Text = "What room do Pudge and the Colonel live in?"
                        });
                });

            modelBuilder.Entity("NewQuizApp.Models.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageSource")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quizzes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageSource = "https://m.media-amazon.com/images/I/81ckDwn0FdL._AC_UF1000,1000_QL80_.jpg",
                            Title = "Looking for Alaska"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}