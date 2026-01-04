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
    }
}
