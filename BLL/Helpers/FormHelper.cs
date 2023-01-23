using FileFilter.BLL.Extensions;
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
        private readonly FileFilterForm _mainForm;

        public FormHelper(FileFilterForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void clearOutputBox()
        {
            _mainForm.rtbOutput.Clear();
        }

        public void appendTextToOutputBox(string text)
        {
            _mainForm.rtbOutput.AppendText(text);
        }

        public void appendTextToOutputBoxWithColor(string text, Color color)
        {
            _mainForm.rtbOutput.AppendText(text, color);
        }


    }
}
