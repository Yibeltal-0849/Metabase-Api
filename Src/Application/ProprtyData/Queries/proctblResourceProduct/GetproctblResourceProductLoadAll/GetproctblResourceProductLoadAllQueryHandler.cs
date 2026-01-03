using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceProduct.GetproctblResourceProductLoadAll
{
    class GetproctblResourceProductLoadAllQueryHandler : IRequestHandler<GetproctblResourceProductLoadAllQuery, GetproctblResourceProductLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceProductLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceProductLoadAllListVm> Handle(GetproctblResourceProductLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResourceProduct> proctblResourceProducts = await _procedureAdabter
               .Execute<tblResourceProduct>("[ProprtyData].[proc_tblResource_ProductLoadAll]");
            GetproctblResourceProductLoadAllListVm vm = new GetproctblResourceProductLoadAllListVm
            {
                proctblResourceProducts = _mapper.Map<IList<tblResourceProduct>, IList<GetproctblResourceProductLoadAllVm>>(proctblResourceProducts)
            };

            return vm;
        }
    }
}
