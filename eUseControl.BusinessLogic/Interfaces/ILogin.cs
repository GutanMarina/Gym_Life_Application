using System;
using System.Collections.Generic;
using System.Text;
using eUseControl.Domain.Model.User;

namespace eUseControl.BusinessLogic.Interfaces
{//declaram metoda
    public interface ILogin
    {
        string UserAuthLogic(UserLoginDTO data);
    }
}
