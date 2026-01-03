using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procEmployeeBioInfoType.GetprocEmployeeBioInfoTypeLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procEmployeeBioInfoType.GetprocEmployeeBioInfoTypeByPrimaryKey
{
    public class GetprocEmployeeBioInfoTypeQueryHandler : IRequestHandler<GetprocEmployeeBioInfoTypeByPrimaryKey, GetprocEmployeeBioInfoTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEmployeeBioInfoTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEmployeeBioInfoTypeLoadAllListVm> Handle(GetprocEmployeeBioInfoTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<EmployeeBioInfoType> procEmployeeBioInfoTypes = await _procedureAdabter
               .Execute<EmployeeBioInfoType>("[HRA].[proc_Employee_Bio_Info_TypeLoadByPrimaryKey]", request);
            GetprocEmployeeBioInfoTypeLoadAllListVm vm = new GetprocEmployeeBioInfoTypeLoadAllListVm
            {
                procEmployeeBioInfoTypes = _mapper.Map<IList<EmployeeBioInfoType>, IList<GetprocEmployeeBioInfoTypeLoadAllVm>>(procEmployeeBioInfoTypes)
            };

            return vm;
        }
    }
}
