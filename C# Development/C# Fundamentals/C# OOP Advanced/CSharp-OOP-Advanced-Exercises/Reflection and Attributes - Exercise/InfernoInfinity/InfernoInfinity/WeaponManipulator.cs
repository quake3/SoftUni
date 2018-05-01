namespace InfernoInfinity
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Interfaces;
    using Enums;
    using Models.Weapons;

    public class WeaponManipulator
    {

        private static List<IWeapon> weapons = new List<IWeapon>();

        public static void CreateWeapon(string[] inputTokens)
        {
            string[] weaponStringArr = inputTokens[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var weaponRarityString = weaponStringArr[0];
            var weaponTypeString = weaponStringArr[1];

            WEAPON_RARITY weaponRarity = (WEAPON_RARITY)Enum.Parse(typeof(WEAPON_RARITY), weaponRarityString);

            Type weaponType = Type.GetType("InfernoInfinity.Models.Weapons." + weaponTypeString);
            if (weaponType == null)
            {
                throw new ArgumentException("Invalid Weapon Type!");
            }

            if (!typeof(IWeapon).IsAssignableFrom(weaponType))
            {
                throw new ArgumentException("Invalid Weapon!");
            }

            IWeapon weapon = (IWeapon)Activator.CreateInstance(weaponType, new object[] { weaponRarity, inputTokens[2] });
            weapons.Add(weapon);
        }

        public static void PrintWeapon(string[] inputTokens)
        {
            string weaponName = inputTokens[1];
            IWeapon weapon = weapons.FirstOrDefault(x => x.Name == weaponName);
            if (weapon != null)
            {
                Console.WriteLine(weapon);
            }
        }

        public static void InsertGem(string[] inputTokens)
        {
            string weaponName = inputTokens[1];
            IWeapon weapon = weapons.First(x => x.Name == weaponName);
            int socketIndex = int.Parse(inputTokens[2]);

            string[] gemTokens = inputTokens[3].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var qualityStringArr = gemTokens[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var gemQualityString = qualityStringArr[0];
            var gemTypeString = qualityStringArr[1];

            GEM_QUALITY quality = (GEM_QUALITY)Enum.Parse(typeof(GEM_QUALITY), gemQualityString);

            Type gemType = Type.GetType("InfernoInfinity.Models.Gems." + gemTypeString);

            if (gemType == null)
            {
                throw new ArgumentException("Invalid Gem Type!");
            }

            if (!typeof(IGem).IsAssignableFrom(gemType))
            {
                throw new ArgumentException("Invalid Gem!");
            }

            IGem gem = (IGem)Activator.CreateInstance(gemType, new object[] { quality });
            weapon.ModifyGemAtIndex(gem, socketIndex);

        }

        public static void RemoveGem(string[] inputTokens)
        {
            string weaponName = inputTokens[1];
            int socketIndex = int.Parse(inputTokens[2]);

            IWeapon weapon = weapons.First(x => x.Name == weaponName);
            weapon.RemoveGemAtIndex(socketIndex);
        }

    }
}
