using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MLANE_PROG3170_A3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string InsertUserDetails(UserDetails userInfo);

        

        // TODO: Add your service operations here
    }

    public class UserDetails
    {
        string customer = string.Empty;
        string amount = string.Empty;
        string email = string.Empty;
        [DataMember]
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        [DataMember]
        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
