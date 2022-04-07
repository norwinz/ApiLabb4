using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Models
{
    public class Interest
    {
        [Key]
        public int interestId { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public virtual ICollection<WebSite> WebSites { get; set; }
        public int personId { get; set; }
        public Person Person { get; set; }
    }
}
