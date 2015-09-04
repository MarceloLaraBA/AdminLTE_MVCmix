using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace app.Controllers
{
    public class SampleDataController : Controller
    {

        private List<TableData> GetData()
        {

            var platformList = new List<Platform>
            {
                new Platform() {Id = 1, Name = "Windows", Vendor = "Microsoft"},
                new Platform() {Id = 2, Name = "OSX", Vendor = "Apple"},
                new Platform() {Id = 3, Name = "Ubuntu", Vendor = "Linux"}
            };
            var result = new List<TableData>();
            result.Add(new TableData() { Id = 1, Browser = "Firefox", RenderingEngine = "Gecko", Platform = platformList.Where(x => x.Id < 3).ToList(), Grade = "A", Version = "1.8" });
            result.Add(new TableData() { Id = 2, Browser = "Seamonkey ", RenderingEngine = "Gecko", Platform = platformList.Where(x => x.Id==2).ToList(), Grade = "A", Version = "1.8" });
            result.Add(new TableData() { Id = 3, Browser = "Safari ", RenderingEngine = "Webkit", Platform = platformList.Where(x => x.Id > 1).ToList(), Grade = "A", Version = "1.8" });
            result.Add(new TableData() { Id = 4, Browser = "PSP browser", RenderingEngine = "Gecko", Platform = platformList.Where(x => x.Id < 3).ToList(), Grade = "A", Version = "1.8" });
            result.Add(new TableData() { Id = 5, Browser = "Opera", RenderingEngine = "Presto", Platform = platformList, Grade = "A", Version = "1.8" });
            result.Add(new TableData() { Id = 6, Browser = "Nokia ", RenderingEngine = "Webkit", Platform = platformList.Where(x => x.Id < 3).ToList(), Grade = "A", Version = "1.8" });
            result.Add(new TableData() { Id = 7, Browser = "OmniWeb ", RenderingEngine = "Gecko", Platform = platformList.Where(x => x.Id < 3).ToList(), Grade = "A", Version = "1.8" });
            return result;
        }


        // GET: SampleData
        public ActionResult Index()
        {
            



            return Json(GetData(), JsonRequestBehavior.AllowGet);
        }
    }

    public class TableData
    {
        public int Id { get; set; }
        public string RenderingEngine { get; set; }
        public string Browser { get; set; }
        public List<Platform> Platform { get; set; }
        public string Version { get; set; }
        public string Grade { get; set; }
    }

    public class Platform
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vendor { get; set; }
    }

}