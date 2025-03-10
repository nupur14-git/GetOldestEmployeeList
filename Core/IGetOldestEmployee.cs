namespace Web
{
    public interface IGetOldestEmployee
    {
        Task<IEnumerable<Employee>> GetOldestEmployeeList(Task<ThirdPartyResponse> thirdPartyResponse);
    }
}
