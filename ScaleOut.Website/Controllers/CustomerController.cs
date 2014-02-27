using System.Web.Mvc;
using ScaleOut.CustomerQuery.Contracts;

namespace ScaleOut.Website.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IQueryCustomers _customerQueries;

        public CustomerController(IQueryCustomers customerQueries)
        {
            _customerQueries = customerQueries;
        }

        public ActionResult Index()
        {
            var model = _customerQueries.GetAllCustomers();
            return View(model);
        }
    }
}
