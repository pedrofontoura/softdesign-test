using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models;

public class Book
{
    public int Id { get; set; }
    
    [DisplayName("Title")]
    [Required(ErrorMessage = "Required field")]
    public string Title { get; set; }
    
    [DisplayName("Synopsis")]
    public string Synopsis { get; set; }
    
    [DisplayName("Status")]
    public Status Status { get; set; } = Status.Available;
    
    [DisplayName("Created at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    [DisplayName("Updated at")]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

public enum Status
{
    Available = 1,
    Rented = 2
}