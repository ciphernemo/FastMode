#region USING
using BattleTech;
using BattleTech.Rendering;
using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
#endregion

namespace FastMode.Patches
{
	public static class MyVars
	{
		public static float timeShort = 0.0001f;
		public static float fadeNone = 1.0f;
	}

	[HarmonyPatch(typeof(DropshipGameLogic))]
	[HarmonyPatch(nameof(DropshipGameLogic.AnimationStarted), MethodType.Normal)]
	public static class DropShipUpdate
	{
		public static void Prefix(DropshipGameLogic __instance)
		{
			__instance.AnimationComplete();
		}
	}

	[HarmonyPatch(typeof(SimGameCameraController), "TransitionCameraRoomLeopard")]
	public static class TransitionCameraDropShip
	{
		public static void Prefix(float transitionTime)
		{
			transitionTime = MyVars.timeShort;
		}
	}

	// get rid of all fades (show renders immediately)
	[HarmonyPatch(typeof(BTPostProcess), "OnRenderImage")]
	public static class PostProcessFade
	{
		public static void Prefix(BTPostProcess __instance)
		{
			__instance.fade = MyVars.fadeNone;
		}
	}
}
