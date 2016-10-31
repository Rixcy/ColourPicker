using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.Alt | Keys.F1))
            {
                string randomCode = ReadFromFile.setRandom();
                new SetClipboardHelper(DataFormats.Text, randomCode).Go();
                clipboard.Text = $"{randomCode} copied to the clipboard!";
                clipboard.ForeColor = Color.Green;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string whatsInIt = txtAdd.Text;
            if (string.IsNullOrEmpty(whatsInIt))
            {
                lblAdd.Text = "Cannot be null";
                lblAdd.ForeColor = Color.Red;
            }
            else
            {
                ReadFromFile.lines.Add(whatsInIt);
                SaveToFile.lines.Add(whatsInIt);
                lblAdd.Text = $"{whatsInIt} added";
                lblAdd.ForeColor = Color.Green;
                txtAdd.Text = String.Empty;
                lboxList.Items.Add(whatsInIt);
                lboxTest.Items.Add(whatsInIt);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFromFile.setLines();

            foreach (string value in ReadFromFile.lines)
            {
                lboxList.Items.Add(value);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile.saveLines();
        }
    }
}
