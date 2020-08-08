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
        }

        private void ClickTrainerButton_Click(object sender, EventArgs e)
        {
            trainer();
        }

        private void trainer()
        {
            LogText.Text += "Opening Trainer Section" + Environment.NewLine;
            var command = "adb shell input tap 120 1650";
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
            LogText.Text += "Clicking top most friend" + Environment.NewLine;
            var command = "adb shell input tap 500 800";
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
            LogText.Text += "Cancelling.." + Environment.NewLine;
            var command = "adb shell input tap 540 1630";
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
            LogText.Text += "Opening Friends section" + Environment.NewLine;
            var command = "adb shell input tap 730 200";
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
        }

        private void scroll()
        {
            LogText.Text += "Scrolling friend" + Environment.NewLine;
            var command = "adb shell input swipe 100 1000 100 10";
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
            LogText.Text += "Clickin on remove friend" + Environment.NewLine;
            var command = "adb shell input tap 500 1500";
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
            LogText.Text += "Confirming Remove Friend" + Environment.NewLine;
            var command = "adb shell input tap 500 950";
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
            LogText.Text += "Clicking gift" + Environment.NewLine;
            var command = "adb shell input tap 570 950";
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
            LogText.Text += "Opening Gift" + Environment.NewLine;
            var command = "adb shell input tap 500 1440";
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
            var command = "adb shell input swipe 100 800 800 800";
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
            string speed = SpeedTextBox.Text;
            var command = "adb shell input swipe 560 1600 560 600 " + speed;
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
            var command = "adb shell input tap 500 1050";
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
            var command = "adb shell input tap 350 175";
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
