using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void ShowResult(int socio, List<Consumption> consumption, double debt)
        {            
            int cubes = 0;
            foreach (Consumption item in consumption)
            {
                if(item.MemberID == socio)
                {
                    cubes = item.Value;
                }
            }
            
            Console.WriteLine("El consumo del socio {0} es de {1} cubos. La deuda actual es de {2} Bs", socio, cubes, debt);
            Console.WriteLine("======================================");
        }
    }
}
