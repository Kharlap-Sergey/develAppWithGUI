using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form3 : Form
    {
        Func<bool, string> callbackAutosave;
        bool autosave = false;
        public Form3(Func<bool, string> callback, bool defaultAutoSave)
        {
            InitializeComponent();
            autosave = defaultAutoSave;
            callbackAutosave = callback;
            checkBox1.Checked = autosave;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            autosave = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            callbackAutosave(autosave);
        }
    }
}
