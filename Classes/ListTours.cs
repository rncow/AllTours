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
                new Tour() { name = "Магия Турции", details = "ToursDetails/tour4" },
                new Tour() { name = "Гостеприимная Грузия", details = "ToursDetails/tour5" },
                new Tour() { name = "Бизнес Дубаи", details = "ToursDetails/tour6" },
            };
    }
}
