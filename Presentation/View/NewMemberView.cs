using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Entities;
using Data.DB;

namespace Presentation.View
{
    public class NewMemberView
    {
        public Member AddMember() 
        {
            Member newMember = new Member();

            Console.WriteLine("Ingrese ID de socio:");
            newMember.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer nombre de socio:");
            newMember.FirstName = Console.ReadLine();
            
            Console.WriteLine("Ingrese el segundo nombre de socio:");
            newMember.SecondName = Console.ReadLine();

            return newMember;
        }


    }
}