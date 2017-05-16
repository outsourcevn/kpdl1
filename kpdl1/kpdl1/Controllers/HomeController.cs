using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kpdl1.Models;
using System.Text;
using System.Net;
namespace kpdl1.Controllers
{
    public class HomeController : Controller
    {
        private luanvanEntities db = new luanvanEntities();
        public class rp1
        {
            public long id { get; set; }
            public string ten { get; set; }
            public int dem { get; set; }
        }
        public ActionResult Index()
        {
            string query = "select id,ten as ten,count(phieuphantichid) as dem from ";
                   query+=" ( ";
                   query+=" select A.id as id,A.ten as ten,C.phieuphantichid as phieuphantichid from ";
                   query+=" (select id,ten from dm_tochucdoanthe) as A inner join ";
                   query+=" (select id,tochucdoantheid from dt_phieuphantich) as B on A.id=B.tochucdoantheid inner join ";
                   query+=" (select id,phieuphantichid from dt_phieuphantichchitieu) as C on B.id=C.phieuphantichid ";
                   query+=" ) as D group by id,ten order by ten";
            var p=db.Database.SqlQuery<rp1>(query).ToList();
            int total=0;
            string data="['Tên Đoàn Thể', 'Tổng Số']";
            for(int i=0;i<p.Count;i++){
                data+=",[\'"+HttpUtility.HtmlDecode(p[i].ten)+"\', "+p[i].dem+"]";
            }
            ViewBag.data=data;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}