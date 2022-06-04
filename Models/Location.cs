namespace BookDB.Models {
    public class Location {
        public int LocationId { get; set; }
        public string City { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
