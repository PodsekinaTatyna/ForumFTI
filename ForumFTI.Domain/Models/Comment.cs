using System.ComponentModel.DataAnnotations.Schema;

namespace ForumFTI.Domain.Models
{
    [Table("сomment")]
    public class Comment
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("thread_id")]
        public Guid ThreadId { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("message")]
        public string Message { get; set; }

        [Column("date", TypeName = "date")]
        public DateTime Date { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        public Question Question { get; set; }

        public User User { get; set; }

    }
}
