

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.J_Phys_Inventory_Journal.J_Phys_Inventory_JournalUpdate.J_Phys_Inventory_JournalUpdateCommand
{

    /// @author  Shimels Alem  c_CA_Beginning_BalanceUpdate stored procedure.


    public class J_Phys_Inventory_JournalUpdateHandler : IRequestHandler<J_Phys_Inventory_JournalUpdateCommand, IList<J_Phys_Inventory_Journal_Posting_Date>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public J_Phys_Inventory_JournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<J_Phys_Inventory_Journal_Posting_Date>> Handle( J_Phys_Inventory_JournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<J_Phys_Inventory_Journal_Posting_Date> result = await _procedureAdabter
                .Execute<J_Phys_Inventory_Journal_Posting_Date>("[FINA].proc_J_Phys_Inventory_JournalUpdate", request);
           

            return result;
        }
    }
}
 