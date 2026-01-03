using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CEmplye_Benefits.DeleteCEmplyeBenefits
{
    public class DeleteCEmplyeBenefitsHandler : IRequestHandler<DeleteCEmplyeBenefitsCommand, IList<Proc_c_Emplye_Benefits_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCEmplyeBenefitsHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_c_Emplye_Benefits_Name>> Handle(DeleteCEmplyeBenefitsCommand request, CancellationToken cancellationToken)
        {
            string name = request.Name;
            IList<Proc_c_Emplye_Benefits_Name> result = await _procedureAdabter
                .Execute<Proc_c_Emplye_Benefits_Name>("[HRA].[proc_c_Emplye_BenefitsDelete]", (nameof(name), name));
           
            return result;
        }
    }
}
