using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceASU1.Controller
{
    public class Engine
    {
        //Лист глист
        public List<Viewer> list_viewer;


        /// <summary>
        /// Перебираем данные из бд и отдаем в лист
        /// </summary>
        public Engine()
        {
            DB.Entities ef = new DB.Entities();
            list_viewer = new List<Viewer>();
            try
            {
                var s = ef.Services.ToList();
                foreach (var item in s)
                {
                    list_viewer.Add(new Viewer(item));
                }
            }
            catch (Exception)
            {
                throw;
            }


        }



    }
}
