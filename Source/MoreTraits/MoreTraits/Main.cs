using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace MoreTraits
{
    public class MoreTraitsInit : Mod
    {
        public MoreTraitsInit(ModContentPack contentPack) : base(contentPack)
        {
            Log.Message("[MoreTraits] Initialized successfully");
        }
    }
}
