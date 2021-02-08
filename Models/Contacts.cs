using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MultiPageWebApp.Models
{
    public class Contacts
    {
        //EF Core will configure the database to generate this value
        public int ContactsId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(100, ErrorMessage = "Maximum characters reached. Is your name really that long?") ]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        [StringLength(15, ErrorMessage = "Max characters for phone number is 15.")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        [StringLength(50, ErrorMessage = "Max characters for address is 50.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a note.")]
        [StringLength(100, ErrorMessage = "Max characters reached. Please keep notes under 100 characters.")]
        public string Note { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Number?.ToString();
    }
}
