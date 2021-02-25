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
using Microsoft.VisualBasic;

namespace ValidateFullWidth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblOutput.Text                 = string.Empty;
            lblContainsFullWidthChar.Text  = string.Empty;

            lblOutput2.Text                = string.Empty;
            lblContainsFullWidthChar2.Text = string.Empty;
            
            lblOutput3.Text                = string.Empty;
            lblContainsFullWidthChar3.Text = string.Empty;

            lblOutput4.Text                = string.Empty;
            lblContainsFullWidthChar4.Text = string.Empty;
        }

        private void tbxInput_TextChanged(object sender, EventArgs e)
        {
            var targetTbx = sender as TextBox;

            var inputText = targetTbx.Text;

            var outputText = inputText.ToHalfWidth();

            lblOutput.Text = outputText;
            lblContainsFullWidthChar.Text = (inputText != outputText).ToString();

            var outputText2 = inputText.ToHalfWidth2();

            lblOutput2.Text = outputText2;
            lblContainsFullWidthChar2.Text = (inputText != outputText2).ToString();

            var outputText3 = inputText.ToHalfWidth3();

            lblOutput3.Text = outputText3;
            lblContainsFullWidthChar3.Text = (inputText != outputText3).ToString();

            lblContainsFullWidthChar4.Text = inputText.IsContainsFullWidthChar().ToString();
        }
    }

    public static class CommonHelper
    {
        public static string ToHalfWidth(this string source)
        {
            return Strings.StrConv(source, VbStrConv.Narrow, 0);
        }

        public static string ToHalfWidth2(this string source)
        {
            return source.Normalize(NormalizationForm.FormKC);
        }

        public static bool IsContainsFullWidthChar(this string source)
        {
            bool res = source.Any(c => c < 65375 && c > 65280);
            if (res) {
                // MessageBox.Show(string.Format("{0} => 含有全形字", str));

                return true;
            }

            return false;
        }
    }

    public static class StringWidthHelper
    {
        private const uint LOCALE_SYSTEM_DEFAULT = 0x0800;
        private const uint LCMAP_HALFWIDTH       = 0x00400000;
        private const uint LCMAP_FULLWIDTH       = 0x00800000;

        public static string ToHalfWidth3(this string fullWidth)
        {
            StringBuilder sb = new StringBuilder(256);
            LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_HALFWIDTH, fullWidth, -1, sb, sb.Capacity);
            return sb.ToString();
        }

        public static string ToFullWidth3(this string halfWidth)
        {
            StringBuilder sb = new StringBuilder(256);
            LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_FULLWIDTH, halfWidth, -1, sb, sb.Capacity);
            return sb.ToString();
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int LCMapString(uint Locale, uint dwMapFlags, string lpSrcStr, int cchSrc, StringBuilder lpDestStr, int cchDest);
    }
}
