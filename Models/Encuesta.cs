#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace EncuestaDojoValidacion.Models;

public class Encuesta{
    [MinLength(2, ErrorMessage = "The Name must be at least 2 characters.")]
    [Required(ErrorMessage = "The Name is required")]
    public string Name {get; set;}

    [Required(ErrorMessage = "The Ubication is required")]
    [RegularExpression("^(?!-).*", ErrorMessage = "The Ubication is required")]
    public string Location {get; set;}
    
    [Required(ErrorMessage = "Favorite Language is required")]
    [RegularExpression("^(?!-).*", ErrorMessage = "Favorite Language is required")]
    public string FavoriteLanguage {get; set;}

    [MinLength(20, ErrorMessage = "The comment must be at least 20 characters.")]
    public string? Comment {get; set;}

}