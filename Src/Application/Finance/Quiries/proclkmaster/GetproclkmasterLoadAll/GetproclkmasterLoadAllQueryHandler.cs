using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proclkmaster.GetproclkmasterLoadAll
{
    class GetproclkmasterLoadAllQueryHandler : IRequestHandler<GetproclkmasterLoadAllQuery, GetproclkmasterLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproclkmasterLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproclkmasterLoadAllListVm> Handle(GetproclkmasterLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<lkmaster> proclkmasters = await _procedureAdabter
               .Execute<lkmaster>("[FINA].[proc_lkmasterLoadAll]");
            GetproclkmasterLoadAllListVm vm = new GetproclkmasterLoadAllListVm
            {
                proclkmasters = _mapper.Map<IList<lkmaster>, IList<GetproclkmasterLoadAllVm>>(proclkmasters)
            };

            return vm;
        }
    }
}
