using System.Web.Mvc;
using Shop.Domain.Model;
using Shop.Domain.Repositories;

namespace Shop.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private  readonly IRepository<Customers> _customerRepository;

        public CustomerController(IRepository<Customers> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public ActionResult List()
        {
           // cos
            var list= _customerRepository.GetAll();
            return View();
        }
    }
}