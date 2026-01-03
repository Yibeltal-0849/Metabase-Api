


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CJournalType.CJournalTypeInsert.CJournalTypeInsertCommand
{

    /// @author  Shimels Alem  C_Journal_TypeInsert stored procedure.


    public class CJournalTypeInsertCommand : IRequest<IList<CJournalType_Type>>
    {
        public string Type { get; set; }
        public string Debit_Accounts { get; set; }
        public string Credit_Accounts { get; set; }
        public System.Guid? Visable_For_Form { get; set; }
        public string No_Series { get; set; }
    }
		
		
		 
}
 
 