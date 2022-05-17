using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_12_05_Proxy
{
    public class InteriorOffice : IServiceMachine, IInteriorOffice
    {
        private readonly List<Citizen> Citizens = new();

        //Implementing IServiceMachine interface, ServiceMachine can accesss this methods only
        public void ChangeAdress(Citizen citizen, string? adress)
        {
            citizen.Address = adress;
        }
        public void ChangeFirstName(Citizen citizen, string? name)
        {
            citizen.FirstName = name;
        }
        public void PassportRenewal(Citizen citizen)
        {
            if (citizen.PassPortValidThrough != null)
            {
                citizen.PassPortValidThrough = DateTime.Now.AddDays(365 * 5);
            }
        }
        public void CreateCitizenRequest(Citizen citizen)
        {
            Random rnd = new();

            citizen.Age = rnd.Next(121);
            citizen.ID = rnd.Next(100000000, 999999999);
            AddCitizen(this, citizen);
        }

        //Implementing IInteriorOffice interface, restricted methods that can be accessed by the office only
        public void AddCitizen(object obj, Citizen citizen)
        {
            if (obj is not IInteriorOffice)
            {
                return;
            }
            GivePassPort(this, citizen);
            Citizens.Add(citizen);
        }
        
        public void GivePassPort(object obj, Citizen citizen)
        {
            if (obj is not IInteriorOffice)
            {
                return;
            }
            citizen.PassPortCreated = DateTime.Now;
            citizen.PassPortValidThrough = DateTime.Now.AddDays(365 * 3);
        }
    }
}
