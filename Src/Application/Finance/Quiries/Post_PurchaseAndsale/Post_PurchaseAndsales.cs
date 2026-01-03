using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.Post_PurchaseAndsale
{
    public class Post_PurchaseAndsales : IMapFrom<PostPurchaseAndsale>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PostPurchaseAndsale, Post_PurchaseAndsales>();
        }
    }
}
