using System.Linq;
using System.Web.Mvc;
using Shop.Domain.Model;
using Shop.Domain.Repositories;
using Shop.WebUI.Models;
using Shop.WebUI.ViewModels;

namespace Shop.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private readonly IRepository<Customers> _customerRepository;
        public int PageSize = 4;

        public CustomerController(IRepository<Customers> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public ActionResult List(int page = 1)
        {
            var customerViewModel = new CustomersListViewModel
            {
                CustomersList = _customerRepository.GetAll().OrderBy(p => p.CustomerID).Skip((page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = _customerRepository.GetAll().Count()
                }
            };
          
            return View(customerViewModel);
        }
    }
}