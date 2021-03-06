// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2020 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using DaggerfallConnect;
using DaggerfallWorkshop.Game.Entity;

namespace DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects
{
    /// <summary>
    /// Invisibility - True
    /// </summary>
    public class InvisibilityTrue : ConcealmentEffect
    {
        public static readonly string EffectKey = "Invisibility-True";

        public override void SetProperties()
        {
            properties.Key = EffectKey;
            properties.ClassicKey = MakeClassicKey(13, 1);
            properties.GroupName = TextManager.Instance.GetText("ClassicEffects", "invisibility");
            properties.SubGroupName = TextManager.Instance.GetText("ClassicEffects", "true");
            properties.DisplayName = string.Format("{0} ({1})", properties.GroupName, properties.SubGroupName);
            properties.SpellMakerDescription = DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1561);
            properties.SpellBookDescription = DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1261);
            properties.SupportDuration = true;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_All;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_MagicOnly;
            properties.AllowedCraftingStations = MagicCraftingStations.SpellMaker;
            properties.MagicSkill = DFCareer.MagicSkills.Illusion;
            properties.DurationCosts = MakeEffectCosts(60, 140);
            concealmentFlag = MagicalConcealmentFlags.InvisibleTrue;
            startConcealmentMessageKey = "youAreInvisible";
        }

        protected override bool IsLikeKind(IncumbentEffect other)
        {
            return (other is InvisibilityTrue);
        }
    }
}
