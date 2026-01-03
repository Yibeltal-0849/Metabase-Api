using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;
namespace Application.Purchase.Quiries.procReciveRent.GetprocReciveRentLoadAll
{ 
    public class GetprocReciveRentLoadAllQueryHandler : IRequestHandler<GetprocRecieRentLoadAllQuery, GetprocReciveRentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocReciveRentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocReciveRentLoadAllListVm> Handle(GetprocRecieRentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ReciveRent> procReciveRent = await _procedureAdabter
               .Execute<ReciveRent>("[Purchase].[proc_Recive_RentLoadAll]");
            GetprocReciveRentLoadAllListVm vm = new GetprocReciveRentLoadAllListVm
            {
                procReciveRent = _mapper.Map<IList<ReciveRent>, IList<GetprocReciveRentLoadAllVm>>(procReciveRent)
            };

            return vm;
        }
    }


}
