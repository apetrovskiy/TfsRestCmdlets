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
		public virtual string Name { get; set; }
		public virtual string ReferenceName { get; set; }
		public virtual string Type { get; set; }
		public virtual bool ReadOnly { get; set; }
		public virtual string Url { get; set; }
	}
}

