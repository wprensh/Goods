using Goods.Api.Aplication.Contract.Services;
using Goods.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.Aplication.Services
{
    public class CovitServices : ICovitServices
    {

        public async Task<Root> EmployeeSearch()
        {
            Root employeeSearchResponse = null;
            try

            {
                string searchUserEndPoint = "https://api.covid19api.com/summary";
                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, cetChain, policyErrors) =>
                    {
                        return true;
                    };
                using var client = new HttpClient(handler);
                //string searchUserJson = SearchUserJson(username, application);
                client.BaseAddress = new Uri(searchUserEndPoint);
                client.DefaultRequestHeaders.Add("X-Access-Token", "5cf9dfd5-3449-485e-b5ae-70a60e997864");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, Uri.EscapeUriString(client.BaseAddress.ToString()));
                //request.Content = new StringContent("", Encoding.UTF8, "application/json");
                HttpResponseMessage tokenResponse = await client.GetAsync(Uri.EscapeUriString(client.BaseAddress.ToString()));

                if (tokenResponse.IsSuccessStatusCode)

                {
                    employeeSearchResponse = tokenResponse.Content.ReadAsAsync<Root>(new[] { new JsonMediaTypeFormatter() }).Result;

                }
            }
            catch (HttpRequestException ex)
            {
            }
            return employeeSearchResponse;
        }

        public HttpClient Method_Headers(string endpointURL)
        {
            HttpClientHandler handler = new HttpClientHandler() { UseDefaultCredentials = false };
            HttpClient client = new HttpClient(handler);
            try
            {
                client.BaseAddress = new Uri(endpointURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-Access-Token", "5cf9dfd5-3449-485e-b5ae-70a60e997864");
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);  
            }
            catch (Exception ex)

            {
                throw ex;
            }
            return client;
        }


    }
}
