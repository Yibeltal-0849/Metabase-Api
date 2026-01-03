using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cEmplyeBenefits.cEmplyeBenefitsDelete.cEmplyeBenefitsDeleteCommand
{

    /// @author  Shimels Alem  c_Emplye_BenefitsDelete stored procedure.


    public class cEmplyeBenefitsDeleteHandler : IRequestHandler<cEmplyeBenefitsDeleteCommand, IList<CEmplyeBenefits_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cEmplyeBenefitsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CEmplyeBenefits_Name>> Handle( cEmplyeBenefitsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CEmplyeBenefits_Name> result = await _procedureAdabter
                .Execute<CEmplyeBenefits_Name>("[FINA].c_Emplye_BenefitsDelete", request);
           

            return result;
        }
    }
}
  