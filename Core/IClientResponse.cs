namespace Web
{
    public interface IClientResponse
    {
        Task<ThirdPartyResponse> GetThirdPartyResponse();
    }
}
