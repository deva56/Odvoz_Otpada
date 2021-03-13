namespace OdvozOtpada.Models
{
    using System.Data.Entity;

    public partial class ModelsContext : DbContext
    {
        public ModelsContext()
            : base("name=ModelsContext")
        {
        }

        public virtual DbSet<aspnetroles> aspnetroles { get; set; }
        public virtual DbSet<aspnetuserclaims> aspnetuserclaims { get; set; }
        public virtual DbSet<aspnetuserlogins> aspnetuserlogins { get; set; }
        public virtual DbSet<aspnetusers> aspnetusers { get; set; }
        public virtual DbSet<grad> grad { get; set; }
        public virtual DbSet<otpad> otpad { get; set; }
        public virtual DbSet<rasporedodvoza> rasporedodvoza { get; set; }
        public virtual DbSet<ulica> ulica { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<aspnetroles>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetroles>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetroles>()
                .HasMany(e => e.aspnetusers)
                .WithMany(e => e.aspnetroles)
                .Map(m => m.ToTable("aspnetuserroles", "odvoz_otpada").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<aspnetuserclaims>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuserclaims>()
                .Property(e => e.ClaimType)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuserclaims>()
                .Property(e => e.ClaimValue)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuserlogins>()
                .Property(e => e.LoginProvider)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuserlogins>()
                .Property(e => e.ProviderKey)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetuserlogins>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetusers>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetusers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetusers>()
                .Property(e => e.PasswordHash)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetusers>()
                .Property(e => e.SecurityStamp)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetusers>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetusers>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<aspnetusers>()
                .HasMany(e => e.aspnetuserclaims)
                .WithRequired(e => e.aspnetusers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<aspnetusers>()
                .HasMany(e => e.aspnetuserlogins)
                .WithRequired(e => e.aspnetusers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<grad>()
                .Property(e => e.imeGrad)
                .IsUnicode(false);

            modelBuilder.Entity<grad>()
                .HasMany(e => e.ulica)
                .WithRequired(e => e.grad)
                .HasForeignKey(e => e.idGrada);

            modelBuilder.Entity<otpad>()
                .Property(e => e.vrstaOtpad)
                .IsUnicode(false);

            modelBuilder.Entity<otpad>()
                .HasMany(e => e.rasporedodvoza)
                .WithRequired(e => e.otpad)
                .HasForeignKey(e => e.idVrsteOtpada);

            modelBuilder.Entity<rasporedodvoza>()
                .Property(e => e.danTjednaOdvoza)
                .IsUnicode(false);

            modelBuilder.Entity<rasporedodvoza>()
                .Property(e => e.vrijemeOdvoza)
                .IsUnicode(false);

            modelBuilder.Entity<rasporedodvoza>()
                .Property(e => e.datumKreiranja)
                .IsUnicode(false);

            modelBuilder.Entity<rasporedodvoza>()
                .Property(e => e.datumOdvoza)
                .IsUnicode(false);

            modelBuilder.Entity<ulica>()
                .Property(e => e.imeUlica)
                .IsUnicode(false);

            modelBuilder.Entity<ulica>()
                .HasMany(e => e.rasporedodvoza)
                .WithRequired(e => e.ulica)
                .HasForeignKey(e => e.idUlice);
        }
    }
}
