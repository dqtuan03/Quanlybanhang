using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class ConnectionSQL
    {
        public static SqlConnection Con;  //Khai báo đối tượng kết nối        

        public static void Connect()
        {
            Con = new SqlConnection();   //Khởi tạo đối tượng
            //Con.ConnectionString = @"Data Source=CUOCCSTUUNS\CUOOCSTUUNS;Initial Catalog=QuanLyBanHangTapHoa;Integrated Security=True";
			//Con.ConnectionString = @"Data Source=TUAN;Initial Catalog=QuanLyBanHangTapHoa;Integrated Security=True;Trust Server Certificate=True";
            //Con.ConnectionString = @"Data Source=TUAN;Initial Catalog=QuanLyBanHangTapHoa;Integrated Security=True";
            Con.ConnectionString = Properties.Settings.Default.chuoiketnoi;

			Con.Open();                  //Mở kết nối
            //Kiểm tra kết nối
            if (Con.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else 
                MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }
    }
}
