using Azure.Core;
using System.Net;

namespace SP_CRUD_DBFirst.MessageHandler
{
    public class ApiKeyHandler : DelegatingHandler
    {
        private const string ApiKeyToCheck = "A1362BNDKL3327655968974SZNBVJHKLHHFLHLKF";
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellation)
        {
            bool validkey = false;
            IEnumerable<string> requestHeaders;
            var checkApiExists = request.Headers.TryGetValues("ApiKey", out requestHeaders);
            if (checkApiExists)
            {
                if (requestHeaders.FirstOrDefault().Equals(ApiKeyToCheck))
                {
                    validkey = true;
                }
            }
            if (!validkey)
            {
                // Create the response.
                var response = new HttpResponseMessage(HttpStatusCode.Forbidden)
                {
                    Content = new StringContent("Api Key Not Vaild")
                };
                return response.Content;

                //request.CreateResponse(HttpStatusCode.Forbidden, "Api Key Not Vaild");
            }
            return await base.SendAsync(request, cancellation);
        }
    }
}





