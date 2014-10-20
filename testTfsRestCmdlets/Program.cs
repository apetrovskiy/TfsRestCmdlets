/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/12/2014
 * Time: 1:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace testVisualStudioOnline
{
	using System;
	using TfsAutomation.Core;
	using TfsAutomation.Core.Actions;
	using TfsAutomation.Core.ObjectModel;

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			
			TfsData.BaseUrl = "https://alexanderpetrovskiy.visualstudio.com";
			TfsData.CurrentProjectCollectionName = "DefaultCollection";
			TfsData.CurrentProjectName = "testprj";
			TfsData.ApiVersion = "";
			TfsData.Username = "shuran"; //@"alexander.petrovsky@netwrix.com";
			TfsData.Password = @"sss=1qwerty"; // @"msdn,6=1qwerty";
			TfsData.AuthenticationType = AuthenticationTypes.NTLM;

			var requestCreator = new RestRequestCreator ();
			requestCreator.Init ();
			var branchesLoader = new BranchesLoader (requestCreator);
			var list = branchesLoader.Load ();
			if (null != list)
				foreach (var item in list)
					Console.WriteLine (item);

			Console.ReadKey();
		}
	}
}
