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
            // Get the values from the form for hungerLevel and dayOfWeek
            int hungerLevel = int.Parse(Request.Form["hungerLevel"]);
            int dayOfWeek = int.Parse(Request.Form["dayOfWeek"]);

            //If else chain to determine message based on hungerLevel
            if (hungerLevel >= 8)
            {
                HungerMessage = "🦁: Roar! I need a big meal!";
            }
            else if (hungerLevel >=5)
            {
                HungerMessage = "🐵: Ooh ooh! I'll take some bananas";
            }
            else if (hungerLevel < 5)
            {
                HungerMessage = "🐢: Slow and steady—I'll have some lettuce.";
            }

            //Ternary Operator for SoundMessage
            SoundMessage = (hungerLevel >= 8) ? "Listen to the 🦁: Roar!" : "Listen to the 🐵: Ooh ooh!";

            //Switch statement for DayMessage
            switch(dayOfWeek)
            {
                case 1:
                    DayMessage = "Today is monday come see the zebras";
                    break;
                case 2:
                    DayMessage = "Today is tuesday our dolphins are swimming in the aquatic center";
                    break;
                case 3:
                    DayMessage = "Today is wednesday come check out the groundhogs";
                    break;
                case 4:
                    DayMessage = "Today is thursday come see the pengins being fed at 2pm";
                    break;
                case 5:
                    DayMessage = "Today is friday the orcas are putting on a show at 4pm";
                    break;
                case 6:
                    DayMessage = "Today is saturday the monkeys are going bananas";
                    break;
                case 7:
                    DayMessage = "The lions are very tired and napping in the sun today";
                    break;
                default:
                    DayMessage = "Welcome to the zoo! Enjoy your visit!";
                    break;
            }
        }
    }
}