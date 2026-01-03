using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.InventoryPostingSetup.InventoryPostingSetupUpdate.InventoryPostingSetupUpdateCommand
{

    /// @author  Shimels Alem  Inventory_Posting_SetupUpdate stored procedure.


    public class InventoryPostingSetupUpdateCommand : IRequest<IList<InventoryPostingSetup_Store_Code>>
   {
        public string Store_Code { get; set; }
        public string Invt_Posting_Group_Code { get; set; }
        public string Sales_Account { get; set; }
        public string Cost_of_Sales_Account { get; set; }
        public string Cost_of_good_Sold { get; set; }
        public string Inventory_Account { get; set; }
        public string WIP_Account { get; set; }
        public string Material_Varicance_Account { get; set; }
        public string Capacity_Varicance_Account { get; set; }
        public string Sub_Contractor_Varicance_Account { get; set; }
        public string Cap_Overhead_Varance_Account { get; set; }
    }
		
		
		 
}

