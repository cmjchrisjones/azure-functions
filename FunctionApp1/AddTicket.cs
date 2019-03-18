using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using FunctionApp1.Models;
using System.Net;

namespace FunctionApp1
{
    public static class AddTicket
    {
        [FunctionName("AddTicket")]
        public static async Task<HttpResponseMessage> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequestMessage req,
            ILogger log)
        {
            log.LogInformation("Adding a ticket");

            HttpResponseMessage response = null;
            try
            {
                var user = await req.Content.ReadAsAsync<User>();
                if (user != null)
                {
                    log.LogInformation("Saving to database");
                    using (var db = new Context())
                    {
                        db.Users.Add(user);
                        await db.SaveChangesAsync();
                    }
                    response = req.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    var errorMessage = "Failed to parse user";
                    log.LogError(errorMessage);
                    response = req.CreateErrorResponse(HttpStatusCode.BadRequest, errorMessage);
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message, ex);
                response = req.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

            return response;
        }
    }
}