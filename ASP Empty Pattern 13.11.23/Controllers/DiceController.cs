using Microsoft.AspNetCore.Mvc;
using ASP_Empty_Pattern_13._11._23.Models;

namespace ASP_Empty_Pattern_13._11._23.Controllers
{
    public class DiceController : Controller
    {
        private Random rnd = new Random((int)DateTime.Now.Ticks);
        private int rand_number()
        {
            return 1 + rnd.Next() % 6;
        }
        public string rolling_dice_text()
        {
            string result = $"2 кубика: {rand_number()} " +
                $"и {rand_number()}";
            return result;
        }
        public IActionResult Index()
        {
            int first = rand_number();
            int second = rand_number();
            return View(new DiceRollerModel
            {
                first_dice = first,
                second_dice = second,
                first_dice_file_path = $"/img/{first}.png",
                second_dice_file_path = $"/img/{second}.png"
            });
        }
    }
}