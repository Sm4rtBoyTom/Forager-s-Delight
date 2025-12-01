using System;
using UnityEngine;
using HarmonyLib;
using Il2CppTLD.IntBackedUnit;
using ModComponent.API.Behaviours;

namespace ForagersDelightMod
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            HarmonyInstance.PatchAll();
            MelonLogger.Msg(System.ConsoleColor.Green, "Releasing your inner Loot Goblin...");
            Settings.instance.AddToModSettings("Forager's Delight");
        }
        public static bool Sceneloaded;

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (Utilities.IsScenePlayable(sceneName))
            {
                Sceneloaded = true;

                ChangeItemProperties();
            }
        }
        private static void ChangeItemProperties() 
        {

            GameObject MooseSatchel = GearItem.LoadGearItemPrefab("GEAR_MooseHideBag").gameObject;
            
            GameManager.DestroyImmediate(MooseSatchel.GetComponent<CarryingCapacityBuff>());

            if (Settings.instance.CampingTools)
            {
                GameObject RangerSatchel = GearItem.LoadGearItemPrefab("GEAR_SatchelM").gameObject;

            GameManager.DestroyImmediate(RangerSatchel.GetComponent<CarryingCapacityBuff>());
            }

            if (Settings.instance.NomadsExpedition)
            {
                GameObject RangerSatchel = GearItem.LoadGearItemPrefab("GEAR_DeerSling2").gameObject;

                GameManager.DestroyImmediate(RangerSatchel.GetComponent<CarryingCapacityBuff>());

                GameObject RabbitPocket = GearItem.LoadGearItemPrefab("GEAR_RabbitPocket").gameObject;

                GameManager.DestroyImmediate(RabbitPocket.GetComponent<CarryingCapacityBuff>());
            }
        }
    }
}
