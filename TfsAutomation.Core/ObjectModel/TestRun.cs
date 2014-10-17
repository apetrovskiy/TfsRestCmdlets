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
    using TfsAutomation.Core.ObjectModel;

	public class TestRun
	{
		/*
		sample
		{
		  "value": [
		    {
		      "id": 1,
		      "name": "NewTestRun2",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Runs/1",
		      "isAutomated": false,
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1\\Sprint 1",
		      "owner": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber"
		      },
		      "startedDate": "2014-05-04T12:50:33.17Z",
		      "completedDate": "2014-05-04T12:50:31.953Z",
		      "state": "Completed",
		      "plan": {
		        "id": "1"
		      },
		      "revision": 4
		    },
		    {
		      "id": 2,
		      "name": "sprint1 (Manual)",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Runs/2",
		      "isAutomated": false,
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1\\Sprint 1",
		      "owner": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber"
		      },
		      "startedDate": "2014-05-04T12:58:36.907Z",
		      "completedDate": "2014-05-04T12:58:36.47Z",
		      "state": "Completed",
		      "plan": {
		        "id": "1"
		      },
		      "revision": 3
		    },
		    {
		      "id": 4,
		      "name": "sprint1 (Manual)",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Runs/4",
		      "isAutomated": false,
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1\\Sprint 1",
		      "owner": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber"
		      },
		      "startedDate": "2014-05-04T13:00:37.447Z",
		      "completedDate": "2014-05-04T13:01:02.943Z",
		      "state": "NeedsInvestigation",
		      "plan": {
		        "id": "1"
		      },
		      "revision": 3
		    },
		    {
		      "id": 6,
		      "name": "sprint1 (Manual)",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Runs/6",
		      "isAutomated": false,
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1\\Sprint 1",
		      "owner": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber"
		      },
		      "startedDate": "2014-05-04T14:00:56.807Z",
		      "completedDate": "2014-05-04T14:00:57.15Z",
		      "state": "Completed",
		      "plan": {
		        "id": "1"
		      },
		      "revision": 3
		    }
		  ],
		  "count": 4
		}
		*/
		public virtual int id { get; set; }
		public virtual string name { get; set; }
		public virtual string url { get; set; }
		public virtual bool isAutomated { get; set; }
		public virtual string iteration { get; set; }
		// public virtual object owner { get; set; }
		public virtual Owner owner { get; set; }
		public virtual DateTime startedDate { get; set; }
		public virtual DateTime completedDate { get; set; }
		public virtual string state { get; set; }
		public virtual TestPlan plan { get; set; }
		public virtual int revision { get; set; }
	}
}

