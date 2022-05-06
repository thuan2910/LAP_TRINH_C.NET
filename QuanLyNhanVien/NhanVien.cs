
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



namespace QuanLyNhanVien
{
    class NhanVien
    {
        public const long Luong_co_ban = 10000000;
        public int MaNV { get; set; }
        public string TNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public LoaiChucVu ChucVu { get; set; }
        public PhongBan Phong { get; set; }
        public long TinhLuong
        {
            get
            {
                if(ChucVu== LoaiChucVu.Giam_doc)
                    return Luong_co_ban + (long)(Luong_co_ban*0.25) ;
                if (ChucVu == LoaiChucVu.Truong_phong)
                    return Luong_co_ban + (long)(Luong_co_ban * 0.15);
                if (ChucVu == LoaiChucVu.Pho_Phong)
                    return Luong_co_ban + (long)(Luong_co_ban * 0.05);
                return Luong_co_ban;
            }
        }
        public override string ToString()
        {
            return this.MaNV + "\t"
                + this.TNV + "\t"
                + this.ChucVu + "\t==>"
                + this.TinhLuong;
        }

    }
}