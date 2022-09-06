using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Entities;
using Data.DB;
using Presentation.View;

namespace BusinessLogic.Commands
{
    class SaveUser
    {
        public void Execute()
        {
            try
            {
                NewMemberView newMember = new NewMemberView();
                LocalMemoryDB.MembersContext.Add(newMember.AddMember());

                MemberRepository members = new MemberRepository();

            }
            catch (System.Exception)
            {

                throw new System.Exception(string.Format("No se pudo completar la operación."));
            }
        }
    }
}
