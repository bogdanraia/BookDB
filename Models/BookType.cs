namespace BookDB.Models {
    public class BookType {
        public int BookTypeId { get; set; }
        public string Type { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
