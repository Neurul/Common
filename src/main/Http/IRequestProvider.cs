﻿//MIT License

//Copyright(c) .NET Foundation and Contributors

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
//
// https://github.com/dotnet-architecture/eShopOnContainers
//
// Modifications copyright(C) 2020 ei8/Elmer Bool

using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace neurUL.Common.Http
{
    public interface IRequestProvider
    {
        Task<TResult> GetAsync<TResult>(string uri, string bearerToken = "", CancellationToken token = default(CancellationToken));

        Task<TResult> PostAsync<TResult>(string uri, TResult data, string token = "", string header = "");

        Task<TResult> PostAsync<TResult>(string uri, string data, string clientId, string clientSecret);

        Task<TResult> PostAsync<TResult>(string uri, object data, string bearerToken = "", CancellationToken token = default(CancellationToken), params KeyValuePair<string, string>[] headers);

        Task<TResult> PutAsync<TResult>(string uri, object data, string bearerToken = "", CancellationToken token = default(CancellationToken), params KeyValuePair<string, string>[] headers);

        Task<TResult> PatchAsync<TResult>(string uri, object data, string bearerToken = "", CancellationToken token = default(CancellationToken), params KeyValuePair<string, string>[] headers);

        Task<TResult> DeleteAsync<TResult>(string uri, object data, string bearerToken = "", CancellationToken token = default(CancellationToken), params KeyValuePair<string, string>[] headers);

        HttpClient HttpClient { get; }

        void SetHttpClientHandler(HttpClientHandler clientHandler);
    }
}