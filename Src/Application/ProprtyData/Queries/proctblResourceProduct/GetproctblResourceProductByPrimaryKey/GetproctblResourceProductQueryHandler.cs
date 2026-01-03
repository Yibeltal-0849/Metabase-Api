using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblResourceProduct.GetproctblResourceProductLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceProduct.GetproctblResourceProductByPrimaryKey
{
    public class GetproctblResourceProductQueryHandler : IRequestHandler<GetproctblResourceProductByPrimaryKey, GetproctblResourceProductLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblResourceProductQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceProductLoadAllListVm> Handle(GetproctblResourceProductByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblResourceProduct> proctblResourceProducts = await _procedureAdabter
               .Execute<tblResourceProduct>("[ProprtyData].[proc_tblResource_ProductLoadByPrimaryKey]", request);
            GetproctblResourceProductLoadAllListVm vm = new GetproctblResourceProductLoadAllListVm
            {
                proctblResourceProducts = _mapper.Map<IList<tblResourceProduct>, IList<GetproctblResourceProductLoadAllVm>>(proctblResourceProducts)
            };

            return vm;
        }
    }
}
