using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.procReciveRent.GetprocReciveRentLoadAll;

using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.procReciveRent.GetprocReciveRentByPrimaryKey
{
    public class GetprocReciveRentQueryHandler : IRequestHandler<GetprocReciveRentByPrimaryKey, GetprocReciveRentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocReciveRentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocReciveRentLoadAllListVm> Handle(GetprocReciveRentByPrimaryKey request, CancellationToken cancellationToken)
        {

            IList<ReciveRent> procReciveRent = await _procedureAdabter
               .Execute<ReciveRent>("[Purchase].[proc_Recive_RentByPrimaryKey]", request);
            GetprocReciveRentLoadAllListVm vm = new GetprocReciveRentLoadAllListVm

            {
                procReciveRent = _mapper.Map<IList<ReciveRent>, IList<GetprocReciveRentLoadAllVm>>(procReciveRent)
            };

            return vm;
        }
    }
}
