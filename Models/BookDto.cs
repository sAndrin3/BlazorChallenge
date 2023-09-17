using System.ComponentModel.DataAnnotations;
namespace BookMgmt.Models{
    public class BookDto{
        public Guid Id {get; set;}
        [Required(ErrorMessage = "Title is required.")]
        public string Title {get; set;} = string.Empty;

        [Required(ErrorMessage = "Description is required.")]
        public string Description {get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Author is required.")]
        public  List<AuthorDto> Author { get; set; } = new List<AuthorDto>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
    
}