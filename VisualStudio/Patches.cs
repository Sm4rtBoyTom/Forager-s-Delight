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

                        if (Settings.instance.CargoPants && clothing.name == "GEAR_CargoPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.CargoPantsBonus /4);

                        if (Settings.instance.CombatPants && clothing.name == "GEAR_CombatPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.CombatPantsBonus /4);

                        if (Settings.instance.DeerSkinPants && clothing.name == "GEAR_DeerSkinPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.DeerSkinBonus / 4);

                        if (Settings.instance.Jeans && clothing.name == "GEAR_Jeans")
                        __result += ItemWeight.FromKilograms(Settings.instance.JeansBuff / 4);

                        if (Settings.instance.MinersPants && clothing.name == "GEAR_MinersPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.MinersPantsBuff / 4);

                        if (Settings.instance.SnowPants && clothing.name == "GEAR_InsulatedPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.SnowPantsBuff / 4);

                        if (Settings.instance.WorkPants && clothing.name == "GEAR_WorkPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.WorkPantsBuff / 4);

                        if (Settings.instance.WorkPants && clothing.name == "GEAR_WorkPants")
                        __result += ItemWeight.FromKilograms(Settings.instance.WorkPantsBuff / 4);
                }
                ClothingLayer[] bodylayers = { ClothingLayer.Top, ClothingLayer.Top2 };

                foreach (ClothingLayer layer in bodylayers)
                {
                    GearItem clothing = __instance.GetClothingInSlot(ClothingRegion.Chest, layer);
                    if (clothing == null) continue;

                    if (Settings.instance.BearskinCoat && clothing.name == "GEAR_BearSkinCoat")
                        __result += ItemWeight.FromKilograms(Settings.instance.Bearskinbouns / 4);

                    if (Settings.instance.Cowichan && clothing.name == "GEAR_CowichanSweater")
                        __result += ItemWeight.FromKilograms(Settings.instance.CowichanBonus / 4);

                    if (Settings.instance.DownVest && clothing.name == "GEAR_DownVest")
                        __result += ItemWeight.FromKilograms(Settings.instance.DownVestBonus / 4);

                    if (Settings.instance.DressShirt && clothing.name == "GEAR_CottonShirt")
                        __result += ItemWeight.FromKilograms(Settings.instance.DressShirtBonus / 4);

                    if (Settings.instance.ExParka && clothing.name == "GEAR_PremiumWinterCoat")
                        __result += ItemWeight.FromKilograms(Settings.instance.ExParkaBonus / 4);

                    if (Settings.instance.ChristmasSweater && clothing.name == "GEAR_SweaterChristmasA")
                        __result += ItemWeight.FromKilograms(Settings.instance.christmasSweaterBonus / 4);

                    if (Settings.instance.FisherManSweater && clothing.name == "GEAR_FishermanSweater")
                        __result += ItemWeight.FromKilograms(Settings.instance.FisherManSweaterBonus / 4);

                    if (Settings.instance.FlightJacket && clothing.name == "GEAR_JacketLeatherFlightA")
                        __result += ItemWeight.FromKilograms(Settings.instance.FlightJacketBonus / 4);

                    if (Settings.instance.Hockey && clothing.name == "GEAR_JerseyHockeyA")
                        __result += ItemWeight.FromKilograms(Settings.instance.HockeyBonus / 4);

                    if (Settings.instance.Hoodie && clothing.name == "GEAR_CottonHoodie")
                        __result += ItemWeight.FromKilograms(Settings.instance.HoodieBonus / 4);

                    if (Settings.instance.SkiJacket && clothing.name == "GEAR_SkiJacket")
                        __result += ItemWeight.FromKilograms(Settings.instance.SkiJacketbonus / 4);

                    if (Settings.instance.Mackinaw && clothing.name == "GEAR_MackinawJacket")
                        __result += ItemWeight.FromKilograms(Settings.instance.MackinawBonus / 4);

                    if (Settings.instance.QualityWinterCoat && clothing.name == "GEAR_QualityWinterCoat")
                        __result += ItemWeight.FromKilograms(Settings.instance.QualWinterCoatBonus / 4);

                    if (Settings.instance.MilitaryParka && clothing.name == "GEAR_MilitaryParka")
                        __result += ItemWeight.FromKilograms(Settings.instance.MilitaryParkaBonus / 4);

                    if (Settings.instance.MilitaryParka && clothing.name == "GEAR_MilitaryParka")
                        __result += ItemWeight.FromKilograms(Settings.instance.MilitaryParkaBonus / 4);

                    if (Settings.instance.MinerJacket && clothing.name == "GEAR_MinersJacket")
                        __result += ItemWeight.FromKilograms(Settings.instance.MinerJacketBonus / 4);

                    if (Settings.instance.MooseCoat && clothing.name == "GEAR_MooseHideCloak")
                        __result += ItemWeight.FromKilograms(Settings.instance.MooseCoatbonus / 4);

                    if (Settings.instance.HeavyParka && clothing.name == "GEAR_HeavyParka")
                        __result += ItemWeight.FromKilograms(Settings.instance.HeavyParkaBonus / 4);

                    if (Settings.instance.ShirtSquare && clothing.name == "GEAR_PlaidShirt")
                        __result += ItemWeight.FromKilograms(Settings.instance.ShirtSquareBonus / 4);

                    if (Settings.instance.LightParka && clothing.name == "GEAR_LightParka")
                        __result += ItemWeight.FromKilograms(Settings.instance.LightParkaBonus / 4);

                    if (Settings.instance.DownSkiJacket && clothing.name == "GEAR_DownSkiJacket")
                        __result += ItemWeight.FromKilograms(Settings.instance.DownSkiJacketBonus / 4);

                    if (Settings.instance.SportVest && clothing.name == "GEAR_InsulatedVest")
                        __result += ItemWeight.FromKilograms(Settings.instance.SportVestBonus / 4);

                    if (Settings.instance.Sweatshirt && clothing.name == "GEAR_FleeceSweater")
                        __result += ItemWeight.FromKilograms(Settings.instance.Sweatshirtbonus / 4);

                    if (Settings.instance.TacticalJacket && clothing.name == "GEAR_TacticalJacket")
                        __result += ItemWeight.FromKilograms(Settings.instance.TacticalJacketBonus / 4);

                    if (Settings.instance.HeavyWoolSweater && clothing.name == "GEAR_HeavyWoolSweater")
                        __result += ItemWeight.FromKilograms(Settings.instance.HeavyWoolSweaterBonus / 4);

                    if (Settings.instance.WoolSweater && clothing.name == "GEAR_WoolSweater")
                        __result += ItemWeight.FromKilograms(Settings.instance.WoolSweaterBonus / 4);


                    //T-Shirts
                    if (Settings.instance.TShirt && clothing.name == "GEAR_TeeShirt")
                        __result += ItemWeight.FromKilograms(Settings.instance.TshirtBonus / 4);

                    if (Settings.instance.TShirt && clothing.name == "GEAR_TShirtGBI")
                        __result += ItemWeight.FromKilograms(Settings.instance.TshirtBonus / 4);

                    if (Settings.instance.TShirt && clothing.name == "GEAR_TShirtCM")
                        __result += ItemWeight.FromKilograms(Settings.instance.TshirtBonus / 4);

                    if (Settings.instance.TShirt && clothing.name == "GEAR_TShirtSnappy")
                        __result += ItemWeight.FromKilograms(Settings.instance.TshirtBonus / 4);


                    if (Settings.instance.DownParka && clothing.name == "GEAR_DownParka")
                        __result += ItemWeight.FromKilograms(Settings.instance.DownParkaBonus / 4);

                    if (Settings.instance.BasicWinterCoat && clothing.name == "GEAR_BasicWinterCoat")
                        __result += ItemWeight.FromKilograms(Settings.instance.BasicWinterCoatbonus / 4);

                    if (Settings.instance.WolfSkin && clothing.name == "GEAR_WolfSkinCape")
                        __result += ItemWeight.FromKilograms(Settings.instance.WolfSkinBonus / 4);

                    if (Settings.instance.WoolShirt && clothing.name == "GEAR_WoolShirt")
                        __result += ItemWeight.FromKilograms(Settings.instance.WoolShirtBonus / 4);



                }
            }
        }
    }
}
