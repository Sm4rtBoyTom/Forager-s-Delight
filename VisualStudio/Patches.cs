using HarmonyLib;
using Il2CppTLD.IntBackedUnit;
using Il2Cpp;

namespace ForagersDelightMod
{
    internal class CarryCapacityBuffManager
    {
        [HarmonyPatch(typeof(PlayerManager), nameof(PlayerManager.GetCarryCapacityKGBuff))]
        public class ApplyCarryCapacityBuff
        {
            public static void Postfix(PlayerManager __instance, ref ItemWeight __result)
            {
                ClothingLayer[] legLayers = { ClothingLayer.Top, ClothingLayer.Top2 };

                foreach (ClothingLayer layer in legLayers)
                {
                    GearItem clothing = __instance.GetClothingInSlot(ClothingRegion.Legs, layer);
                    if (clothing == null) continue;

                    if (clothing.name == "GEAR_CargoPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.CargoPantsBonus / 2);

                        if (clothing.name == "GEAR_CombatPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.CombatPantsBonus /2);

                        if (clothing.name == "GEAR_DeerSkinPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.DeerSkinBonus / 2);

                        if (clothing.name == "GEAR_Jeans")
                        __result += ItemWeight.FromKilograms(Settings.instance.JeansBuff / 2);

                        if (clothing.name == "GEAR_MinersPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.MinersPantsBuff / 2);

                        if (clothing.name == "GEAR_InsulatedPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.SnowPantsBuff / 2);

                        if (clothing.name == "GEAR_WorkPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.WorkPantsBuff / 2);

                        if (clothing.name == "GEAR_WorkPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.WorkPantsBuff / 2);
                }
                ClothingLayer[] bodylayers = { ClothingLayer.Mid, ClothingLayer.Base, ClothingLayer.Top, ClothingLayer.Top2 };

                foreach (ClothingLayer layer in bodylayers)
                {
                    GearItem clothing = __instance.GetClothingInSlot(ClothingRegion.Chest, layer);
                    if (clothing == null) continue;

                    //NorthFolk Clothing Pack
                    if (Settings.instance.Northfolk && clothing.name == "GEAR_DeerskinCoat_MOD")
                        __result += ItemWeight.FromKilograms(Settings.instance.DeerskinCoat / 2);

                    if (clothing.name == "GEAR_BearSkinCoat")
                        __result += ItemWeight.FromKilograms(Settings.instance.Bearskinbouns / 2);

                    if (clothing.name == "GEAR_CowichanSweater")
                        __result += ItemWeight.FromKilograms(Settings.instance.CowichanBonus / 2);

                    if (clothing.name == "GEAR_DownVest")
                        __result += ItemWeight.FromKilograms(Settings.instance.DownVestBonus / 2);

                    if (clothing.name == "GEAR_CottonShirt")
                        __result += ItemWeight.FromKilograms(Settings.instance.DressShirtBonus / 2);

                    if (clothing.name == "GEAR_PremiumWinterCoat")
                        __result += ItemWeight.FromKilograms(Settings.instance.ExParkaBonus / 2);

                    if (clothing.name == "GEAR_SweaterChristmasA")
                        __result += ItemWeight.FromKilograms(Settings.instance.christmasSweaterBonus / 2);

                    if (clothing.name == "GEAR_FishermanSweater")
                        __result += ItemWeight.FromKilograms(Settings.instance.FisherManSweaterBonus / 2);

                    if (clothing.name == "GEAR_JacketLeatherFlightA")
                        __result += ItemWeight.FromKilograms(Settings.instance.FlightJacketBonus / 2);

                    if (clothing.name == "GEAR_JerseyHockeyA")
                        __result += ItemWeight.FromKilograms(Settings.instance.HockeyBonus / 2);

                    if (clothing.name == "GEAR_CottonHoodie")
                        __result += ItemWeight.FromKilograms(Settings.instance.HoodieBonus / 2);

                    if (clothing.name == "GEAR_SkiJacket")
                        __result += ItemWeight.FromKilograms(Settings.instance.SkiJacketbonus / 2);

                    if (clothing.name == "GEAR_MackinawJacket")
                        __result += ItemWeight.FromKilograms(Settings.instance.MackinawBonus / 2);

                    if (clothing.name == "GEAR_QualityWinterCoat")
                        __result += ItemWeight.FromKilograms(Settings.instance.QualWinterCoatBonus / 2);

                    if (clothing.name == "GEAR_MilitaryParka")
                        __result += ItemWeight.FromKilograms(Settings.instance.MilitaryParkaBonus / 2);

                    if (clothing.name == "GEAR_MilitaryParka")
                        __result += ItemWeight.FromKilograms(Settings.instance.MilitaryParkaBonus / 2);

                    if (clothing.name == "GEAR_MinersJacket")
                        __result += ItemWeight.FromKilograms(Settings.instance.MinerJacketBonus / 2);

                    if (clothing.name == "GEAR_MooseHideCloak")
                        __result += ItemWeight.FromKilograms(Settings.instance.MooseCoatbonus / 2);

                    if (clothing.name == "GEAR_HeavyParka")
                        __result += ItemWeight.FromKilograms(Settings.instance.HeavyParkaBonus / 2);

                    if (clothing.name == "GEAR_PlaidShirt")
                        __result += ItemWeight.FromKilograms(Settings.instance.ShirtSquareBonus / 2);

                    if (clothing.name == "GEAR_LightParka")
                        __result += ItemWeight.FromKilograms(Settings.instance.LightParkaBonus / 2);

                    if (clothing.name == "GEAR_DownSkiJacket")
                        __result += ItemWeight.FromKilograms(Settings.instance.DownSkiJacketBonus / 2);

                    if (clothing.name == "GEAR_InsulatedVest")
                        __result += ItemWeight.FromKilograms(Settings.instance.SportVestBonus / 2);

                    if (clothing.name == "GEAR_FleeceSweater")
                        __result += ItemWeight.FromKilograms(Settings.instance.Sweatshirtbonus / 2);

                    if (clothing.name == "GEAR_TacticalJacket")
                        __result += ItemWeight.FromKilograms(Settings.instance.TacticalJacketBonus / 2);

                    if (clothing.name == "GEAR_HeavyWoolSweater")
                        __result += ItemWeight.FromKilograms(Settings.instance.HeavyWoolSweaterBonus / 2);

                    if (clothing.name == "GEAR_WoolSweater")
                        __result += ItemWeight.FromKilograms(Settings.instance.WoolSweaterBonus / 2);


                    //T-Shirts
                    if (clothing.name == "GEAR_TeeShirt")
                        __result += ItemWeight.FromKilograms(Settings.instance.TshirtBonus / 2);

                    if (clothing.name == "GEAR_TShirtGBI")
                        __result += ItemWeight.FromKilograms(Settings.instance.TshirtBonus / 2);

                    if (clothing.name == "GEAR_TShirtCM")
                        __result += ItemWeight.FromKilograms(Settings.instance.TshirtBonus / 2);

                    if (clothing.name == "GEAR_TShirtSnappy")
                        __result += ItemWeight.FromKilograms(Settings.instance.TshirtBonus / 2);


                    if (clothing.name == "GEAR_DownParka")
                        __result += ItemWeight.FromKilograms(Settings.instance.DownParkaBonus / 2);

                    if (clothing.name == "GEAR_BasicWinterCoat")
                        __result += ItemWeight.FromKilograms(Settings.instance.BasicWinterCoatbonus / 2);

                    if (clothing.name == "GEAR_WolfSkinCape")
                        __result += ItemWeight.FromKilograms(Settings.instance.WolfSkinBonus / 2);

                    if (clothing.name == "GEAR_WoolShirt")
                        __result += ItemWeight.FromKilograms(Settings.instance.WoolShirtBonus / 2);
                }
                ClothingLayer[] Accessory = { ClothingLayer.Mid, ClothingLayer.Base, ClothingLayer.Top, ClothingLayer.Top2 };

                foreach (ClothingLayer layer in bodylayers)
                {
                    GearItem clothing = __instance.GetClothingInSlot(ClothingRegion.Accessory, layer);
                    if (clothing == null) continue;

                    if (clothing.name == "GEAR_MooseHideBag")
                        __result += ItemWeight.FromKilograms(Settings.instance.MooseSatchel / 2);

                        //Camping Tools
                    if (Settings.instance.CampingTools && clothing.name == "GEAR_SatchelM")
                        __result += ItemWeight.FromKilograms(Settings.instance.SatchelM / 2);
                       //Nomad's Expedition
                    if (Settings.instance.NomadsExpedition && clothing.name == "GEAR_DeerSling2")
                        __result += ItemWeight.FromKilograms(Settings.instance.DeerSling / 2);

                    if (Settings.instance.NomadsExpedition && clothing.name == "GEAR_RabbitPocket")
                        __result += ItemWeight.FromKilograms(Settings.instance.RabbitPocket / 2);
                }
        }
    }
}
}
