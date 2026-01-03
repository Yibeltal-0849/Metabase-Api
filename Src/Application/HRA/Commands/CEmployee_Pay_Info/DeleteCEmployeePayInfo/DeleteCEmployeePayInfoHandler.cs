using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CEmployee_Pay_Info.DeleteCEmployeePayInfo
{
    public class DeleteCEmployeePayInfoHandler : IRequestHandler<DeleteCEmployeePayInfoCommand, IList<CEmployeePayInfo_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCEmployeePayInfoHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CEmployeePayInfo_id>> Handle(DeleteCEmployeePayInfoCommand request, CancellationToken cancellationToken)
        {
            long? Id = request.Id;
            IList<CEmployeePayInfo_id> result = await _procedureAdabter
                .Execute<CEmployeePayInfo_id>("[HRA].[proc_C_EmployeePayInfoDelete]", (nameof(Id), Id));

            return result;
        }
    }
}
