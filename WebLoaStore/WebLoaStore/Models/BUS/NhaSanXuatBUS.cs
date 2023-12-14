using ShopLoaStoreConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoaStore.Models.BUS
{
    public class NhaSanXuatBUS
    {
        public static IEnumerable<NhaSanXuat> DanhSach()
        {
            var db = new ShopLoaStoreConnectionDB();
            return db.Query<NhaSanXuat>("select * from NhaSanXuat where TinhTrang = 0");
        }
        public static IEnumerable<SanPham> ChiTiet(String id)
        {
            var db = new ShopLoaStoreConnectionDB();
            return db.Query<SanPham>("select * from SanPham where MaNhaSanXuat = '"+id+"'");
        }
    }
}