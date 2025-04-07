using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAuth
    {
        Task Register(string name, string surname, string email, string password, UserRole role, string language);
        Task Login(string email, string password);
    }
}
