using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace MoreTraits.Thoughts
{
    public class ThoughtWorker_OptimistPlus : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            if (p.story.traits.HasTrait(TraitDef.Named("OptimistPlus")))
            {
                Log.Message("OptimistPlus trait is active, triggering thought.");

                var socialSkill = p.skills.GetSkill(SkillDefOf.Social);
                Log.Message($"Social skill before adjustment: {p.skills.GetSkill(SkillDefOf.Social).Level}");
                if (socialSkill != null)
                {
                    socialSkill.Level = Mathf.Max(0, socialSkill.Level - 1);
                    Log.Message($"Social skill after adjustment: {p.skills.GetSkill(SkillDefOf.Social).Level}");
                }

                return ThoughtState.ActiveDefault;
            }
            return ThoughtState.Inactive;
        }
    }
}
