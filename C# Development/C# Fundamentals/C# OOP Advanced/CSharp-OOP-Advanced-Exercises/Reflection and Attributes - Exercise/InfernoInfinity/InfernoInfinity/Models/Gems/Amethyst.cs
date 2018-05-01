namespace InfernoInfinity.Models.Gems
{

    using Enums;

    class Amethyst : Gem
    {

        #region Constants

        private const int STRENGTH = 2;
        private const int AGILITY = 8;
        private const int VITALITY = 4;

        #endregion

        #region Constructors

        public Amethyst(GEM_QUALITY _gemQuality)
            : base(STRENGTH, AGILITY, VITALITY, _gemQuality)
        {
        }

        #endregion
    }

}
