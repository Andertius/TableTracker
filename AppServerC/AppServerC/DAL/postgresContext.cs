using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AppServerC
{
    public partial class PostgresContext : DbContext
    {
        public PostgresContext()
        {
        }

        public PostgresContext(DbContextOptions<PostgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChainName> ChainNames { get; set; }
        public virtual DbSet<Favourite> Favourites { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<PgBuffercache> PgBuffercaches { get; set; }
        public virtual DbSet<PgStatStatement> PgStatStatements { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<PlaceScheme> PlaceSchemes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersContactDatum> UsersContactData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=table-tracker-db.postgres.database.azure.com;Port=5432;Username=TableTrackerMaster@table-tracker-db;Password=\"`T@77n^FLBZzZ$sh\";Database=postgres;Ssl Mode=Require;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_buffercache")
                .HasPostgresExtension("pg_stat_statements")
                .HasAnnotation("Relational:Collation", "English_United States.1252");

            modelBuilder.Entity<ChainName>(entity =>
            {
                entity.ToTable("chainNames");

                entity.HasIndex(e => e.Name, "chainNames_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Favourite>(entity =>
            {
                entity.ToTable("favourites");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PlaceId).HasColumnName("placeId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Favourites)
                    .HasForeignKey(d => d.PlaceId)
                    .HasConstraintName("favourites_placeId_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Favourites)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("favourites_userId_fkey");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.PlaceId).HasColumnName("placeId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.PlaceId)
                    .HasConstraintName("history_placeId_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("history_userId_fkey");
            });

            modelBuilder.Entity<PgBuffercache>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pg_buffercache");

                entity.Property(e => e.Bufferid).HasColumnName("bufferid");

                entity.Property(e => e.Isdirty).HasColumnName("isdirty");

                entity.Property(e => e.PinningBackends).HasColumnName("pinning_backends");

                entity.Property(e => e.Relblocknumber).HasColumnName("relblocknumber");

                entity.Property(e => e.Reldatabase)
                    .HasColumnType("oid")
                    .HasColumnName("reldatabase");

                entity.Property(e => e.Relfilenode)
                    .HasColumnType("oid")
                    .HasColumnName("relfilenode");

                entity.Property(e => e.Relforknumber).HasColumnName("relforknumber");

                entity.Property(e => e.Reltablespace)
                    .HasColumnType("oid")
                    .HasColumnName("reltablespace");

                entity.Property(e => e.Usagecount).HasColumnName("usagecount");
            });

            modelBuilder.Entity<PgStatStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pg_stat_statements");

                entity.Property(e => e.BlkReadTime).HasColumnName("blk_read_time");

                entity.Property(e => e.BlkWriteTime).HasColumnName("blk_write_time");

                entity.Property(e => e.Calls).HasColumnName("calls");

                entity.Property(e => e.Dbid)
                    .HasColumnType("oid")
                    .HasColumnName("dbid");

                entity.Property(e => e.LocalBlksDirtied).HasColumnName("local_blks_dirtied");

                entity.Property(e => e.LocalBlksHit).HasColumnName("local_blks_hit");

                entity.Property(e => e.LocalBlksRead).HasColumnName("local_blks_read");

                entity.Property(e => e.LocalBlksWritten).HasColumnName("local_blks_written");

                entity.Property(e => e.MaxTime).HasColumnName("max_time");

                entity.Property(e => e.MeanTime).HasColumnName("mean_time");

                entity.Property(e => e.MinTime).HasColumnName("min_time");

                entity.Property(e => e.Query).HasColumnName("query");

                entity.Property(e => e.Queryid).HasColumnName("queryid");

                entity.Property(e => e.Rows).HasColumnName("rows");

                entity.Property(e => e.SharedBlksDirtied).HasColumnName("shared_blks_dirtied");

                entity.Property(e => e.SharedBlksHit).HasColumnName("shared_blks_hit");

                entity.Property(e => e.SharedBlksRead).HasColumnName("shared_blks_read");

                entity.Property(e => e.SharedBlksWritten).HasColumnName("shared_blks_written");

                entity.Property(e => e.StddevTime).HasColumnName("stddev_time");

                entity.Property(e => e.TempBlksRead).HasColumnName("temp_blks_read");

                entity.Property(e => e.TempBlksWritten).HasColumnName("temp_blks_written");

                entity.Property(e => e.TotalTime).HasColumnName("total_time");

                entity.Property(e => e.Userid)
                    .HasColumnType("oid")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.ToTable("places");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cuisine)
                    .HasColumnType("character varying")
                    .HasColumnName("cuisine");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.PlaceId).HasColumnName("placeId");

                entity.Property(e => e.PlaceType)
                    .HasColumnType("character varying")
                    .HasColumnName("placeType");

                entity.Property(e => e.PriceRange).HasColumnName("priceRange");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.HasOne(d => d.PlaceNavigation)
                    .WithMany(p => p.Places)
                    .HasForeignKey(d => d.PlaceId)
                    .HasConstraintName("places_placeId_fkey");
            });

            modelBuilder.Entity<PlaceScheme>(entity =>
            {
                entity.ToTable("placeSchemes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PlaceId).HasColumnName("placeId");

                entity.Property(e => e.PlaceScheme1)
                    .HasColumnType("character varying")
                    .HasColumnName("placeScheme");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.PlaceSchemes)
                    .HasForeignKey(d => d.PlaceId)
                    .HasConstraintName("placeSchemes_placeId_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PlaceSchemes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("placeSchemes_userId_fkey");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email, "users_email_key")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "users_username_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasColumnType("character varying")
                    .HasColumnName("avatar");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasColumnType("character varying")
                    .HasColumnName("password");

                entity.Property(e => e.Roles).HasColumnName("roles");

                entity.Property(e => e.Salt)
                    .HasColumnType("character varying")
                    .HasColumnName("salt");

                entity.Property(e => e.Username)
                    .HasColumnType("character varying")
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UsersContactDatum>(entity =>
            {
                entity.ToTable("usersContactData");

                entity.HasIndex(e => e.PhoneNumber, "usersContactData_phoneNumber_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Surname)
                    .HasColumnType("character varying")
                    .HasColumnName("surname");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersContactData)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("usersContactData_userId_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
