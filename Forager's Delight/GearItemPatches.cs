
namespace ForagersDelightMod
{
    internal class GearItemPatches
    {
        [HarmonyPatch(typeof(GearItem), "Awake")]
        public class Satchel
        {
            public static void Postfix(ref GearItem __instance)
            {
                if (__instance != null)
                {
                    CarryingCapacityBuff Carrybuff = __instance.GetComponent<CarryingCapacityBuff>();

                    if (Carrybuff != null)
                    {
                        if (__instance.name.Contains("GEAR_MooseHideBag") || __instance.name.Contains("MooseBagPlusScabbard"))
                        {
                            GameManager.DestroyImmediate(Carrybuff);
                        }
                        if (__instance.name.Contains("GEAR_SatchelM"))
                        {
                            GameManager.DestroyImmediate(Carrybuff);
                        }
                        if (__instance.name.Contains("GEAR_DeerSling2"))
                        {
                            GameManager.DestroyImmediate(Carrybuff);
                        }
                        if (__instance.name.Contains("GEAR_RabbitPocket"))
                        {
                            GameManager.DestroyImmediate(Carrybuff);
                        }
                    }

                     WeightReductionBuff weightbuff = __instance.GetComponent<WeightReductionBuff>();

                     if (weightbuff != null)
                     {
                         if (__instance.name.Contains("RifleScabbardA") || __instance.name.Contains("MooseBagPlusScabbard"))
                         {
                            weightbuff.m_WeightReduction = Settings.instance.RifleScabbardWeightReduction;
                        }
                         if (__instance.name.Contains("Toolbelt") || __instance.name.Contains("ToolBelt"))
                         {
                             weightbuff.m_WeightReduction = Settings.instance.ToolbeltWeightReduction;
                             weightbuff.m_AffectedItems = Settings.instance.ToolbeltItemAmount;
                         }
                     }  
                }
            }
        }
    }
}
