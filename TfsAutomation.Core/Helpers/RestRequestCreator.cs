/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/12/2014
 * Time: 1:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TfsAutomation.Core
{
	using System;
	using System.Collections.Generic;
	using System.Net;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Spring.Http.Client;
	using Spring.Http.Converters.Json;
	using Spring.Rest.Client;
	using TfsAutomation.Core.ObjectModel;

	public class RestRequestCreator
	{
		RestTemplate _restTemplate;

		public virtual RestTemplate GetRestTemplate()
		{
			/*
			if (null == _restTemplate)
				_restTemplate = new RestTemplate(TfsData.BaseUrl);
			var requestFactory = new WebClientHttpRequestFactory();
			requestFactory.Credentials = new NetworkCredential(Username, Password, Domain);
			_restTemplate.RequestFactory = requestFactory;
			_restTemplate.MessageConverters.Add(new NJsonHttpMessageConverter());
			*/
			return _restTemplate;
		}

		public virtual void SetRestTemplate(RestTemplate restTemplate)
		{
			_restTemplate = restTemplate;
		}

		public virtual void Init()
		{
			if (null == _restTemplate)
				_restTemplate = new RestTemplate(TfsData.BaseUrl);
			var requestFactory = new WebClientHttpRequestFactory();
			switch (TfsData.AuthenticationType) {
				case AuthenticationTypes.NTLM:
					requestFactory.Credentials = new NetworkCredential(Username, Password, Domain);
					break;
				case AuthenticationTypes.OAuth:
					// requestFactory.Credentials = new NetworkCredential(Username, Password, Domain);
					break;
			}
			// requestFactory.Credentials = new NetworkCredential(Username, Password, Domain);
			_restTemplate.RequestFactory = requestFactory;
			_restTemplate.MessageConverters.Add(new NJsonHttpMessageConverter());
		}

		public virtual string Domain { get { return TfsData.Domain; } }
		public virtual string Username { get { return TfsData.Username; } }
		public virtual string Password { get { return TfsData.Password; } }
	}
}

