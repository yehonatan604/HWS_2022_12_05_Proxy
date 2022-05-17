using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_12_05_Proxy
{
    public class ServiceMachine : InteriorOffice, IServiceMachine
    {
        public InteriorOffice InteriorOffice;

        public ServiceMachine(InteriorOffice interiorOffice)
        {
            InteriorOffice = interiorOffice;
        }

        public new void ChangeAdress(Citizen citizen, string? adress)
        {
            InteriorOffice.ChangeAdress(citizen, adress);
        }

        public new void ChangeFirstName(Citizen citizen, string? name)
        {
            InteriorOffice.ChangeFirstName(citizen, name);
        }

        public new void CreateCitizenRequest(Citizen citizen)
        {
            InteriorOffice.CreateCitizenRequest(citizen);
        }

        public new void PassportRenewal(Citizen citizen)
        {
            InteriorOffice.PassportRenewal(citizen);
        }
    }
}
