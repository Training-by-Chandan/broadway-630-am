using MyDesktop.Data;
using MyDesktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesktop.Service
{
    public class UserService
    {
        private DefaultContext db = new DefaultContext();

        public ResponseViewModel Login(LoginViewModel model)
        {
            var res = new ResponseViewModel();
            try
            {
                var user = db.UserInfo.FirstOrDefault(p => p.Username == model.Username);
                if (user == null)
                {
                    res.Message = "User not found!";
                    return res;
                }
                else
                {
                    if (user.Password == model.Password)
                    {
                        res.Success = true;
                        res.Message = "Success";
                        return res;
                    }
                    else
                    {
                        res.Message = "Password didnot match";
                        return res;
                    }
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }
            return res;
        }
    }
}
