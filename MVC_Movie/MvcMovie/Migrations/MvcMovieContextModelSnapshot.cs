﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace MvcMovie.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("MvcMovie.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EpisodeNumber")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Poster")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Runtime")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<int?>("SeasonId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SeasonNumber")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<int?>("VideoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.HasIndex("VideoId");

                    b.ToTable("Episode");
                });

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Poster")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Runtime")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("TmdbId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("VideoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VideoId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MvcMovie.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Poster")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<int?>("SeasonNumber")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ShowId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("MvcMovie.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genres")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NumberOfSeasons")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Poster")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<int?>("TmdbId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Show");
                });

            modelBuilder.Entity("MvcMovie.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Filepath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("MvcMovie.Models.Episode", b =>
                {
                    b.HasOne("MvcMovie.Models.Season", "Season")
                        .WithMany("Episodes")
                        .HasForeignKey("SeasonId");

                    b.HasOne("MvcMovie.Models.Video", "Video")
                        .WithMany()
                        .HasForeignKey("VideoId");

                    b.Navigation("Season");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
                {
                    b.HasOne("MvcMovie.Models.Video", "Video")
                        .WithMany()
                        .HasForeignKey("VideoId");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("MvcMovie.Models.Season", b =>
                {
                    b.HasOne("MvcMovie.Models.Show", "Show")
                        .WithMany("Seasons")
                        .HasForeignKey("ShowId");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("MvcMovie.Models.Season", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("MvcMovie.Models.Show", b =>
                {
                    b.Navigation("Seasons");
                });
#pragma warning restore 612, 618
        }
    }
}
