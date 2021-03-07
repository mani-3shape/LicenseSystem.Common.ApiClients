using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreeShape.LicenseSystem.Common.ApiClients
{
	public abstract class ApiClientBase
	{
		private readonly IApiClientConfiguration _configuration;

		protected string BaseUrl
		{
			get
			{
				return _configuration.BaseUrl;
			}
		}

		protected ApiClientBase(IApiClientConfiguration configuration)
		{
			_configuration = configuration;
		}

		protected Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken)
		{
			return Task.FromResult(new HttpRequestMessage());
		}
	}
}
