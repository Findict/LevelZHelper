using System.Diagnostics.CodeAnalysis;
using LevelZHelper.Models.LevelConfigs;
using LevelZHelper.Models.LevelConfigs.Interfaces;

namespace LevelZHelper.Helpers.EqualityComparers
{
    internal class LevelConfigEqualityComparer : IEqualityComparer<ILevelConfig>
    {
        public bool Equals(ILevelConfig? x, ILevelConfig? y)
        {
            if (x == null && y == null) return true;

            if (x == null || y == null) return false;

            return x.ConfigType == y.ConfigType &&
                   x.ModId == y.ModId &&
                   x.Name == y.Name &&
                   (x is not MaterialItemLevelConfig || x.Material == y.Material);
        }

        public int GetHashCode([DisallowNull] ILevelConfig obj)
        {
            return (int)((int)obj.ConfigType +
             17 * obj.ModId?.GetHashCode() ?? -1 +
             Math.Pow(17, 2) * obj.Name.GetHashCode() +
             Math.Pow(17, 3) * (obj is MaterialItemLevelConfig ? obj.Material?.GetHashCode() ?? -2 : -1));
        }
    }
}
