﻿// RequireJS.NET
// Copyright VeriTech.io
// http://veritech.io
// Dual licensed under the MIT and GPL licenses:
// http://www.opensource.org/licenses/mit-license.php
// http://www.gnu.org/licenses/gpl.html

using System.Web.Mvc;

using RequireJsNet.Models;

namespace RequireJsNet.Helpers
{
    internal static class HtmlHelpers
    {
        public static RoutingInfo GetRoutingInfo(this HtmlHelper html)
        {
            var area = html.ViewContext.RouteData.DataTokens["area"] != null
                ? html.ViewContext.RouteData.DataTokens["area"].ToString()
                : "Root";

            var controller = html.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue as string;
            var action = html.ViewContext.Controller.ValueProvider.GetValue("action").RawValue as string;
            return new RoutingInfo
            {
                Area = area,
                Controller = controller,
                Action = action
            };
        }
    }
}
