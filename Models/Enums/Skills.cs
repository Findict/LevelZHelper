namespace LevelZHelper.Models.Enums
{
    internal enum Skills
    {
        None = 0,
        Health,
        Strength,
        Agility,
        Defense,
        Stamina,
        Luck,
        Archery,
        Trade,
        Smithing,
        Mining,
        Farming,
        Alchemy
    }

    internal static class SkillsExtensions
    {
        internal static Skills ToSkills(this string skillString)
        {
            switch (skillString.ToLower())
            {
                case "health":
                    return Skills.Health;
                case "strength":
                    return Skills.Strength;
                case "agility":
                    return Skills.Agility;
                case "defense":
                    return Skills.Defense;
                case "stamina":
                    return Skills.Stamina;
                case "luck":
                    return Skills.Luck;
                case "archery":
                    return Skills.Archery;
                case "trade":
                    return Skills.Trade;
                case "smithing":
                    return Skills.Smithing;
                case "mining":
                    return Skills.Mining;
                case "farming":
                    return Skills.Farming;
                case "alchemy":
                    return Skills.Alchemy;
                default:
                    return Skills.None;
            }
        }
    }
}
