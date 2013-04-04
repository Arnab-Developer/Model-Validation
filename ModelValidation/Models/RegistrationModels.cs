using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ModelValidation.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Please enter name.")]
        [StringLength(20, ErrorMessage = "Name must be 20 char max.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter phone number.")]
        [StringLength(10, ErrorMessage = "Phone number must be 10 digit max.")]
        [Display(Name = "Phone Number")]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter email.")]
        [StringLength(20, ErrorMessage = "Email must be 20 char max.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$", ErrorMessage = "Please enter valid email id.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter user name.")]
        [StringLength(20, ErrorMessage = "User name must be 20 char max.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password name must be in between 6 to 20 char.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and confirm pssword must match")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public Address AddressDetails { get; set; }
    }

    public class Address
    {
        [Required(ErrorMessage = "Please enter Street name.")]
        [StringLength(20, ErrorMessage = "Streen name must be 20 char max.")]
        [Display(Name = "Street Name")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Please enter state.")]
        [StringLength(20, ErrorMessage = "State must be 20 char max.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter country.")]
        [StringLength(20, ErrorMessage = "Country must be 20 char max.")]
        public string Country { get; set; }
    }

    public interface IRegistrationRepositary
    {
        void Register(Registration reg);
    }

    public class RegistrationRepositary : IRegistrationRepositary
    {
        public void Register(Registration reg)
        {
            // Save new Registration to DB.
        }
    }
}