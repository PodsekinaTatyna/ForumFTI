using System.ComponentModel.DataAnnotations.Schema;

namespace ForumFTI.Domain.Models
{

    [Table("question")]
    public class Question
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("section_id")]
        public Guid SectionId { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("ount_of_msg")]
        public int CountOfMsg { get; set; }

        [Column("message")]
        public string Message { get; set; }

        [Column("date", TypeName = "date")]
        public DateTime Date { get; set; }

        public Theme Section { get; set; }

        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
