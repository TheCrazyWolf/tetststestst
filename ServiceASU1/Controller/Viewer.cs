using ServiceASU1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceASU1.Controller
{
    public class Viewer
    {

        public int idService { get; set; }

        // какие то поля
        public string Title { get; set; }
        public string MainPath { get; set; }
        public string Duration { get; set; }
        public string OldPrice { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
        public int CostSort { get; set; }

        // Получаем данные из бд
        public Viewer(DB.Services services)
        {
            idService = services.idService;
            Title = GetTitle(services);
            MainPath = GetPath(services);
            Duration = GetDuration(services);
            OldPrice = GetOldPrice(services);
            Price = GetPrice(services);
            Discount = GetDiscount(services);

        }


        // Обрабатываем данные
        private string GetOldPrice(Services services)
        {
            decimal discount = Convert.ToDecimal(services.Price) * Convert.ToDecimal(services.Discount);
            return Math.Round(Convert.ToDecimal(services.Price) - discount) + "";
        }

        private string GetDiscount(Services services)
        {
            return services.Discount * 100 + "%";
        }

        private string GetDuration(Services services)
        {
            return services.Duration + " ч.";
        }

        private string GetPrice(Services services)
        {
            return Math.Round(services.Price) + " рублей за ";
        }

        private string GetPath(Services services)
        {
            return services.MainPath;
        }

        private string GetTitle(Services services)
        {
            return services.Title;
        }
    }
}
