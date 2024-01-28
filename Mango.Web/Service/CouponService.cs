using Mango.Web.Models;
using Mango.Web.Service.IService;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public Task<ResponseDTO?> CreateCouponAsync(CouponDTO couponDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO?> DeleteCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO?> GetAllCouponsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO?> GetCouponByCodeAsync(string couponCode)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO?> GetCouponByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO?> UpdateCouponAsync(CouponDTO couponDTO)
        {
            throw new NotImplementedException();
        }
    }
}
