using System.ComponentModel.DataAnnotations;
using RemindMeal.Models;

namespace RemindMeal.ModelViews
{
    public class RecipeEditModelView
    {   
        [Required]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Nom")]
        public string Name { get; set; }
        
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Type")]
        public RecipeType Type { get; set; }
    }
}