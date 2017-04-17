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

    public class TestResult
	{
		/*
		sample
		{
		  "value": [
		    {
		      "id": 100000,
		      "configuration": {
		        "id": "2",
		        "name": "Windows 8"
		      },
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "startedDate": "2014-05-04T13:00:38.3Z",
		      "completedDate": "2014-05-04T13:00:38.3Z",
		      "outcome": "Passed",
		      "owner": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "revision": 5,
		      "runBy": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "state": "Completed",
		      "testCase": {
		        "id": "39",
		        "name": "Shopping cart"
		      },
		      "testRun": {
		        "id": "4",
		        "name": "sprint1 (Manual)",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Runs/4"
		      },
		      "lastUpdatedDate": "2014-05-04T13:01:02.943Z",
		      "lastUpdatedBy": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "priority": 2,
		      "computerName": "",
		      "createdDate": "2014-05-04T13:00:37.22Z",
		      "associatedBugs": [],
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Runs/4/Results/100000"
		    },
		    {
		      "id": 100001,
		      "configuration": {
		        "id": "2",
		        "name": "Windows 8"
		      },
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "startedDate": "2014-05-04T13:00:38.3Z",
		      "completedDate": "2014-05-04T13:00:38.3Z",
		      "outcome": "Failed",
		      "owner": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "revision": 3,
		      "runBy": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "state": "Completed",
		      "testCase": {
		        "id": "40",
		        "name": "Price check"
		      },
		      "testRun": {
		        "id": "4",
		        "name": "sprint1 (Manual)",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Runs/4"
		      },
		      "lastUpdatedDate": "2014-05-04T13:01:02.943Z",
		      "lastUpdatedBy": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "priority": 2,
		      "computerName": "",
		      "createdDate": "2014-05-04T13:00:37.22Z",
		      "associatedBugs": [],
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Runs/4/Results/100001"
		    }
		  ],
		  "count": 2
		}
		*/

		public virtual int Id { get; set; }
		public virtual object Configuration { get; set; }
		public virtual Project Project { get; set; }
		public virtual DateTime StartedDate { get; set; }
		public virtual DateTime CompletedDate { get; set; }
		public virtual string Outcome { get; set; }
		// public virtual object owner { get; set; }
		public virtual Owner Owner { get; set; }
		public virtual int Revision { get; set; }
		public virtual object RunBy { get; set; }
		public virtual string State { get; set; }
		public virtual TestCase TestCase { get; set; }
		public virtual object TestRun { get; set; }
		public virtual DateTime LastUpdatedDate { get; set; }
		public virtual DateTime LastUpdatedBy { get; set; }
		public virtual int Priority { get; set; }
		public virtual string ComputerName { get; set; }
		public virtual DateTime CreatedDate { get; set; }
		public virtual object AssociatedBugs { get; set; }
		public virtual string Url { get; set; }
	}
}

