using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HOMM_2_Score_Calculator
{
    class MapModel
    {
        public string MapName { get; private set; }
        public string MapSize { get; private set; }
        public string MapDifficulty { get; private set; }
        public string MapDescription { get; private set; }
        public string MapFileName { get; private set; }
        public decimal SizeValue { get; private set; }
        public int DifficultyValue { get; private set; }

        public MapModel(string name, string size, string difficulty, string description, string mapfilename)
        {
            MapName = name;
            MapSize = size.ToUpper();
            MapDifficulty = difficulty[0].ToString().ToUpper() + difficulty.Remove(0,1).ToLower();
            
            MapDescription = description;
            MapFileName = mapfilename;
            switch (size)
            {
                case "S":
                    SizeValue = 140;
                    break;
                case "M":
                    SizeValue = 100;
                    break;
                case "L":
                    SizeValue = 80;
                    break;
                case "XL":
                    SizeValue = 60;
                    break;
                default:
                    SizeValue = 100;
                    break;
            }

            switch (difficulty)
            {
                case "Easy":
                    DifficultyValue = 0;
                    break;
                case "Normal":
                    DifficultyValue = 20;
                    break;
                case "Hard":
                    DifficultyValue = 40;
                    break;
                case "Expert":
                    DifficultyValue = 80;
                    break;
                default:
                    DifficultyValue = 0;
                    break;
            }
        }

        public static List<MapModel> Maps = new List<MapModel>();
    }
}


