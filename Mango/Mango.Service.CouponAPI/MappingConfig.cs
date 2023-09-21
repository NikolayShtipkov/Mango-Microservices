using AutoMapper;
using Mango.Service.CouponAPI.Models;
using Mango.Service.CouponAPI.Models.DTO;

namespace Mango.Service.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });

            return mappingConfig;
        }
    }
}
