using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procStockBIN.GetprocStockBINLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procStockBIN.GetprocStockBINByPrimaryKey
{
    public class GetprocStockBINQueryHandler : IRequestHandler<GetprocStockBINByPrimaryKey, GetprocStockBINLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocStockBINQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStockBINLoadAllListVm> Handle(GetprocStockBINByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Stock_BIN> procStockBINs = await _procedureAdabter
               .Execute<Stock_BIN>("[Inventory].[proc_Stock_BINLoadByPrimaryKey]", request);
            GetprocStockBINLoadAllListVm vm = new GetprocStockBINLoadAllListVm
            {
                procStockBINs = _mapper.Map<IList<Stock_BIN>, IList<GetprocStockBINLoadAllVm>>(procStockBINs)
            };

            return vm;
        }
    }
}
