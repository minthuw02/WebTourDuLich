using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourDuLich.Models
{
    public class mapTour
    {
        public List<TourDuLich> ListTheoTinh(int? idTinh) { 
        DuLichDBEntities1 db = new DuLichDBEntities1();
            var data = (from tour in db.TourDuLiches
                        join tinh in db.TinhThanhs on tour.idTinh equals tinh.ID_Tinh
                        into tinh2 from tinh in tinh2.DefaultIfEmpty()
                        
                        where tour.idTinh == idTinh
                        select tour).ToList();
            return data;
                }

        public List<TourDuLich> ListTheoLoai(int? idLoaiTour)
        {
            DuLichDBEntities1 db = new DuLichDBEntities1();
            var data = (from tour in db.TourDuLiches
                        where tour.idLoaiTour == idLoaiTour
                        select tour).ToList();
            return data;
        }
        public List<TourDuLich> ListMucGia(int? idMucGia)
        {
            DuLichDBEntities1 db = new DuLichDBEntities1();
            var data = (from tour in db.TourDuLiches
                        where tour.idMucGia == idMucGia
                        select tour).ToList();
            return data;
        }
        public List<TourDuLich> ListT(int? idTinh,int? idLoaiTour, int? idMucGia)
        {
            DuLichDBEntities1 db = new DuLichDBEntities1();
            var data = (from item in db.TourDuLiches
                        where (item.idTinh ==idTinh | idTinh==null)&
                        (item.idLoaiTour==idLoaiTour | idLoaiTour==null)&
                        (item.idMucGia==idMucGia |idMucGia == null)
                        select item).ToList();
            return data;
        }
    }
}