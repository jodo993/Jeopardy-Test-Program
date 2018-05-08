using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyTestCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void topicAddButton_Click(object sender, EventArgs e)
        {
            string topic = topicTextBox.Text;

            if (string.IsNullOrWhiteSpace(topic))
            {
                MessageBox.Show("Cannot be left blank.");
                return;
            }
            else if (topicListBox.Items.Count < 5)
            {
                topicListBox.Items.Add(topic);
                topicTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Five topics have already been added.");
                topicTextBox.Clear();
            }
        }

        private void topicChangeButton_Click(object sender, EventArgs e)
        {
            string topic = topicTextBox.Text;

            if (topicListBox.SelectedItem == null)
            {
                MessageBox.Show("You didnt choose anything to change.");
                return;
            }
            else
            {
                topicListBox.Items.Remove(topicListBox.SelectedItem);
                topicListBox.Items.Add(topic);
                topicTextBox.Clear();
            }
        }

    }
}
