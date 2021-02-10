
namespace HOMM_2_Score_Calculator
{
    class ScoreCalculator
    {
        //Campaign score
        internal static string GetCampaignRating(int days)
        {
            string rating = "";
            if (days < 301)
            {
                rating = "Black Dragon";
                return rating;
            }
            else if (days < 321)
            {
                rating = "Titan";
                return rating;
            }
            else if (days < 341)
            {
                rating = "Red Dragon";
                return rating;
            }
            else if (days < 361)
            {
                rating = "Green Dragon";
                return rating;
            }
            else if (days < 381)
            {
                rating = "Bone Dragon";
                return rating;
            }

            else if (days < 401)
            {
                rating = "Phoenix";
                return rating;
            }
            else if (days < 421)
            {
                rating = "Giant";
                return rating;
            }
            else if (days < 441)
            {
                rating = "Cyclops";
                return rating;
            }
            else if (days < 461)
            {
                rating = "Crusader";
                return rating;
            }
            else if (days < 481)
            {
                rating = "Genie";
                return rating;
            }

            else if (days < 501)
            {
                rating = "Paladin";
                return rating;
            }
            else if (days < 521)
            {
                rating = "Hydra";
                return rating;
            }
            else if (days < 541)
            {
                rating = "Unicorn";
                return rating;
            }
            else if (days < 561)
            {
                rating = "Power Lich";
                return rating;
            }
            else if (days < 581)
            {
                rating = "Archmage";
                return rating;
            }

            else if (days < 601)
            {
                rating = "Vampire Lord";
                return rating;
            }
            else if (days < 621)
            {
                rating = "War Troll";
                return rating;
            }
            else if (days < 641)
            {
                rating = "Champion";
                return rating;
            }
            else if (days < 661)
            {
                rating = "Minotaur King";
                return rating;
            }
            else if (days < 681)
            {
                rating = "Ogre Lord";
                return rating;
            }

            else if (days < 701)
            {
                rating = "Lich";
                return rating;
            }
            else if (days < 721)
            {
                rating = "Medusa";
                return rating;
            }
            else if (days < 741)
            {
                rating = "Mage";
                return rating;
            }
            else if (days < 761)
            {
                rating = "Troll";
                return rating;
            }
            else if (days < 781)
            {
                rating = "Cavalry";
                return rating;
            }

            else if (days < 801)
            {
                rating = "Minotaur";
                return rating;
            }
            else if (days < 821)
            {
                rating = "Roc";
                return rating;
            }
            else if (days < 841)
            {
                rating = "Earth Elemental";
                return rating;
            }
            else if (days < 861)
            {
                rating = "Water Elemental";
                return rating;
            }
            else if (days < 881)
            {
                rating = "Vampire";
                return rating;
            }

            else if (days < 901)
            {
                rating = "Ghost";
                return rating;
            }
            else if (days < 921)
            {
                rating = "Fire Elemental";
                return rating;
            }
            else if (days < 941)
            {
                rating = "Greater Druid";
                return rating;
            }
            else if (days < 961)
            {
                rating = "Air Elemental";
                return rating;
            }
            else if (days < 981)
            {
                rating = "Master Swordsman";
                return rating;
            }

            else if (days < 1001)
            {
                rating = "Steel Golem";
                return rating;
            }
            else if (days < 1101)
            {
                rating = "Druid";
                return rating;
            }
            else if (days < 1201)
            {
                rating = "Swordsman";
                return rating;
            }
            else if (days < 1301)
            {
                rating = "Griffin";
                return rating;
            }
            else if (days < 1401)
            {
                rating = "Ogre";
                return rating;
            }

            else if (days < 1501)
            {
                rating = "Royal Mummy";
                return rating;
            }
            else if (days < 1601)
            {
                rating = "Iron Golem";
                return rating;
            }
            else if (days < 1701)
            {
                rating = "Mummy";
                return rating;
            }
            else if (days < 1801)
            {
                rating = "Wolf";
                return rating;
            }
            else if (days < 1901)
            {
                rating = "Veteran Pikeman";
                return rating;
            }

            else if (days < 2001)
            {
                rating = "Nomad";
                return rating;
            }
            else if (days < 2201)
            {
                rating = "Battle Dwarf";
                return rating;
            }
            else if (days < 2401)
            {
                rating = "Grand Elf";
                return rating;
            }
            else if (days < 2601)
            {
                rating = "Pikeman";
                return rating;
            }
            else if (days < 2801)
            {
                rating = "Gargoyle";
                return rating;
            }

            else if (days < 3001)
            {
                rating = "Elf";
                return rating;
            }
            else if (days < 3201)
            {
                rating = "Orc Chief";
                return rating;
            }
            else if (days < 3401)
            {
                rating = "Mutant Zombie";
                return rating;
            }
            else if (days < 3601)
            {
                rating = "Dwarf";
                return rating;
            }
            else if (days < 3801)
            {
                rating = "Boar";
                return rating;
            }

            else if (days < 4001)
            {
                rating = "Ranger";
                return rating;
            }
            else if (days < 4201)
            {
                rating = "Archer";
                return rating;
            }
            else if (days < 4401)
            {
                rating = "Zombie";
                return rating;
            }
            else if (days < 4601)
            {
                rating = "Orc";
                return rating;
            }
            else if (days < 4801)
            {
                rating = "Skeleton";
                return rating;
            }

            else if (days < 5001)
            {
                rating = "Rogue";
                return rating;
            }
            else if (days < 5201)
            {
                rating = "Centaur";
                return rating;
            }
            else if (days < 5401)
            {
                rating = "Halfling";
                return rating;
            }
            else if (days < 5601)
            {
                rating = "Sprite";
                return rating;
            }
            else if (days < 5801)
            {
                rating = "Goblin";
                return rating;
            }

            else if (days > 5800)
            {
                rating = "Peasant";
                return rating;

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
            else if(gameDays>600 && lowLimitOff)
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

            if (finalScore >= 228)
            {
                rating = "Black Dragon";
            }
            else if (finalScore >= 225)
            {
                rating = "Titan";
            }
            else if (finalScore >= 222)
            {
                rating = "Red Dragon";
            }
            else if (finalScore >= 219)
            {
                rating = "Green Dragon";
            }
            else if (finalScore >= 216)
            {
                rating = "Bone Dragon";
            }
            else if (finalScore >= 213)
            {
                rating = "Phoenix";
            }
            else if (finalScore >= 210)
            {
                rating = "Giant";
            }
            else if (finalScore >= 207)
            {
                rating = "Cyclops";
            }
            else if (finalScore >= 204)
            {
                rating = "Crusader";
            }
            else if (finalScore >= 201)
            {
                rating = "Genie";
            }
            else if (finalScore >= 198)
            {
                rating = "Paladin";
            }
            else if (finalScore >= 195)
            {
                rating = "Hydra";
            }
            else if (finalScore >= 192)
            {
                rating = "Unicorn";
            }
            else if (finalScore >= 189)
            {
                rating = "Power Lich";
            }
            else if (finalScore >= 186)
            {
                rating = "Archmage";
            }
            else if (finalScore >= 183)
            {
                rating = "Vampire Lord";
            }
            else if (finalScore >= 180)
            {
                rating = "War Troll";
            }
            else if (finalScore >= 177)
            {
                rating = "Champion";
            }
            else if (finalScore >= 174)
            {
                rating = "Minotaur King";
            }
            else if (finalScore >= 171)
            {
                rating = "Ogre Lord";
            }
            else if (finalScore >= 168)
            {
                rating = "Lich";
            }
            else if (finalScore >= 165)
            {
                rating = "Medusa";
            }
            else if (finalScore >= 162)
            {
                rating = "Mage";
            }
            else if (finalScore >= 159)
            {
                rating = "Troll";
            }
            else if (finalScore >= 156)
            {
                rating = "Cavalry";
            }
            else if (finalScore >= 153)
            {
                rating = "Minotaur";
            }
            else if (finalScore >= 150)
            {
                rating = "Roc";
            }
            else if (finalScore >= 147)
            {
                rating = "Earth Elemental";
            }
            else if (finalScore >= 144)
            {
                rating = "Water Elemental";
            }
            else if (finalScore >= 141)
            {
                rating = "Vampire";
            }
            else if (finalScore >= 138)
            {
                rating = "Ghost";
            }
            else if (finalScore >= 135)
            {
                rating = "Fire Elemental";
            }
            else if (finalScore >= 132)
            {
                rating = "Greater Druid";
            }
            else if (finalScore >= 128)
            {
                rating = "Air Elemental";
            }
            else if (finalScore >= 124)
            {
                rating = "Master Swordsman";
            }
            else if (finalScore >= 120)
            {
                rating = "Steel Golem";
            }
            else if (finalScore >= 116)
            {
                rating = "Druid";
            }
            else if (finalScore >= 112)
            {
                rating = "Swordsman";
            }
            else if (finalScore >= 108)
            {
                rating = "Griffin";
            }
            else if (finalScore >= 104)
            {
                rating = "Ogre";
            }
            else if (finalScore >= 100)
            {
                rating = "Royal Mummy";
            }
            else if (finalScore >= 96)
            {
                rating = "Iron Golem";
            }
            else if (finalScore >= 92)
            {
                rating = "Mummy";
            }
            else if (finalScore >= 88)
            {
                rating = "Wolf";
            }
            else if (finalScore >= 84)
            {
                rating = "Veteran Pikeman";
            }
            else if (finalScore >= 80)
            {
                rating = "Nomad";
            }
            else if (finalScore >= 76)
            {
                rating = "Battle Dwarf";
            }
            else if (finalScore >= 72)
            {
                rating = "Grand Elf";
            }
            else if (finalScore >= 68)
            {
                rating = "Pikeman";
            }
            else if (finalScore >= 64)
            {
                rating = "Gargoyle";
            }
            else if (finalScore >= 60)
            {
                rating = "Elf";
            }
            else if (finalScore >= 56)
            {
                rating = "Orc Chief";
            }
            else if (finalScore >= 52)
            {
                rating = "Mutant Zombie";
            }
            else if (finalScore >= 48)
            {
                rating = "Dwarf";
            }
            else if (finalScore >= 44)
            {
                rating = "Boar";
            }
            else if (finalScore >= 40)
            {
                rating = "Ranger";
            }
            else if (finalScore >= 36)
            {
                rating = "Archer";
            }
            else if (finalScore >= 32)
            {
                rating = "Zombie";
            }
            else if (finalScore >= 28)
            {
                rating = "Orc";
            }
            else if (finalScore >= 24)
            {
                rating = "Skeleton";
            }
            else if (finalScore >= 20)
            {
                rating = "Rogue";
            }
            else if (finalScore >= 16)
            {
                rating = "Centaur";
            }
            else if (finalScore >= 12)
            {
                rating = "Halfling";
            }
            else if (finalScore >= 8)
            {
                rating = "Sprite";
            }
            else if (finalScore >= 4)
            {
                rating = "Goblin";
            }
            else if (finalScore >= 0)
            {
                rating = "Peasant";
            }
            return rating;

        }
    }
}