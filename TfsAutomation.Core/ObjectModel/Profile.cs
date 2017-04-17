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
		public virtual string DisplayName { get; set; }
		public virtual Guid PublicAlias { get; set; }
		public virtual string EmailAddress { get; set; }
		public virtual int CoreRevision { get; set; }
		public virtual DateTime TimeStamp { get; set; }
		public virtual Guid Id { get; set; }
		public virtual int Revision { get; set; }
	}
}

