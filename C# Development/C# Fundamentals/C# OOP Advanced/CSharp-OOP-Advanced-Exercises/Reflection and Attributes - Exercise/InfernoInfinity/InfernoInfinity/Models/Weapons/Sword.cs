namespace InfernoInfinity.Models.Weapons
{

    using Enums;

    class Sword : Weapon
    {

        #region Constants

        private const int MIN_DAMAGE = 4;
        private const int MAX_DAMAGE = 6;
        private const int SLOTS = 3;

        #endregion

        #region Constructors

        public Sword(WEAPON_RARITY _rarity, string _name)
            : base(MIN_DAMAGE, MAX_DAMAGE, _rarity, _name, SLOTS)
        {
        }

        #endregion

    }
}
