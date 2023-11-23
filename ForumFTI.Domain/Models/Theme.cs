using System.ComponentModel.DataAnnotations.Schema;

namespace ForumFTI.Domain.Models
{
    [Table("theme")]
    public class Theme
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name{ get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
