namespace InfernoInfinity.Models.Gems
{

    using Enums;

    class Ruby : Gem
    {

        #region Constants

        private const int STRENGTH = 7;
        private const int AGILITY = 2;
        private const int VITALITY = 5;

        #endregion

        #region Constructors

        public Ruby(GEM_QUALITY _gemQuality)
            : base(STRENGTH, AGILITY, VITALITY, _gemQuality)
        {
        }

        #endregion

    }
}
