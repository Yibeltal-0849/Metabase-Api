using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procPayroleTransaction
{
    public class GetprocPayroleTransactionLoadAllVm : IMapFrom<PayroleTransaction>
    {
        public Guid Payrole_Trans_Id { get; set; }
        public string Period { get; set; }
        public DateTime? start_Date { get; set; }
        public DateTime? End_date { get; set; }
        public string Month { get; set; }
        public bool? For_Permanent { get; set; }
        public bool? Generate { get; set; }
        public string Archived_Pay_Slip { get; set; }
        public string Application_Number { get; set; }
        public Guid? Applicaation_Code { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PayroleTransaction, GetprocPayroleTransactionLoadAllVm>();
        }
    }
}
