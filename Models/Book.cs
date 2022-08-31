using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDB.Models {
    public class Book {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string? Title { get; set; }
        public int? PageCount { get; set; }

        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public int? PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }
    }
}
