using System;
using UnityEngine;
using HarmonyLib;
using Il2CppTLD.IntBackedUnit;

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

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (Utilities.IsScenePlayable(sceneName))
            {
            }
        }
    }
}
