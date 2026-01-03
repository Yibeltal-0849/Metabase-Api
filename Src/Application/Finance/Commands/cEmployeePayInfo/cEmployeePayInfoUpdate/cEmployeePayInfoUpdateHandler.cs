

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cEmployeePayInfo.cEmployeePayInfoUpdate.cEmployeePayInfoUpdateCommand
{

    /// @author  Shimels Alem  c_EmployeePayInfoUpdate stored procedure.


    public class cEmployeePayInfoUpdateHandler : IRequestHandler<cEmployeePayInfoUpdateCommand, IList<CEmployeePayInfo_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cEmployeePayInfoUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CEmployeePayInfo_id>> Handle( cEmployeePayInfoUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CEmployeePayInfo_id> result = await _procedureAdabter
                .Execute<CEmployeePayInfo_id>("[FINA].c_EmployeePayInfoUpdate", request);
           

            return result;
        }
    }
}
 