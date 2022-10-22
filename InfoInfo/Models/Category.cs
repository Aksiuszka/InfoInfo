using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InfoInfo.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Identyfikator wymagany")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Musi zostać podane")]
        [Display(Name = "Nazwa Kategorii")]
        [MaxLength(50, ErrorMessage = "Nazwa kategorii nie może być dłuższa niż 50 znaków")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Musi zostać podane")]
        [Display(Name = "Opis")]
        [MaxLength(255, ErrorMessage = "Imię nie może być dłuższa niż 255 znaków")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Musi zostać podane")]
        [Display(Name = "Ikona")]
        [MaxLength(30, ErrorMessage = "Opis nie może być dłuższe niż 255 znaków")]
        public string? Icon { get; set; }

        [Required]
        [Display(Name = "Czy aktywna:")]
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Czy wyswietlać: ")]
        [DefaultValue(true)]
   
        public bool IsDisplayed { get; set; }

        public virtual List<Text>? Texts { get; set; }
    } 
}
