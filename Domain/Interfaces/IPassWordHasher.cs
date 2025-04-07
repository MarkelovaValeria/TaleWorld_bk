using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPassWordHasher
    {
        string Generate(string password);
        bool Verify(string password, string hashedPassword);
    }
}
