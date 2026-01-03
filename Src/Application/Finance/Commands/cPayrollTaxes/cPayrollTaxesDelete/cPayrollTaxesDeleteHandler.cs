using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cPayrollTaxes.cPayrollTaxesDelete.cPayrollTaxesDeleteCommand
{

    /// @author  Shimels Alem  c_PayrollTaxesDelete stored procedure.


    public class cPayrollTaxesDeleteHandler : IRequestHandler<cPayrollTaxesDeleteCommand, IList<CPayrollTaxes_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPayrollTaxesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPayrollTaxes_Id>> Handle( cPayrollTaxesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CPayrollTaxes_Id> result = await _procedureAdabter
                .Execute<CPayrollTaxes_Id>("[FINA].c_PayrollTaxesDelete", request);
           

            return result;
        }
    }
}
  