using AdapterDesignPatternExam.Adaptors;
using Microsoft.AspNetCore.Mvc;

namespace AdapterDesignPatternExam.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService _employeeService;
        private readonly IAnalyticAdapter _analyticAdapter;

        public HomeController(
            ILogger<HomeController> logger,
            IEmployeeService employeeService,
            IAnalyticAdapter analyticAdapter)
        {
            _logger = logger;
            _employeeService = employeeService;
            _analyticAdapter = analyticAdapter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var employees = _employeeService.GetEmployees();
            _analyticAdapter.ProccessEmployee(employees);

            return Ok(employees);
        }
    }
}