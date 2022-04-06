using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Models
{
    public class Person
    {
        [Key]
        public int personId { get; set; }
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
    }
}
