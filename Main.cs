#region USING
using Harmony;
using System.Reflection;
#endregion

namespace FastMode
{
	public static class Main
	{
		//string Directory, string Settings
		public static void Init()
		{
			var harmony = HarmonyInstance.Create("com.github.ciphernemo.FastMode");
			harmony.PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}
