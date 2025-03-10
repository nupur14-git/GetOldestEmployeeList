namespace Web
{
    public interface IGetOldestEmployee
    {
        Task<EmployeeResponse> GetOldestEmployeeList(Task<EmployeeResponse> thirdPartyResponse);
    }
}
