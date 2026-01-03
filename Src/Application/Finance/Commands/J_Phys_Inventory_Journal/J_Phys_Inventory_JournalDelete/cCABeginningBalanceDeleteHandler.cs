using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.J_Phys_Inventory_Journal.J_Phys_Inventory_JournalDelete.J_Phys_Inventory_JournalDeleteCommand
{

    /// @author  Shimels Alem  c_CA_Beginning_BalanceDelete stored procedure.


    public class J_Phys_Inventory_JournalDeleteHandler : IRequestHandler<J_Phys_Inventory_JournalDeleteCommand, IList<J_Phys_Inventory_Journal_Posting_Date>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public J_Phys_Inventory_JournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<J_Phys_Inventory_Journal_Posting_Date>> Handle( J_Phys_Inventory_JournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<J_Phys_Inventory_Journal_Posting_Date> result = await _procedureAdabter
                .Execute<J_Phys_Inventory_Journal_Posting_Date>("[FINA].proc_J_Phys_Inventory_JournalDelet", request);
           

            return result;
        }
    }
}
  