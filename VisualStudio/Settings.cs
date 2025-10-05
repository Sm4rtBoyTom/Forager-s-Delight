using System.Reflection;
using System.Text.Json.Serialization;
using ModSettings;

namespace ForagersDelightMod
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Upper Body")]

        [Name("Bearskin Coat")]
        [Description("Enables Carry Weight bonus for Bearskin Coat. Default - false")]
        public bool BearskinCoat = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float Bearskinbouns = 0f;

        [Name("Cowichan Sweater")]
        [Description("Enables Carry Weight bonus for Cowichan Sweater. Default - false")]
        public bool Cowichan = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float CowichanBonus = 0f;

        [Name("Down Vest")]
        [Description("Enables Carry Weight bonus for Down Vest. Default - true")]
        public bool DownVest = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2.kg.")]
        [Slider(0f, 2f, 21)]
        public float DownVestBonus = 0.4f;

        [Name("Dress Shirt")]
        [Description("Enables Carry Weight bonus for Dress Shirt. Default - false")]
        public bool DressShirt = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float DressShirtBonus = 0f;

        [Name("Expedition Parka")]
        [Description("Enables Carry Weight bonus for Expedition Parka. Default - true")]
        public bool ExParka = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.25kg.")]
        [Slider(0f, 2f, 21)]
        public float ExParkaBonus = 0.5f;

        [Name("Festive Sweater")]
        [Description("Enables Carry Weight bonus for Festive Sweater. Default - false")]
        public bool ChristmasSweater = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float christmasSweaterBonus = 0f;

        [Name("Fisherman's Sweater")]
        [Description("Enables Carry Weight bonus for Fisherman's Sweater. Default - false")]
        public bool FisherManSweater = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float FisherManSweaterBonus = 0f;

        [Name("Flight Jacket")]
        [Description("Enables Carry Weight bonus for Flight Jacket. Default - true")]
        public bool FlightJacket = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.4kg.")]
        [Slider(0f, 2f, 21)]
        public float FlightJacketBonus = 0.4f;

        [Name("Hockey jersey")]
        [Description("Enables Carry Weight bonus for Hockey Jersey. Default - false")]
        public bool Hockey = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float HockeyBonus = 0f;

        [Name("Hoodie")]
        [Description("Enables Carry Weight bonus for Hoodie. Default - false")]
        public bool Hoodie = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float HoodieBonus = 0f;

        [Name("Light Shell")]
        [Description("Enables Carry Weight bonus for Light Shell. Default - true")]
        public bool SkiJacket = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2kg.")]
        [Slider(0f, 2f, 21)]
        public float SkiJacketbonus = 0.4f;

        [Name("Mackinaw Jacket")]
        [Description("Enables Carry Weight bonus for Mackinaw Jacket. Default - true")]
        public bool Mackinaw = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.3kg.")]
        [Slider(0f, 2f, 21)]
        public float MackinawBonus = 0.6f;

        [Name("Mariner's Pea Coat")]
        [Description("Enables Carry Weight bonus for Mariner's Pea Coat. Default - true")]
        public bool QualityWinterCoat = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2kg.")]
        [Slider(0f, 2f, 21)]
        public float QualWinterCoatBonus = 0.4f;

        [Name("Military Coat")]
        [Description("Enables Carry Weight bonus for Military Coat. Default - true")]
        public bool MilitaryParka = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.3kg.")]
        [Slider(0f, 2f, 21)]
        public float MilitaryParkaBonus = 0.6f;

        [Name("Miner'S Jacket")]
        [Description("Enables Carry Weight bonus for Miner's Jacket. Default - true")]
        public bool MinerJacket = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.25kg.")]
        [Slider(0f, 2f, 21)]
        public float MinerJacketBonus = 0.5f;

        [Name("Moose-Hide Cloak")]
        [Description("Enables Carry Weight bonus for Moose-Hide Cloak. Default - false")]
        public bool MooseCoat = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float MooseCoatbonus = 0f;

        [Name("Old Fashioned Parka")]
        [Description("Enables Carry Weight bonus for Old Fashioned Parka. Default - true")]
        public bool HeavyParka = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2kg.")]
        [Slider(0f, 2f, 21)]
        public float HeavyParkaBonus = 0.4f;

        [Name("Plaid Shirt")]
        [Description("Enables Carry Weight bonus for Plaid Shirt. Default - true")]
        public bool ShirtSquare = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.05kg.")]
        [Slider(0f, 2f, 21)]
        public float ShirtSquareBonus = 0.1f;

        [Name("Simple Parka")]
        [Description("Enables Carry Weight bonus for Simple Parka. Default - true")]
        public bool LightParka = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.25kg.")]
        [Slider(0f, 2f, 21)]
        public float LightParkaBonus = 0.5f;

        [Name("Ski Jacket")]
        [Description("Enables Carry Weight bonus for Ski Jacket. Default - true")]
        public bool DownSkiJacket = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.3kg.")]
        [Slider(0f, 2f, 21)]
        public float DownSkiJacketBonus = 0.6f;

        [Name("Sport Vest")]
        [Description("Enables Carry Weight bonus for Sport Vest. Default - true")]
        public bool SportVest = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.1kg.")]
        [Slider(0f, 2f, 21)]
        public float SportVestBonus = 0.2f;

        [Name("Sweatshirt")]
        [Description("Enables Carry Weight bonus for sweatshirt. Default - false")]
        public bool Sweatshirt = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float Sweatshirtbonus = 0f;

        [Name("Tactical jacket")]
        [Description("Enables Carry Weight bonus for Tactical Jacket. Default - true")]
        public bool TacticalJacket = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.4kg.")]
        [Slider(0f, 2f, 21)]
        public float TacticalJacketBonus = 0.8f;

        [Name("Thick Wool Sweater")]
        [Description("Enables Carry Weight bonus for Thick Wool Sweater. Default - false")]
        public bool HeavyWoolSweater = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float HeavyWoolSweaterBonus = 0f;

        [Name("Thin Wool Sweater")]
        [Description("Enables Carry Weight bonus for Thin Wool Sweater. Default - false")]
        public bool WoolSweater = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float WoolSweaterBonus = 0f;

        [Name("T-Shirt")]
        [Description("Enables Carry Weight bonus for T-Shirt. Default - false")]
        public bool TShirt = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float TshirtBonus = 0f;

        [Name("Urban Parka")]
        [Description("Enables Carry Weight bonus for Urban Parka. Default - true")]
        public bool DownParka = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2kg.")]
        [Slider(0f, 2f, 21)]
        public float DownParkaBonus = 0.4f;

        [Name("Windbreaker")]
        [Description("Enables Carry Weight bonus for WindBreaker. Default - true")]
        public bool BasicWinterCoat = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.2kg.")]
        [Slider(0f, 2f, 21)]
        public float BasicWinterCoatbonus = 0.4f;

        [Name("Wolfskin Coat")]
        [Description("Enables Carry Weight bonus for Wolfskin Coat. Default - false")]
        public bool WolfSkin = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0kg.")]
        [Slider(0f, 2f, 21)]
        public float WolfSkinBonus = 0f;

        [Name("Wool Shirt")]
        [Description("Enables Carry Weight bonus for Wolf Shirt. Default - true")]
        public bool WoolShirt = false;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.05kg.")]
        [Slider(0f, 2f, 21)]
        public float WoolShirtBonus = 0f;


        [Section("Lower Body")]

        [Name("Cargo Pants")]
        [Description("Enables Carry Weight bonus for cargo pants. Default - true")]
        public bool CargoPants = true;

        [Name("Weight Bonus")]
        [Description("Carry Weight Bonus in kilograms. Default  0.5kg.")]
        [Slider(0f, 2f, 21)]
        public float CargoPantsBonus = 0.5f;

        [Name("Combat Pants")]
        [Description("Enables Carry Weight bonus for Combat pants. Default - true")]
        public bool CombatPants = true;

        [Name("Weight bonus")]
        [Description("Carry Weight Bonus in KG. Default - 0.5Kg")]
        [Slider(0f, 2f, 21)]
        public float CombatPantsBonus = 1f;

        [Name("Deerskin Pants")]
        [Description("Enables Carry Weight bonus for Deerskin Pants. Default - false")]
        public bool DeerSkinPants = false;

        [Name("Weight bonus")]
        [Description("Carry Weight Bonus in KG. Default - 0Kg")]
        [Slider(0f, 2f, 21)]
        public float DeerSkinBonus = 0f;

        [Name("Jeans")]
        [Description("Enables Carry Weight bonus for Jeans. Default - true")]
        public bool Jeans = true;

        [Name("Weight bonus")]
        [Description("Carry Weight Bonus in KG. Default - 0.3Kg")]
        [Slider(0f, 2f, 21)]
        public float JeansBuff = 0.6f;

        [Name("Miner's Pants")]
        [Description("Enables Carry Weight bonus for Miner's Pants. Default - true")]
        public bool MinersPants = true;

        [Name("Weight bonus")]
        [Description("Carry Weight Bonus in KG. Default - 0.3Kg")]
        [Slider(0f, 2f, 21)]
        public float MinersPantsBuff = 0.6f;

        [Name("Snow Pants")]
        [Description("Enables Carry Weight bonus for Work Pants. Default - true")]
        public bool SnowPants = true;

        [Name("Weight bonus")]
        [Description("Carry Weight Bonus in KG. Default - 0.3Kg")]
        [Slider(0f, 2f, 21)]
        public float SnowPantsBuff = 0.6f;

        [Name("Wolfskin Pants")]
        [Description("Enables Carry Weight bonus for Wolfskin Pants. Default - false")]
        public bool WolfSkinPants = false;

        [Name("Weight bonus")]
        [Description("Carry Weight Bonus in KG. Default - 0Kg")]
        [Slider(0f, 2f, 21)]
        public float WolfSkinBuff = 0f;

        [Name("Work Pants")]
        [Description("Enables Carry Weight bonus for Work Pants. Default - true")]
        public bool WorkPants = true;

        [Name("Weight bonus")]
        [Description("Carry Weight Bonus in KG. Default - 0.3Kg")]
        [Slider(0f, 2f, 21)]
        public float WorkPantsBuff = 0.6f;

        [Section("Reset Settings")]
        [Name("Reset To Default")]
        [Description("Resets all settings to Default. [Requires scene reload.]")]
        public bool ResetSettings = false;

        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue) => RefreshFields();

        protected override void OnConfirm()
        {
            ApplyReset();
            instance.ResetSettings = false;
            base.OnConfirm();
            RefreshGUI();
        }

        internal static void OnLoad()
        {
            instance.RefreshFields();
        }

        internal void RefreshFields()
        {
            if (instance.CargoPants == true) //Lower Body Section
            {
                SetFieldVisible(nameof(instance.CargoPantsBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.CargoPantsBonus), false);
            }
            if (instance.CombatPants == true)
            {
                SetFieldVisible(nameof(instance.CombatPantsBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.CombatPantsBonus), false);
            }
            if (instance.Jeans == true)
            {
                SetFieldVisible(nameof(instance.JeansBuff), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.JeansBuff), false);
            }
            if (instance.MinersPants == true)
            {
                SetFieldVisible(nameof(instance.MinersPantsBuff), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.MinersPantsBuff), false);
            }
            if (instance.WorkPants == true)
            {
                SetFieldVisible(nameof(instance.WorkPantsBuff), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.WorkPantsBuff), false);
            }
            if (instance.SnowPants == true)
            {
                SetFieldVisible(nameof(instance.SnowPantsBuff), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.SnowPantsBuff), false);
            }
            if (instance.WolfSkinPants == true)
            {
                SetFieldVisible(nameof(instance.WolfSkinBuff), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.WolfSkinBuff), false);
            }
            if (instance.DeerSkinPants == true)
            {
                SetFieldVisible(nameof(instance.DeerSkinBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.DeerSkinBonus), false);
            }
            if (instance.BearskinCoat == true) //Upper body section
            {
                SetFieldVisible(nameof(instance.Bearskinbouns), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.Bearskinbouns), false);
            }
            if (instance.Cowichan == true)
            {
                SetFieldVisible(nameof(instance.CowichanBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.CowichanBonus), false);
            }
            if (instance.DownVest == true)
            {
                SetFieldVisible(nameof(instance.DownVestBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.DownVestBonus), false);
            }
            if (instance.DressShirt == true)
            {
                SetFieldVisible(nameof(instance.DressShirtBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.DressShirtBonus), false);
            }
            if (instance.ExParka == true)
            {
                SetFieldVisible(nameof(instance.ExParkaBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.ExParkaBonus), false);
            }
            if (instance.ChristmasSweater == true)
            {
                SetFieldVisible(nameof(instance.christmasSweaterBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.christmasSweaterBonus), false);
            }
            if (instance.FisherManSweater == true)
            {
                SetFieldVisible(nameof(instance.FisherManSweaterBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.FisherManSweaterBonus), false);
            }
            if (instance.FlightJacket == true)
            {
                SetFieldVisible(nameof(instance.FlightJacketBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.FlightJacketBonus), false);
            }
            if (instance.Hockey == true)
            {
                SetFieldVisible(nameof(instance.HockeyBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.HockeyBonus), false);
            }
            if (instance.Hoodie == true)
            {
                SetFieldVisible(nameof(instance.HoodieBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.HoodieBonus), false);
            }
            if (instance.SkiJacket == true)
            {
                SetFieldVisible(nameof(instance.SkiJacketbonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.SkiJacketbonus), false);
            }
            if (instance.Mackinaw == true)
            {
                SetFieldVisible(nameof(instance.MackinawBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.MackinawBonus), false);
            }
            if (instance.QualityWinterCoat == true)
            {
                SetFieldVisible(nameof(instance.QualWinterCoatBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.QualWinterCoatBonus), false);
            }
            if (instance.MilitaryParka == true)
            {
                SetFieldVisible(nameof(instance.MilitaryParkaBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.MilitaryParkaBonus), false);
            }
            if (instance.MinerJacket == true)
            {
                SetFieldVisible(nameof(instance.MinerJacketBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.MinerJacketBonus), false);
            }
            if (instance.MooseCoat == true)
            {
                SetFieldVisible(nameof(instance.MooseCoatbonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.MooseCoatbonus), false);
            }
            if (instance.HeavyParka == true)
            {
                SetFieldVisible(nameof(instance.HeavyParkaBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.HeavyParkaBonus), false);
            }
            if (instance.ShirtSquare == true)
            {
                SetFieldVisible(nameof(instance.ShirtSquareBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.ShirtSquareBonus), false);
            }
            if (instance.LightParka == true)
            {
                SetFieldVisible(nameof(instance.LightParkaBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.LightParkaBonus), false);
            }
            if (instance.DownSkiJacket == true)
            {
                SetFieldVisible(nameof(instance.DownSkiJacketBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.DownSkiJacketBonus), false);
            }
            if (instance.SportVest == true)
            {
                SetFieldVisible(nameof(instance.SportVestBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.SportVestBonus), false);
            }
            if (instance.Sweatshirt == true)
            {
                SetFieldVisible(nameof(instance.Sweatshirtbonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.Sweatshirtbonus), false);
            }
            if (instance.TacticalJacket == true)
            {
                SetFieldVisible(nameof(instance.TacticalJacketBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.TacticalJacketBonus), false);
            }
            if (instance.HeavyWoolSweater == true)
            {
                SetFieldVisible(nameof(instance.HeavyWoolSweaterBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.HeavyWoolSweaterBonus), false);
            }
            if (instance.WoolSweater == true)
            {
                SetFieldVisible(nameof(instance.WoolSweaterBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.WoolSweaterBonus), false);
            }
            if (instance.TShirt == true)
            {
                SetFieldVisible(nameof(instance.TshirtBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.TshirtBonus), false);
            }
            if (instance.DownParka == true)
            {
                SetFieldVisible(nameof(instance.DownParkaBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.DownParkaBonus), false);
            }
            if (instance.BasicWinterCoat == true)
            {
                SetFieldVisible(nameof(instance.BasicWinterCoatbonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.BasicWinterCoatbonus), false);
            }
            if (instance.WolfSkin == true)
            {
                SetFieldVisible(nameof(instance.WolfSkinBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.WolfSkinBonus), false);
            }
            if (instance.WoolShirt == true)
            {
                SetFieldVisible(nameof(instance.WoolShirtBonus), true);
            }
            else
            {
                SetFieldVisible(nameof(instance.WoolShirtBonus), false);
            }

        }

        public static void ApplyReset()
        {
            if (instance.ResetSettings == true)
            {
                instance.CargoPants = true; //Lower Body Section
                instance.CargoPantsBonus = 1f;
                instance.CombatPants = true;
                instance.CombatPantsBonus = 1f;
                instance.Jeans = true;
                instance.JeansBuff = 0.6f;
                instance.MinersPants = true;
                instance.MinersPantsBuff = 0.6f;
                instance.WorkPants = true;
                instance.WorkPantsBuff = 0.6f;
                instance.SnowPants = true;
                instance.SnowPantsBuff = 0.6f;
                instance.WolfSkinPants = false;
                instance.WolfSkinBuff = 0f;
                instance.DeerSkinPants = false;
                instance.DeerSkinBonus = 0f;
                instance.BearskinCoat = false; //Upper Body Section
                instance.Bearskinbouns = 0f;
                instance.Cowichan = false;
                instance.CowichanBonus = 0f;
                instance.DownVest = true;
                instance.DownVestBonus = 0.4f;
                instance.DressShirt = false;
                instance.DressShirtBonus = 0f;
                instance.ExParka = true;
                instance.ExParkaBonus = 0.5f;
                instance.ChristmasSweater = false;
                instance.christmasSweaterBonus = 0f;
                instance.FisherManSweater = false;
                instance.FisherManSweaterBonus = 0f;
                instance.FlightJacket = true;
                instance.FlightJacketBonus = 0.4f;
                instance.Hockey = false;
                instance.HockeyBonus = 0f;
                instance.Hoodie = false;
                instance.HoodieBonus = 0f;
                instance.SkiJacket = true;
                instance.SkiJacketbonus = 0.4f;
                instance.Mackinaw = true;
                instance.MackinawBonus = 0.6f;
                instance.QualityWinterCoat = true;
                instance.QualWinterCoatBonus = 0.4f;
                instance.MilitaryParka = true;
                instance.MilitaryParkaBonus = 0.6f;
                instance.MinerJacket = true;
                instance.MinerJacketBonus = 0.5f;
                instance.MooseCoat = false;
                instance.MooseCoatbonus = 0f;
                instance.HeavyParka = true;
                instance.HeavyParkaBonus = 0.4f;
                instance.ShirtSquare = true;
                instance.ShirtSquareBonus = 0.1f;
                instance.LightParka = true;
                instance.LightParkaBonus = 0.5f;
                instance.DownSkiJacket = true;
                instance.DownSkiJacketBonus = 0.6f;
                instance.SportVest = true;
                instance.SportVestBonus = 0.2f;
                instance.Sweatshirt = false;
                instance.Sweatshirtbonus = 0f;
                instance.TacticalJacket = true;
                instance.TacticalJacketBonus = 0.8f;
                instance.HeavyWoolSweater = false;
                instance.HeavyWoolSweaterBonus = 0f;
                instance.WoolSweater = false;
                instance.WoolSweaterBonus = 0f;
                instance.TShirt = false;
                instance.TshirtBonus = 0f;
                instance.DownParka = true;
                instance.DownParkaBonus = 0.4f;
                instance.BasicWinterCoat = true;
                instance.BasicWinterCoatbonus = 0.4f;
                instance.WolfSkin = false;
                instance.WolfSkinBonus = 0f;
                instance.WoolShirt = true;
                instance.WoolShirtBonus = 0.1f;

            }
        }
    }
}
