using AutoMapper;
using ShopBeta.Core.DTO.Response;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ShopBeta.Core.Entities.Requests;
using ShopBeta.Core.DTO;
using ShopBeta.Infrastructure.Authentication;

namespace ShopBeta.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<ProductCreationDto, Products>();
            CreateMap<Products, ProductCreationDto>();
            CreateMap<ProductUpdateDto, Products>();
            CreateMap<ReviewsDto, Reviews>();

            CreateMap<Products, ProductsDto>();
            CreateMap<Products, ProductsDto>().ReverseMap();
            CreateMap<UserRegistrationDto, User>();
                
           



        }

    }
}
