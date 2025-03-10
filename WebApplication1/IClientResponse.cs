namespace Web
{
    public interface IClientResponse
    {
        Task<EmployeeResponse> GetThirdPartyResponse();
    }
}
