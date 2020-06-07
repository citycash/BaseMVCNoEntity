using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMVCNoEntity.Model
{
    public class HomeModel
    {
        public List<UserModel> ListUser { get; set; }
        public UserModel User { get; set; }
    }

    public class UserModel
    {
        public int Option { get; set; }
        public string ID { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
    }
}
