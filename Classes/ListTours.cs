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
                new Tour() { name = "Из России в Россию", details = "ToursDetails/tour1", cost = 10000 },
                new Tour() { name = "Турция для своих", details = "ToursDetails/tour2", cost = 35000  },
                new Tour() { name = "Эконом Беларусь", details = "ToursDetails/tour3", cost = 5000  },
                new ExclusiveTour() { name = "Магия Турции", details = "ToursDetails/tour4", cost = 55000 },
                new Tour() { name = "Гостеприимная Грузия", details = "ToursDetails/tour5", cost = 25000  },
                new BusinessTour() { name = "Бизнес Дубаи", details = "ToursDetails/tour6", cost = 60000  },
                new Tour() { name = "Патриотичный Крым", details = "ToursDetails/tour7", cost = 20000 },
                new WorldTour() { name = "Тур по Прибалтике", details = "ToursDetails/tour8", countries = { "Литва", "Латвия", "Эстония" }, cost = 30000  },
            };
    }
}
