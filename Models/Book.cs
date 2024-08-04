using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models;

public class Book
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Required field")]
    public string Title { get; set; }
    
    public Status Status { get; set; } = Status.Available;
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

public enum Status
{
    Available = 1,
    Rented = 2
}