using Mango.Web.Models;
using Mango.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;
        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<CouponDTO>? list = new();

            ResponseDTO? response = await _couponService.GetAllCouponsAsync();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<CouponDTO>>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CouponDTO couponDTO)
        {
            if(ModelState.IsValid)
            {
                ResponseDTO? response = await _couponService.CreateCouponAsync(couponDTO);
                if (response != null && response.IsSuccess)
                {
                    TempData["success"] = "Coupon successfully created.";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error"] = response?.Message;
                }
            }
            return View(couponDTO);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int couponId)
        {
            ResponseDTO? response = await _couponService.GetCouponByIdAsync(couponId);
            if (response != null && response.IsSuccess)
            {
                CouponDTO? model  = JsonConvert.DeserializeObject<CouponDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(CouponDTO couponDTO)
        {
            ResponseDTO? response = await _couponService.DeleteCouponAsync(couponDTO.Id);
            if (response != null && response.IsSuccess)
            {
                TempData["success"] = "Coupon successfully deleted.";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(couponDTO);
        }
    }
}
