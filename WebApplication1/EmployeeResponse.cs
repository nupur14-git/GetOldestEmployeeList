namespace Web
{
    public class EmployeeResponse
    {
        public string status { get; set; }
        public List<Employee> data { get; set; }
        public string message { get; set; }
    }
}
