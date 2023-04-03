namespace AdapterDesignPatternExam.Adaptors
{
    public class AnalyticAdapter : IAnalyticAdapter
    {
        private readonly IAnalyticService _service;

        public AnalyticAdapter(IAnalyticService service)
        {
            _service = service;
        }

        public void ProccessEmployee(List<Employee> employees)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(employees);            
            _service.GenerateReport(json);
        }
    }
}
