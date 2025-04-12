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

                return ThoughtState.ActiveDefault;
            }
            return ThoughtState.Inactive;
        }
    }
}
