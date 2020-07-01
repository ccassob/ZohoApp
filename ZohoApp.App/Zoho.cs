using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZohoApp.App
{
    public partial class Zoho : Form
    {
        private ITransformHistory transformHistory = new TransformHistory();

        public Zoho()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string historyText = txtHistory.Text;
            string task1Text = txtTask1.Text;
            string task2Text = txtTask2.Text;

            Actions action = (Actions)cbActions.SelectedIndex;

            TransformHistory(historyText, task1Text, task2Text, action);
        }

        private void TransformHistory(string historyText, string task1Text, string task2Text, Actions action)
        {
            txtResult.Text = transformHistory.Transform(new TransformHistoryDto()
            {
                History = historyText,
                FirstTask = task1Text,
                SecondTask = task2Text,
                Actions = action
            });
        }
    }
}