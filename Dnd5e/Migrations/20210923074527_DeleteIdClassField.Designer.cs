﻿// <auto-generated />
using System;
using Dnd5e;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dnd5e.Migrations
{
    [DbContext(typeof(CharacterContext))]
    [Migration("20210923074527_DeleteIdClassField")]
    partial class DeleteIdClassField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dnd5e.Entities.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aligment")
                        .HasColumnType("int");

                    b.Property<int>("CharismaScore")
                        .HasColumnType("int");

                    b.Property<int?>("ClassesId")
                        .HasColumnType("int");

                    b.Property<int>("ConstitutionScore")
                        .HasColumnType("int");

                    b.Property<int>("DexterityScore")
                        .HasColumnType("int");

                    b.Property<int>("FlyingSpeed")
                        .HasColumnType("int");

                    b.Property<int>("HitPoints")
                        .HasColumnType("int");

                    b.Property<int>("IntelligenceScore")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StrengthScore")
                        .HasColumnType("int");

                    b.Property<int>("SwimingSpeed")
                        .HasColumnType("int");

                    b.Property<int>("WalkingSpeed")
                        .HasColumnType("int");

                    b.Property<int>("WisdomScore")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.HasIndex("ClassesId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Dnd5e.Entities.CharacterSkill", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("SkillBonusType")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "SkillId");

                    b.ToTable("CharacterSkills");
                });

            modelBuilder.Entity("Dnd5e.Entities.Classes", b =>
                {
                    b.Property<int>("ClassesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassesId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Dnd5e.Entities.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AbilityType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Dnd5e.Entities.Character", b =>
                {
                    b.HasOne("Dnd5e.Entities.Classes", "Classes")
                        .WithMany("Characters")
                        .HasForeignKey("ClassesId");

                    b.Navigation("Classes");
                });

            modelBuilder.Entity("Dnd5e.Entities.Classes", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}