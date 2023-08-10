using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;



namespace MemesLoader
{
    public class MemesLoaderClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MemesLoaderClient(IHttpClientFactory httpClientFactory)
        {

            _httpClientFactory = httpClientFactory;

        }

        public async Task<MemesLoaderData>? GetSearch(string Search)
        {
            var client = _httpClientFactory.CreateClient("Giphy");
            var response = await client.GetAsync($"/v1/gifs/search?api_key=FwBaBOKYPxe3YXUgESpBoH7rMDwXPo4u&q={Search}&limit=25&offset=0&rating=g&lang=en&bundle=messaging_non_clips");
            string Content = await response.Content.ReadAsStringAsync();
            MemesLoaderData memes = JsonConvert.DeserializeObject<MemesLoaderData>(Content);
            return memes;



        }

        public async Task<MemesLoaderData>? GetTrending()
        {
            var client = _httpClientFactory.CreateClient("Giphy");
            var response = await client.GetAsync("v1/gifs/trending?api_key=FwBaBOKYPxe3YXUgESpBoH7rMDwXPo4u&limit=25&offset=0&rating=g&bundle=messaging_non_clips");
            string Content = await response.Content.ReadAsStringAsync();
            MemesLoaderData memes = JsonConvert.DeserializeObject<MemesLoaderData>(Content);
            return memes;

        }


    }
}