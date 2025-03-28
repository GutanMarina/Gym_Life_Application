using System;
using System.Collections.Generic;
using System.Text;
using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Model.User;

namespace eUseControl.BusinessLogic.BlStruct
{//legatura businesslog cu metoda, declararea metodei, implementare din interfata cu parametru in useriapi
    public class LoginBl: UserAPI, ILogin
    {
     
public string UserAuthLogic(UserLoginDTO data)
        {
            return UserAuthLogicAction(data);
        }
    }
}
