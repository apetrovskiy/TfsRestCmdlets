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

    public class User
	{
		/*
		sample
		{
		  "count": 5,
		  "value": [
		    {
		      "roomId": 305,
		      "user": {
		        "id": "3b5f0c34-4aec-4bf4-8708-1d36f0dbc468",
		        "displayName": "Christie Church",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/3b5f0c34-4aec-4bf4-8708-1d36f0dbc468",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=3b5f0c34-4aec-4bf4-8708-1d36f0dbc468"
		      },
		      "lastActivity": "0001-01-01T00:00:00",
		      "joinedDate": "0001-01-01T00:00:00",
		      "isOnline": false
		    },
		    {
		      "roomId": 305,
		      "user": {
		        "id": "8c8c7d32-6b1b-47f4-b2e9-30b477b5ab3d",
		        "displayName": "Chuck Reinhart",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/8c8c7d32-6b1b-47f4-b2e9-30b477b5ab3d",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=8c8c7d32-6b1b-47f4-b2e9-30b477b5ab3d"
		      },
		      "lastActivity": "0001-01-01T00:00:00",
		      "joinedDate": "0001-01-01T00:00:00",
		      "isOnline": false
		    },
		    {
		      "roomId": 305,
		      "user": {
		        "id": "e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "displayName": "Fabrikam Fiber",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
		      },
		      "lastActivity": "0001-01-01T00:00:00",
		      "joinedDate": "0001-01-01T00:00:00",
		      "isOnline": false
		    },
		    {
		      "roomId": 305,
		      "user": {
		        "id": "19d9411e-9a34-45bb-b985-d24d9d87c0c9",
		        "displayName": "Johnnie McLeod",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/19d9411e-9a34-45bb-b985-d24d9d87c0c9",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=19d9411e-9a34-45bb-b985-d24d9d87c0c9"
		      },
		      "lastActivity": "0001-01-01T00:00:00",
		      "joinedDate": "0001-01-01T00:00:00",
		      "isOnline": false
		    },
		    {
		      "roomId": 305,
		      "user": {
		        "id": "d291b0c4-a05c-4ea6-8df1-4b41d5f39eff",
		        "displayName": "Jamal Hartnett",
		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/d291b0c4-a05c-4ea6-8df1-4b41d5f39eff",
		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=d291b0c4-a05c-4ea6-8df1-4b41d5f39eff"
		      },
		      "lastActivity": "0001-01-01T00:00:00",
		      "joinedDate": "0001-01-01T00:00:00",
		      "isOnline": false
		    }
		  ]
		}
		*/
		public virtual int RoomId { get; set; }
		public virtual object user { get; set; }
		public virtual DateTime LastActivity { get; set; }
		public virtual DateTime JoinedDate { get; set; }
		public virtual bool IsOnline { get; set; }
	}
}

