namespace InfernoInfinity.Interfaces
{

    using Enums;

    public interface IWeapon
    {
        string Name { get; set; }
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        IGem[] Gems { get; }
        int Strength { get; set; }
        int Agility { get; set; }
        int Vitality { get; set; }
        WEAPON_RARITY Rarity { get; set; }

        void ModifyGemAtIndex(IGem gem, int index);
        void RemoveGemAtIndex(int index);
    }
}
