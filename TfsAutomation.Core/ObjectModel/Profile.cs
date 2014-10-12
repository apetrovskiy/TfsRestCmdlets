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

	public class Profile
	{
		/*
		sample
		{
		  "displayName": "Jamal Hartnett",
		  "publicAlias": "d291b0c4-a05c-4ea6-8df1-4b41d5f39eff",
		  "emailAddress": "fabrikamfiber4@hotmail.com",
		  "coreRevision": 87,
		  "timeStamp": "2014-03-13T09:26:20.8-07:00",
		  "id": "d291b0c4-a05c-4ea6-8df1-4b41d5f39eff",
		  "revision": 920
		}
		*/
		public virtual string displayName { get; set; }
		public virtual Guid publicAlias { get; set; }
		public virtual string emailAddress { get; set; }
		public virtual int coreRevision { get; set; }
		public virtual DateTime timeStamp { get; set; }
		public virtual Guid id { get; set; }
		public virtual int revision { get; set; }
	}
}

