namespace Web
{
    public class GetOldestEmployee : IGetOldestEmployee
    {
        public async Task<EmployeeResponse> GetOldestEmployeeList(Task<EmployeeResponse> employeeResponse)
        {
            var response =  new EmployeeResponse();
            var oldestEmployees = new List<Employee>();
            try
            {
                int empAge = 0;
                if (employeeResponse != null && employeeResponse.Result != null && employeeResponse.Result.data != null)
                {
                    foreach (var employee in employeeResponse.Result.data)
                    {
                        if (employee.employee_age > empAge)
                        {
                            empAge = employee.employee_age;
                            oldestEmployees.Clear(); //clear the list
                            oldestEmployees.Add(employee);
                        }
                        else if (employee.employee_age == empAge)
                        {
                            oldestEmployees.Add(employee);
                        }
                    }
                }
                response.status = "success";
                response.message = "Oldest employee list fetched successfully.";
                response.data = oldestEmployees;
            }
            catch (Exception ex)
            {
                response.status = "error";
                response.message = "Error while getting oldest employee list.";
                response.data = null;
            }
            return response;
        }
    }
}
