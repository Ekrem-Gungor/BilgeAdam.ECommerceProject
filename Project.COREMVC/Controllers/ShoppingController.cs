using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.LibraryModel;
using Project.BLL.Managers.Abstracts;
using Project.COREMVC.Models.PageVms;
using Project.ENTITIES.Models;
using X.PagedList;

namespace Project.COREMVC.Controllers
{
    public class ShoppingController : Controller
    {
        readonly IProductManager _productManager;
        readonly ICategoryManager _categoryManager;
        readonly IOrderManager _orderManager;
        readonly IOrderDetailManager _orderDetailManager;
        readonly UserManager<AppUser> _userManager;

        public ShoppingController(IProductManager productManager, ICategoryManager categoryManager, IOrderManager orderManager, IOrderDetailManager orderDetailManager, UserManager<AppUser> userManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            _orderManager = orderManager;
            _orderDetailManager = orderDetailManager;
            _userManager = userManager;
        }

        public IActionResult Index(int? page, int? categoryID)
        {
            ShoppingPageVM spVm = new()
            {
                Products = categoryID == null ? _productManager.GetActives().ToPagedList(page ?? 1, 5) : _productManager.Where(x => x.CategoryID == categoryID).ToPagedList(page ?? 1, 5),
                Categories = _categoryManager.GetActives()
            };

            if (categoryID != null) TempData["catID"] = categoryID;
            return View(spVm);
        }
    }
}
