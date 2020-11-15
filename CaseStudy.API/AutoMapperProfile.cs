using AutoMapper;
using CaseStudy.Data.Entities;
using CaseStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductModel>();
            CreateMap<ProductModel, Product>()
                .ForMember(dest=>dest.Created, opt=>opt.Ignore())
                .ForMember(dest=>dest.Modified, opt=>opt.Ignore())
                ;
        }
    }
}
