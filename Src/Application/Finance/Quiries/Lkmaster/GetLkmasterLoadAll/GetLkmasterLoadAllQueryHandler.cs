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

namespace Application.Finance.Quiries.Lkmaster.GetLkmasterLoadAll
{
    class GetLkmasterLoadAllQueryHandler : IRequestHandler<GetLkmasterLoadAllQuery, GetLkmasterLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetLkmasterLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetLkmasterLoadAllListVm> Handle(GetLkmasterLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<lkmaster> Lkmasters = await _procedureAdabter
               .Execute<lkmaster>("[FINA].[Lkmaster_GetRecords]");
            GetLkmasterLoadAllListVm vm = new GetLkmasterLoadAllListVm
            {
                Lkmasters = _mapper.Map<IList<lkmaster>, IList<GetLkmasterLoadAllVm>>(Lkmasters)
            };

            return vm;
        }
    }
}
