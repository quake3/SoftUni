namespace InfernoInfinity
{

    using System;
    using System.Collections.Generic;

    using Interfaces;

    class Program
    {

        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputTokens = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (inputTokens[0])
                    {
                        case "Create":
                            WeaponManipulator.CreateWeapon(inputTokens);
                            break;
                        case "Add":
                            WeaponManipulator.InsertGem(inputTokens);
                            break;
                        case "Remove":
                            WeaponManipulator.RemoveGem(inputTokens);
                            break;
                        case "Print":
                            WeaponManipulator.PrintWeapon(inputTokens);
                            break;
                        default:
                            throw new ArgumentException(string.Format("Invalid Command: {0}!", inputTokens[0]));
                    }
                }
                catch (Exception)
                {

                }
            }
        
        }

    }
}
