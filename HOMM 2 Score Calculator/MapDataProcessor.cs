using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace HOMM_2_Score_Calculator
{
    class MapDataProcessor
    {

        public static int GetMapInfoFormFile(string filepath)
        {
            int returnindex = -1;
            string mapfilename = filepath.Remove(0, filepath.LastIndexOf(@"\") + 1);
            byte[] mapBytes = File.ReadAllBytes(filepath);
            bool IsAValidMap = MapValidation(mapBytes);
            bool MapIsNotInList = true;

            foreach (var item in MapModel.Maps)
            {
                if (item.MapFileName == mapfilename)
                {
                    MapIsNotInList = false;
                    returnindex = MapModel.Maps.IndexOf(item);
                    break;
                }
            }
            if (IsAValidMap)
            {

                string mapName = ReturnMapName(mapBytes);
                string mapSize = ReturnMapSize(mapBytes);
                string mapDifficulty = ReturnMapDifficulty(mapBytes);
                string mapDescription = ReturnMapDescription(mapBytes);
                if (MapModel.Maps.Count == 0 || MapIsNotInList)
                {
                    MapModel newmapformfile = new MapModel(mapName, mapSize, mapDifficulty, mapDescription, mapfilename);
                    MapModel.Maps.Add(newmapformfile);
                    MapModel.Maps = MapModel.Maps.OrderBy(x => x.MapName).ToList();
                    returnindex = MapModel.Maps.IndexOf(newmapformfile);
                }

                else
                {
                    _ = MessageBox.Show($"{ mapfilename } as \"{ mapName}\" is already in the list!");
                }
            }
            else
            {
                _ = MessageBox.Show($"{ mapfilename } is not a valid HOMM2 map!");                
            }
            return returnindex;
        }
        private static string ReturnMapDifficulty(byte[] mapBytes)
        {
            var mapDifficulty = mapBytes[4];
            string output;
            switch (mapDifficulty)
            {
                case 0:
                    output = "Easy";
                    break;
                case 1:
                    output = "Normal";
                    break;
                case 2:
                    output = "Hard";
                    break;
                case 3:
                    output = "Expert";
                    break;
                default:
                    output = "This is not a HOMM2 map";
                    break;
            }
            return output;
        }

        private static string ReturnMapSize(byte[] mapBytes)

        {
            string output;

            byte mapsize = mapBytes[6];

            switch (mapsize)
            {
                case 36:
                    output = "S";
                    break;
                case 72:
                    output = "M";
                    break;
                case 108:
                    output = "L";
                    break;
                case 144:
                    output = "XL";
                    break;
                default:
                    output = "This is not a HOMM2 map";
                    break;
            }

            return output;
        }

        private static string ReturnMapName(byte[] mapBytes)
        {
            string output = "";
            int j = 0;
            int i = 58;

            while (mapBytes[i] != 0 && i <= 96)
            {
                i++;
                j++;
            }

            i = 58;
            byte[] mapNameBytes = new byte[j];
            j = 0;

            foreach (byte bit in mapNameBytes)
            {
                mapNameBytes[j] = mapBytes[i];
                i++;
                j++;
            }

            char[] mapNameChars = Encoding.ASCII.GetChars(mapNameBytes);
            foreach (char character in mapNameChars)
            {
                output += character;
            }

            return output;
        }

        private static string ReturnMapDescription(byte[] mapBytes)
        {
            string output = "";
            int j = 0;
            int i = 118;

            while (mapBytes[i] != 0 && i <= 317)
            {
                i++;
                j++;
            }

            i = 118;
            byte[] mapDescriptionBytes = new byte[j];
            j = 0;

            foreach (byte bit in mapDescriptionBytes)
            {
                mapDescriptionBytes[j] = mapBytes[i];
                i++;
                j++;
            }

            char[] mapDescriptionChars = Encoding.ASCII.GetChars(mapDescriptionBytes);
            foreach (char character in mapDescriptionChars)
            {
                output += character;
            }

            return output;
        }

        private static bool MapValidation(byte[] b)
        {
            if (b.Length < 318)
            {
                return false;
            }
            if (b[0] != 92)
            {
                return false;
            }
            if (b[1] != 0)
            {
                return false;
            }
            if (b[2] != 0)
            {
                return false;
            }
            if (b[3] != 0)
            {
                return false;
            }
            if (b[4] > 3)
            {
                return false;
            }
            if (b[5] != 0)
            {
                return false;
            }
            if (b[6] != 36 & b[6] != 72 & b[6] != 108 & b[6] != 144)
            {
                return false;
            }
            if (b[6] != b[7])
            {
                return false;
            }
            if (b[58] == 0)
            {
                return false;
            }
            if (b[118] == 0)
            {
                return false;
            }
            return true;
        }

    }
}
