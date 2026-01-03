



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.J_Phys_Inventory_Journal.J_Phys_Inventory_JournalInsert.J_Phys_Inventory_JournalInsertCommand
{

    /// @author  Shimels Alem  c_CA_Beginning_BalanceInsert stored procedure.


    public class J_Phys_Inventory_JournalInsertHandler : IRequestHandler<J_Phys_Inventory_JournalInsertCommand, IList<J_Phys_Inventory_Journal_Posting_Date>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public J_Phys_Inventory_JournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<J_Phys_Inventory_Journal_Posting_Date>> Handle( J_Phys_Inventory_JournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<J_Phys_Inventory_Journal_Posting_Date> result = await _procedureAdabter
                .Execute<J_Phys_Inventory_Journal_Posting_Date>("[FINA].proc_J_Phys_Inventory_JournalInsert", request);
           

            return result;
        }
    }
}
 