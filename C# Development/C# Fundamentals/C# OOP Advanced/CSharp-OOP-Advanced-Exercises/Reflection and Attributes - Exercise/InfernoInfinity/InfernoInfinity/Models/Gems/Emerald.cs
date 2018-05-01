namespace InfernoInfinity.Models.Gems
{

    using Enums;

    class Emerald : Gem
    {

        #region Constants

        private const int STRENGTH = 1;
        private const int AGILITY = 4;
        private const int VITALITY = 9;

        #endregion

        #region Constructors

        public Emerald(GEM_QUALITY _gemQuality)
            : base(STRENGTH, AGILITY, VITALITY, _gemQuality)
        {
        }

        #endregion

    }
}
