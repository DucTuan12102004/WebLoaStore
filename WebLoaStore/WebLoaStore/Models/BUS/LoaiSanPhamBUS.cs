using ShopLoaStoreConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoaStore.Models.BUS
{
    public class LoaiSanPhamBUS
    {
        public static IEnumerable<LoaiSanPham> DanhSach()
        {
            var db = new ShopLoaStoreConnectionDB();
            return db.Query<LoaiSanPham>("select * from LoaiSanPham where TinhTrang = 0");
        }
        public static IEnumerable<SanPham> ChiTiet(String id)
        {
            var db = new ShopLoaStoreConnectionDB();
            return db.Query<SanPham>("select * from SanPham where MaLoaiSanPham = '"+id+"'");
        }
    }
}