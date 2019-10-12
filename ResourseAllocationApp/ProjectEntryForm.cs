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
    public partial class ProjectEntryForm : Form
    {
        ProjectModel PF;
        BooleanInformationModel B = new BooleanInformationModel();
        ProjectBusiness PB = new ProjectBusiness();

        public ProjectEntryForm()
        {
            InitializeComponent();
        }

        private async void SaveProEntryBtn_ClickAsync(object sender, EventArgs e)
        {
            if (Validation_Check_For_Project() == true)
            {
                PF = new ProjectModel() { ProjectName = NameProEntryTxtBox.Text, NoOfResources = 0};
                B = await PB.SaveProjectValues(PF);
                if (B.TrueOrFalse)
                {
                    MessageBox.Show("Value Stored Successfully");
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        public bool Validation_Check_For_Project()
        {
            if (string.IsNullOrEmpty(NameProEntryTxtBox.Text))
            {
                MessageBox.Show("Please Enter values to Necessary Field");
                return false;
            }
            return true;
        }
    }
}
