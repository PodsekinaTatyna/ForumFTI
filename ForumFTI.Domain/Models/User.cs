using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumFTI.Domain.Models
{

    [Table("user")]
    public class User
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("loin")]
        public string Login { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("email")]
        public string Email { get; set; }


        public ICollection<Question> Question { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
