using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                trainerCommand(70, 1040);
            }
            else if (SecondaryRadioButton.Checked)
            {
                trainerCommand(70, 2220);
            }
            else if (DualApp.Checked)
            {
                trainerCommand(70, 1040);
                Thread.Sleep(100);
                trainerCommand(70, 2220);
            }
        }

        private void trainerCommand(int x, int y)
        {
            LogText.Text += "Opening Trainer Section" + Environment.NewLine;
            var command = $"adb shell input tap {x} {y}";
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
                clickFriendCommand(165, 850);
            }
            else if (SecondaryRadioButton.Checked)
            {
                clickFriendCommand(165, 1940);
            }
            else if (DualApp.Checked)
            {
                clickFriendCommand(165, 850);
                Thread.Sleep(100);
                clickFriendCommand(165, 1940);
            }
        }

        private void clickFriendCommand(int x, int y)
        {
            LogText.Text += "Clicking top most friend" + Environment.NewLine;
            var command = $"adb shell input tap {x} {y}";
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
                cancelCommand(540, 1025);
            }
            else if (SecondaryRadioButton.Checked)
            {
                cancelCommand(540, 2220);
            }
            else if (DualApp.Checked)
            {
                cancelCommand(540, 1025);
                Thread.Sleep(100);
                cancelCommand(540, 2220);
            }
        }

        private void cancelCommand(int x, int y)
        {
            LogText.Text += "Cancelling.." + Environment.NewLine;
            var command = $"adb shell input tap {x} {y}";
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
                friendsCommand(730, 255);
            }
            else if (SecondaryRadioButton.Checked)
            {
                friendsCommand(730, 1350);
            }
            else if (DualApp.Checked)
            {
                friendsCommand(730, 255);
                Thread.Sleep(100);
                friendsCommand(730, 1350);
            }
        }

        private void friendsCommand(int x, int y)
        {
            LogText.Text += "Opening Friends section" + Environment.NewLine;
            var command = $"adb shell input tap {x} {y}";
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
            Thread.Sleep(700);
            scroll();
        }

        private void scroll()
        {
            if (PrimaryRadioButton.Checked)
            {
                scrollCommand(100, 1025, 100, 20);
            }
            else if (SecondaryRadioButton.Checked)
            {
                scrollCommand(100, 2220, 100, 1200);
            }
            else if (DualApp.Checked)
            {
                scrollCommand(100, 1025, 100, 20);
                Thread.Sleep(700);
                scrollCommand(100, 2220, 100, 1200);
            }
        }

        private void scrollCommand(int x1, int y1, int x2, int y2)
        {
            LogText.Text += "Scrolling friend" + Environment.NewLine;
            var command = $"adb shell input swipe {x1} {y1} {x2} {y2}";
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
                removeFriendCommand(540, 815);
            }
            else if (SecondaryRadioButton.Checked)
            {
                removeFriendCommand(540, 2010);
            }
            else if (DualApp.Checked)
            {
                removeFriendCommand(540, 815);
                Thread.Sleep(100);
                removeFriendCommand(540, 2010);
            }
        }

        private void removeFriendCommand(int x, int y)
        {
            LogText.Text += "Clickin on remove friend" + Environment.NewLine;
            var command = $"adb shell input tap {x} {y}";
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
                confirmRemoveCommand(540, 645);
            }
            else if (SecondaryRadioButton.Checked)
            {
                confirmRemoveCommand(540, 1790);
            }
            else if (DualApp.Checked)
            {
                confirmRemoveCommand(540, 645);
                Thread.Sleep(100);
                confirmRemoveCommand(540, 1790);
            }
        }

        private void confirmRemoveCommand(int x, int y)
        {
            LogText.Text += "Confirming Remove Friend" + Environment.NewLine;
            var command = $"adb shell input tap {x} {y}";
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
                clickGiftCommand(560, 620);
            }
            else if (SecondaryRadioButton.Checked)
            {
                clickGiftCommand(560, 1780);
            }
            else if (DualApp.Checked)
            {
                clickGiftCommand(560, 620);
                Thread.Sleep(100);
                clickGiftCommand(560, 1780);
            }
        }

        private void clickGiftCommand(int x, int y)
        {
            LogText.Text += "Clicking gift" + Environment.NewLine;
            var command = $"adb shell input tap {x} {y}";
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
                openGiftCommand(540, 940);
            }
            else if (SecondaryRadioButton.Checked)
            {
                openGiftCommand(540, 2110);
            }
            else if (DualApp.Checked)
            {
                openGiftCommand(540, 940);
                Thread.Sleep(100);
                openGiftCommand(540, 2110);
            }
        }

        private void openGiftCommand(int x, int y)
        {
            LogText.Text += "Opening Gift" + Environment.NewLine;
            var command = $"adb shell input tap {x} {y}";
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
                spinPokestopCommand(90, 550, 1020, 550);
            }
            else if (SecondaryRadioButton.Checked)
            {
                spinPokestopCommand(90, 1760, 1020, 1760);
            }
            else if (DualApp.Checked)
            {
                spinPokestopCommand(90, 550, 1020, 550);
                Thread.Sleep(700);
                spinPokestopCommand(90, 1760, 1020, 1760);
            }
        }

        private void spinPokestopCommand(int x1, int y1, int x2, int y2)
        {
            var command = $"adb shell input swipe {x1} {y1} {x2} {y2}";
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
                throwPokeBallCommand(540, 1040, 540, 570);
            }
            else if (SecondaryRadioButton.Checked)
            {
                throwPokeBallCommand(540, 2220, 540, 1720);
            }
            else if (DualApp.Checked)
            {
                throwPokeBallCommand(540, 1040, 540, 570);
                Thread.Sleep(700);
                throwPokeBallCommand(540, 2220, 540, 1720);
            }
        }

        private void throwPokeBallCommand(int x1, int y1, int x2, int y2)
        {
            string speed = SpeedTextBox.Text;
            var command = $"adb shell input swipe {x1} {y1} {x2} {y2} " + speed;
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
                cancelRemoveCommand(540, 805);
            }
            else if (SecondaryRadioButton.Checked)
            {
                cancelRemoveCommand(540, 1950);
            }
            else if (DualApp.Checked)
            {
                cancelRemoveCommand(540, 805);
                Thread.Sleep(100);
                cancelRemoveCommand(540, 1950);
            }
        }

        private void cancelRemoveCommand(int x, int y)
        {
            var command = $"adb shell input tap {x} {y}";
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
                meCommand(350, 255);
            }
            else if (SecondaryRadioButton.Checked)
            {
                meCommand(350, 1350);
            }
            else if (DualApp.Checked)
            {
                meCommand(350, 255);
                Thread.Sleep(100);
                meCommand(350, 1350);
            }
        }

        private void meCommand(int x, int y)
        {
            var command = $"adb shell input tap {x} {y}";
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
    }
}
