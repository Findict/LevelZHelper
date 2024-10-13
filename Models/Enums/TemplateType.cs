using System.Runtime.Serialization;

namespace LevelZHelper.Models.Enums
{
    internal enum TemplateType
    {
        Armor,
        [EnumMember(Value = "Material tool set")]
        MaterialToolSet
    }
}
