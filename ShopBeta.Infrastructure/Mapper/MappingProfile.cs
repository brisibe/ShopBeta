﻿using AutoMapper;
using ShopBeta.Core.Entities.Requests;
using ShopBeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBeta.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<ProductCreationDto, Products>();
            CreateMap<ProductUpdateDto, Products>();
            CreateMap<ReviewsDto, Reviews>();
           



        }

    }
}
