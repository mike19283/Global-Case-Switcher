using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPStolower
{
    static class SwapCase
    {
        private static int durationTimer = 0;

        public static void Change()
        {
            // Is there text on the clipboard?
            try
            {
                // Get contents from clipboard
                String content_string = Clipboard.GetText().ToString();
                // Our result
                String result = "";
                // Loop through string
                foreach (var character in content_string)
                {
                    // Cast char to bytecode to check case
                    // Which case is it?
                    if ((byte)character <= 90)
                    {
                        result += character.ToString().ToLower();
                    }
                    else
                    {
                        result += character.ToString().ToUpper();
                    }
                }
                // Finally, place our result back on the clipboard
                Clipboard.Clear();
                Clipboard.SetText(result);

                // Set our display timer
                durationTimer = 20;
            }
            // Text wasn't present
            catch (Exception ex)
            {
                //MessageBox.Show("Not valid clipboard contents");
            }

        }
        public static bool Timer_Display()
        {
            // Stop displaying if time ran out
            if (durationTimer == 0)
                return false;
            else
            {
                // Interval is every 100ms
                durationTimer -= 1;
                return true;

            }

        }

    }
}
