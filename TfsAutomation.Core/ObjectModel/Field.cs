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

	public class Field
	{
		/*
		sample
		{
		  "name": "Iteration Path",
		  "referenceName": "System.IterationPath",
		  "type": "treePath",
		  "readOnly": true,
		  "url": "https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.IterationPath"
		}
		*/
		public virtual string name { get; set; }
		public virtual string referenceName { get; set; }
		public virtual string type { get; set; }
		public virtual bool readOnly { get; set; }
		public virtual string url { get; set; }
	}
}

