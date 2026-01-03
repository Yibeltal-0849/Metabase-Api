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

namespace XOKA.Application.HRA.Quiries.Employement_Request.Getproc_Employement_RequestLoadByPrimaryKey_application_code
{
    public class GetEmployement_RequestQueryHandler : IRequestHandler<Getproc_Employement_RequestLoadByPrimaryKey_application_code, GetEmployement_RequestLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetEmployement_RequestQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetEmployement_RequestLoadAllListVm> Handle(Getproc_Employement_RequestLoadByPrimaryKey_application_code request, CancellationToken cancellationToken)
        {
            Guid application_code = request.application_code;
            IList<EmployementRequest> Employement_Requests = await _procedureAdabter
               .Execute<EmployementRequest>("[HRA].[proc_Employement_RequestLoadByPrimaryKey_application_code]", (nameof(application_code), application_code));
            GetEmployement_RequestLoadAllListVm vm = new GetEmployement_RequestLoadAllListVm
            {
                Employement_Requests = _mapper.Map<IList<EmployementRequest>, IList<GetEmployement_RequestLoadAllVm>>(Employement_Requests)
            };

            return vm;
        }
    }
}
