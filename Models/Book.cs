namespace BookDB.Models {
    public class Book {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<Genre> Genres { get; set; }
        public ICollection<Domain> Domains { get; set; }
        public ICollection<BookType> BookTypes { get; set; }
    }
}
