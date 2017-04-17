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
    public class TestPlan
	{
		/*
		sample
		{
		  "value": [
		    {
		      "id": 1,
		      "name": "sprint1",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/1",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1\\Sprint 1",
		      "state": "Active",
		      "rootSuite": {
		        "id": "1"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=1"
		    },
		    {
		      "id": 2,
		      "name": "sprint2",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/2",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1\\Sprint 1",
		      "state": "Active",
		      "rootSuite": {
		        "id": "2"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=2"
		    },
		    {
		      "id": 3,
		      "name": "newCreatedPlan2",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/3",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC",
		      "state": "Inactive",
		      "rootSuite": {
		        "id": "3"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=3"
		    },
		    {
		      "id": 4,
		      "name": "spritn3",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/4",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1\\Sprint 1",
		      "state": "Active",
		      "rootSuite": {
		        "id": "21"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=4"
		    },
		    {
		      "id": 5,
		      "name": "sprint4",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/5",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1\\Sprint 1",
		      "state": "Active",
		      "rootSuite": {
		        "id": "22"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=5"
		    },
		    {
		      "id": 6,
		      "name": "sprint5",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/6",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1\\Sprint 1",
		      "state": "Active",
		      "rootSuite": {
		        "id": "23"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=6"
		    },
		    {
		      "id": 7,
		      "name": "newCreatedPlan2",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/7",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC",
		      "state": "Active",
		      "rootSuite": {
		        "id": "24"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=7"
		    },
		    {
		      "id": 8,
		      "name": "newCreatedPlan",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/8",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC",
		      "state": "Active",
		      "rootSuite": {
		        "id": "25"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=8"
		    },
		    {
		      "id": 9,
		      "name": "newCreatedPlan2",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/9",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC",
		      "state": "Inactive",
		      "rootSuite": {
		        "id": "26"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=9"
		    },
		    {
		      "id": 10,
		      "name": "newCreatedPlan",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/10",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC",
		      "state": "Active",
		      "rootSuite": {
		        "id": "27"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=10"
		    },
		    {
		      "id": 11,
		      "name": "ANewPlan",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/11",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "411",
		        "name": "Fabrikam-Fiber-TFVC\\Quality assurance"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1",
		      "state": "Active",
		      "rootSuite": {
		        "id": "28"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=11"
		    },
		    {
		      "id": 12,
		      "name": "newCreatedPlan2",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/12",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC",
		      "state": "Inactive",
		      "rootSuite": {
		        "id": "29"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=12"
		    },
		    {
		      "id": 13,
		      "name": "newCreatedPlan",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/13",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC",
		      "state": "Active",
		      "rootSuite": {
		        "id": "30"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=13"
		    },
		    {
		      "id": 14,
		      "name": "newCreatedPlan2",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/14",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC",
		      "state": "Inactive",
		      "rootSuite": {
		        "id": "31"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=14"
		    },
		    {
		      "id": 15,
		      "name": "newCreatedPlan",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/15",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "343",
		        "name": "Fabrikam-Fiber-TFVC"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC",
		      "state": "Active",
		      "rootSuite": {
		        "id": "32"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=15"
		    },
		    {
		      "id": 16,
		      "name": "ANewPlan",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/16",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "411",
		        "name": "Fabrikam-Fiber-TFVC\\Quality assurance"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1",
		      "state": "Active",
		      "rootSuite": {
		        "id": "33"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=16"
		    },
		    {
		      "id": 17,
		      "name": "newCreatedPlan2",
		      "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/test/Fabrikam-Fiber-TFVC/Plans/17",
		      "project": {
		        "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
		        "name": "Fabrikam-Fiber-TFVC",
		        "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC"
		      },
		      "area": {
		        "id": "411",
		        "name": "Fabrikam-Fiber-TFVC\\Quality assurance"
		      },
		      "iteration": "Fabrikam-Fiber-TFVC\\Release 1",
		      "state": "Inactive",
		      "rootSuite": {
		        "id": "34"
		      },
		      "clientUrl": "mtms://fabrikam.visualstudio.com:443/DefaultCollection/p:Fabrikam-Fiber-TFVC/Testing/testplan/connect?id=17"
		    }
		  ],
		  "count": 17
		}
		*/
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Url { get; set; }
		public virtual Project Project { get; set; }
		public virtual object Area { get; set; }
		public virtual string Iteration { get; set; }
		public virtual string State { get; set; }
		public virtual object RootSuite { get; set; }
		public virtual string ClientUrl { get; set; }
	}
}

