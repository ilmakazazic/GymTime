using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTeretane.Model;

namespace eTeretane.WinUI
{
    class APIServices
    {
        public static string Username { get; set; }
        public static string Password { get; set; }


        private string _route;
        public APIServices(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.API}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.API}/{_route}/{id}";


            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.API}/{_route}";


            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();

        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.API}/{_route}/{id}";


            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

        }

        public async Task<T> GetByDateGym<T>(object date, object id, object id2)
        {
            var url = $"{Properties.Settings.Default.API}/{_route}/GetByDateGym/{date}/{id}/{id2}";


            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

    }
}
