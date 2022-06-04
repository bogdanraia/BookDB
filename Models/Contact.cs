namespace BookDB.Models {
    public class Contact {
        public int ContactId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
