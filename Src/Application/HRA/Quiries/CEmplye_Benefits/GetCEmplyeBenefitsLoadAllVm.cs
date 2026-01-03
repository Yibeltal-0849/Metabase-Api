using Application.Common.Mappings;
using AutoMapper;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Quiries.CEmplye_Benefits
{
    public class GetCEmplyeBenefitsLoadAllVm : IMapFrom<Proc_c_Emplye_Benefits>
    {
        public string Name { get; set; }
        public bool? Enable { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_c_Emplye_Benefits, GetCEmplyeBenefitsLoadAllVm>()
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name != null ? s.Name : null))
                .ForMember(d => d.Enable, opt => opt.MapFrom(s => s.Enable != null ? s.Enable : null));
        }
    }
}
