using System;
using System.Collections.Generic;
using GNN_DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Data;

public partial class GNNDbContext : DbContext
{
    public GNNDbContext(DbContextOptions<GNNDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<Bookmark> Bookmarks { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<CountriesOfNews> CountriesOfNews { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventsNews> EventsNews { get; set; }

    public virtual DbSet<Journalist> Journalists { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NewsAgency> NewsAgencies { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<RatesOfNewsAgency> RatesOfNewsAgencies { get; set; }

    public virtual DbSet<Story> Stories { get; set; }

    public virtual DbSet<Technician> Technicians { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.Admins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admins_Users");
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.Property(e => e.ApplicationStatus)
                .HasDefaultValue((byte)1)
                .HasComment("1 = Review | 2 = Accepted | 3 = Rejected | 4 = Cancelled");

            entity.HasOne(d => d.ApplicantJournalist).WithMany(p => p.Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Applications_JournalistID");

            entity.HasOne(d => d.NewsAgencyCountry).WithMany(p => p.Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Applications_Country");
        });

        modelBuilder.Entity<Bookmark>(entity =>
        {
            entity.HasKey(e => e.BookmarkID).HasName("PK_Archives");

            entity.HasOne(d => d.News).WithMany(p => p.Bookmarks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bookmarks_News");

            entity.HasOne(d => d.User).WithMany(p => p.Bookmarks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bookmarks_Users");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryID).ValueGeneratedNever();
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasOne(d => d.News).WithMany(p => p.Comments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comments_News");

            entity.HasOne(d => d.Person).WithMany(p => p.Comments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comments_Person");
        });

        modelBuilder.Entity<CountriesOfNews>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Country).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CountriesOfNews_Country");

            entity.HasOne(d => d.News).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CountriesOfNews_News");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.Property(e => e.CountryID).ValueGeneratedNever();
        });

        modelBuilder.Entity<EventsNews>(entity =>
        {
            entity.HasOne(d => d.Event).WithMany(p => p.EventsNews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventsNews_Event");

            entity.HasOne(d => d.News).WithMany(p => p.EventsNews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventsNews_News");
        });

        modelBuilder.Entity<Journalist>(entity =>
        {
            entity.Property(e => e.NewsAgencyID).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.NewsAgency).WithMany(p => p.Journalists).HasConstraintName("FK_Journalist_NewsAgency");

            entity.HasOne(d => d.User).WithMany(p => p.Journalists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Journalist_User");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasOne(d => d.Country).WithMany(p => p.News).HasConstraintName("FK_News_Countries");

            entity.HasOne(d => d.Journalist).WithMany(p => p.News)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_News_Journalist");
        });

        modelBuilder.Entity<NewsAgency>(entity =>
        {
            entity.HasOne(d => d.Country).WithMany(p => p.NewsAgencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NewsAgencies_Countries");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasOne(d => d.Country).WithMany(p => p.People)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_People_Countries");
        });

        modelBuilder.Entity<RatesOfNewsAgency>(entity =>
        {
            entity.HasOne(d => d.Agency).WithMany(p => p.RatesOfNewsAgencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RatesOfNewsAgencies_Agency");

            entity.HasOne(d => d.User).WithMany(p => p.RatesOfNewsAgencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RatesOfNewsAgencies_User");
        });

        modelBuilder.Entity<Story>(entity =>
        {
            entity.Property(e => e.CountReadings).HasDefaultValue(1);

            entity.HasOne(d => d.Journalist).WithMany(p => p.Stories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stories_Journalist");
        });

        modelBuilder.Entity<Technician>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.Technicians)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Technicians_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(d => d.Person).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Person");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
