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

	public class WorkItem
	{
		/*
		sample
		{
		  "count": 3,
		  "value": [
		    {
		      "id": 220,
		      "rev": 1,
		      "fields": {
		        "System.AreaPath": "Fabrikam-Fiber-Git",
		        "System.TeamProject": "Fabrikam-Fiber-Git",
		        "System.IterationPath": "Fabrikam-Fiber-Git",
		        "System.WorkItemType": "Product Backlog Item",
		        "System.State": "New",
		        "System.Reason": "New backlog item",
		        "System.CreatedDate": "2014-10-07T22:19:58.85Z",
		        "System.CreatedBy": "Chuck Reinhart",
		        "System.ChangedDate": "2014-10-07T22:19:58.85Z",
		        "System.ChangedBy": "Chuck Reinhart",
		        "System.Title": "Customer can sign in using their Microsoft Account",
		        "Microsoft.VSTS.Scheduling.Effort": 8,
		        "WEF_6CB513B6E70E43499D9FC94E5BBFB784_Kanban.Column": "New",
		        "System.Description": "Our authorization logic needs to allow for users with Microsoft accounts (formerly Live Ids) - http://msdn.microsoft.com/en-us/library/live/hh826547.aspx"
		      },
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/workItems/220"
		    },
		    {
		      "id": 222,
		      "rev": 7,
		      "fields": {
		        "System.AreaPath": "Fabrikam-Fiber-Git\\Website",
		        "System.TeamProject": "Fabrikam-Fiber-Git",
		        "System.IterationPath": "Fabrikam-Fiber-Git",
		        "System.WorkItemType": "Task",
		        "System.State": "To Do",
		        "System.Reason": "New task",
		        "System.AssignedTo": "Johnnie McLeod",
		        "System.CreatedDate": "2014-10-07T22:20:01.8Z",
		        "System.CreatedBy": "Chuck Reinhart",
		        "System.ChangedDate": "2014-10-07T22:20:07.7Z",
		        "System.ChangedBy": "Chuck Reinhart",
		        "System.Title": "JavaScript implementation for Microsoft Account",
		        "Microsoft.VSTS.Scheduling.RemainingWork": 4,
		        "System.Description": "Follow the code samples from MSDN",
		        "System.Tags": "Tag1; Tag2"
		      },
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/workItems/222"
		    },
		    {
		      "id": 223,
		      "rev": 1,
		      "fields": {
		        "System.AreaPath": "Fabrikam-Fiber-Git",
		        "System.TeamProject": "Fabrikam-Fiber-Git",
		        "System.IterationPath": "Fabrikam-Fiber-Git",
		        "System.WorkItemType": "Task",
		        "System.State": "To Do",
		        "System.Reason": "New task",
		        "System.CreatedDate": "2014-10-07T22:20:02.34Z",
		        "System.CreatedBy": "Chuck Reinhart",
		        "System.ChangedDate": "2014-10-07T22:20:02.34Z",
		        "System.ChangedBy": "Chuck Reinhart",
		        "System.Title": "Unit Testing for MSA login",
		        "Microsoft.VSTS.Scheduling.RemainingWork": 3,
		        "System.Description": "We need to ensure we have coverage to prevent regressions"
		      },
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/workItems/223"
		    }
		  ]
		}
		*/
		public virtual int id { get; set; }
		public virtual int rev { get; set; }
		public virtual object fields { get; set; }
		public virtual string url { get; set; }
	}
}

