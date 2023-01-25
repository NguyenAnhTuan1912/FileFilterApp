using FileFilter.BLL.Extensions;
using FileFilter.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFilter.BLL.Helpers
{
    public class FormHelper
    {
        public FormHelper() {}

        public void clearOutputBox(RichTextBox box)
        {
            box.Clear();
        }

        /// <summary>
        /// Recieve a list of output lines as "[Color]|Message". And print messages to Rich Text Box with [Color].
        /// </summary>
        /// <param name="outputLines">A list of output lines.</param>
        public void printOutput(RichTextBox box, List<string> outputLines = null)
        {
            try
            {
                if (outputLines is null) throw new ArgumentException("Output list bị rỗng!");
                foreach (string output in outputLines)
                {
                    string[] splitOutput = output.Split('|');
                    if (splitOutput.Length == 1) appendTextToOutputBox(box, output);
                    else
                    {
                        string color = splitOutput[0].Trim();
                        string outputLine = splitOutput[1].Trim();
                        appendTextToOutputBoxWithColor(box, outputLine, getColorByText(color));
                    }
                }
            } catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string[] getAllLinesFromRTB(RichTextBox box)
        {
            return box.Text.Split('\n').Where(line => line != "").ToArray();
        }

        public void appendTextToOutputBox(RichTextBox box, string text)
        {
            box.AppendText(text);
        }

        public void appendTextToOutputBoxWithColor(RichTextBox box, string text, Color color)
        {
            box.AppendText(text, color);
        }

        public Color getColorByText(string text = "")
        {
            switch(text)
            {
                case "[DodgerBlue]": return Color.DodgerBlue;
                case "[Yellow]": return Color.Yellow;
                case "[Green]": return Color.Green;
                case "[Red]": return Color.Red;
                default: return Color.Black;
            }
        }
    }
}
