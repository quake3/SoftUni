namespace InfernoInfinity.Models.Gems
{

    using Interfaces;
    using Enums;

    class Gem : IGem
    {

        #region Private vars

        private int strength;
        private int agility;
        private int vitality;
        private GEM_QUALITY gemQuality;

        #endregion

        #region Constructors

        public Gem(int _strength, int _agility, int _vitality, GEM_QUALITY _gemQuality)
        {
            this.strength = _strength;
            this.agility = _agility;
            this.vitality = _vitality;
            this.gemQuality = _gemQuality;
        }

        #endregion

        #region Public Fields

        public GEM_QUALITY GemQuality
        {
            get { return gemQuality; }
            set { gemQuality = value; }
        }

        public int Vitality
        {
            get { return vitality + (int)this.gemQuality; }
            set { vitality = value; }
        }

        public int Agility
        {
            get { return agility + (int)this.gemQuality; }
            set { agility = value; }
        }

        public int Strength
        {
            get { return strength + (int)this.gemQuality; }
            set { strength = value; }
        }

        #endregion


    }
}
