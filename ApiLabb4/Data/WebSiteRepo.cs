using ApiLabb4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Data
{
    public class WebSiteRepo : IWebSiteRepo
    {
        private ApiLabb4Context _Labb4Context;
        public WebSiteRepo(ApiLabb4Context labb4Context)
        {
            _Labb4Context = labb4Context;
        }
        public WebSite AddWebSite(WebSite newWebsite)
        {
            _Labb4Context.WebSites.Add(newWebsite);
            _Labb4Context.SaveChanges();
            return newWebsite;
        }
    }
}
