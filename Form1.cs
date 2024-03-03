using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WindowsInput;
using System.Windows.Forms;

namespace Autoclicker2
{
    public partial class Form1 : Form
    {
        #region DLL Imports
        #region user32.dll import
        // Import user32.dll for global keyboard hook
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private LowLevelKeyboardProc hookCallback;

        private IntPtr hookId = IntPtr.Zero;
        #endregion
        #endregion

        #region Variables
        // Mouse X and Y
        private int centerMouseX;
        private int centerMouseY;
        
        
        private Thread clickingThread;
        // private int tDelay;
        public int delay;

        // isClicking bool
        private bool isClicking = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
            hookCallback = HookCallback;
            hookId = SetHook(hookCallback);
            this.TopMost = true;
        }

        // Start listening for keybinds
        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_KEYUP))
            {
                int vkCode = Marshal.ReadInt32(lParam);
                string keyBind = bindingBox.Text;

                int hrs = (int)hourBox.Value;
                int mins = (int)minBox.Value;
                int secs = (int)secBox.Value; 
                int milli = (int)milliBox.Value;
                delay = (hrs * 3600 + mins * 60 + secs) * 1000 + milli;

                // this conditional handles checking if the user inputted a valid key
                if (Enum.TryParse(keyBind, out Keys userKey) == false)
                {
                    warnLabel.Text = ("Invalid key!");
                    warnLabel.Visible = true;
                }
                else
                {
                    warnLabel.Visible = false;
                    // handle the key event
                    if (vkCode == (int)userKey && wParam == (IntPtr)WM_KEYDOWN && !isClicking)
                    {
                       // start the thread only if it's not already running
                       startButton.Enabled = false;
                       stopButton.Enabled = true;
                       isClicking = true;
                       startClickingThread();
                   }
                   else if (vkCode == (int)userKey && wParam == (IntPtr)WM_KEYDOWN && isClicking)
                   {
                       stopButton.Enabled = false;
                       startButton.Enabled = true;
                       isClicking = false;
                       Thread.Sleep(10);
                       clickingThread.Abort(); 
                   }
               }
           }

            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        private void startClickingThread()
        {
            string clickType = clickTypeBox.Text;
            string mouseType = mouseButtonType.Text;
            clickingThread = new Thread(() =>
            {
                var simulator = new InputSimulator();

                while (isClicking)
                {
                        if (!isClicking) return; // check if the thread should stop
                        // because the user can switch between different modes of clicking, we want a switch (not if) here.
                        switch (clickType)
                        {
                            case  "Single" when mouseType == "Left":
                                simulator.Mouse.LeftButtonClick();
                                Thread.Sleep(delay);                           
                                break;

                            case "Double" when mouseType == "Left":
                                simulator.Mouse.LeftButtonDoubleClick();
                                Thread.Sleep(delay);
                                break;
                            case "Single" when mouseType == "Right":
                                simulator.Mouse.RightButtonClick();
                                Thread.Sleep(delay);
                                break;

                            case "Double" when mouseType == "Right":
                                simulator.Mouse.RightButtonDoubleClick();
                                Thread.Sleep(delay);
                                break;
                    }
                }
            });

            clickingThread.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Time variables
            int hrs = (int)hourBox.Value;
            int mins = (int)minBox.Value;
            int secs = (int)secBox.Value; // hehe secs
            int milli = (int)milliBox.Value;

            // Setting variables
            string mouseType = mouseButtonType.Text;
            string clickType = clickTypeBox.Text;
            string keyBind = bindingBox.Text;

            // some math (yuck) to figure out the delay between each click in seconds
            // todo: figure out if i even did this right
            delay = (hrs * 3600 + mins * 60 + secs) * 1000 + milli;

            startButton.Enabled = false;
            stopButton.Enabled = true;

            isClicking = true;
            startClickingThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // TopMost window checkbox
        {
            this.TopMost = topMostCheckBox.Checked;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            startButton.Enabled = true;
            isClicking = false;
            clickingThread.Join(); // wait for the thread to finish
            Console.WriteLine("Stopped clicking.");
        }

        #region Presets
        private void minecraftSwordFarmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hourBox.Value = (0);
            minBox.Value = (0);
            secBox.Value = (1);
            milliBox.Value = (25);
        }

        private void wTFHX0RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hourBox.Value = (0);
            minBox.Value = (0);
            secBox.Value = (0);
            milliBox.Value = (1);
        }
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hourBox.Value = (0);
            minBox.Value = (0);
            secBox.Value = (1);
            milliBox.Value = (0);
        }
        #endregion


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // super dooper stupid string because i'm too lazy to make another form for easier editing.
            System.Windows.Forms.MessageBox.Show("┌───────────────────────────────────────────────────────────┐ \n│This software is both free as in freedom AND free as in price. If you    | \n│ paid money for this, you were scammed.                                                 │ \n└───────────────────────────────────────────────────────────┘  \n \n GNU GENERAL PUBLIC LICENSE: \n https://www.gnu.org/licenses/gpl-3.0.en.html#license-text  \n Project Github link: \n https://github.com/minegamer72/bobs_autoclicker");
        }
    }
}
