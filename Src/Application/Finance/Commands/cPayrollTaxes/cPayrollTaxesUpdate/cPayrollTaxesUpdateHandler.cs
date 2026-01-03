

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cPayrollTaxes.cPayrollTaxesUpdate.cPayrollTaxesUpdateCommand
{

    /// @author  Shimels Alem  c_PayrollTaxesUpdate stored procedure.


    public class cPayrollTaxesUpdateHandler : IRequestHandler<cPayrollTaxesUpdateCommand, IList<CPayrollTaxes_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPayrollTaxesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPayrollTaxes_Id>> Handle( cPayrollTaxesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CPayrollTaxes_Id> result = await _procedureAdabter
                .Execute<CPayrollTaxes_Id>("[FINA].c_PayrollTaxesUpdate", request);
           

            return result;
        }
    }
}
 