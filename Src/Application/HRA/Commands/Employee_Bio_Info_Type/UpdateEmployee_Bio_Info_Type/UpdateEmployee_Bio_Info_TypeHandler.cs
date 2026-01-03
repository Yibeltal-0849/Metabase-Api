using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Employee_Bio_Info_Type.UpdateEmployee_Bio_Info_Type
{
    public class UpdateEmployee_Bio_Info_TypeHandler : IRequestHandler<UpdateEmployee_Bio_Info_TypeCommand, IList<EmployeeBioInfoType_Bio_Type_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateEmployee_Bio_Info_TypeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmployeeBioInfoType_Bio_Type_ID>> Handle(UpdateEmployee_Bio_Info_TypeCommand request, CancellationToken cancellationToken)
        {

            IList<EmployeeBioInfoType_Bio_Type_ID> result = await _procedureAdabter
                .Execute<EmployeeBioInfoType_Bio_Type_ID>("[HRA].[proc_Employee_Bio_Info_TypeUpdate]", request);

            return result;
        }
    }
}
