using MelonLoader;
using UnityEngine;
using Il2CppTLD.IntBackedUnit;
using Il2CppTLD.Gear;
using Il2Cpp;
using HarmonyLib;
using Il2CppNodeCanvas.Tasks.Actions;

namespace ForagersDelightMod
{
    internal class GearItemPatches
    {
        [HarmonyPatch(typeof(GearItem), "Awake")]
        public class Satchel
        {
            public static void Postfix (ref GearItem __instance)
            {
                if (__instance != null)
                {
                   if (__instance.name.Contains("GEAR_MooseHideBag"))
                    {
                        GameManager.DestroyImmediate(__instance.GetComponent<CarryingCapacityBuff>());
                    }
                   if (__instance.name.Contains("GEAR_SatchelM"))
                    {
                        GameManager.DestroyImmediate(__instance.GetComponent<CarryingCapacityBuff>());
                    }
                    if (__instance.name.Contains("GEAR_DeerSling2"))
                    {
                        GameManager.DestroyImmediate(__instance.GetComponent<CarryingCapacityBuff>());
                    }
                    if (__instance.name.Contains("GEAR_RabbitPocket"))
                    {
                        GameManager.DestroyImmediate(__instance.GetComponent<CarryingCapacityBuff>());
                    }
                }
            }
        }
    }
}
