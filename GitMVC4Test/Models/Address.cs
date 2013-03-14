using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GitMVC4Test.Models
{
    [Table("PCore.Address")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Country { get; set; }
    }
}