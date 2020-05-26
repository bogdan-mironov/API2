using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;

namespace api3.Controllers
{
    public class HostPointController : Controller
    {
        private readonly ILogger<HostPointController> _logger;
        WebClient client = new WebClient();
        public HostPointController(ILogger<HostPointController> logger)
        {
            _logger = logger;
        }

        public byte[] GetFile(string filter)
        {
            string address = "http://hidemyna.me/ru/api/proxylist.php?&code=688296646857634&" + filter.Replace(';', '&');
            byte[] data = client.DownloadData(address);
            return data;
        }
    }
}