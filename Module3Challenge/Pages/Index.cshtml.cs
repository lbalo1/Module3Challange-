using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        public void OnPost()
        {
            // Get the values from the form
            int hungerLevel = int.Parse(Request.Form["hungerLevel"]);
            int dayOfWeek = int.Parse(Request.Form["dayOfWeek"]);

            // Add your if-else statement here
            if (hungerLevel >= 8)
            {
                HungerMessage = "Lion: Roar! I need a big meal! 🦁🥩";
            }
            else if (hungerLevel >= 5)
            {
                HungerMessage = "Monkey: Ooh ooh! I'll take some bananas. 🍌✨";
            }
            else
            {
                HungerMessage = "Tortoise: Slow and steady—I'll have some lettuce. 🐢🥬";
            }

            // Add your ternary operator here
            SoundMessage = hungerLevel >= 8
                ? "Listen to the Lion: Roar!"
                : "Listen to the Monkey: Ooh ooh!";

            // Add your switch statement here
              switch (dayOfWeek)
            {
                case 1:
                    DayMessage = "Sunday: Family Fun Day at the Zoo! 🥳";
                    break;
                case 2:
                    DayMessage = "Monday: Monkey Mischief Show! 🙈🙉🙊 ";
                    break;
                case 3:
                    DayMessage = "Tuesday: Tortoise Talk with the Zookeeper! 🐢";
                    break;
                case 4:
                    DayMessage = "Wednesday: Wildlife Education Day! 🦒🦓🐆";
                    break;
                case 5:
                    DayMessage = "Thursday: Big Cat Feeding Time! 🦁";
                    break;
                case 6:
                    DayMessage = "Friday: Zoo Night Adventures! 🌌";
                    break;
                case 7:
                    DayMessage = "Saturday: Safari Exploration Day!" 🦏;
                    break;
                default:
                    DayMessage = "Invalid day selected. Try again!";
                    break;
            }
        }
    }
}
