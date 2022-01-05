using BattleTech;
using Harmony;

namespace FastMode
{
	// skip the intro Bink video by setting enum to "HasPlayed" after Init method
	[HarmonyPatch(typeof(IntroCinematicLauncher))]
	[HarmonyPatch(nameof(IntroCinematicLauncher.Init), MethodType.Normal)]
	public static class IntroVideoInit
	{
		public static void Postfix()
		{
			Traverse.Create(typeof(IntroCinematicLauncher)).Field("state").SetValue(3);
		}
	}

	// skip the splash animation by setting serialized activate variable to enabled before Update method
	[HarmonyPatch(typeof(SplashLauncher), "Update")]
	public static class SplashAnimationUpdate
	{
		public static bool Prefix(SplashLauncher __instance)
		{
			var activate = Traverse.Create(__instance).Field("activate").GetValue<ActivateAfterInit>();
			if (activate != null && !activate.enabled)
			{
				activate.enabled = true;
			}
			return false;
		}
	}

	//[HarmonyPatch(typeof(SplashLauncher), "OnStart")]
	//public static class SplashAnimationOnStart
	//{
	//	public static void Prefix(SplashLauncher __instance)
	//	{
	//		Traverse.Create(typeof(SplashAnimationOnStart)).Field("currentState").SetValue("Complete");
	//	}
	//}
}
