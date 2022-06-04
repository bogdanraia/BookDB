namespace BookDB.Models {
    public class Publisher {
        public int PublisherId { get; set; }
        public string Name { get; set; }

        public List<Location> Locations { get; set; }
        public List<Book> Books { get; set; }
    }
}
