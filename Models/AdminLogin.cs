using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace SLTBBooking.Models;

[Table("TableAdminLogin")]
public class AdminLogin
{
    [Key]
    public int AdminId { get; set; }
    
    [Required(ErrorMessage = "User Name is Required")]
    [Display(Name = "User Name")]
    public string AdminName { get; set; }
    
    
    [Required(ErrorMessage = "Password is Required")]
    [DataType(DataType.Password)]
    [MinLength(5,ErrorMessage = "Min 5 characters Required"),MaxLength(10,ErrorMessage = "Max charcters are allowe is 10")]
    public string AdminPassword { get; set; }
    
}

[Table("TabelUserLogin")]
public class UserLogin
{
    [Key]
    public int UserId { get; set; }
    
    [Required(ErrorMessage = "First Name is Required")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Last Name is Required")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Email Address is Required")]
    [Display(Name = "Email Address")]
    public string EmailId { get; set; }
    
    [Required(ErrorMessage = "NIC NUmber is Required"),RegularExpression(@"^([0-9]{10})$",ErrorMessage = "NIC Number is Not Valid")]
    [Display(Name = "NIC Number")]
    [StringLength(12)]
    public string NicNumber { get; set; }
    
    [Required(ErrorMessage = "Age is Required")]
    [Range(18,120, ErrorMessage = "Min 18 has a book a ticket")]
    public int Age { get; set; }
    
    [Display(Name = "Phone Number")]
    [Required(ErrorMessage = "Phone Number is Required"),RegularExpression(@"^([0-9]{10})$",ErrorMessage = "Phone Number is Not Valid")]
    [StringLength(10)]
    public string PhoneNumber { get; set; }
    
    [Required(ErrorMessage = "Password is Required")]
    [DataType(DataType.Password)]
    [MinLength(5,ErrorMessage = "Min 5 characters Required"),MaxLength(10,ErrorMessage = "Max charcters are allowe is 20")]
    public string UserPassword { get; set; }
    
    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
}

public class AdminBus
{
    [Key]
    
}