namespace InfernoInfinity.Models.Weapons
{

    using Enums;
    using Interfaces;

    class Weapon : IWeapon
    {

        #region Private vars

        private int minDamage;
        private int maxDamage;

        private int originalMinDamage;
        private int originalMaxDamage;

        private int numberOfSockets;

        private int strength;
        private int agility;
        private int vitality;

        private string name;
        private WEAPON_RARITY rarity;

        private IGem[] gems;

        #endregion

        #region Constructors

        protected Weapon(int _minDamage, int _maxDamage, WEAPON_RARITY rarity, string name, int slots)
        {
            this.Rarity = rarity;
            this.originalMinDamage = _minDamage;
            this.originalMaxDamage = _maxDamage;
            this.Name = name;
            this.gems = new IGem[slots];
        }

        #endregion

        #region Public Fields

        public IGem[] Gems
        {
            get { return gems; }
        }

        public WEAPON_RARITY Rarity
        {
            get { return rarity; }
            set { rarity = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Vitality
        {
            get { return vitality; }
            set { vitality = value; }
        }

        public int Agility
        {
            get { return agility; }
            set { agility = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int NumberOfSockets
        {
            get { return numberOfSockets; }
            set { numberOfSockets = value; }
        }

        public int MaxDamage
        {
            get { return maxDamage; }
            set { maxDamage = value; }
        }

        public int MinDamage
        {
            get { return minDamage; }
            set { minDamage = value; }
        }

        #endregion

        #region Utils

        public void RefreshWeaponProperties()
        {
            this.minDamage = this.originalMinDamage * (int)rarity;
            this.maxDamage = this.originalMaxDamage * (int)rarity;
            this.Strength = 0;
            this.Agility = 0;
            this.Vitality = 0;
            foreach (var gem in this.gems)
            {
                if (gem == null) 
                {
                    continue;
                }
                this.Strength += gem.Strength;
                this.Agility += gem.Agility;
                this.Vitality += gem.Vitality;

                this.minDamage += gem.Strength * 2 + gem.Agility * 1;
                this.maxDamage += gem.Strength * 3 + gem.Agility * 4;
            }
        }

        public void ModifyGemAtIndex(IGem gem, int index)
        {
            if (index >= 0 && index < this.Gems.Length)
            {
                this.Gems[index] = gem;
            }
        }

        public void RemoveGemAtIndex(int index)
        {
            if (index >= 0 && index < this.Gems.Length)
            {
                IGem gem = this.Gems[index];
                if (gem != null)
                {
                    this.gems[index] = null;
                }
            }
        }

        public override string ToString()
        {
            this.RefreshWeaponProperties();
            return string.Format("{0}: {1}-{2} Damage, +{3} Strength, +{4} Agility, +{5} Vitality", this.Name, this.MinDamage, this.MaxDamage, this.Strength, this.Agility, this.Vitality);
        }

        #endregion 

    }
}
