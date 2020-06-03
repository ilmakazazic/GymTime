using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eTeretane.Model;
using Flurl.Http;

namespace eTeretane.Mobile
{
    class APIServices
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

#if DEBUG
        private string _apiurl = "http://localhost:52089/api";
#endif
#if RELEASE
        private string _apiurl = "http://imesajta.com/api";
#endif


        private string _route;
        public APIServices(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiurl}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            var result = await url.GetJsonAsync<T>();
            return result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiurl}/{_route}/{id}";


            var result = await url.GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiurl}/{_route}";


            return await url.PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_apiurl}/{_route}/{id}";


            return await url.PutJsonAsync(request).ReceiveJson<T>();

        }

        public async Task<T> GetByDateGym<T>(object date, object id, object id2)
        {
            var url = $"{_apiurl}/{_route}/GetByDateGym/{date}/{id}/{id2}";


            var result = await url.GetJsonAsync<T>();
            return result;
        }
    }


}
