namespace InfernoInfinity.Models.Weapons
{

    using Enums;

    class Axe:Weapon
    {

        #region Constants

        private const int MIN_DAMAGE = 5;
        private const int MAX_DAMAGE = 10;
        private const int SLOTS = 4;

        #endregion

        #region Constructors

        public Axe(WEAPON_RARITY _rarity, string _name)
            : base(MIN_DAMAGE, MAX_DAMAGE, _rarity, _name, SLOTS)
        {
        }

        #endregion

    }
}
