using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseMVCNoEntity.BLL.Helper;
using BaseMVCNoEntity.DAL;
using BaseMVCNoEntity.Model;

namespace BaseMVCNoEntity.BLL.BussinessLogic
{
    public class HomeBLL
    {
        DbTransaction dbTrans = DbTrans.defaultTransaction();
        public List<UserModel> GetDataUser()
        {
            try
            {
                var Data = dbTrans.DbToList<UserModel>("USP_Get_User", true);
                return Data;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public string InsertOrUpdateUser(UserModel Model)
        {
            try
            {
                dbTrans.DbExecute("USP_Insert_Or_Update_User", new {
                    Option = Model.Option,
                    ID = Model.ID,
                    Nama = Model.Nama,
                    Email = Model.Email,
                } ,true);
                return "Sukses";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteUser(UserModel Model)
        {
            try
            {
                dbTrans.DbExecute("USP_Delete_User", new
                {
                    ID = Model.ID,
                }, true);
                return "Sukses";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
