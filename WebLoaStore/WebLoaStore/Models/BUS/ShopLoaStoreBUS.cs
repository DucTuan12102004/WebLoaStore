using ShopLoaStoreConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoaStore.Models.BUS
{
    public class ShopLoaStoreBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopLoaStoreConnectionDB();
           return db.Query<SanPham>("select * from SanPham where TinhTrang = 0");
        }
        public static SanPham ChiTiet(String a)
        {
            var db = new ShopLoaStoreConnectionDB();
            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham = @0",a);
        }
        public static IEnumerable<SanPham> Top4New()
        {
            var db = new ShopLoaStoreConnectionDB();
            return db.Query<SanPham>("select Top 4 * from SanPham where GhiChu = N'New'");
        }
        public static IEnumerable<SanPham> TopHot()
        {
            var db = new ShopLoaStoreConnectionDB();
            return db.Query<SanPham>("select Top 4 * from SanPham where LuotView > 0 ");
        }

    }
}