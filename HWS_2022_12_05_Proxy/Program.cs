using System;

namespace HWS_2022_12_05_Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InteriorOffice interiorOffice = new();
            ServiceMachine serviceMachine = new(interiorOffice);

            List<Citizen> citizens = new()
            {
                new Citizen("Joe", "Rogan", "Jerusalem 2 PetahTikva"),
                new Citizen("Ringo", "Starr", "HaShomer 14 Holon"),
                new Citizen("George", "Mushtakel", "Begin 65 Tel-Aviv"),
                new Citizen("Kuni", "Lamel", "HaPardes 20 Yavne")
            };

            //adding citizens to Interior Office via the service machine:
            citizens.ForEach(citizen => serviceMachine.CreateCitizenRequest(citizen));
            citizens.ForEach(citizen => Console.WriteLine(citizen));

            //testing the ServiceMachine methods:
            serviceMachine.ChangeFirstName(citizens[0], "Moe");
            serviceMachine.ChangeAdress(citizens[citizens.Count-1], "Denia 87 Haifa");
            citizens.ForEach(citizen => serviceMachine.PassportRenewal(citizen));

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>> Citizens after changes: <<<<<<<<<<<<<<<<<<<<<<\n");

            citizens.ForEach(citizen => Console.WriteLine(citizen));
        }
    }
}
