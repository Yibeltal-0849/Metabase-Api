using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proclkmaster.GetproclkmasterLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proclkmaster.GetproclkmasterByPrimaryKey
{
    public class GetproclkmasterQueryHandler : IRequestHandler<GetproclkmasterByPrimaryKey, GetproclkmasterLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproclkmasterQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproclkmasterLoadAllListVm> Handle(GetproclkmasterByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<lkmaster> proclkmasters = await _procedureAdabter
               .Execute<lkmaster>("[FINA].[proc_lkmasterLoadByPrimaryKey]", request);
            GetproclkmasterLoadAllListVm vm = new GetproclkmasterLoadAllListVm
            {
                proclkmasters = _mapper.Map<IList<lkmaster>, IList<GetproclkmasterLoadAllVm>>(proclkmasters)
            };

            return vm;
        }
    }
}
