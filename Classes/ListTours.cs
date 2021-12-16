using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTours
{
    public class ListTours
    {
        public static List<Tour> listTours = new List<Tour>
            {
                new Tour() { name = "Из России в Россию", details = "ToursDetails/tour1" },
                new Tour() { name = "Турция для своих", details = "ToursDetails/tour2" },
                new Tour() { name = "Эконом Беларусь", details = "ToursDetails/tour3" },
                new ExclusiveTour() { name = "Магия Турции", details = "ToursDetails/tour4" },
                new Tour() { name = "Гостеприимная Грузия", details = "ToursDetails/tour5" },
                new BusinessTour() { name = "Бизнес Дубаи", details = "ToursDetails/tour6" },
                new Tour() { name = "Патриотичный Крым", details = "ToursDetails/tour7" },
                new WorldTour() { name = "Тур по Прибалтике", details = "ToursDetails/tour8", countries = { "Литва", "Латвия", "Эстония" } },
            };
    }
}
