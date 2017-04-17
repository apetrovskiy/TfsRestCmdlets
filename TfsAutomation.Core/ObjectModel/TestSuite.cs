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

    public class TestSuite
	{
		/*
		sample
		{
		  "value": [
		    {
		      "id": 1,
		      "name": "sprint1",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/1",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "plan": {
		        "id": "1",
		        "name": "sprint1",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1"
		      },
		      "revision": 12,
		      "testCaseCount": 2,
		      "suiteType": "StaticTestSuite",
		      "testCasesUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/1/testcases",
		      "inheritDefaultConfigurations": false,
		      "defaultConfigurations": [
		        {
		          "id": "2",
		          "name": "Windows 8"
		        }
		      ],
		      "state": "InProgress",
		      "lastUpdatedBy": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "lastUpdatedDate": "2014-05-04T11:54:29.827Z"
		    },
		    {
		      "id": 8,
		      "name": "NewTestSuite",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/8",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "plan": {
		        "id": "1",
		        "name": "sprint1",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1"
		      },
		      "parent": {
		        "id": "1",
		        "name": "sprint1",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/1"
		      },
		      "revision": 1,
		      "testCaseCount": 0,
		      "suiteType": "StaticTestSuite",
		      "testCasesUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/8/testcases",
		      "inheritDefaultConfigurations": true,
		      "state": "InProgress",
		      "lastUpdatedBy": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "lastUpdatedDate": "2014-05-04T11:33:25.857Z"
		    },
		    {
		      "id": 9,
		      "name": "AllTestCases",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/9",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "plan": {
		        "id": "1",
		        "name": "sprint1",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1"
		      },
		      "parent": {
		        "id": "1",
		        "name": "sprint1",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/1"
		      },
		      "queryString": "SELECT [System.Id],[System.WorkItemType],[System.Title],[Microsoft.VSTS.Common.Priority],[System.AssignedTo],[System.AreaPath] FROM WorkItems WHERE [System.WorkItemType] IN GROUP 'Microsoft.TestCaseCategory'",
		      "revision": 1,
		      "testCaseCount": 2,
		      "suiteType": "DynamicTestSuite",
		      "testCasesUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/9/testcases",
		      "inheritDefaultConfigurations": true,
		      "lastPopulatedDate": "2014-05-04T11:33:28.497Z",
		      "state": "InProgress",
		      "lastUpdatedBy": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "lastUpdatedDate": "2014-05-04T11:33:28.497Z"
		    },
		    {
		      "id": 10,
		      "name": "41 : Webapp",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/10",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "plan": {
		        "id": "1",
		        "name": "sprint1",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1"
		      },
		      "parent": {
		        "id": "1",
		        "name": "sprint1",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/1"
		      },
		      "requirementId": 41,
		      "revision": 1,
		      "testCaseCount": 0,
		      "suiteType": "RequirementTestSuite",
		      "testCasesUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1/Suites/10/testcases",
		      "inheritDefaultConfigurations": true,
		      "lastPopulatedDate": "2014-05-04T11:54:29.827Z",
		      "state": "InProgress",
		      "lastUpdatedBy": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "lastUpdatedDate": "2014-05-04T11:54:29.827Z"
		    }
		  ],
		  "count": 4
		}
		*/
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Url { get; set; }
		public virtual Project Project { get; set; }
		public virtual TestPlan Plan { get; set; }
		public virtual int Revision { get; set; }
		public virtual int TestCaseCount { get; set; }
		public virtual string SuiteType { get; set; }
		public virtual string TestCasesUrl { get; set; }
		public virtual bool InheritDefaultConfigurations { get; set; }
		public virtual bool DefaultConfigurations { get; set; }
		public virtual string State { get; set; }
		public virtual object LastUpdatedBy { get; set; }
		public virtual DateTime LastUpdatedDate { get; set; }
	}
}

