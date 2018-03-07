using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace joesGolfSite.Models
{
    public class Registerer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Adress")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "Phone")]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        [Required]
        [Display(Name = "Shirt Size")]
        public string ShirtSize { get; set; }
        
        [Display(Name = "Team Member 1:")]
        public string TeamMember1 { get; set; }

        [Display(Name = "Team Member 2:")]
        public string TeamMember2 { get; set; }
        [Display(Name = "Team Member 3:")]
        public string TeamMember3 { get; set; }
    }
}