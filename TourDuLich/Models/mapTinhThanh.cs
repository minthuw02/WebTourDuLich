using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourDuLich.Models
{
    public class mapTinhThanh
    {
        List<TinhThanh> ListTT()
        {
            DuLichDBEntities1 db = new DuLichDBEntities1();
            List<TinhThanh> data2 = (from tinh in db.TinhThanhs
                                     select tinh).ToList();
            return data2;
        }

    }
}