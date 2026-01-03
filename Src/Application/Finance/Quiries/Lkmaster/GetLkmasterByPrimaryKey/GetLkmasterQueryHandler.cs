using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.Lkmaster.GetLkmasterLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.Lkmaster.GetLkmasterByPrimaryKey
{
    public class GetLkmasterQueryHandler : IRequestHandler<GetLkmasterByPrimaryKey, GetLkmasterLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetLkmasterQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetLkmasterLoadAllListVm> Handle(GetLkmasterByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<lkmaster> Lkmasters = await _procedureAdabter
               .Execute<lkmaster>("[FINA].[lkmaster_GetRecord]", request);
            GetLkmasterLoadAllListVm vm = new GetLkmasterLoadAllListVm
            {
                Lkmasters = _mapper.Map<IList<lkmaster>, IList<GetLkmasterLoadAllVm>>(Lkmasters)
            };

            return vm;
        }
    }
}
