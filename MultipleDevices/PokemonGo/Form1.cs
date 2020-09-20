using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
            DualApp.Checked = true;
        }

        private void ClickTrainerButton_Click(object sender, EventArgs e)
        {
            trainer();
        }

        private void trainer()
        {
            if (PrimaryRadioButton.Checked)
            {
                trainerCommand(serial1.Text, 70, 1040);
            }
            else if (SecondaryRadioButton.Checked)
            {
                trainerCommand(serial2.Text, 70, 2220);
            }
            else if (DualApp.Checked)
            {
                trainerCommand(serial1.Text, 70, 1040);
                trainerCommand(serial2.Text, 70, 2220);
            }
        }

        private void trainerCommand(string serial, int x, int y)
        {
            LogText.Text += "Opening Trainer Section" + Environment.NewLine;
            var command = $"adb -s {serial} input tap {x} {y}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void ClickFriend_Click(object sender, EventArgs e)
        {
            clickFriend();
        }

        private void clickFriend()
        {
            if (PrimaryRadioButton.Checked)
            {
                clickFriendCommand(serial1.Text, 165, 850);
            }
            else if (SecondaryRadioButton.Checked)
            {
                clickFriendCommand(serial2.Text, 165, 1940);
            }
            else if (DualApp.Checked)
            {
                clickFriendCommand(serial1.Text, 165, 850);
                clickFriendCommand(serial2.Text, 165, 1940);
            }
        }

        private void clickFriendCommand(string serial, int x, int y)
        {
            LogText.Text += "Clicking top most friend" + Environment.NewLine;
            var command = $"adb -s {serial} input tap {x} {y}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void cancel()
        {
            if (PrimaryRadioButton.Checked)
            {
                cancelCommand(serial1.Text, 540, 1025);
            }
            else if (SecondaryRadioButton.Checked)
            {
                cancelCommand(serial2.Text, 540, 2220);
            }
            else if (DualApp.Checked)
            {
                cancelCommand(serial1.Text, 540, 1025);
                cancelCommand(serial2.Text, 540, 2220);
            }
        }

        private void cancelCommand(string serial, int x, int y)
        {
            LogText.Text += "Cancelling.." + Environment.NewLine;
            var command = $"adb -s {serial} input tap {x} {y}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void GoToTrainerTabButton_Click(object sender, EventArgs e)
        {
            friends();
        }

        private void friends()
        {
            if (PrimaryRadioButton.Checked)
            {
                friendsCommand(serial1.Text, 730, 255);
            }
            else if (SecondaryRadioButton.Checked)
            {
                friendsCommand(serial2.Text, 730, 1350);
            }
            else if (DualApp.Checked)
            {
                friendsCommand(serial1.Text, 730, 255);
                friendsCommand(serial2.Text, 730, 1350);
            }
        }

        private void friendsCommand(string serial, int x, int y)
        {
            LogText.Text += "Opening Friends section" + Environment.NewLine;
            var command = $"adb -s {serial} input tap {x} {y}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void ScrollButton_Click(object sender, EventArgs e)
        {
            scroll();
            scroll();
        }

        private void scroll()
        {
            if (PrimaryRadioButton.Checked)
            {
                scrollCommand(serial1.Text, 100, 1025, 100, 20);
            }
            else if (SecondaryRadioButton.Checked)
            {
                scrollCommand(serial2.Text, 100, 2220, 100, 1200);
            }
            else if (DualApp.Checked)
            {
                scrollCommand(serial1.Text, 100, 1025, 100, 20);
                scrollCommand(serial2.Text, 100, 2220, 100, 1200);
            }
        }

        private void scrollCommand(string serial, int x1, int y1, int x2, int y2)
        {
            LogText.Text += "Scrolling friend" + Environment.NewLine;
            var command = $"adb -s {serial} input swipe {x1} {y1} {x2} {y2}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void RemoveFriend_Click(object sender, EventArgs e)
        {
            removeFriend();
        }

        private void removeFriend()
        {
            if (PrimaryRadioButton.Checked)
            {
                removeFriendCommand(serial1.Text, 540, 815);
            }
            else if (SecondaryRadioButton.Checked)
            {
                removeFriendCommand(serial2.Text, 540, 2010);
            }
            else if (DualApp.Checked)
            {
                removeFriendCommand(serial1.Text, 540, 815);
                removeFriendCommand(serial2.Text, 540, 2010);
            }
        }

        private void removeFriendCommand(string serial, int x, int y)
        {
            LogText.Text += "Clickin on remove friend" + Environment.NewLine;
            var command = $"adb -s {serial} input tap {x} {y}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void ConfirmRemove_Click(object sender, EventArgs e)
        {
            confirmRemove();
        }

        private void confirmRemove()
        {
            if (PrimaryRadioButton.Checked)
            {
                confirmRemoveCommand(serial1.Text, 540, 645);
            }
            else if (SecondaryRadioButton.Checked)
            {
                confirmRemoveCommand(serial2.Text, 540, 1790);
            }
            else if (DualApp.Checked)
            {
                confirmRemoveCommand(serial1.Text, 540, 645);
                confirmRemoveCommand(serial2.Text, 540, 1790);
            }
        }

        private void confirmRemoveCommand(string serial, int x, int y)
        {
            LogText.Text += "Confirming Remove Friend" + Environment.NewLine;
            var command = $"adb -s {serial} input tap {x} {y}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void ClickGift_Click(object sender, EventArgs e)
        {
            clickGift();
        }

        private void clickGift()
        {
            if (PrimaryRadioButton.Checked)
            {
                clickGiftCommand(serial1.Text, 560, 620);
            }
            else if (SecondaryRadioButton.Checked)
            {
                clickGiftCommand(serial2.Text, 560, 1780);
            }
            else if (DualApp.Checked)
            {
                clickGiftCommand(serial1.Text, 560, 620);
                clickGiftCommand(serial2.Text, 560, 1780);
            }
        }

        private void clickGiftCommand(string serial, int x, int y)
        {
            LogText.Text += "Clicking gift" + Environment.NewLine;
            var command = $"adb -s {serial} input tap {x} {y}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void OpenGift_Click(object sender, EventArgs e)
        {
            openGift();
        }

        private void openGift()
        {
            if (PrimaryRadioButton.Checked)
            {
                openGiftCommand(serial1.Text, 540, 940);
            }
            else if (SecondaryRadioButton.Checked)
            {
                openGiftCommand(serial2.Text, 540, 2110);
            }
            else if (DualApp.Checked)
            {
                openGiftCommand(serial1.Text, 540, 940);
                openGiftCommand(serial2.Text, 540, 2110);
            }
        }

        private void openGiftCommand(string serial, int x, int y)
        {
            LogText.Text += "Opening Gift" + Environment.NewLine;
            var command = $"adb -s {serial} input tap {x} {y}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void SpinPokestop_Click(object sender, EventArgs e)
        {
            spinPokestop();
        }

        private void spinPokestop()
        {
            if (PrimaryRadioButton.Checked)
            {
                spinPokestopCommand(serial1.Text, 90, 550, 1020, 550);
            }
            else if (SecondaryRadioButton.Checked)
            {
                spinPokestopCommand(serial2.Text, 90, 1760, 1020, 1760);
            }
            else if (DualApp.Checked)
            {
                spinPokestopCommand(serial1.Text, 90, 550, 1020, 550);
                spinPokestopCommand(serial2.Text, 90, 1760, 1020, 1760);
            }
        }

        private void spinPokestopCommand(string serial, int x1, int y1, int x2, int y2)
        {
            var command = $"adb -s {serial} input swipe {x1} {y1} {x2} {y2}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void CatchButton_Click(object sender, EventArgs e)
        {
            throwPokeBall();
        }

        private void throwPokeBall()
        {
            if (PrimaryRadioButton.Checked)
            {
                throwPokeBallCommand(serial1.Text, 540, 2130, 540, 1180);
            }
            else if (SecondaryRadioButton.Checked)
            {
                throwPokeBallCommand(serial2.Text, 540, 1630, 540, 900);
            }
            else if (DualApp.Checked)
            {
                throwPokeBallCommand(serial1.Text, 540, 2130, 540, 1180);
                throwPokeBallCommand(serial2.Text, 540, 1630, 540, 900);
            }
        }

        private void throwPokeBallCommand(string serial, int x1, int y1, int x2, int y2)
        {
            string speed = SpeedTextBox.Text;
            var command = $"adb -s {serial} shell input swipe {x1} {y1} {x2} {y2} " + speed;
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void CancelRemove_Click(object sender, EventArgs e)
        {
            cancelRemove();
        }

        private void cancelRemove()
        {
            if (PrimaryRadioButton.Checked)
            {
                cancelRemoveCommand(serial1.Text, 540, 805);
            }
            else if (SecondaryRadioButton.Checked)
            {
                cancelRemoveCommand(serial2.Text, 540, 1950);
            }
            else if (DualApp.Checked)
            {
                cancelRemoveCommand(serial1.Text, 540, 805);
                cancelRemoveCommand(serial2.Text, 540, 1950);
            }
        }

        private void cancelRemoveCommand(string serial, int x, int y)
        {
            var command = $"adb -s {serial} input tap {x} {y}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void ThrowCurve_Click(object sender, EventArgs e)
        {
            var command = "";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private void SpeedTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    SpeedTextBox.Text = (Int32.Parse(SpeedTextBox.Text) - 10).ToString();
                    break;
                case MouseButtons.Right:
                    SpeedTextBox.Text = (Int32.Parse(SpeedTextBox.Text) + 10).ToString();
                    break;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SpeedTextBox.Text = "200";
        }

        private void MeTabButton_Click(object sender, EventArgs e)
        {
            me();
        }

        private void me()
        {
            if (PrimaryRadioButton.Checked)
            {
                meCommand(serial1.Text, 350, 255);
            }
            else if (SecondaryRadioButton.Checked)
            {
                meCommand(serial2.Text, 350, 1350);
            }
            else if (DualApp.Checked)
            {
                meCommand(serial1.Text, 350, 255);
                meCommand(serial2.Text, 350, 1350);
            }
        }

        private void meCommand(string serial, int x, int y)
        {
            var command = $"adb -s {serial} input tap {x} {y}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }

        private async void RemoveSequenceButton_Click(object sender, EventArgs e)
        {
            LogText.Text += "Starting remove sequence -" + Environment.NewLine;
            await Task.Run(() => 
            {
                int numberOfRemoveActions = Int32.Parse(NumberOfRemoveActions.Text);
                trainer();
                WaitAndLog(5);
                friends();
                WaitAndLog(3);
                for (int i = 1; i <= numberOfRemoveActions; i++)
                {
                    LogText.Text += "Removing Friend #" + i.ToString() + Environment.NewLine;
                    clickFriend();
                    WaitAndLog(4);
                    scroll();
                    WaitAndLog(3);
                    removeFriend();
                    WaitAndLog(3);
                    confirmRemove();
                    WaitAndLog(4);
                }
                cancel();
            });
            LogText.Text += "Remove sequence Completed." + Environment.NewLine;
        }

        private async void OpenGiftSequencesButton_Click(object sender, EventArgs e)
        {
            LogText.Text += "Starting opening gift sequence -" + Environment.NewLine;
            await Task.Run(() =>
            {
              int numberOfGiftOpenActions = Int32.Parse(NumbeOfGiftOpenActions.Text);

              for (int i = 1; i <= numberOfGiftOpenActions; i++)
              {
                  LogText.Text += "Opening Gift for Friend #" + i.ToString() + Environment.NewLine;
                  trainer();
                  WaitAndLog(5);
                  friends();
                  WaitAndLog(5);
                  clickFriend();
                  WaitAndLog(4);
                  clickGift();
                  WaitAndLog(3);
                  openGift();
                  WaitAndLog(20);
                  cancel();
                  WaitAndLog(3);
                  cancel();
                  WaitAndLog(20);
              }
            });
            LogText.Text += "Opening gift sequence Completed." + Environment.NewLine;
        }

        private void WaitAndLog(int v)
        {
            LogText.Text += "Waiting for " + v.ToString() + " seconds..." + Environment.NewLine;
            Thread.Sleep(v * 1000);
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            LogText.Text = ""; 
        }

        private async void RemoveGifterFiendsSequence_Click(object sender, EventArgs e)
        {
            LogText.Text += "Starting remove sequence -" + Environment.NewLine;
            await Task.Run(() =>
            {
                int numberOfRemoveActions = Int32.Parse(NumberOfGifterFiends.Text);
                trainer();
                WaitAndLog(5);
                friends();
                WaitAndLog(3);
                for (int i = 1; i <= numberOfRemoveActions; i++)
                {
                    LogText.Text += "Removing Friend #" + i.ToString() + Environment.NewLine;
                    clickFriend();
                    WaitAndLog(4);
                    cancel();
                    WaitAndLog(3);
                    scroll();
                    WaitAndLog(3);
                    removeFriend();
                    WaitAndLog(3);
                    confirmRemove();
                    WaitAndLog(4);
                }
                cancel();
            });
            LogText.Text += "Remove sequence Completed." + Environment.NewLine;
        }

        private void LogText_TextChanged(object sender, EventArgs e)
        {
            LogText.SelectionStart = LogText.Text.Length;
            LogText.ScrollToCaret();
        }

        private void RightCatch_Click(object sender, EventArgs e)
        {
            throwPokeBallRight();
        }

        private void LeftCatch_Click(object sender, EventArgs e)
        {
            throwPokeBallLeft();
        }

        private void throwPokeBallRight()
        {
            if (PrimaryRadioButton.Checked)
            {
                throwPokeBallCommand(serial1.Text, 540, 2130, 800, 1180);
            }
            else if (SecondaryRadioButton.Checked)
            {
                throwPokeBallCommand(serial2.Text, 540, 1630, 800, 900);
            }
            else if (DualApp.Checked)
            {
                throwPokeBallCommand(serial1.Text, 540, 2130, 800, 1180);
                throwPokeBallCommand(serial2.Text, 540, 1630, 800, 900);
            }
        }

        private void throwPokeBallLeft()
        {
            if (PrimaryRadioButton.Checked)
            {
                throwPokeBallCommand(serial1.Text, 540, 2130, 280, 1180);
            }
            else if (SecondaryRadioButton.Checked)
            {
                throwPokeBallCommand(serial2.Text, 540, 1630, 280, 900);
            }
            else if (DualApp.Checked)
            {
                throwPokeBallCommand(serial1.Text, 540, 2130, 280, 1180);
                throwPokeBallCommand(serial2.Text, 540, 1630, 280, 900);
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            var serialNumber1 = serial1.Text;
            var serialNumber2 = serial2.Text;

            lunchScrcpy(serialNumber1);
            Thread.Sleep(1000);
            lunchScrcpy(serialNumber2);
        }

        private void lunchScrcpy(string serialNumber)
        {
            var command = $"scrcpy -s {serialNumber}";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }
    }
}
