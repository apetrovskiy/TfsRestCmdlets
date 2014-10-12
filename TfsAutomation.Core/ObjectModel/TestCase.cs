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

	public class TestCase
	{
		/*
		sample
		{
		  "value": [
		    {
		      "testCase": {
		        "id": "39",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/workItems/39",
		        "webUrl": "https://fabrikam.visualstudio.com/web/wi.aspx?pcguid=d81542e4-cdfa-4333-b082-1ae2d6c3ad16&id=39"
		      },
		      "pointAssignments": [
		        {
		          "configuration": {
		            "id": "2",
		            "name": "Windows 8"
		          },
		          "tester": {
		            "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		            "displayName": "Fabrikam Fiber",
		            "uniqueName": "fabrikamfiber1@outlook.com",
		            "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		            "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		          }
		        }
		      ]
		    },
		    {
		      "testCase": {
		        "id": "40",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/workItems/40",
		        "webUrl": "https://fabrikam.visualstudio.com/web/wi.aspx?pcguid=d81542e4-cdfa-4333-b082-1ae2d6c3ad16&id=40"
		      },
		      "pointAssignments": [
		        {
		          "configuration": {
		            "id": "2",
		            "name": "Windows 8"
		          },
		          "tester": {
		            "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		            "displayName": "Fabrikam Fiber",
		            "uniqueName": "fabrikamfiber1@outlook.com",
		            "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		            "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		          }
		        }
		      ]
		    }
		  ],
		  "count": 2
		}
		*/
		/*
		{
		  "testCase": {
		    "id": "39",
		    "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/workItems/39",
		    "webUrl": "https://fabrikam.visualstudio.com/web/wi.aspx?pcguid=d81542e4-cdfa-4333-b082-1ae2d6c3ad16&id=39"
		  },
		  "pointAssignments": [
		    {
		      "configuration": {
		        "id": "2",
		        "name": "Windows 8"
		      },
		      "tester": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "uniqueName": "fabrikamfiber1@outlook.com",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      }
		    }
		  ]
		}
		*/
		public virtual int id { get; set; }
		public virtual string url { get; set; }
		public virtual string webUrl { get; set; }
	}
}

