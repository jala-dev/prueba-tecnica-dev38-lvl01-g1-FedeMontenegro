using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Presentation.View
{
    public class UserReceivableView
    {
        public InputData RequestData()
        {
            return this.GetData();
        }

        private InputData GetData()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el codigo del socio: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());
            return input;
        }

        public void ShowResult(int member, List<Consumption> consumption, double debt)
        {            
            MemberRepository repository = new MemberRepository();
            string name = repository.GetMember(member).FirstName + " " + repository.GetMember(member).SecondName;
            int cubes = 0;

            foreach (Consumption item in consumption)
            {
                if(item.MemberID == member)
                {
                    cubes = item.Value;
                }
            }
            
            Console.WriteLine("El consumo del socio {0}, correspondiente a {1} es de {2} cubos. La deuda total es de {3} Bs.", member, name, cubes, debt);
            Console.WriteLine("======================================");
        }
    }
}
