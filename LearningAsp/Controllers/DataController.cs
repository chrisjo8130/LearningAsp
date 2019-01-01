using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LearningAsp.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Result()
        {
            return new ContentResult { Content = "Data/Result" };
        }

        public IActionResult Position(string id)
        {
            return new ContentResult { Content = $"ID: {id}" };
        }
    }
}