using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Employement_Request.GetEmployement_RequestLoadAll
{
    class GetEmployement_RequestLoadAllQueryHandler : IRequestHandler<GetEmployement_RequestLoadAllQuery, GetEmployement_RequestLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetEmployement_RequestLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetEmployement_RequestLoadAllListVm> Handle(GetEmployement_RequestLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<EmployementRequest> Employement_Request = await _procedureAdabter
               .Execute<EmployementRequest>("[HRA].[proc_Employement_RequestLoadAll]");
            GetEmployement_RequestLoadAllListVm vm = new GetEmployement_RequestLoadAllListVm
            {
                Employement_Requests = _mapper.Map<IList<EmployementRequest>, IList<GetEmployement_RequestLoadAllVm>>(Employement_Request)
            };

            return vm;
        }
    }
}
