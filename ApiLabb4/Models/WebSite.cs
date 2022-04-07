using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Models
{
    public class WebSite
    {
        [Key]
        public int WebSiteId { get; set; }
        public string SiteURL { get; set; }
        public int interestId { get; set; }
        public Interest Interest { get; set; }
    }
}
