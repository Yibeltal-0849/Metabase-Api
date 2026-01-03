using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Quiries.AnnualStrategicGoals
{
    public class AnnualStrategicGoalsLoadAllVm : IMapFrom<Proc_Annual_Strategic_Goals>
    {
        public string Annual_Strategic_GoalID { get; set; } 
        public string Strategic_ThemeID { get; set; } 
        public DateTime? Created_Date { get; set; } 
        public int? Year { get; set; } 
        public double? Result_In_Per { get; set; } 
        public System.Guid? ApplicationCode { get; set; } 
        public string Application_NO { get; set; } 
        public string DocNo { get; set; } 
        public string Log { get; set; } 
        public bool? IsActive { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_Annual_Strategic_Goals, AnnualStrategicGoalsLoadAllVm>()
             .ForMember(d => d.Annual_Strategic_GoalID, opt => opt.MapFrom(s => s.Annual_Strategic_GoalID != null ? s.Annual_Strategic_GoalID : null))
            .ForMember(d => d.Strategic_ThemeID, opt => opt.MapFrom(s => s.Strategic_ThemeID != null ? s.Strategic_ThemeID : null))
            .ForMember(d => d.Created_Date, opt => opt.MapFrom(s => s.Created_Date != null ? s.Created_Date : null))
            .ForMember(d => d.Year, opt => opt.MapFrom(s => s.Year != null ? s.Year : null))
            .ForMember(d => d.Result_In_Per, opt => opt.MapFrom(s => s.Result_In_Per != null ? s.Result_In_Per : null))
            .ForMember(d => d.ApplicationCode, opt => opt.MapFrom(s => s.ApplicationCode != null ? s.ApplicationCode : null))
            .ForMember(d => d.Application_NO, opt => opt.MapFrom(s => s.Application_NO != null ? s.Application_NO : null))
            .ForMember(d => d.DocNo, opt => opt.MapFrom(s => s.DocNo != null ? s.DocNo : null))
            .ForMember(d => d.Log, opt => opt.MapFrom(s => s.Log != null ? s.DocNo : null))
            .ForMember(d => d.IsActive, opt => opt.MapFrom(s => s.IsActive != null ? s.IsActive : null));
        }
    }
}
