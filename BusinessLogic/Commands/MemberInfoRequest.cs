using Data;
using Data.Entities;
using Presentation;
using Presentation.View;

namespace BusinessLogic.Commands
{
    class MemberInfoRequest
    {
        public void Execute()
        {
            try
            {
                MemberInfoView view = new MemberInfoView();
                InputData data = view.RequestData();
                Member entity = new Member();
                entity.ID = int.Parse(data.fields["CodigoSocio"]);

                Member member = new MemberRepository().GetMember(entity.ID);

                view.ShowResult(member.FirstName + " " + member.SecondName);

            }
            catch (System.Exception ex)
            {
                throw new System.Exception(string.Format("El código ingresado no existe en el sistema."));
            }
        }
    }
}
