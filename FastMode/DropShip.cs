#region USING
using BattleTech;
using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
#endregion

namespace FastMode
{
	//[HarmonyPatch(typeof(DropshipGameLogic))]
	//[HarmonyPatch(nameof(DropshipGameLogic.StartDropoff), MethodType.Normal)]
	//public static class DropShipAnimation
	//{
	//	public static void Prefix(DropshipGameLogic __instance)
	//	{
	//		Traverse.Create(typeof(DropshipGameLogic)).Field("dropoffDropshipAnimationSequence").SetValue(null);
	//		__instance.startingAnimationState = DropshipAnimationState.OffScreen;
	//		__instance.currentAnimationState = DropshipAnimationState.OffScreen;
	//		__instance.SetState(EncounterObjectStatus.Finished);
	//		__instance.OnEnterFinished();
	//		__instance.GetMeshRenderer().enabled = false;
	//		__instance.GetMeshCollider().enabled = false;
	//		bool flag = __instance.currentAnimationState == DropshipAnimationState.Landed;
	//		for (int i = 0; i < __instance.buildingDataList.Count; i++)
	//		{
	//			__instance.buildingDataList[i].enabled = flag;
	//		}
	//		if (__instance.autoMarkDropshipLandingZone)
	//		{
	//			__instance.MarkDropshipLandingZone(!flag && true);
	//		}
	//		__instance.UpdateRelatedTerrainCells();
	//		__instance.UpdatePathingNearMe();
	//	}
	//}

	//SpawnDropshipForFlyby

	//[HarmonyPatch(typeof(DropshipAnimationSequence), "Load")]
	//public static class DropShipAnimation
	//{
	//	public static void Prefix()
	//	{
	//		// completely skip the dropship animation
	//		//Traverse.Create(typeof(DropshipAnimationSequence)).Field("DropshipAnimationComplete").SetValue(true);
	//	}
	//}
}
