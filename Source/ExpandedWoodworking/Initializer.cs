using RimWorld;
using Verse;

namespace ExpandedWoodworking
{
    [StaticConstructorOnStartup]
    static class Initializer
    {
        static Initializer()
        {
            PlaceholderLogPatcher placeholderLogPatcher = new PlaceholderLogPatcher();
            placeholderLogPatcher.Patcher();
        }
    }
}
