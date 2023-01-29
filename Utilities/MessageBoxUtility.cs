using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFilter.Utilities
{
    public static class MessageBoxUtility
    {
        public static DialogResult ShowError(string message, string title = "Error")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowInfo(string message, string title = "Information")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowWarning(string message, string title = "Error")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowStop(string message, string title = "Hold on")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public static DialogResult ShowYNQuestion(string message, string title = "Yes or no?")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }
    }
}
