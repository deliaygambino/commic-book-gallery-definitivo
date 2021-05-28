using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mic_book_galery_definitivo.Controllers
{
    public class ComicBookController : Controller
    {
        public IActionResult Detail()
        {
            return View();
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(todaysDate);
        }
    }
}
