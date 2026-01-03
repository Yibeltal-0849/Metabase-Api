using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procGenPostingType.GetprocGenPostingTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procGenPostingType.GetprocGenPostingTypeByPrimaryKey
{
    public class GetprocGenPostingTypeQueryHandler : IRequestHandler<GetprocGenPostingTypeByPrimaryKey, GetprocGenPostingTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocGenPostingTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocGenPostingTypeLoadAllListVm> Handle(GetprocGenPostingTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<GenPostingType> procGenPostingTypes = await _procedureAdabter
               .Execute<GenPostingType>("[FINA].[proc_Gen_Posting_TypeLoadByPrimaryKey]", request);
            GetprocGenPostingTypeLoadAllListVm vm = new GetprocGenPostingTypeLoadAllListVm
            {
                procGenPostingTypes = _mapper.Map<IList<GenPostingType>, IList<GetprocGenPostingTypeLoadAllVm>>(procGenPostingTypes)
            };

            return vm;
        }
    }
}
