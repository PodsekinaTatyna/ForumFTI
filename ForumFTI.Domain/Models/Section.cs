using System.ComponentModel.DataAnnotations.Schema;

namespace ForumFTI.Domain.Models
{
    [Table("section")]
    public class Section
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public ICollection<Theme> Themes { get; set; }

    }
}
