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
            string data="['Tên Đoàn Thể', 'Số kiểm nghiệm']";
            for(int i=0;i<p.Count;i++){
                data+=",[\'Khoa "+HttpUtility.HtmlDecode(p[i].ten)+"\', "+p[i].dem+"]";
            }
            ViewBag.data=data;

            query = "select id,ten,count(tenCR) as dem from ";
            query += " ( ";
            query += " select A.id as id,A.ten as ten,B.tenCR from ";
            query += " (select id,ten from dm_tochucdoanthe) as A inner join ";
            query += " (select tochucdoantheid,tenCR from DM_ChiTieu) as B on A.id=B.tochucdoantheid ";
            query += " ) as C group by id,ten order by ten ";
          
            p = db.Database.SqlQuery<rp1>(query).ToList();
            data = "['Tên Đoàn Thể', 'Số Chỉ Tiêu']";
            for (int i = 0; i < p.Count; i++)
            {
                data += ",[\'Khoa " + HttpUtility.HtmlDecode(p[i].ten) + "\', " + p[i].dem + "]";
            }
            ViewBag.data2 = data;

            return View();
        }
        //Thống kê mỗi mẫu dịch vụ có bao nhiêu mẫu kiểm nghiệm
        public ActionResult BaoCao2(DateTime? from_date,DateTime? to_date)
        {
            var mdv = (from q in db.DM_LoaiMau select q).OrderBy(o => o.Ten).ToList();
            string[] color = new string[] { "red", "blue", "green", "yellow","grey","brown" };
            string data = "[\"Tên dịch vụ\", \"Số lượng mẫu kiểm nghiệm\", { role: \"style\" } ]";
            string data2 = "[\"Tên dịch vụ\", \"Số lượng hồ sơ kiểm nghiệm\"]";
            for (int i = 0; i < mdv.Count; i++)
            {
                var item = mdv[i].Ma;
                var ten = mdv[i].Ten;
                long id = mdv[i].ID;
                try{
                    int? c = db.DT_MauKiemNghiem.Count(o => o.MaSoMau.Contains(item));
                    //if (from_date != null)
                    //{
                    //    long fdate = from_date.Value.ToFileTime();
                    //    long tdate = to_date.Value.ToFileTime();
                    //    c = db.DT_MauKiemNghiem.Where(o => o.NgayTao >= fdate && o.NgayTao <= tdate).Count(o => o.MaSoMau.Contains(item));
                    //}
                    data += ",[\'" + HttpUtility.HtmlDecode(ten) + "\', " + c + ", '" + color[i%color.Length] + "']";
                    c = db.DT_HoSoKiemNghiem.Count(o => o.LoaiMauID==id);
                    data2 += ",[\'" + HttpUtility.HtmlDecode(ten) + "\', " + c + "]";
                }
                catch (Exception ex)
                {

                }
            }
            ViewBag.data = data;
            ViewBag.data2 = data2;
            return View();
        }
        //Thống kê mỗi hồ sơ kiểm nghiệm đang ở trạng thái nào
        public ActionResult BaoCao3(DateTime? from_date, DateTime? to_date)
        {
            var mdv = (from q in db.DM_TrangThai select q).OrderBy(o => o.Ten).ToList();
            string[] color = new string[] { "red", "blue", "green", "yellow", "grey", "brown" };
            string data = "[\"Tên trạng thái\", \"Số lượng hồ sơ kiểm nghiệm\",{ role: \"style\" }]";
           
            for (int i = 0; i < mdv.Count; i++)
            {
                var ten = mdv[i].Ten;
                long id = mdv[i].ID;
                try
                {
                    int? c = db.DT_HoSoKiemNghiem.Count(o => o.TrangThaiTempID==id);
                    data += ",[\'" + HttpUtility.HtmlDecode(ten) + "\', " + c + ", '" + color[i % color.Length] + "']";
                }
                catch (Exception ex)
                {

                }
            }
            ViewBag.data = data;
            return View();
        }
        public class itemCount
        {
            public int dem { get; set;}
        }
        //Thống kê theo thời gian
        public ActionResult BaoCao4(DateTime? from_date, DateTime? to_date)
        {
            if (from_date == null) from_date = DateTime.Now.AddDays(-1500);
            if (to_date == null) to_date = DateTime.Now;
            string[] color = new string[] { "red", "blue", "green", "yellow", "grey", "brown" };
            string data = "[\"Đăng ký Nhập khẩu\", \"Số lượng khách hàng\",{ role: \"style\" }]";
            string data2 = "[\"Phiếu phân tích chỉ tiêu\", \"Số lượng phiếu phân tích chỉ tiêu\",{ role: \"style\" }]";
            string query=" select isnull(sum(dem),0) as dem from ( ";
                query+="select ngaylap,count([TenKhachHang]) as dem from ";
                query+="(";
                query+=" select cast([NgayLap] as datetime) as NgayLap,[TenKhachHang] from [luanvan].[dbo].[DT_DangKyNhapKhau] ";
                query += ") as A where ngaylap>='" + from_date.Value.ToString() + "' and ngaylap<='" + to_date.Value.ToString() + "' group by ngaylap ";
                query += ") as B ";
                var rs = db.Database.SqlQuery<itemCount>(query).ToList();
                int dem = rs[0].dem;
                data += ",[\'Số khách hàng\', " + dem + ", '" + color[0] + "']";

                query = " select isnull(sum(dem),0) as dem from ( ";
                query += "select ngaylap,count([id]) as dem from ";
                query += "(";
                query += " select cast([NgayTao] as datetime) as NgayLap,[id] from [luanvan].[dbo].[DT_PhieuPhanTichChiTieu] ";
                query += ") as A where ngaylap>='" + from_date.Value.ToString() + "' and ngaylap<='" + to_date.Value.ToString() + "' group by ngaylap ";
                query += ") as B ";
                rs = db.Database.SqlQuery<itemCount>(query).ToList();
                dem = rs[0].dem;
                data2 += ",[\'Phiếu phân tích chỉ tiêu\', " + dem + ", '" + color[1] + "']";
            ViewBag.data = data;
            ViewBag.data2 = data2;
            ViewBag.from_date = from_date.Value.ToShortDateString();
            ViewBag.to_date = to_date.Value.ToShortDateString();
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