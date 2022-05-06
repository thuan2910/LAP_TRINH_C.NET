/*
Công ty XYZ muốn viết phần mềm quản lý nhân viên, mô tả hệ thống như sau:
-   Mỗi nhân viên sẽ thuộc một phòng ban, thông tin của phòng ban
(mã phòng ban, tên phòng ban, trưởng phòng hiện tại), thông tin
của mỗi nhân viên (Mã nhân viên, tên nhân viên, ngày sinh, chức vụ). 
Theo chính sách công ty có các chức vụ: Giám đốc( quản lý chung), trưởng phòng,
nhân viên. Lương cơ bản của toàn bộ nhân viên trong công ty là 10 triệu/tháng.
Giám đốc phụ cấp chức vụ 25%, trưởng phòng phụ cấp chức vụ 15%, phó phòng phụ cấp 
5% nhân viên ko có phụ cấp chức vụ.
-   Chương trình cung cấp các chức năng:
    +   Thêm,xuat, sửa, xóa, sắp xếp, tìm Phòng ban, nhân viên.
    +   Thống kê tổng số lương phải trả cho nhân viên trong 1 tháng.

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuanLyNhanVien
{
    class Program
    {
        static List<PhongBan> dsPB = new List<PhongBan>();
        static void TessQLNV()
        {
                
            PhongBan pNS = new PhongBan();
            pNS.MaPB = 1;
            pNS.TPB = "phong nhan su";
            dsPB.Add(pNS);

            NhanVien teo = new NhanVien();
            teo.MaNV = 1;
            teo.TNV = "uyen";
            teo.ChucVu = LoaiChucVu.Truong_phong;
            pNS.ThemNhanVien(teo);

            NhanVien ty = new NhanVien();
            ty.MaNV = 2;
            ty.TNV = "uyen";
            ty.ChucVu = LoaiChucVu.Nhan_Vien;
            pNS.ThemNhanVien(ty);

            NhanVien met = new NhanVien();
            met.MaNV = 45;
            met.TNV = "Teo";
            met.ChucVu = LoaiChucVu.Nhan_Vien;
            pNS.ThemNhanVien(met);


            PhongBan pkt = new PhongBan();
            pkt.MaPB = 2;
            pkt.TPB = "PHONG KE TOAN";
            dsPB.Add(pkt);

            NhanVien bin = new NhanVien();
            bin.MaNV = 3;
            bin.TNV = "Bin bin bin";
            bin.ChucVu = LoaiChucVu.Pho_Phong;
            pkt.ThemNhanVien(bin);


            Console.WriteLine("Danh sach toan bo nhan vien trong cong ty:");
            foreach(PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TPB);
                pb.XuatToanBoNhanVien();
            }
            NhanVien old = pkt.TimNV(3);
            if (old != null)
            {
                old.TNV = "Bim bim bim";
            }
            Console.WriteLine("Ds toan bo nhan vien tong cong ty sau khi sua:");
            foreach (PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TPB);
                pb.XuatToanBoNhanVien();
            }
            if (pNS.XoaNV(113) == false)
            {
                Console.WriteLine("Ko tim thay ma nv 113 de xoa");
            }
            else
            {
                Console.WriteLine("Ds toan bo nhan vien tong cong ty sau khi xoa:");
                foreach (PhongBan pb in dsPB)
                {
                    Console.WriteLine(pb.TPB);
                    pb.XuatToanBoNhanVien();
                }
            }
            Console.WriteLine("Danh sach toan bo nhan vien trong cong ty:");
            pNS.XuatToanBoNhanVien();
            
            pNS.Sapxep();
            Console.WriteLine("Danh sach toan bo nhan vien trong cong ty sau khi sap xep:");

            pNS.XuatToanBoNhanVien();

            long sum = 0;
            foreach(PhongBan pb in dsPB) 
                sum+= pb.TongLuong();
            Console.WriteLine("tong luong can thanh toan la: {0}",sum);

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TessQLNV();
            Console.ReadLine();
        }
    }
}
