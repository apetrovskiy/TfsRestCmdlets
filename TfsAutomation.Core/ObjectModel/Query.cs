/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/13/2014
 * Time: 0:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TfsAutomation.Core.ObjectModel
{
    using System;

    public class Query
	{
		/*
		sample
		{
		  "count": 2,
		  "value": [
		    {
		      "id": "eb5c1e25-9b3e-4416-a833-e500122882c7",
		      "name": "Shared Queries",
		      "path": "Shared Queries",
		      "isFolder": true,
		      "hasChildren": true,
		      "children": [
		        {
		          "id": "7662ea76-d42d-43db-abb0-19e6f1d0be9b",
		          "name": "Feedback",
		          "path": "Shared Queries/Feedback",
		          "isPublic": true,
		          "url": "https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/7662ea76-d42d-43db-abb0-19e6f1d0be9b"
		        },
		        {
		          "id": "139a3503-6ac6-4fa0-9a91-f76f180e7b65",
		          "name": "Current Sprint",
		          "path": "Shared Queries/Current Sprint",
		          "isFolder": true,
		          "hasChildren": true,
		          "isPublic": true,
		          "url": "https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/139a3503-6ac6-4fa0-9a91-f76f180e7b65"
		        }
		      ],
		      "isPublic": true,
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/eb5c1e25-9b3e-4416-a833-e500122882c7"
		    },
		    {
		      "id": "18898192-0338-4278-86b3-ec2266a6f517",
		      "name": "My Queries",
		      "path": "My Queries",
		      "isFolder": true,
		      "hasChildren": false,
		      "isPublic": false,
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/18898192-0338-4278-86b3-ec2266a6f517"
		    }
		  ]
		}
		*/
		public virtual Guid Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Path { get; set; }
		public virtual bool IsFolder { get; set; }
		public virtual bool HasChildren { get; set; }
		public virtual Query[] Children { get; set; }
		public virtual bool IsPublic { get; set; }
		public virtual string Url { get; set; }
	}
}

