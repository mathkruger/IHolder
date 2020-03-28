using System;
using System.Collections.Generic;
using System.Text;

namespace IHolder.Business.Interfaces
{
    public interface IUser
    {
        int GetUserId();
        string GetUserEmail();
        string GetUserName();
        bool IsAuthenticated();
    }
}
