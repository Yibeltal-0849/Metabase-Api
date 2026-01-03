using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblResourceBuyers.GetproctblResourceBuyersLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceBuyers.GetproctblResourceBuyersByPrimaryKey
{
    public class GetproctblResourceBuyersQueryHandler : IRequestHandler<GetproctblResourceBuyersByPrimaryKey, GetproctblResourceBuyersLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblResourceBuyersQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceBuyersLoadAllListVm> Handle(GetproctblResourceBuyersByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblResourceBuyers> proctblResourceBuyerss = await _procedureAdabter
               .Execute<tblResourceBuyers>("[ProprtyData].[proc_tblResourceBuyersLoadByPrimaryKey]", request);
            GetproctblResourceBuyersLoadAllListVm vm = new GetproctblResourceBuyersLoadAllListVm
            {
                proctblResourceBuyerss = _mapper.Map<IList<tblResourceBuyers>, IList<GetproctblResourceBuyersLoadAllVm>>(proctblResourceBuyerss)
            };

            return vm;
        }
    }
}
