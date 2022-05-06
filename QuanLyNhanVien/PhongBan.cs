using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuanLyNhanVien
{
    class PhongBan
    {
        private List<NhanVien> dsNV = new List<NhanVien>();
        public int MaPB { get; set; }
        public string TPB { get; set; }
        public NhanVien Truong_phong { get; set; }
        public bool ThemNhanVien(NhanVien nv)
        {
            bool trungMaNV = false;
            foreach(NhanVien oldNV in dsNV)
                if(oldNV.MaNV == nv.MaNV)
                {
                    trungMaNV = true;
                    break;
                }
            if (trungMaNV == true)
                return false;
            dsNV.Add(nv);
            return true;
        }
        public void XuatToanBoNhanVien()
        {
            foreach(NhanVien nv in dsNV)
            {
                Console.WriteLine(nv);
            }
        }
        public NhanVien TimNV(int MaNV)
        {
            foreach(NhanVien old in dsNV)
                if(old.MaNV == MaNV)
                    return old; 
            return null;
        }
        public bool XoaNV(int MaNV)
        {
            NhanVien nv =TimNV(MaNV);
            if (nv == null) return false;
            dsNV.Remove(nv);
            return true ;          
        }
        private int compare(NhanVien nv1, NhanVien nv2)
        {
            int kqSSTen =  string.Compare(nv1.TNV,nv2.TNV,true);
            if(kqSSTen == 0)
            {
                if (nv1.MaNV < nv2.MaNV) return 1;
                if(nv1.MaNV > nv2.MaNV) return -1;
                return 0;
            }
            return kqSSTen;
        
        }
        public void Sapxep()
        {
            dsNV.Sort(compare);
        }

        public long TongLuong()
        {
            long sum = 0;
            foreach (NhanVien nv in dsNV)
                sum += nv.TinhLuong;
            return sum;
        }
    } 
}