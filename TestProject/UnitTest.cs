using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using Xunit;

namespace TestProject
{
    //public class ApiClientTests
    //{
    //    private readonly Mock<HttpMessageHandler> _httpMessageHandlerMock;
    //    private readonly HttpClient _httpClient;
    //    private readonly ApiClient _apiClient;

    //    public ApiClientTests()
    //    {
    //        _httpMessageHandlerMock = new Mock<HttpMessageHandler>();
    //        _httpClient = new HttpClient(_httpMessageHandlerMock.Object) { BaseAddress = new Uri("https://dummy.restapiexample.com/") };
    //        _apiClient = new ApiClient(_httpClient);
    //    }

    //    [Fact]
    //    public async Task GetEmployees_ReturnsData()
    //    {
    //        // Arrange
    //        var mockResponse = new { status = "success", data = new[] { new { id = 1, employee_name = "John Doe" } } };
    //        var responseMessage = new HttpResponseMessage
    //        {
    //            StatusCode = HttpStatusCode.OK,
    //            Content = new StringContent(JsonConvert.SerializeObject(mockResponse))
    //        };

    //        _httpMessageHandlerMock
    //            .Protected()
    //            .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
    //            .ReturnsAsync(responseMessage);

    //        // Act
    //        var result = await _apiClient.GetEmployeesAsync();

    //        // Assert
    //        Assert.NotNull(result);
    //        Assert.Single(result);
    //        Assert.Equal("John Doe", result[0].EmployeeName);
    //    }
    //}

    //public class ServiceLayerTests
    //{
    //    private readonly Mock<IClientResponse> _apiClientMock;
    //    private readonly EmployeeService _employeeService;

    //    public ServiceLayerTests()
    //    {
    //        _apiClientMock = new Mock<IApiClient>();
    //        _employeeService = new EmployeeService(_apiClientMock.Object);
    //    }

    //    [Fact]
    //    public async Task GetEmployees_DelegatesToApiClient()
    //    {
    //        // Arrange
    //        var mockEmployees = new[] { new Employee { Id = 1, EmployeeName = "John Doe" } };
    //        _apiClientMock.Setup(x => x.GetEmployeesAsync()).ReturnsAsync(mockEmployees);

    //        // Act
    //        var result = await _employeeService.GetEmployeesAsync();

    //        // Assert
    //        Assert.NotNull(result);
    //        Assert.Single(result);
    //        Assert.Equal("John Doe", result[0].EmployeeName);
    //    }
    //}
}
