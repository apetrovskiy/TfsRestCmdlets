/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/12/2014
 * Time: 1:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TfsAutomation.Core.Internal
{
    using Spring.Context.Support;

    public static class ObjectFactory
	{
		static ObjectFactory ()
		{
			// initialize container...


		}

		public static T Resolve<T>(T type)
		{
			var ctx = ContextRegistry.GetContext();
			return (T)ctx.GetObject (type.GetType().Name);
		}
	}
}

