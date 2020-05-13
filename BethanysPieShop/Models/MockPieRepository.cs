using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository:IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie>
        {
          new Pie{PieId=1,Name="Strawberry Pie",Price=15.95M,ShortDescription="Lorem Epsum",CategoryId=1,ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",Category=_categoryRepository.AllCategories.ToList()[0],IsPieOfTheWeek=false},
          new Pie{PieId=2,Name="Cheese Cake",Price=18.95M,ShortDescription="Lorem Epsum",CategoryId=2,ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",Category=_categoryRepository.AllCategories.ToList()[1],IsPieOfTheWeek=false},
          new Pie{PieId=3,Name="Rhubarb Pie",Price=15.95M,ShortDescription="Lorem Epsum",CategoryId=1,ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",Category=_categoryRepository.AllCategories.ToList()[0],IsPieOfTheWeek=true},
          new Pie{PieId=4,Name="Pumpkin Pie",Price=12.95M,ShortDescription="Lorem Epsum",CategoryId=3,ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",Category=_categoryRepository.AllCategories.ToList()[2],IsPieOfTheWeek=true}
        };
        public IEnumerable<Pie> PiesOfTheWeek { get; }
        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p=>p.PieId==pieId);
        }
    }
}
