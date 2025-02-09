namespace HOMM_2_Score_Calculator
{
    class ScoreCalculator
    {
        //Campaign score
        internal static string GetCampaignRating(int days)
        {
            string rating = "";
            switch (days)
            {
                case < 301:
                    rating = "Black Dragon";
                    break;
                case < 321:
                    rating = "Titan";
                    break;
                case < 341:
                    rating = "Red Dragon";
                    break;
                case < 361:
                    rating = "Green Dragon";
                    break;
                case < 381:
                    rating = "Bone Dragon";
                    break;
                case < 401:
                    rating = "Phoenix";
                    break;
                case < 421:
                    rating = "Giant";
                    break;
                case < 441:
                    rating = "Cyclops";
                    break;
                case < 461:
                    rating = "Crusader";
                    break;
                case < 481:
                    rating = "Genie";
                    break;
                case < 501:
                    rating = "Paladin";
                    break;
                case < 521:
                    rating = "Hydra";
                    break;
                case < 541:
                    rating = "Unicorn";
                    break;
                case < 561:
                    rating = "Power Lich";
                    break;
                case < 581:
                    rating = "Archmage";
                    break;
                case < 601:
                    rating = "Vampire Lord";
                    break;
                case < 621:
                    rating = "War Troll";
                    break;
                case < 641:
                    rating = "Champion";
                    break;
                case < 661:
                    rating = "Minotaur King";
                    break;
                case < 681:
                    rating = "Ogre Lord";
                    break;
                case < 701:
                    rating = "Lich";
                    break;
                case < 721:
                    rating = "Medusa";
                    break;
                case < 741:
                    rating = "Mage";
                    break;
                case < 761:
                    rating = "Troll";
                    break;
                case < 781:
                    rating = "Cavalry";
                    break;
                case < 801:
                    rating = "Minotaur";
                    break;
                case < 821:
                    rating = "Roc";
                    break;
                case < 841:
                    rating = "Earth Elemental";
                    break;
                case < 861:
                    rating = "Water Elemental";
                    break;
                case < 881:
                    rating = "Vampire";
                    break;
                case < 901:
                    rating = "Ghost";
                    break;
                case < 921:
                    rating = "Fire Elemental";
                    break;
                case < 941:
                    rating = "Greater Druid";
                    break;
                case < 961:
                    rating = "Air Elemental";
                    break;
                case < 981:
                    rating = "Master Swordsman";
                    break;
                case < 1001:
                    rating = "Steel Golem";
                    break;
                case < 1101:
                    rating = "Druid";
                    break;
                case < 1201:
                    rating = "Swordsman";
                    break;
                case < 1301:
                    rating = "Griffin";
                    break;
                case < 1401:
                    rating = "Ogre";
                    break;
                case < 1501:
                    rating = "Royal Mummy";
                    break;
                case < 1601:
                    rating = "Iron Golem";
                    break;
                case < 1701:
                    rating = "Mummy";
                    break;
                case < 1801:
                    rating = "Wolf";
                    break;
                case < 1901:
                    rating = "Veteran Pikeman";
                    break;
                case < 2001:
                    rating = "Nomad";
                    break;
                case < 2201:
                    rating = "Battle Dwarf";
                    break;
                case < 2401:
                    rating = "Grand Elf";
                    break;
                case < 2601:
                    rating = "Pikeman";
                    break;
                case < 2801:
                    rating = "Gargoyle";
                    break;
                case < 3001:
                    rating = "Elf";
                    break;
                case < 3201:
                    rating = "Orc Chief";
                    break;
                case < 3401:
                    rating = "Mutant Zombie";
                    break;
                case < 3601:
                    rating = "Dwarf";
                    break;
                case < 3801:
                    rating = "Boar";
                    break;
                case < 4001:
                    rating = "Ranger";
                    break;
                case < 4201:
                    rating = "Archer";
                    break;
                case < 4401:
                    rating = "Zombie";
                    break;
                case < 4601:
                    rating = "Orc";
                    break;
                case < 4801:
                    rating = "Skeleton";
                    break;
                case < 5001:
                    rating = "Rogue";
                    break;
                case < 5201:
                    rating = "Centaur";
                    break;
                case < 5401:
                    rating = "Halfling";
                    break;
                case < 5601:
                    rating = "Sprite";
                    break;
                case < 5801:
                    rating = "Goblin";
                    break;
                case > 5800:
                    rating = "Peasant";
                    break;
            }

            return rating;
        }


        //Standard score//

        //Count game days week + month + day
        internal static int CountDays(int day, int week, int month)
        {
            return (month - 1) * 28 + (week - 1) * 7 + day;
        }

        //days * mapsize
        internal static decimal CountGameDays(int gameDays, decimal mapSize)
        {
            return System.Math.Floor(gameDays * mapSize / 100);
        }

        //final days 0 - 180. With bool true 0-200
        internal static decimal CountFinalDays(decimal gameDays, bool lowLimitOff)
        {
            decimal finaldays = 0;
            if (gameDays <= 60)
            {
                finaldays += gameDays;
            }
            else if (gameDays <= 120)
            {
                finaldays += 60 + (gameDays - 60) / 2;
            }
            else if (gameDays <= 360)
            {
                finaldays += 90 + (gameDays - 120) / 4;
            }
            else if (gameDays <= 600)
            {
                finaldays += 150 + (gameDays - 360) / 8;
            }
            else if (gameDays > 600 && lowLimitOff)
            {
                finaldays += 150 + (gameDays - 360) / 8;
                if (finaldays > 200)
                {
                    finaldays = 200;
                }
            }
            else
            {
                finaldays = 180;
            }
            return System.Math.Ceiling(finaldays);
        }

        //difficulty 50% to 220%
        internal static int GetDifficulty(int mapDifficulty, int gameDifficulty)
        {
            return 50 + mapDifficulty + gameDifficulty;
        }

        //final score 
        internal static int FinalScore(decimal finaldays, int difficulty)
        {
            return System.Convert.ToInt32(System.Math.Floor((200 - finaldays) * difficulty / 100));
        }
        //monster rating
        internal static string GetStandardRating(int finalScore)
        {
            string rating = "";

            switch (finalScore)
            {
                case >= 228:
                    rating = "Black Dragon";
                    break;
                case >= 225:
                    rating = "Titan";
                    break;
                case >= 222:
                    rating = "Red Dragon";
                    break;
                case >= 219:
                    rating = "Green Dragon";
                    break;
                case >= 216:
                    rating = "Bone Dragon";
                    break;
                case >= 213:
                    rating = "Phoenix";
                    break;
                case >= 210:
                    rating = "Giant";
                    break;
                case >= 207:
                    rating = "Cyclops";
                    break;
                case >= 204:
                    rating = "Crusader";
                    break;
                case >= 201:
                    rating = "Genie";
                    break;
                case >= 198:
                    rating = "Paladin";
                    break;
                case >= 195:
                    rating = "Hydra";
                    break;
                case >= 192:
                    rating = "Unicorn";
                    break;
                case >= 189:
                    rating = "Power Lich";
                    break;
                case >= 186:
                    rating = "Archmage";
                    break;
                case >= 183:
                    rating = "Vampire Lord";
                    break;
                case >= 180:
                    rating = "War Troll";
                    break;
                case >= 177:
                    rating = "Champion";
                    break;
                case >= 174:
                    rating = "Minotaur King";
                    break;
                case >= 171:
                    rating = "Ogre Lord";
                    break;
                case >= 168:
                    rating = "Lich";
                    break;
                case >= 165:
                    rating = "Medusa";
                    break;
                case >= 162:
                    rating = "Mage";
                    break;
                case >= 159:
                    rating = "Troll";
                    break;
                case >= 156:
                    rating = "Cavalry";
                    break;
                case >= 153:
                    rating = "Minotaur";
                    break;
                case >= 150:
                    rating = "Roc";
                    break;
                case >= 147:
                    rating = "Earth Elemental";
                    break;
                case >= 144:
                    rating = "Water Elemental";
                    break;
                case >= 141:
                    rating = "Vampire";
                    break;
                case >= 138:
                    rating = "Ghost";
                    break;
                case >= 135:
                    rating = "Fire Elemental";
                    break;
                case >= 132:
                    rating = "Greater Druid";
                    break;
                case >= 128:
                    rating = "Air Elemental";
                    break;
                case >= 124:
                    rating = "Master Swordsman";
                    break;
                case >= 120:
                    rating = "Steel Golem";
                    break;
                case >= 116:
                    rating = "Druid";
                    break;
                case >= 112:
                    rating = "Swordsman";
                    break;
                case >= 108:
                    rating = "Griffin";
                    break;
                case >= 104:
                    rating = "Ogre";
                    break;
                case >= 100:
                    rating = "Royal Mummy";
                    break;
                case >= 96:
                    rating = "Iron Golem";
                    break;
                case >= 92:
                    rating = "Mummy";
                    break;
                case >= 88:
                    rating = "Wolf";
                    break;
                case >= 84:
                    rating = "Veteran Pikeman";
                    break;
                case >= 80:
                    rating = "Nomad";
                    break;
                case >= 76:
                    rating = "Battle Dwarf";
                    break;
                case >= 72:
                    rating = "Grand Elf";
                    break;
                case >= 68:
                    rating = "Pikeman";
                    break;
                case >= 64:
                    rating = "Gargoyle";
                    break;
                case >= 60:
                    rating = "Elf";
                    break;
                case >= 56:
                    rating = "Orc Chief";
                    break;
                case >= 52:
                    rating = "Mutant Zombie";
                    break;
                case >= 48:
                    rating = "Dwarf";
                    break;
                case >= 44:
                    rating = "Boar";
                    break;
                case >= 40:
                    rating = "Ranger";
                    break;
                case >= 36:
                    rating = "Archer";
                    break;
                case >= 32:
                    rating = "Zombie";
                    break;
                case >= 28:
                    rating = "Orc";
                    break;
                case >= 24:
                    rating = "Skeleton";
                    break;
                case >= 20:
                    rating = "Rogue";
                    break;
                case >= 16:
                    rating = "Centaur";
                    break;
                case >= 12:
                    rating = "Halfling";
                    break;
                case >= 8:
                    rating = "Sprite";
                    break;
                case >= 4:
                    rating = "Goblin";
                    break;
                case >= 0:
                    rating = "Peasant";
                    break;

            }
            return rating;

        }
    }
}