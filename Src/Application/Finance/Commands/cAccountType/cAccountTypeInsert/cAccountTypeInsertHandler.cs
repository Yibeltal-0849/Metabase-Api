



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cAccountType.cAccountTypeInsert.cAccountTypeInsertCommand
{

    /// @author  Shimels Alem  c_Account_TypeInsert stored procedure.


    public class cAccountTypeInsertHandler : IRequestHandler<cAccountTypeInsertCommand, IList<CAccountType_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cAccountTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CAccountType_Id>> Handle( cAccountTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CAccountType_Id> result = await _procedureAdabter
                .Execute<CAccountType_Id>("[FINA].c_Account_TypeInsert", request);
           

            return result;
        }
    }
}
 