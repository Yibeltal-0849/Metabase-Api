using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblEnergy
{
    public class GetproctblEnergyLoadAllVm : IMapFrom<tblEnergy>
    {
		public long id { get; set; }
		public string Name { get; set; }
		public bool? Enable { get; set; }
		public bool Renewable { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Last_Modified { get; set; }
		public long? Grouping { get; set; }
		public long? State { get; set; }
		public long? Energy_Typ { get; set; }
		public decimal? Net_Energy_Content { get; set; }
		public long? Energy_Units { get; set; }
		public long? per_Physical_Unit { get; set; }
		public decimal? Net_Gross_Heating_Value_Ratio { get; set; }
		public decimal? Density_kg_liter { get; set; }
		public decimal? Carbon_Content { get; set; }
		public decimal? Sulfur_Content { get; set; }
		public decimal? Nitrogen_Content { get; set; }
		public decimal? Ash_Content { get; set; }
		public decimal? Moisture_Content { get; set; }
		public decimal? Methane_Content { get; set; }
		public decimal? Fraction_Oxidized { get; set; }
		public decimal? Sulfur_Retention { get; set; }
		public string Note { get; set; }
		public string Referance { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<tblEnergy, GetproctblEnergyLoadAllVm>();
        }
    }
}
