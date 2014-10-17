/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/17/2014
 * Time: 3:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TfsAutomation.Core.ObjectModel
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// Description of Branch.
    /// </summary>
    public class Branch
    {
        public Branch()
        {
            Children = new List<Branch>();
        }
        
        public string Path { get; set; }
        public Owner Owner { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Branch> Children { get; set; }
    }
}
