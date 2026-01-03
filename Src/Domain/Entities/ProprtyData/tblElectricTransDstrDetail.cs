
namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblElectricTransDstrDetail
	{
		public long id { get; set; }
		public long? ETD_ID { get; set; }
		public string Number_of_Substation_by_voltage_level { get; set; }
		public string Transmissions_line_length_in_km_by_voltage_level { get; set; }
		public string Distribution_line_length_by_voltage_level { get; set; }
		public string No_of_distribution_transformers { get; set; }

	}
}
