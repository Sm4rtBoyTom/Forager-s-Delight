using System.Reflection;
using System.Text.Json.Serialization;
using ModSettings;

namespace ForagersDelightMod
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Accessories")]

        [Name("Moose-Hide Satchel")]
        [Description("Carry Weight Bonus in KG. Default - 5Kg")]
        [Slider(5f, 10f, 51)]
        public float MooseSatchel = 5f;

        [Name("Ranger Satchel")]
        [Description("Carry Weight Bonus in KG. Default - 2Kg")]
        [Slider(2f, 5f, 31)]
        public float SatchelM = 2f;

        [Name("Deer Sling")]
        [Description("Carry Weight Bonus in KG. Default - 2.3Kg")]
        [Slider(2.3f, 4f, 18)]
        public float DeerSling = 2.3f;

        [Name("Rabbit Bag")]
        [Description("Carry Weight Bonus in KG. Default - 0.6Kg")]
        [Slider(0.6f, 2.5f, 20)]
        public float RabbitPocket = 0.6f;

        [Section("Upper Body")]

        [Name("Bearskin Coat")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float Bearskinbouns = 0f;

        [Name("Cowichan Sweater")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float CowichanBonus = 0f;

        [Name("Deerskin Coat")]
        [Description("Carry Weight Bonus in KG. Default - 0Kg")]
        [Slider(0f, 2f, 21)]
        public float DeerskinCoat = 0f;

        [Name("Down Vest")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2.kg.")]
        [Slider(0f, 2f, 21)]
        public float DownVestBonus = 0.4f;

        [Name("Dress Shirt")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float DressShirtBonus = 0f;

        [Name("Expedition Parka")]
        [Description("Carry Weight Bonus in kilograms. Default  0.25kg.")]
        [Slider(0f, 2f, 21)]
        public float ExParkaBonus = 0.5f;

        [Name("Festive Sweater")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float christmasSweaterBonus = 0f;

        [Name("Fisherman's Sweater")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float FisherManSweaterBonus = 0f;

        [Name("Flight Jacket")]
        [Description("Carry Weight Bonus in kilograms. Default  0.4kg.")]
        [Slider(0f, 2f, 21)]
        public float FlightJacketBonus = 0.4f;

        [Name("Hockey jersey")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float HockeyBonus = 0f;

        [Name("Hoodie")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float HoodieBonus = 0f;

        [Name("Light Shell")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2kg.")]
        [Slider(0f, 2f, 21)]
        public float SkiJacketbonus = 0.4f;

        [Name("Mackinaw Jacket")]
        [Description("Carry Weight Bonus in kilograms. Default  0.3kg.")]
        [Slider(0f, 2f, 21)]
        public float MackinawBonus = 0.6f;

        [Name("Mariner's Pea Coat")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2kg.")]
        [Slider(0f, 2f, 21)]
        public float QualWinterCoatBonus = 0.4f;

        [Name("Military Coat")]
        [Description("Carry Weight Bonus in kilograms. Default  0.3kg.")]
        [Slider(0f, 2f, 21)]
        public float MilitaryParkaBonus = 0.6f;

        [Name("Miner's Jacket")]
        [Description("Carry Weight Bonus in kilograms. Default  0.25kg.")]
        [Slider(0f, 2f, 21)]
        public float MinerJacketBonus = 0.5f;

        [Name("Moose-Hide Cloak")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float MooseCoatbonus = 0f;

        [Name("Old Fashioned Parka")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2kg.")]
        [Slider(0f, 2f, 21)]
        public float HeavyParkaBonus = 0.4f;

        [Name("Plaid Shirt")]
        [Description("Carry Weight Bonus in kilograms. Default  0.05kg.")]
        [Slider(0f, 2f, 21)]
        public float ShirtSquareBonus = 0.1f;

        [Name("Simple Parka")]
        [Description("Carry Weight Bonus in kilograms. Default  0.25kg.")]
        [Slider(0f, 2f, 21)]
        public float LightParkaBonus = 0.5f;

        [Name("Ski Jacket")]
        [Description("Carry Weight Bonus in kilograms. Default  0.3kg.")]
        [Slider(0f, 2f, 21)]
        public float DownSkiJacketBonus = 0.6f;

        [Name("Sport Vest")]
        [Description("Carry Weight Bonus in kilograms. Default  0.1kg.")]
        [Slider(0f, 2f, 21)]
        public float SportVestBonus = 0.2f;

        [Name("Sweatshirt")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float Sweatshirtbonus = 0f;

        [Name("Tactical jacket")]
        [Description("Carry Weight Bonus in kilograms. Default  0.4kg.")]
        [Slider(0f, 2f, 21)]
        public float TacticalJacketBonus = 0.8f;

        [Name("Thick Wool Sweater")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float HeavyWoolSweaterBonus = 0f;

        [Name("Thin Wool Sweater")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float WoolSweaterBonus = 0f;

        [Name("T-Shirt")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float TshirtBonus = 0f;

        [Name("Urban Parka")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2kg.")]
        [Slider(0f, 2f, 21)]
        public float DownParkaBonus = 0.4f;

        [Name("Windbreaker")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2kg.")]
        [Slider(0f, 2f, 21)]
        public float BasicWinterCoatbonus = 0.4f;

        [Name("Wolfskin Coat")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float WolfSkinBonus = 0f;

        [Name("Wool Shirt")]
        [Description("Carry Weight Bonus in kilograms. Default  0.05kg.")]
        [Slider(0f, 2f, 21)]
        public float WoolShirtBonus = 0f;

        [Section("Lower Body")]

        [Name("Cargo Pants")]
        [Description("Carry Weight Bonus in kilograms. Default  0.5kg.")]
        [Slider(0f, 2f, 21)]
        public float CargoPantsBonus = 0.5f;

        [Name("Combat Pants")]
        [Description("Carry Weight Bonus in KG. Default - 0.5Kg")]
        [Slider(0f, 2f, 21)]
        public float CombatPantsBonus = 1f;

        [Name("Deerskin Pants")]
        [Description("Carry Weight Bonus in KG. Default - 0Kg")]
        [Slider(0f, 2f, 21)]
        public float DeerSkinBonus = 0f;

        [Name("Jeans")]
        [Description("Carry Weight Bonus in KG. Default - 0.3Kg")]
        [Slider(0f, 2f, 21)]
        public float JeansBuff = 0.6f;

        [Name("Miner's Pants")]
        [Description("Carry Weight Bonus in KG. Default - 0.3Kg")]
        [Slider(0f, 2f, 21)]
        public float MinersPantsBuff = 0.6f;

        [Name("Snow Pants")]
        [Description("Carry Weight Bonus in KG. Default - 0.3Kg")]
        [Slider(0f, 2f, 21)]
        public float SnowPantsBuff = 0.6f;

        [Name("Wolfskin Pants")]
        [Description("Carry Weight Bonus in KG. Default - 0Kg")]
        [Slider(0f, 2f, 21)]
        public float WolfSkinBuff = 0f;

        [Name("Work Pants")]
        [Description("Carry Weight Bonus in KG. Default - 0.3Kg")]
        [Slider(0f, 2f, 21)]
        public float WorkPantsBuff = 0.6f;

        [Section("Reset Settings")]
        [Name("Reset To Default")]
        [Description("Resets all settings to Default. [Requires scene reload.]")]
        public bool ResetSettings = false;

        protected override void OnConfirm()
        {
            ApplyReset();
            instance.ResetSettings = false;
            base.OnConfirm();
        }
        public static void ApplyReset()
        {
            if (instance.ResetSettings == true)
            {
                 //Lower Body Section
                instance.CargoPantsBonus = 1f;
                instance.CombatPantsBonus = 1f;
                instance.JeansBuff = 0.6f;
                instance.MinersPantsBuff = 0.6f;
                instance.WorkPantsBuff = 0.6f;
                instance.SnowPantsBuff = 0.6f;
                instance.WolfSkinBuff = 0f;
                instance.DeerSkinBonus = 0f;
                 //Upper Body Section
                instance.Bearskinbouns = 0f;
                instance.CowichanBonus = 0f;
                instance.DownVestBonus = 0.4f;
                instance.DressShirtBonus = 0f;
                instance.ExParkaBonus = 0.5f;
                instance.christmasSweaterBonus = 0f;
                instance.FisherManSweaterBonus = 0f;
                instance.FlightJacketBonus = 0.4f;
                instance.HockeyBonus = 0f;
                instance.HoodieBonus = 0f;
                instance.SkiJacketbonus = 0.4f;
                instance.MackinawBonus = 0.6f;
                instance.QualWinterCoatBonus = 0.4f;
                instance.MilitaryParkaBonus = 0.6f;
                instance.MinerJacketBonus = 0.5f;
                instance.MooseCoatbonus = 0f;
                instance.HeavyParkaBonus = 0.4f;
                instance.ShirtSquareBonus = 0.1f;
                instance.LightParkaBonus = 0.5f;
                instance.DownSkiJacketBonus = 0.6f;
                instance.SportVestBonus = 0.2f;
                instance.Sweatshirtbonus = 0f;
                instance.TacticalJacketBonus = 0.8f;
                instance.HeavyWoolSweaterBonus = 0f;
                instance.WoolSweaterBonus = 0f;
                instance.TshirtBonus = 0f;
                instance.DownParkaBonus = 0.4f;
                instance.BasicWinterCoatbonus = 0.4f;
                instance.WolfSkinBonus = 0f;
                instance.WoolShirtBonus = 0.1f;
                // Accessories + Mod Compatibility
                instance.MooseSatchel = 5f;
                instance.SatchelM = 2f;
                instance.DeerSling = 2.3f;
                instance.RabbitPocket = 0.6f;
                instance.DeerskinCoat = 0f;
            }
        }
    }
}
