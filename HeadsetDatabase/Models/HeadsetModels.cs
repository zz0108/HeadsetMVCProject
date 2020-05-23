namespace HeadsetDatabase.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HeadsetModels : DbContext
    {
        public HeadsetModels()
            : base("name=HeadsetModels")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Client_Table> Client_Table { get; set; }
        public virtual DbSet<Country_Table> Country_Table { get; set; }
        public virtual DbSet<Main_Table> Main_Table { get; set; }
        public virtual DbSet<Manufacturer_Table> Manufacturer_Table { get; set; }
        public virtual DbSet<Product_Table> Product_Table { get; set; }
        public virtual DbSet<Standard_Table> Standard_Table { get; set; }
        public virtual DbSet<text> text { get; set; }
        public virtual DbSet<ButtonType_Table> ButtonType_Table { get; set; }
        public virtual DbSet<Community_Table> Community_Table { get; set; }
        public virtual DbSet<Order_Table> Order_Table { get; set; }
        public virtual DbSet<Return_Table> Return_Table { get; set; }
        public virtual DbSet<Shopping_Car_Table> Shopping_Car_Table { get; set; }
        public virtual DbSet<Type_Table> Type_Table { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Client_Table>()
                .Property(e => e.Account_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Table>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Table>()
                .Property(e => e.Identity_Card)
                .IsUnicode(false);

            modelBuilder.Entity<Client_Table>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Order_Table>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }
    }
}
