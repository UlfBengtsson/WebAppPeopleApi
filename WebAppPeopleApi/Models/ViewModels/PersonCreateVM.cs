using System.ComponentModel.DataAnnotations;

namespace WebAppPeopleApi.Models.ViewModels
{
    public class PersonCreateVM
    {

        [Required]
        [StringLength(80, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(120, MinimumLength = 5)]
        public string Email { get; set; }

        public string Title { get; set; }
    }
}
