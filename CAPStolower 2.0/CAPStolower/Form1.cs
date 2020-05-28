using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace CAPStolower
{
    public partial class Form1 : Form
    {
        /* This program parses whatever text is on the clipboard (if there is any)
         * And swaps the case of every letter
         * Displaying the clipboard contents so you always know what you'll paste
         * */
        private IntPtr thisWindow;
        private Hotkey hotkey;
        // 0x0312 is WinProc message code for hotkey (hotkeys only assigned by this code)
        private const int WM_HOTKEY = 0x312;

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        public Form1()
        {
            InitializeComponent();
        }
        #region Global Hotkeys
        private void Form1_Load(object sender, EventArgs e)
        {
            thisWindow = this.Handle; /*FindWindow(null, "Case changer");*/
            hotkey = new Hotkey(thisWindow);
            hotkey.RegisterHotKeys();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotkey.UnRegisterHotKeys();
        }
        protected override void WndProc(ref Message keyPressed)
        {
            // WParam is index of hotkey
            if (keyPressed.Msg == WM_HOTKEY && keyPressed.WParam == (IntPtr)1)
            {
                SwapCase.Change();
            }
            // Do whatever windows was going to do
            base.WndProc(ref keyPressed);
        }
        #endregion
        #region Case changer
        private void button_swap_Click(object sender, EventArgs e)
        {
            SwapCase.Change();
        }
        private void timer_display_Tick(object sender, EventArgs e)
        {
            label_display.Visible = SwapCase.Timer_Display();
        }
        // Every 50 ms
        private void timer_clipboard_Tick(object sender, EventArgs e)
        {
            // Try in case contents are something other than text
            try
            {
                label_clipboard.Text = Clipboard.GetText().ToString();

            } catch (Exception)
            {
                // Contents weren't text
                // Annoying
                //MessageBox.Show("Not valid clipboard contents");

            }
        }
        // About message
        private void button_about_Click(object sender, EventArgs e) => MessageBox.Show("This takes whatever text was last on your clipboard (copy) and swaps case of every character. If something other than text was last on the clipboard, this application ignores it and displays an error if you continue anyways. Also, this application gives you a preview of text on the clipboard so you always know what you will paste. This toggles case, so if \"Hello There!\" is input, \"hELLO tHERE!\" will be returned. Also, this app has a global hotkey of CTRL + SHIFT + Z that swaps the case and pastes your text for you. All you need to do is highlight the text, copy it, and then press CTRL + SHIFT + Z.");
        #endregion
    }
}
