using BattleTech;
using Harmony;

namespace FastMode
{
	public static class Travel
	{
		[HarmonyPatch(typeof(SGTravelManager))]
		[HarmonyPatch(nameof(SGTravelManager.BeginTransferAnim), MethodType.Normal)]
		public static class TravelBegin
		{
			public static void Postfix(SGTravelManager __instance)
			{
				__instance.AnimationInterrupt();
			}
		}

		[HarmonyPatch(typeof(SGTravelManager))]
		[HarmonyPatch(nameof(SGTravelManager.ReturnFromTransferAnim), MethodType.Normal)]
		public static class TravelReturn
		{
			public static void Postfix(SGTravelManager __instance)
			{
				var counter = Traverse.Create(__instance).Field("jumpshipChargeAndLeaveAnimCounter").GetValue<int>();
				if (counter == 1)
				{
					__instance.AnimationInterrupt();
				}
			}
		}
	}
}
