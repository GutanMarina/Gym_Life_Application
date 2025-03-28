using System;
using eUseControl.BusinessLogic.BlStruct;
using eUseControl.BusinessLogic.Interfaces;

namespace eUseControl.BusinessLogic
{//implimentarea la metoda
    public class BusinessLogic
    {
        public ILogin GetAuthBl()
        {
            return new LoginBl();
        }

    }
}
