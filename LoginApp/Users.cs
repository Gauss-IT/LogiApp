namespace LoginApp
{
    using System.Data.Entity;

    public partial class Users : DbContext
    {
        public Users()
            : base("name=Users")
        {
        }

        public virtual DbSet<User> Useres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
