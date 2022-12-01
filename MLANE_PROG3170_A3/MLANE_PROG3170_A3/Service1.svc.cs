using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MLANE_PROG3170_A3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string InsertUserDetails(UserDetails userInfo)
        {
            string Message;
            SqlConnection con = new SqlConnection("Data Source=MATLAP\\SQLEXPRESS;Initial Catalog=WCFA3db;User ID=sa;Password=test");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RegistrationTable(Customer,Amount,Email) values(@Customer,@Amount,@Email)", con);
            cmd.Parameters.AddWithValue("@UserName", userInfo.Customer);
            cmd.Parameters.AddWithValue("@Amount", userInfo.Amount);
            cmd.Parameters.AddWithValue("@Email", userInfo.Email);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = userInfo.Customer + " Order Placed successfully";
            }
            else
            {
                Message = userInfo.Customer + " Order Error";
            }
            con.Close();
            return Message;
        }
    }
}
