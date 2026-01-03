using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetRent.FixedAssetRentUpdate.FixedAssetRentUpdateCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_RentUpdate stored procedure.


    public class FixedAssetRentUpdateCommand : IRequest<IList<FixedAssetRent_Rent_ID>>
    {
        public long Rent_ID { get; set; }
        public long Item_ID { get; set; }
        public string Fixed_Asset_Type { get; set; }
        public string Contract_No { get; set; }
        public System.DateTime? Rent_Start_Date { get; set; }
        public System.DateTime? Rent_End_Date { get; set; }
        public double? Rent_Value { get; set; }
        public double? VAT { get; set; }
        public double? Total_RentValue { get; set; }
        public string Reference_Number { get; set; }
        public string Payment_Mode { get; set; }
        public string Applicatiom_Number { get; set; }
        public System.Guid? Application_Code { get; set; }
    }
		
		
		 
	}

