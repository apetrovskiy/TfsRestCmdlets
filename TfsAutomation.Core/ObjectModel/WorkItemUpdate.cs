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

    public class WorkItemUpdate
	{
		/*
		sample
		{
		  "id": 4,
		  "rev": 3,
		  "revisedBy": {
		    "id": "d6245f20-2af8-44f4-9451-8107cb2767db",
		    "name": "Normal Paulk",
		    "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/d6245f20-2af8-44f4-9451-8107cb2767db"
		  },
		  "revisedDate": "2014-10-01T11:16:22.27Z",
		  "relations": {
		    "added": [
		      {
		        "rel": "System.LinkTypes.Dependency-Forward",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/workItems/183",
		        "attributes": {
		          "isLocked": false,
		          "comment": "Adding traceability to dependencies"
		        }
		      }
		    ]
		  },
		  "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/workItems/182/updates/4"
		}
		*/
		public virtual int Id { get; set; }
		public virtual int Rev { get; set; }
		public virtual object RevisedBy { get; set; }
		public virtual DateTime RevisedDate { get; set; }
		public virtual object Relations { get; set; }
		public virtual string Url { get; set; }
	}
}

