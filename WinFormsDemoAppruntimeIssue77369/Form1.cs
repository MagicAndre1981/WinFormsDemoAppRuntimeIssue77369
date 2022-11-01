using System.Diagnostics;
using WinFormsDemoAppruntimeIssue77369.Properties;

namespace WinFormsDemoAppruntimeIssue77369
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (Settings.Default.myBoolSetting)
                Debug.WriteLine("TRUE");
            else
                Debug.WriteLine("FALSE");
        }
    }
}