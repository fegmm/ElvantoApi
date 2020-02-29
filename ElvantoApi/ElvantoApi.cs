using ElvantoApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ElvantoApi
{
    public class Client
    {
        private readonly string apiToken;
        private readonly string username;
        private readonly string password;
        private readonly HttpClient client;

        public Client(string apiToken)
        {
            this.apiToken = apiToken;
            client = new HttpClient();
            client.BaseAddress = new Uri("https://api.elvanto.com/");
            var byteArray = Encoding.ASCII.GetBytes(apiToken + ":");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new CamelCaseNamingStrategy(true, false)
                },
                NullValueHandling = NullValueHandling.Ignore,
                Error = (sender, e) => e.ErrorContext.Handled = true
            };
        }

        public Client(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        // Siehe https://www.elvanto.com/api/services/getInfo/
        #region Async Get Calls

        public async Task<PeopleGetAllResponse> PeopleGetAllAsync(GetAllPeopleRequest request)
            => await CallAsync<PeopleGetAllResponse>("v1/people/getAll.json", request);

        public async Task<GroupsGetAllResponse> GroupsGetAllAsync(GetAllRequest request)
            => await CallAsync<GroupsGetAllResponse>("v1/groups/getAll.json", request);

        public async Task<ServicesGetAllResponse> ServicesGetAllAsync()
            => await CallAsync<ServicesGetAllResponse>("v1/services/getAll.json", new { all = "yes", fields = new[] { "volunteers" } });

        public async Task<ServicesGetAllResponse> ServicesGetAllNoFieldsAsync()
          => await CallAsync<ServicesGetAllResponse>("v1/services/getAll.json", new { all = "yes" });

        public async Task<ServiceGetDetailsResponse> ServiceGetDetailsAsync(string serviceId)
          => await CallAsync<ServiceGetDetailsResponse>("v1/services/getInfo.json", new { id = serviceId, fields = new[] { "volunteers", "plans" } });

        #endregion

        #region Async Post Calls
        public async Task<GroupsChangePersonResponse> GroupsAddPersonAsync(string groupId, string personId, string position = "")
            => await CallAsync<GroupsChangePersonResponse>("https://api.elvanto.com/v1/groups/addPerson.json", new
            {
                id = groupId,
                person_id = personId,
                position
            }
            );

        public async Task<GroupsChangePersonResponse> GroupsRemovePersonAsync(string groupId, string personId)
            => await CallAsync<GroupsChangePersonResponse>("https://api.elvanto.com/v1/groups/removePerson.json", new
            {
                id = groupId,
                person_id = personId
            }
            );
        #endregion

        public async Task<T> CallAsync<T>(string url, object data)
        {
            var response = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"));
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
