namespace InfernoInfinity.Models.Weapons
{

    using Enums;

    class Knife : Weapon
    {

        #region Constants

        private const int MIN_DAMAGE = 3;
        private const int MAX_DAMAGE = 4;
        private const int SLOTS = 2;

        #endregion

        #region Constructors

        public Knife(WEAPON_RARITY _rarity, string _name)
            : base(MIN_DAMAGE, MAX_DAMAGE, _rarity, _name, SLOTS)
        {
        }

        #endregion

    }
}
