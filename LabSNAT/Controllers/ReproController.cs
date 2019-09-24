using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LabSNAT.Controllers
{
    public class ReproController : Controller
    {
        // GET: Repro
        public string Index(string url)
        {
            var request = HttpWebRequest.Create(url);
            request.GetResponse();

            return "OK";
        }
    }
}