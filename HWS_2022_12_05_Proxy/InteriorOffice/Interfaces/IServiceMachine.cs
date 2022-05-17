using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_12_05_Proxy
{
    public interface IServiceMachine
    {
        void ChangeAdress(Citizen citizen, string? adress);
        void ChangeFirstName(Citizen citizen, string? name);
        void PassportRenewal(Citizen citizen);
        void CreateCitizenRequest(Citizen citizen);
    }
}
