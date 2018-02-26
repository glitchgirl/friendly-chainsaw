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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string TeamName { get; set; }
        public string ShirtSize { get; set; }
        public string TeamMembers { get; set; }
    }
}