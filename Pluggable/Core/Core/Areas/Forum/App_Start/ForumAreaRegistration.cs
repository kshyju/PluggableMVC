using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Forum
{
    public class ForumAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Forum"; }
        }
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "forum_default",
                "Forum/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Forum.Controllers" }

            );
        }
    }
}
