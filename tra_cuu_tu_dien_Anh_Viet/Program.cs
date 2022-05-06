using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tra_cuu_tu_dien_Anh_Viet
{
    class tra_cuu_tu_dien_Anh_Viet
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();//tra cứu từ nhập tiếng anh ra tiếng việt;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();
                Console.WriteLine("Ban co tiep tuc su dung tu dien ko?(c/k):");
                string s = Console.ReadLine();
                if (s == "k")
                    break;
            }
            Console.WriteLine("Bye bye!");
        }

        private static void menu()
        {
            Console.WriteLine("1.Tạo từ mới");
            Console.WriteLine("2.Sửa từ");
            Console.WriteLine("3.tra cứu từ");
            Console.WriteLine("4.xóa từ");
            Console.WriteLine("Bạn chọn chức năng nào?");
            try
            {
                int cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        Taotumoi();
                        break;
                    case 2:
                        Suatu();
                        break;
                    case 3:
                        Tracuu();
                        break;
                    case 4:
                        Xoatu();
                        break;
                    default:
                        Console.WriteLine("Bạn chọn nhậm chức năng rồi!");
                        break;
                }
            }catch (Exception ex)
            {
                Console.WriteLine("lỗi gì đó: " + ex.Message);
            
        }
    }

        private static void Xoatu()
        {
            Console.WriteLine("nhập vào từ muốn xóa:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                dic.Remove(ta);
                Console.WriteLine("xóa thành công từ [(0)]",ta);
            }
            else
            {
                Console.WriteLine("ko tìm thấy từ [{0}] để xóa", ta);
            }
        }

        private static void Tracuu()
        {
            Console.WriteLine("nhập vào từ tiếng anh:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                string tv = dic[ta];
                Console.WriteLine("nghĩa của [{0}] là [{1}]",ta,tv);
            }
            else
            {
                Console.WriteLine("từ điển chưa cập nhập từ [{0}]", ta);
            }

        }

        private static void Suatu()
        {
            Console.WriteLine("nhập vào tiếng anh để sửa lại nghĩa:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                Console.WriteLine("Ko tìm thấy {0} để sửa", ta);
            }
            else
            {
                Console.WriteLine("mời bạn nhập lại nghĩa tiếng việt");
                string tv = Console.ReadLine();
                dic[ta] = tv;
            }
        }

        private static void Taotumoi()
        {
            Console.WriteLine("nhập từ tiếng anh");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                Console.WriteLine("từ {0} đã tồn tại rồi", ta);
            }
            else
            {
                Console.WriteLine("mời nhập nghĩa tiếng việt:");
                string tv = Console.ReadLine();
                dic.Add(ta, tv);
            }  
        }
    }
}