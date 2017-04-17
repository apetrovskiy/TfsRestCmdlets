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

    public class ProjectCollection
	{
		/*
		sample
		{
		  "count": 1,
		  "value": [
		    {
		      "id": "d81542e4-cdfa-4333-b082-1ae2d6c3ad16",
		      "name": "DefaultCollection",
		      "url": "https://fabrikam.visualstudio.com/_apis/projectCollections/d81542e4-cdfa-4333-b082-1ae2d6c3ad16"
		    }
		  ]
		}
		*/
		public virtual Guid Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Url { get; set; }
	}
}

