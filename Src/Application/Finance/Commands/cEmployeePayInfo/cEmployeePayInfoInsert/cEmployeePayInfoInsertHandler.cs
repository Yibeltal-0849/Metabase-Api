



using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cEmployeePayInfo.cEmployeePayInfoInsert.cEmployeePayInfoInsertCommand
{

    /// @author  Shimels Alem  c_EmployeePayInfoInsert stored procedure.


    public class cEmployeePayInfoInsertHandler : IRequestHandler<cEmployeePayInfoInsertCommand, IList<CEmployeePayInfo_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cEmployeePayInfoInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CEmployeePayInfo_id>> Handle( cEmployeePayInfoInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CEmployeePayInfo_id> result = await _procedureAdabter
                .Execute<CEmployeePayInfo_id>("[FINA].c_EmployeePayInfoInsert", request);
           

            return result;
        }
    }
}
 