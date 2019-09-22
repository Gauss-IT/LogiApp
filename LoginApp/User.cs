namespace LoginApp
{
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
