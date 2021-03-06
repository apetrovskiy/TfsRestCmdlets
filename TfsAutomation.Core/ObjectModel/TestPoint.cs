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
    public class TestPoint
	{
		/*
		sample
		{
		  "value": [
		    {
		      "id": 1,
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/1/Points/1",
		      "assignedTo": {
		        "id": "d291b0c4-a05c-4ea6-8df1-4b41d5f39eff",
		        "displayName": "Jamal Hartnett"
		      },
		      "configuration": {
		        "id": "2",
		        "name": "Windows 8"
		      },
		      "lastTestRun": {
		        "id": "28"
		      },
		      "lastResult": {
		        "id": "100000"
		      },
		      "outcome": "Passed",
		      "state": "Completed",
		      "testCase": {
		        "id": "39",
		        "url": null,
		        "webUrl": null
		      },
		      "workItemProperties": [
		        {
		          "workItem": {
		            "key": "Microsoft.VSTS.TCM.AutomationStatus",
		            "value": "Not Automated"
		          }
		        }
		      ]
		    },
		    {
		      "id": 2,
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/1/Points/2",
		      "assignedTo": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber"
		      },
		      "configuration": {
		        "id": "2",
		        "name": "Windows 8"
		      },
		      "lastTestRun": {
		        "id": "4"
		      },
		      "lastResult": {
		        "id": "100001"
		      },
		      "outcome": "Failed",
		      "state": "NotReady",
		      "testCase": {
		        "id": "40",
		        "url": null,
		        "webUrl": null
		      },
		      "workItemProperties": [
		        {
		          "workItem": {
		            "key": "Microsoft.VSTS.TCM.AutomationStatus",
		            "value": "Not Automated"
		          }
		        }
		      ]
		    }
		  ],
		  "count": 2
		}
		*/
		public virtual int Id { get; set; }
		public virtual string Url { get; set; }
		public virtual object AssignedTo { get; set; }
		public virtual object Configuration { get; set; }
		public virtual object LastTestRun { get; set; }
		public virtual object LastResult { get; set; }
		public virtual string Outcome { get; set; }
		public virtual string State { get; set; }
		public virtual TestCase TestCase { get; set; }
		public virtual object WorkItemProperties { get; set; }
	}
}

