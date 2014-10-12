﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/12/2014
 * Time: 2:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TfsAutomation.Core.ObjectModel
{
	using System;
	using System.Collections.Generic;
	
	/// <summary>
	/// Description of Account.
	/// </summary>
	public class Account
	{
		/*
		[
		  {
		    "AccountId": "14ba3122-98e3-4b40-82ce-bb89b905e151",
		    "NamespaceId": "00000000-0000-0000-0000-000000000000",
		    "AccountName": "fabrikam-inc",
		    "OrganizationName": "fabrikam-inc",
		    "AccountType": 0,
		    "AccountOwner": "d291b0c4-a05c-4ea6-8df1-4b41d5f39eff",
		    "CreatedBy": "d291b0c4-a05c-4ea6-8df1-4b41d5f39eff",
		    "CreatedDate": "2013-04-26T16:46:25.683Z",
		    "AccountStatus": 1,
		    "StatusReason": null,
		    "LastUpdatedBy": "d291b0c4-a05c-4ea6-8df1-4b41d5f39eff",
		    "Properties": {}
		  }
		]
		*/
		
		public Guid AccountId { get; set; }
	    public Guid NamespaceId { get; set; }
	    public string AccountName { get; set; }
	    public string OrganizationName { get; set; }
	    public AccountTypes AccountType { get; set; }
	    public Guid AccountOwner { get; set; }
	    public Guid CreatedBy { get; set; }
	    public DateTime CreatedDate { get; set; }
	    public AccountStatuses AccountStatus { get; set; }
	    public object StatusReason { get; set; }
	    public Guid LastUpdatedBy { get; set; }
	    public List<object> Properties { get; set; }
	}
}
