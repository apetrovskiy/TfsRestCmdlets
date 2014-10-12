/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/13/2014
 * Time: 0:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TfsAutomation.Core
{
	using System;

	public class TeamMember
	{
		/*
		sample
		{
		  "value": [
		    {
		      "id": "3b5f0c34-4aec-4bf4-8708-1d36f0dbc468",
		      "displayName": "Christie Church",
		      "uniqueName": "fabrikamfiber1@hotmail.com",
		      "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/3b5f0c34-4aec-4bf4-8708-1d36f0dbc468",
		      "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=3b5f0c34-4aec-4bf4-8708-1d36f0dbc468"
		    },
		    {
		      "id": "8c8c7d32-6b1b-47f4-b2e9-30b477b5ab3d",
		      "displayName": "Chuck Reinhart",
		      "uniqueName": "fabrikamfiber3@hotmail.com",
		      "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/8c8c7d32-6b1b-47f4-b2e9-30b477b5ab3d",
		      "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=8c8c7d32-6b1b-47f4-b2e9-30b477b5ab3d"
		    },
		    {
		      "id": "19d9411e-9a34-45bb-b985-d24d9d87c0c9",
		      "displayName": "Johnnie McLeod",
		      "uniqueName": "fabrikamfiber2@hotmail.com",
		      "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/19d9411e-9a34-45bb-b985-d24d9d87c0c9",
		      "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=19d9411e-9a34-45bb-b985-d24d9d87c0c9"
		    }
		  ],
		  "count": 3
		}
		*/
		public virtual Guid id { get; set; }
		public virtual string displayName { get; set; }
		public virtual string uniqueName { get; set; }
		public virtual string url { get; set; }
		public virtual string imageUrl { get; set; }
	}
}

