using m7_mvc_net6.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m7_mvc_net6.Tests
{
    public class HomeControllerTests
    {
        ILogger<HomeController> _logger;
        [Theory, InlineData(500)]
        public void HomeController_CheckCountValue_Fail(int i)
        {
            Assert.Throws<Exception>(() => (new HomeController(_logger).CheckCountValue(i)));
        }
        [Theory, InlineData(2)]
        public void HomeController_CheckCountValue_Success(int i)
        {
            Assert.IsType<ViewResult>((new HomeController(_logger).CheckCountValue(i)));
        }
    }
}
