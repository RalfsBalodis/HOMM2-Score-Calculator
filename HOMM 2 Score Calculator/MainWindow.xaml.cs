using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace HOMM_2_Score_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                AppControls.GetMaps();
                MapSelectBox.ItemsSource = MapModel.Maps;
                MapsListBox.ItemsSource = MapModel.Maps;

            }
            catch (Exception e)
            {
                //_ = MessageBox.Show("The MapInfo.txt is missing or empty!");
                _ = MessageBox.Show(e.Message);
                CalculateButton.IsEnabled = false;
                calculateCallEnable = false;
            }
            try
            {
                MapSelectBox.SelectedIndex = 0;
                MapsListBox.SelectedIndex = 0;
            }
            catch (Exception)
            {
                _ = MessageBox.Show("The list of maps is empty!");

            }
        }

        //Capmpaign
        private void CampaignDayInputTextChangedEvent(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            AppControls.NumberInputOnly(CampaignDaysInput);
        }
        private void GetCampaignRating(object sender, RoutedEventArgs e)
        {

            try
            {
                int days = Convert.ToInt32(CampaignDaysInput.Text);
                if (days < 0)
                {
                    days = 0;
                }

                CampaignRating.Content = ScoreCalculator.GetCampaignRating(days);
                CampaignDaysInput.Text = days.ToString();
                CampaignDaysInput.CaretIndex = CampaignDaysInput.Text.Length;
                CampaignDaysInput.Focus();

                try
                {
                    CampaigneMonsterImage.Source = ImageProcesor.GetImage(CampaignRating.Content.ToString());

                }
                catch (Exception)
                {
                    _ = MessageBox.Show("The image is missing!");
                }

            }
            catch (Exception)
            {
                _ = MessageBox.Show("Enter an integer!");
                CampaignDaysInput.Clear();
            }
        }

        //Standard
        bool calculateCallEnable = true;
        bool showLimitMessage = true;
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int days = 1;
            int week = 1;
            int month = 1;

            try
            {
                days = Convert.ToInt32(StandardDayInput.Text);
                if (days < 1)
                {
                    days = 1;
                    StandardDayInput.Text = "1";
                    StandardDayInput.CaretIndex = StandardDayInput.Text.Length;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("For \"Day\" 1-7 should do!");
                StandardDayInput.Text = "1";
                StandardDayInput.CaretIndex = StandardDayInput.Text.Length;
            }
            try
            {
                week = Convert.ToInt32(StandardWeekInput.Text);
                if (week < 1)
                {
                    week = 1;
                    StandardWeekInput.Text = "1";
                    StandardWeekInput.CaretIndex = StandardWeekInput.Text.Length;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("For \"Week\" 1 - 4 should do!");
                StandardWeekInput.Text = "1";
                StandardWeekInput.CaretIndex = StandardWeekInput.Text.Length;
            }
            try
            {
                month = Convert.ToInt32(StandardMonthInput.Text);
                if (month < 1)
                {
                    month = 1;
                    StandardMonthInput.Text = "1";
                    StandardMonthInput.CaretIndex = StandardMonthInput.Text.Length;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("For \"Month\" 1 - 99 should do!");
                StandardMonthInput.Text = "1";
                StandardMonthInput.CaretIndex = StandardMonthInput.Text.Length;
            }

            int totaldays = ScoreCalculator.CountDays(days, week, month);

            decimal gamedays = ScoreCalculator.CountGameDays(totaldays, MapModel.Maps[MapSelectBox.SelectedIndex].SizeValue);

            decimal finaldays = ScoreCalculator.CountFinalDays(gamedays, (bool)StandardLowLimitOff.IsChecked);

            int gamedifficulty = 0;

            if ((bool)EasyButon.IsChecked)
            {
                gamedifficulty = 0;
            }
            else if ((bool)NormalButton.IsChecked)
            {
                gamedifficulty = 30;
            }
            else if ((bool)HardButton.IsChecked)
            {
                gamedifficulty = 50;
            }
            else if ((bool)ExpertButton.IsChecked)
            {
                gamedifficulty = 70;
            }
            else if ((bool)ImpossibleButton.IsChecked)
            {
                gamedifficulty = 90;
            }

            int difficluty = ScoreCalculator.GetDifficulty(MapModel.Maps[MapSelectBox.SelectedIndex].DifficultyValue, gamedifficulty);
            int finalscore = ScoreCalculator.FinalScore(finaldays, difficluty);
            string rating = ScoreCalculator.GetStandardRating(finalscore);

            try
            {
                StandardMonsterImage.Source = ImageProcesor.GetImage(rating);

            }
            catch (Exception)
            {
                _ = MessageBox.Show($"The image is missing!\nYour Rating is {rating}!");
            }
            StandardDays.Content = totaldays;
            StandardDaysLabel.ToolTip = $"Base score: {200 - finaldays}";

            StandardRating.Content = finalscore;
            StandardRatingLabel.ToolTip = $"Difficulty: {difficluty}%";

            StandardMonsterImage.ToolTip = rating;

            if ((bool)StandardAutoDate.IsChecked)
            {
                if (days > 7 || week > 4)
                {
                    int actualMonth = (((totaldays - 1) / 28) + 1);
                    int actualWeek = ((totaldays - 1) / 7) - (actualMonth - 1) * 4 + 1;
                    int actualDay = totaldays - (actualWeek - 1) * 7 - (actualMonth - 1) * 28;

                    StandardMonthInput.Text = actualMonth.ToString();
                    StandardMonthInput.CaretIndex = StandardMonthInput.Text.Length;
                    StandardWeekInput.Text = actualWeek.ToString();
                    StandardWeekInput.CaretIndex = StandardWeekInput.Text.Length;
                    StandardDayInput.Text = actualDay.ToString();
                    StandardDayInput.CaretIndex = StandardDayInput.Text.Length;
                }
            }
        }

        private void MapSelectedEvent(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (MapSelectBox.SelectedIndex != -1)
            {
                MapDifficulty.Content = MapModel.Maps[MapSelectBox.SelectedIndex].MapDifficulty;
                MapSize.Content = MapModel.Maps[MapSelectBox.SelectedIndex].MapSize;
                MapSelectBox.ToolTip = MapModel.Maps[MapSelectBox.SelectedIndex].MapDescription;
                MapDifficulty.ToolTip = $"{MapModel.Maps[MapSelectBox.SelectedIndex].DifficultyValue}%";
            }
            else
            {
                MapDifficulty.Content = "";
                MapSize.Content = "";
                MapSelectBox.ToolTip = "";
                MapDifficulty.ToolTip = "";
            }
        }

        private void LowerLimitOffChecked(object sender, RoutedEventArgs e)
        {
            if (showLimitMessage)
            {
                MessageBox.Show("In game the base score limit is 20, thus the lowest possible rating is 10. This option removes the base score limit and sets it to 0. This allows you to see hypothetical ratings that are lower than 10.");
                showLimitMessage = false;
            }
            if (calculateCallEnable)
            {
                CalculateButton_Click(sender, e);
            }
        }

        private void LowerLimitOffUnchecked(object sender, RoutedEventArgs e)
        {
            if (calculateCallEnable)
            {
                CalculateButton_Click(sender, e);
            }
        }

        private void StandardDayInputTextChangedEvent(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            AppControls.NumberInputOnly(StandardDayInput);
        }

        private void StandardWeekInputTextChangedEvent(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            AppControls.NumberInputOnly(StandardWeekInput);
        }

        private void StandardMonthInputTextChangedEvent(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            AppControls.NumberInputOnly(StandardMonthInput);
        }

        //Maps
        private void MapsListSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (MapsListBox.SelectedIndex != -1)
            {
                MapsDiscription.Text = MapModel.Maps[MapsListBox.SelectedIndex].MapDescription;
                MapsListSize.Text = MapModel.Maps[MapsListBox.SelectedIndex].MapSize;
                MapsListDifficulty.Text = MapModel.Maps[MapsListBox.SelectedIndex].MapDifficulty;
                MapsListBox.ScrollIntoView(MapsListBox.SelectedItem);
            }
            else
            {
                MapsDiscription.Text = "";
                MapsListSize.Text = "";
                MapsListDifficulty.Text = "";
            }
        }

        private void DeleteMap(object sender, RoutedEventArgs e)
        {
            if (MapModel.Maps.Count != 0)
            {
                int index1 = MapsListBox.SelectedIndex;
                int index2 = MapSelectBox.SelectedIndex;

                AppControls.DeleteMaps(index1);

                MapSelectBox.ItemsSource = MapModel.Maps;
                MapsListBox.ItemsSource = MapModel.Maps;
                MapSelectBox.Items.Refresh();
                MapsListBox.Items.Refresh();

                if (index1 < MapModel.Maps.Count)
                {
                    MapsListBox.SelectedIndex = index1;
                }
                else
                {
                    MapsListBox.SelectedIndex = MapModel.Maps.Count - 1;
                }
                if (index2 < MapModel.Maps.Count)
                {
                    MapSelectBox.SelectedIndex = index2;
                }
                else
                {
                    MapSelectBox.SelectedIndex = MapModel.Maps.Count - 1;
                }

                if (MapModel.Maps.Count == 0)
                {
                    CalculateButton.IsEnabled = false;
                    calculateCallEnable = false;
                }
            }
        }

        private void AddMaps(object sender, RoutedEventArgs e)
        {
            int index1 = MapsListBox.SelectedIndex;
            int index2 = MapSelectBox.SelectedIndex;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter =
                "HOMM2 single scenarios|*.mp2;*.mx2|HOMM2 standard maps|*.mp2|HOMM2 expansion maps|*.mx2|HOMM2 standard campaign maps|*.h2c|HOMM2 expansion campaign maps|*.hxc|HOMMM2 all maps|*.mp2;*.mx2;*.h2c;*.hxc";
            dialog.ShowDialog();

            int newindex = AppControls.AddMapsFromFile(dialog.FileNames);

            MapSelectBox.ItemsSource = MapModel.Maps;
            MapsListBox.ItemsSource = MapModel.Maps;

            MapSelectBox.Items.Refresh();
            MapsListBox.Items.Refresh();

            if (newindex != -1)
            {
                MapsListBox.SelectedItem = MapModel.Maps[newindex];
                MapSelectBox.SelectedItem = MapModel.Maps[newindex];
                MapsListBox.Focus();
            }
            else if (index1 == -1)
            {
                MapsListBox.Focus();
            }

            else
            {
                MapsListBox.SelectedItem = MapModel.Maps[index1];
                MapSelectBox.SelectedItem = MapModel.Maps[index2];
                MapsListBox.Focus();
            }

            if (MapModel.Maps.Count > 0)
            {
                CalculateButton.IsEnabled = true;
                calculateCallEnable = true;
            }
        }

        private void SaveMaps(object sender, RoutedEventArgs e)
        {
            bool mapssaved = AppControls.SaveMaps();
            if (mapssaved)
            {
                _ = MessageBox.Show("List saved to MapInfo.txt!");
            }
            else
            {
                _ = MessageBox.Show("List of maps was not saved!");
            }
        }

        private void MapsListsKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                DeleteMap(sender, e);
            }
        }
    }
}