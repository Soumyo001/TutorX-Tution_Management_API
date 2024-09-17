﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tutor_X_Tution_Management.Data;

#nullable disable

namespace Tutor_X_Tution_Management.Migrations
{
    [DbContext(typeof(apiDbContext))]
    [Migration("20240915161314_changed_column")]
    partial class changed_column
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.BackgroundChecks", b =>
                {
                    b.Property<int>("checkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("checkId"));

                    b.Property<string>("backgroundCheckedType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("checkedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("result")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("tutorId")
                        .HasColumnType("int");

                    b.HasKey("checkId");

                    b.ToTable("background_checks");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.Messege", b =>
                {
                    b.Property<string>("messegeId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("messegeText")
                        .HasColumnType("longtext");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("timeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("tutorId")
                        .HasColumnType("int");

                    b.HasKey("messegeId");

                    b.ToTable("messege");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.Payment", b =>
                {
                    b.Property<int>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("paymentId"));

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<string>("paymentDate")
                        .HasColumnType("longtext");

                    b.Property<string>("paymentMethod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("paymentStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("sessionId")
                        .HasColumnType("int");

                    b.HasKey("paymentId");

                    b.ToTable("payment");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.Report", b =>
                {
                    b.Property<int>("reportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("reportId"));

                    b.Property<string>("reportDate")
                        .HasColumnType("longtext");

                    b.Property<string>("reportText")
                        .HasColumnType("longtext");

                    b.Property<int>("uidFrom")
                        .HasColumnType("int");

                    b.Property<int>("uidTo")
                        .HasColumnType("int");

                    b.HasKey("reportId");

                    b.ToTable("report");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.Request", b =>
                {
                    b.Property<int>("requestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("requestId"));

                    b.Property<bool>("isFromTutor")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("requestDate")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("uidFrom")
                        .HasColumnType("int");

                    b.Property<int>("uidTo")
                        .HasColumnType("int");

                    b.HasKey("requestId");

                    b.ToTable("request");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.Resource", b =>
                {
                    b.Property<int>("resourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("resourceId"));

                    b.Property<string>("resourceDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("resourceTitle")
                        .HasColumnType("longtext");

                    b.Property<string>("resourceUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("uploadDate")
                        .HasColumnType("longtext");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("resourceId");

                    b.ToTable("resource");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.Session", b =>
                {
                    b.Property<int>("sessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("sessionId"));

                    b.Property<string>("duration")
                        .HasColumnType("longtext");

                    b.Property<string>("endDate")
                        .HasColumnType("longtext");

                    b.Property<string>("sessionStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("startDate")
                        .HasColumnType("longtext");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<int>("tutorId")
                        .HasColumnType("int");

                    b.HasKey("sessionId");

                    b.ToTable("session");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("studentId"));

                    b.Property<string>("StudentMedium")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("firstName")
                        .HasColumnType("longtext");

                    b.Property<string>("imagePath")
                        .HasColumnType("longtext");

                    b.Property<string>("lastName")
                        .HasColumnType("longtext");

                    b.Property<string>("studentSelfDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("studentId");

                    b.ToTable("student");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.StudentPost", b =>
                {
                    b.Property<int>("studentPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("studentPostId"));

                    b.Property<string>("days")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<string>("education")
                        .HasColumnType("longtext");

                    b.Property<string>("fullName")
                        .HasColumnType("longtext");

                    b.Property<string>("location")
                        .HasColumnType("longtext");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<string>("studentMedium")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("studentTypes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("subjectTypes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("studentPostId");

                    b.ToTable("student_post");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.StudentReview", b =>
                {
                    b.Property<int>("studentReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("studentReviewId"));

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.Property<string>("reviewDate")
                        .HasColumnType("longtext");

                    b.Property<string>("reviewText")
                        .HasColumnType("longtext");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<int>("tutorId")
                        .HasColumnType("int");

                    b.HasKey("studentReviewId");

                    b.ToTable("student_review");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.Tutor", b =>
                {
                    b.Property<int>("tutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("tutorId"));

                    b.Property<int>("expectedSalary")
                        .HasColumnType("int");

                    b.Property<string>("expectedStudent")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("imagePath")
                        .HasColumnType("longtext");

                    b.Property<string>("mediumOfInterest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("profession")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("subjectOfInterest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("tutorSelfDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<string>("verificationStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("tutorId");

                    b.ToTable("tutor");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.TutorPost", b =>
                {
                    b.Property<int>("tutorPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("tutorPostId"));

                    b.Property<string>("bio")
                        .HasColumnType("longtext");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<string>("fullName")
                        .HasColumnType("longtext");

                    b.Property<string>("location")
                        .HasColumnType("longtext");

                    b.Property<string>("studentMedium")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("studentTypes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("subjectTypes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("tutorId")
                        .HasColumnType("int");

                    b.HasKey("tutorPostId");

                    b.ToTable("tutor_post");
                });

            modelBuilder.Entity("Tutor_X_Tution_Management.Model.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("education")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("fullName")
                        .HasColumnType("longtext");

                    b.Property<string>("location")
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .HasColumnType("longtext");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("userId");

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}
