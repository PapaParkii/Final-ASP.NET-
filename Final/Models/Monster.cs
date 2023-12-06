using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Monster
    {
        //validation and errors
        public int MonsterID { get; set; }

        [Required(ErrorMessage = "Please Enter a Name.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter a Rating.")]
        [Range(1, 5, ErrorMessage = "Rating Must be Between 1 and 5.")]
        public int? Rating { get; set; }
    }
}
