using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_12_05_Proxy
{
    public interface IInteriorOffice
    {
        void AddCitizen(object obj, Citizen citizen);
        void GivePassPort(object obj, Citizen citizen);
    }
}
