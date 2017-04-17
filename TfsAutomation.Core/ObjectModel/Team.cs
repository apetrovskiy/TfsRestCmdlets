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

    public class Team
	{
		/*
		sample
		{
		  "value": [
		    {
		      "id": "564e8204-a90b-4432-883b-d4363c6125ca",
		      "name": "Quality assurance",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1/teams/564e8204-a90b-4432-883b-d4363c6125ca",
		      "description": "Testing staff",
		      "identityUrl": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/564e8204-a90b-4432-883b-d4363c6125ca"
		    },
		    {
		      "id": "66df9be7-3586-467b-9c5f-425b29afedfd",
		      "name": "Fabrikam-Fiber-TFVC Team",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1/teams/66df9be7-3586-467b-9c5f-425b29afedfd",
		      "description": "The default project team.",
		      "identityUrl": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/66df9be7-3586-467b-9c5f-425b29afedfd"
		    }
		  ],
		  "count": 2
		}
		*/
		public virtual Guid Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Url { get; set; }
		public virtual string Description { get; set; }
		public virtual string IdentityUrl { get; set; }
	}
}

