using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Markup.Localizer;

namespace HOMM_2_Score_Calculator
{
    class AppControls
    {
        /*****************************************************************************************************/
        //Save MapModel.Maps List to file MapInfo.txt*/

        public static bool SaveMaps()
        {
            bool returnbool = true;
            List<string> output = new List<string>();

            try
            {
                foreach (MapModel map in MapModel.Maps)
                {
                    output.Add($"{ map.MapName };{ map.MapSize };{ map.MapDifficulty };{ map.MapDescription };{ map.MapFileName }");
                }
                File.WriteAllLines("MapInfo.txt", output);
                return returnbool;

            }
            catch (System.Exception)
            {
                returnbool = false;
                return returnbool;
            };
        }

        /*****************************************************************************************************/
        /*Populate MapModel.Maps List with maps from MapInfo.txt.*/

        public static void GetMaps()
        {
            bool AllLinesBlankOrWhitespace = true;
            try
            {
                List<string> lines = File.ReadAllLines(@"MapInfo.txt").ToList();
                foreach (string line in lines)
                {
                    if (line.Trim() != "")
                    {
                        AllLinesBlankOrWhitespace = false;
                        string[] data = line.Split(";");
                        if (data.Length >= 5)
                        {
                            if (
                                    (data[1].ToUpper() == "S" | data[1].ToUpper() == "M" | data[1].ToUpper() == "L" | data[1].ToUpper() == "XL")
                                    &
                                    (data[2].ToUpper() == "EASY" | data[2].ToUpper() == "NORMAL" | data[2].ToUpper() == "HARD" | data[2].ToUpper() == "EXPERT")
                                )
                            {
                                MapModel newMap = new MapModel(data[0], data[1], data[2], data[3], data[4]);
                                MapModel.Maps.Add(newMap);
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                throw new Exception("MapInfo.txt was not found!");
            }
            if (AllLinesBlankOrWhitespace)
            {
                throw new Exception("The MapInfo.txt is blank!");
            }
            if (MapModel.Maps.Count == 0)
            {
                throw new Exception("The map info was not valid!");
            }
        }

        /*****************************************************************************************************/
        /*Add map file via map dialog*/

        public static int AddMapsFromFile(string[] mapfiles)
        {
            int newindex = -1;
            foreach (var filepath in mapfiles)
            {
                newindex = MapDataProcessor.GetMapInfoFormFile(filepath);
            }
            return newindex;
        }

        /*****************************************************************************************************/
        /*Delete map form MapModel.Maps List*/

        public static void DeleteMaps(int SelectedMapIndex)
        {
            MapModel.Maps.RemoveAt(SelectedMapIndex);
        }

        /*****************************************************************************************************/
        /*Numeric input*/

        public static void NumberInputOnly(System.Windows.Controls.TextBox TextBox)
        {
            int index = TextBox.CaretIndex;
            var TextBoxContent = TextBox.Text;
            foreach (var item in TextBoxContent)
            {
                if (!char.IsDigit(item))
                {
                    //Will not work without this if statement!
                    if (TextBox.Text.Contains(item))
                    {
                        TextBox.Text = TextBox.Text.Remove(TextBox.Text.IndexOf(item), 1);
                    }
                    TextBox.CaretIndex = (index != 0) ? index - 1 : index;
                }

            }
        }
    }
}
