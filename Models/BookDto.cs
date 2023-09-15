namespace BookMgmt.Models{
    public class BookDto{
        public Guid Id {get; set;}
        public string Title {get; set;} = string.Empty;
        public string Description {get; set; } = string.Empty;
        public  List<AuthorDto> Author { get; set; } = new List<AuthorDto>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
    
}