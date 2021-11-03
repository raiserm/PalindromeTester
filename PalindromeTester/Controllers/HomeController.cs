using Microsoft.AspNetCore.Mvc;
using PalindromeTester.Models;
using System.Diagnostics;

namespace PalindromeTester.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tester()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Tester(TesterViewModel viewModel)
        {
            ModelState.AddModelError("", IsPalindrome(viewModel.NumberToTest) ? "Yes it is" : "No it is not");

            return View(viewModel);
        }

        private static bool IsPalindrome(int inputNumber)
        {
            var sum = 0;
            var num = inputNumber;
            while (num > 0)
            {
                var remainder = num % 10;
                num = num / 10;
                sum = sum * 10 + remainder;
            }

            return sum == inputNumber;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
