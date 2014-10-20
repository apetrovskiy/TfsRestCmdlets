/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/17/2014
 * Time: 3:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TfsAutomation.Core.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Spring.Http.Client;
    using Spring.Http.Converters.Json;
    using Spring.Rest.Client;
    using TfsAutomation.Core.ObjectModel;
    
    /// <summary>
    /// Description of BranchesLoader.
    /// </summary>
    public class BranchesLoader
    {
        // RestTemplate _restTemplate;
		RestRequestCreator _restRequest;

		// public BranchesLoader(RestTemplate restTemplate, string baseUrl, string domain, string username, string password)
		public BranchesLoader(RestRequestCreator restRequestCreator)
		{
			// _restTemplate = restRequestCreator.GetRestTemplate();
			_restRequest = restRequestCreator;
		}
        
        public List<string> Load()
        {
            // createClient(@"http://spbtfs2013.nwx.local:8080/tfs/defaultcollection/_apis/tfvc/branches", @"nwx", @"at_nwx_user", @"Lock12Lock");
			// createClient (_branchesUrl, _domain, _username, _password);
            var response = loadAllBranchesData();
            
            int count = (int)response["count"];
            var topBranch0 = (JToken)response["value"][0];
            var topBranch = JsonConvert.DeserializeObject<Branch>(topBranch0.ToString());
            var branches = new List<Branch> { topBranch };
            recursiveAddToList(branches, topBranch);
            
//            foreach (var element in branches) {
//                Console.WriteLine(element.Path);
//            }
            
            return branches.Select(branch => branch.Path).ToList();
        }
        
        void recursiveAddToList(List<Branch> list, Branch item)
        {
            if (0 == item.Children.Count) return;
            list.AddRange(item.Children);
            foreach (var child in item.Children) {
                recursiveAddToList(list, child);
            }
        }
        
		/*
        void createClient(string baseUrl, string domain, string username, string password)
        {
            var requestFactory = new WebClientHttpRequestFactory();
            requestFactory.Credentials = new NetworkCredential(username, password, domain);
            // _restTemplate = new RestTemplate(baseUrl);
            // _restTemplate.RequestFactory = requestFactory;
            // _restTemplate.MessageConverters.Add(new NJsonHttpMessageConverter());
			_restRequest.GetRestTemplate ().RequestFactory = requestFactory;
			// _restRequest.GetRestTemplate ().MessageConverters.Add (new NJsonHttpMessageConverter ());
        }
		*/
        
        JObject loadAllBranchesData()
        {
            // return _restTemplate.GetForObject<JObject>(@"http://spbtfs2013.nwx.local:8080/tfs/defaultcollection/_apis/tfvc/branches?includeChildren=true");//, prms);
			// return _restTemplate.GetForObject<JObject>(TfsData.BaseUrlBranches);
			// return _restRequest.GetRestTemplate ().GetForObject<JObject> (TfsData.BaseUrlBranches);
			return _restRequest.GetRestTemplate ().GetForObject<JObject> (_restRequest.GetRestTemplate().BaseAddress + TfsData.BaseUrlBranches);
        }
        
        void selectBranchesForProject(JObject response, string productName)
        {
            // 
        }
    }
}
