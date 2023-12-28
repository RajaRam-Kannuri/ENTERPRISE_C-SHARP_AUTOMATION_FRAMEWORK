using RestSharp;
using System.Collections.Generic;
using System.Configuration;

/// <summary>
/// Base class for API tests.
/// </summary>
public abstract class BaseAPITest
{
    protected RestClient client;
    protected readonly string environment;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseAPITest"/> class.
    /// </summary>
    /// <param name="endpoint">The endpoint to be appended to the base URL.</param>
    public BaseAPITest()
    {
        environment = ConfigurationManager.AppSettings["Environment"];
        client = RestClient();
    }

    /// <summary>
    /// Retrieves the base URL of the API.
    /// </summary>
    /// <returns>The base URL of the API.</returns>
    protected abstract string BaseUrl();

    protected abstract RestClient RestClient();

    /// <summary>
    /// Sends a GET request to the specified resource.
    /// </summary>
    /// <param name="resource">The resource to send the request to.</param>
    /// <param name="headers">Optional headers to be included in the request.</param>
    /// <param name="queryParameters">Optional query parameters to be included in the request.</param>
    /// <returns>The response received from the server.</returns>
    public RestResponse Get(string resource, Dictionary<string, string> headers = null, Dictionary<string, string> queryParameters = null)
    {
        var request = new RestRequest(resource, Method.Get);
        AddHeaders(request, headers);
        AddQueryParameters(request, queryParameters);
        return client.Execute(request);
    }

    /// <summary>
    /// Sends a POST request to the specified resource.
    /// </summary>
    /// <param name="resource">The resource to send the request to.</param>
    /// <param name="requestBody">The request body to be included in the request.</param>
    /// <param name="headers">Optional headers to be included in the request.</param>
    /// <returns>The response received from the server.</returns>
    public RestResponse Post(string resource, object requestBody, Dictionary<string, string> headers = null)
    {
        var request = new RestRequest(resource, Method.Post);
        request.AddJsonBody(requestBody);
        if (headers != null) AddHeaders(request, headers);
        return client.Execute(request);
    }

    /// <summary>
    /// Sends a PUT request to the specified resource.
    /// </summary>
    /// <param name="resource">The resource to send the request to.</param>
    /// <param name="requestBody">The request body to be included in the request.</param>
    /// <param name="headers">Optional headers to be included in the request.</param>
    /// <returns>The response received from the server.</returns>
    public RestResponse Put(string resource, object requestBody, Dictionary<string, string> headers = null)
    {
        var request = new RestRequest(resource, Method.Put);
        request.AddJsonBody(requestBody);
        AddHeaders(request, headers);
        return client.Execute(request);
    }

    /// <summary>
    /// Sends a DELETE request to the specified resource.
    /// </summary>
    /// <param name="resource">The resource to send the request to.</param>
    /// <param name="headers">Optional headers to be included in the request.</param>
    /// <returns>The response received from the server.</returns>
    public RestResponse Delete(string resource, Dictionary<string, string> headers = null)
    {
        var request = new RestRequest(resource, Method.Delete);
        AddHeaders(request, headers);
        return client.Execute(request);
    }

    // Add additional methods for other HTTP methods as needed (e.g., PATCH, OPTIONS, etc.)

    /// <summary>
    /// Adds the specified headers to the request.
    /// </summary>
    /// <param name="request">The request object.</param>
    /// <param name="headers">The headers to be added to the request.</param>
    private void AddHeaders(RestRequest request, Dictionary<string, string> headers)
    {
        if (headers != null)
        {
            foreach (var header in headers)
            {
                request.AddHeader(header.Key, header.Value);
            }
        }
    }

    /// <summary>
    /// Adds the specified query parameters to the request.
    /// </summary>
    /// <param name="request">The request object.</param>
    /// <param name="queryParameters">The query parameters to be added to the request.</param>
    private void AddQueryParameters(RestRequest request, Dictionary<string, string> queryParameters)
    {
        if (queryParameters != null)
        {
            foreach (var parameter in queryParameters)
            {
                request.AddQueryParameter(parameter.Key, parameter.Value);
            }
        }
    }

}
