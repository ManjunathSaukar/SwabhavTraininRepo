using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Web.Mvc;
using System.Diagnostics;

namespace POCOnCustomActionFilter.Models
{
    public class LogThisRequestAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Log the request details here
            var request = filterContext.HttpContext.Request;
            var method = request.HttpMethod;
            var url = request.Url.AbsoluteUri;
            var timestamp = DateTime.Now;

            // Perform your logging logic (e.g., write to a log file, database, etc.)
            LogRequest(method, url, timestamp);

            base.OnActionExecuting(filterContext);
        }

        private void LogRequest(string method, string url, DateTime timestamp)
        {
            // Implement your logging logic here
            // You can write the request details to a log file, database, etc.
            // Example:
            Debug.WriteLine($"Request: {method} {url} - Timestamp: {timestamp}");
        }
    }
}