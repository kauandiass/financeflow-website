using System.ComponentModel.DataAnnotations;

namespace FinaFlow.Shared.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    public long Id { get; set; }

    [Required(ErrorMessage = "Invalid title")]
    [MaxLength(80, ErrorMessage = "The title must contain up to 80 characters")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Invalid description")]
    public string? Description { get; set; }
}