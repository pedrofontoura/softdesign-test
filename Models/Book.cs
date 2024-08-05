using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models;

public class Book
{
    public int Id { get; set; }
    
    [DisplayName("Title")]
    [Required(ErrorMessage = "Required field")]
    [StringLength(200, ErrorMessage = "Title must have 200 characters or less")]
    public string Title { get; set; }
    
    [DisplayName("Synopsis")]
    [StringLength(10000, ErrorMessage = "Synopsis must have 10000 characters or less")]
    public string Synopsis { get; set; }
    
    [DisplayName("Status")]
    public BookStatus Status { get; set; } = BookStatus.Available;
    
    [DisplayName("Created at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    [DisplayName("Updated at")]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

public enum BookStatus
{
    Available = 1,
    Rented = 2
}