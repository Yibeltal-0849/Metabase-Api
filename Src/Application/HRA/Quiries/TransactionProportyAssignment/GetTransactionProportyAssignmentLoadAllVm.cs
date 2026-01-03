using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Quiries.TransactionProportyAssignment
{
    public class GetTransactionProportyAssignmentLoadAllVm : IMapFrom<proc_Transaction_Proporty_Assignment>
    {

        public System.Guid Trasn_Id { get; set; }
        public byte[] Documents { get; set; }
        public System.DateTime? Period { get; set; }
        public System.DateTime? Created_Date { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<proc_Transaction_Proporty_Assignment, GetTransactionProportyAssignmentLoadAllVm>();
        }
    }
}
