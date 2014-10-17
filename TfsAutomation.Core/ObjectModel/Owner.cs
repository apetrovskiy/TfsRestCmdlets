/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/17/2014
 * Time: 3:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TfsAutomation.Core.ObjectModel
{
    using System;
    
    /// <summary>
    /// Description of Owner.
    /// </summary>
    public class Owner
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string UniqueName { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
//		        "url": "https://fabrikam-fiber-inc.vssps.visualstudio.com/_apis/Identities/e5a5f7f8-6507-4c34-b397-6c4818e002f4",
//		        "imageUrl": "https://fabrikam.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=e5a5f7f8-6507-4c34-b397-6c4818e002f4"
    }
}
