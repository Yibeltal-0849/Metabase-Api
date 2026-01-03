using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceBuyers.GetproctblResourceBuyersLoadAll
{
    class GetproctblResourceBuyersLoadAllQueryHandler : IRequestHandler<GetproctblResourceBuyersLoadAllQuery, GetproctblResourceBuyersLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceBuyersLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceBuyersLoadAllListVm> Handle(GetproctblResourceBuyersLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResourceBuyers> proctblResourceBuyerss = await _procedureAdabter
               .Execute<tblResourceBuyers>("[ProprtyData].[proc_tblResourceBuyersLoadAll]");
            GetproctblResourceBuyersLoadAllListVm vm = new GetproctblResourceBuyersLoadAllListVm
            {
                proctblResourceBuyerss = _mapper.Map<IList<tblResourceBuyers>, IList<GetproctblResourceBuyersLoadAllVm>>(proctblResourceBuyerss)
            };

            return vm;
        }
    }
}
