namespace LevelZHelper.Models.Enums
{
    [Flags]
    internal enum EditFields
    {
        ModKey = 1,
        Name = 1 << 1,
        Level = 1 << 2,
        Skill = 1 << 3,
        Material = 1 << 4,
        ToSmithing = 1 << 5,
    }
}
