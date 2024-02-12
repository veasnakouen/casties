using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
            CreateMap<Item, AuctionDto>();

            CreateMap<CreateAuctionDto, Auction>()
            .ForMember(c => c.Item, o => o.MapFrom(s => s));//in this case s represent Item
            CreateMap<CreateAuctionDto, Item>();
        }
    }
}