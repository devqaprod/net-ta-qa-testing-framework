﻿// <auto-generated />
using System;
using ApplicationName.Databases.MySql.AppDatabase.WhoIsWhoSchema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApplicationName.Databases.MySql.AppDatabase.WhoIsWhoSchema.Migrations
{
    [DbContext(typeof(WhoIsWhoAppDatabaseDbContext))]
    partial class WhoIsWhoAppDatabaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApplicationName.ModelsAndFacilities.EntityModels.WhoIsWho.UserPasswordEntityModel", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("varchar(128)")
                        .HasColumnName("UserName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(512)")
                        .HasColumnName("Password");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ValidFrom");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ValidTo");

                    b.HasKey("UserName");

                    b.ToTable("users_passwords", (string)null);
                });

            modelBuilder.Entity("ApplicationName.ModelsAndFacilities.EntityModels.WhoIsWho.UserXApiKeyEntityModel", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("varchar(128)")
                        .HasColumnName("UserName");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ValidFrom");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ValidTo");

                    b.Property<string>("XApiKey")
                        .IsRequired()
                        .HasColumnType("varchar(512)")
                        .HasColumnName("XApiKey");

                    b.HasKey("UserName");

                    b.HasIndex("XApiKey")
                        .IsUnique()
                        .HasDatabaseName("UX_Users_X_Api_Keys_XApiKey");

                    b.ToTable("users_x_api_keys", (string)null);
                });

            modelBuilder.Entity("ApplicationName.ModelsAndFacilities.EntityModels.WhoIsWho.UserXApiKeyEntityModel", b =>
                {
                    b.HasOne("ApplicationName.ModelsAndFacilities.EntityModels.WhoIsWho.UserPasswordEntityModel", "UserPasswordEntityModel")
                        .WithMany()
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserPasswordEntityModel");
                });
#pragma warning restore 612, 618
        }
    }
}
