



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.HRA;
using System.Collections.Generic;


namespace Application.HRA.Commands.procCourtOrderDeduction.procCourtOrderDeductionInsert.procCourtOrderDeductionInsertCommand
{

    /// @author  Shimels Alem  proc_Court_Order_DeductionInsert stored procedure.


    public class procCourtOrderDeductionInsertHandler : IRequestHandler<procCourtOrderDeductionInsertCommand, IList<CourtOrderDeduction_CourtOrderID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCourtOrderDeductionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CourtOrderDeduction_CourtOrderID>> Handle( procCourtOrderDeductionInsertCommand request, CancellationToken cancellationToken)
        {


            System.Guid Court_Order_ID = request.Court_Order_ID;
            string Employee_ID = request.Employee_ID;
            string Sub_Account_No = request.Sub_Account_No;
            string Payee_Name = request.Payee_Name;
            double? Amount = request.Amount;
            byte[] Court_Letter = request.Court_Letter;
            IList<CourtOrderDeduction_CourtOrderID> result = await _procedureAdabter
                .Execute<CourtOrderDeduction_CourtOrderID>("[HRA].proc_Court_Order_DeductionInsert",
                (nameof(Court_Order_ID), Court_Order_ID),
                (nameof(Employee_ID), Employee_ID),
                (nameof(Sub_Account_No), Sub_Account_No),
                (nameof(Payee_Name), Payee_Name),
                (nameof(Amount), Amount),
                (nameof(Court_Letter), Court_Letter)
                );
           

            return result;
        }
    }
}
 