using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie { PieId = 1, Name = "Strawberry pie", Price = 25M, ShortDescription = "Lorem ipsum" },
            new Pie { PieId = 2, Name = "Cheese cake", Price = 23M, ShortDescription = "Lorem ipsum" },
            new Pie { PieId = 3, Name = "Rhubarb Pie", Price = 10M, ShortDescription = "Lorem ipsum" },
            new Pie { PieId = 4, Name = "Pumpkin Pie", Price = 6M, ShortDescription = "Lorem ipsum" },
        };

        public IEnumerable<Pie> PiesOfTheWeek => new List<Pie>
        {
            new Pie {PieId = 1, Name = "", },
            new Pie {PieId = 1, Name = "", },
            new Pie {PieId = 1, Name = "", },
            new Pie {PieId = 1, Name = "", },
        };

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
