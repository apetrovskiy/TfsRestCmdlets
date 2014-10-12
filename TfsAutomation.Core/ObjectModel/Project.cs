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

	public class Project
	{
		/*
		sample
		{
		  "count": 3,
		  "value": [
		    {
		      "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		      "name": "Fabrikam-Fiber-TFVC",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		      "state": "wellFormed"
		    },
		    {
		      "id": "6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
		      "name": "Fabrikam-Fiber-Git",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c",
		      "state": "wellFormed"
		    },
		    {
		      "id": "281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
		      "name": "TestGit",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/281f9a5b-af0d-49b4-a1df-fe6f5e5f84d0",
		      "state": "wellFormed"
		    }
		  ]
		}
		*/
		public virtual Guid id { get; set; }
		public virtual string name { get; set; }
		public virtual string url { get; set; }
		public virtual string state { get; set; }
	}
}

