using ResourceAllocation.Business;
using ResourceAllocation.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourseAllocationApp
{
    public partial class ResourceEntryForm : Form
    {
        ResourceModel RM;
        BooleanInformationModel B = new BooleanInformationModel();
        ResourceBusiness RB = new ResourceBusiness();

        public ResourceEntryForm()
        {
            InitializeComponent();
            NameResEntryTxtBox.Clear();
            EmailResEntryTxtBox.Clear();
            ThresholdResEntryTxtBox.Clear();
        }
        private async void SaveResEntryBtn_ClickAsync(object sender, EventArgs e)
        {
            if (Validation_Check_For_Resource() == true)
            {
                RM = new ResourceModel() { Name = NameResEntryTxtBox.Text, Email = EmailResEntryTxtBox.Text, Threshold = Int32.Parse(ThresholdResEntryTxtBox.Text) };
                B = await RB.SaveResourceValues(RM);
                if (B.TrueOrFalse)
                {
                    MessageBox.Show("Value Stored Successfully");
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        public bool Validation_Check_For_Resource()
        {
            if(!int.TryParse(ThresholdResEntryTxtBox.Text,out int threshold))
            {
                MessageBox.Show("This is an Interger Field,Please Insert Valid Data");
                return false;
            }
            if(string.IsNullOrEmpty(NameResEntryTxtBox.Text) || string.IsNullOrEmpty(EmailResEntryTxtBox.Text) || string.IsNullOrEmpty(ThresholdResEntryTxtBox.Text))
            {
                MessageBox.Show("Please Enter values to Necessary Fields");
                return false;
            }
            return true;
        }
    }
}
