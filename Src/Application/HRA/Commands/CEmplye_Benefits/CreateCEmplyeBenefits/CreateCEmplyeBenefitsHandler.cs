using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CEmplye_Benefits.CreateCEmplyeBenefits
{
    public class CreateCEmplyeBenefitsHandler : IRequestHandler<CreateCEmplyeBenefitsCommand, IList<Proc_c_Emplye_Benefits_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateCEmplyeBenefitsHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_c_Emplye_Benefits_Name>> Handle(CreateCEmplyeBenefitsCommand request, CancellationToken cancellationToken)
        {
            string Name = request.Name;
            bool? Enable = request.Enable;
            IList<Proc_c_Emplye_Benefits_Name> result = await _procedureAdabter
                .Execute<Proc_c_Emplye_Benefits_Name>("[HRA].[proc_c_Emplye_BenefitsInsert]",
                (nameof(Name), Name), 
                (nameof(Enable), Enable)
                );
           
            return result;
        }
    }
}
