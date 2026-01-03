using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.Employement_Request.GetEmployement_RequestLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Employement_Request.GetEmployement_RequestByPrimaryKey
{
    public class GetEmployement_RequestQueryHandler : IRequestHandler<GetEmployement_RequestByPrimaryKey, GetEmployement_RequestLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetEmployement_RequestQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetEmployement_RequestLoadAllListVm> Handle(GetEmployement_RequestByPrimaryKey request, CancellationToken cancellationToken)
        {
            Guid JOBPost_ID = request.JOBPost_ID;
            IList<EmployementRequest> Employement_Requests = await _procedureAdabter
               .Execute<EmployementRequest>("[HRA].[proc_Employement_RequestLoadByPrimaryKey]", (nameof(JOBPost_ID), JOBPost_ID));
            GetEmployement_RequestLoadAllListVm vm = new GetEmployement_RequestLoadAllListVm
            {
                Employement_Requests = _mapper.Map<IList<EmployementRequest>, IList<GetEmployement_RequestLoadAllVm>>(Employement_Requests)
            };

            return vm;
        }
    }
}
