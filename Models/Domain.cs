namespace BookDB.Models {
    public class Domain {
        public int DomainId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
