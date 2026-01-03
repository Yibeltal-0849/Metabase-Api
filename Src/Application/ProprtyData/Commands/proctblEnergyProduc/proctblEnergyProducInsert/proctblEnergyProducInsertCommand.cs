


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblEnergyProduc.proctblEnergyProducInsert.proctblEnergyProducInsertCommand
{

    /// @author  Shimels Alem  proc_tblEnergyProducInsert stored procedure.


    public class proctblEnergyProducInsertCommand : IRequest<IList<tblEnergyProduc_Id>>
    {
        public long? Id { get; set; }
        public string Energy_Number { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
    }
		
		
		 
}
 
 