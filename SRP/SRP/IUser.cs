using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal interface IUser
    {
        bool Login(string userName, string password);
        bool Register(string userName, string password, string email);

        /*
         No SRP avaliable useage

         void LogError(string errorMessage);
         bool SendEmail(string emailContent);
        */
    }

    // SRP avaliable useage

    interface ILogger
    {
        void LogError(string errorMessage);
    }
    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
