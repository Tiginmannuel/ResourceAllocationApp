using ResourceAllocation.Business;
using ResourceAllocation.Business.Models;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ResourseAllocationApp
{
    public partial class Form1 : Form
    {
        ResourceEntryForm EF;
        ProjectEntryForm PF;
        ProjectBusiness PB = new ProjectBusiness();
        ResourceBusiness RB = new ResourceBusiness();
        ResourceAllocationBusiness RAB = new ResourceAllocationBusiness();

        public Form1()
        {
            InitializeComponent();
        }

        public async void Form1_LoadAsync(object sender, EventArgs e)
        {
            var result = await RB.ShowResourceDataAsync();
            ResourceDataGrid.DataSource = result;

            var project = await PB.ShowProjectDataAsync();
            ProjectDataGrid.DataSource = project;

            var projectNameOnly = await RAB.ShowProjectNameOnlyAsync();           
            this.SelectProCmbBox.SelectedIndexChanged -= new System.EventHandler(this.SelectProCmbBox_SelectedIndexChangedAsync);
            SelectProCmbBox.DataSource = projectNameOnly;
            SelectProCmbBox.DisplayMember = "ProjectName";
            SelectProCmbBox.ValueMember = "ProjectID";
            SelectProCmbBox.SelectedIndex = -1;
            this.SelectProCmbBox.SelectedIndexChanged += new System.EventHandler(this.SelectProCmbBox_SelectedIndexChangedAsync);

            var projectNameOnly2 = await RAB.ShowProjectNameOnlyAsync();
            this.ChoosePrjNameCmbBox.SelectedIndexChanged -= new System.EventHandler(this.ChoosePrjNameCmbBox_SelectedIndexChangedAsync);
            ChoosePrjNameCmbBox.DataSource = projectNameOnly2;
            ChoosePrjNameCmbBox.DisplayMember = "ProjectName";
            ChoosePrjNameCmbBox.ValueMember = "ProjectID";
            ChoosePrjNameCmbBox.SelectedIndex = -1;
            this.ChoosePrjNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.ChoosePrjNameCmbBox_SelectedIndexChangedAsync);


            var projectNameOnly3 = await RAB.ShowResourceNameOnlyAsync();
            this.ChooseResNameCmbBox.SelectedIndexChanged -= new System.EventHandler(this.ChooseResNameCmbBox_SelectedIndexChangedAsync);
            ChooseResNameCmbBox.DataSource = projectNameOnly3;
            ChooseResNameCmbBox.DisplayMember = "Name";
            ChooseResNameCmbBox.ValueMember = "ResourceID";
            ChooseResNameCmbBox.SelectedIndex = -1;
            this.ChooseResNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.ChooseResNameCmbBox_SelectedIndexChangedAsync);
        }

        private async void AddResBtn_ClickAsync(object sender, EventArgs e)
        {
            EF = new ResourceEntryForm();
            if(EF.ShowDialog() == DialogResult.OK)
            {
                ResourceGridRefreshAsync();
            }
            var projectNameOnly3 = await RAB.ShowResourceNameOnlyAsync();
            this.ChooseResNameCmbBox.SelectedIndexChanged -= new System.EventHandler(this.ChooseResNameCmbBox_SelectedIndexChangedAsync);
            ChooseResNameCmbBox.DataSource = projectNameOnly3;
            ChooseResNameCmbBox.DisplayMember = "Name";
            ChooseResNameCmbBox.ValueMember = "ResourceID";
            ChooseResNameCmbBox.SelectedIndex = -1;
            this.ChooseResNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.ChooseResNameCmbBox_SelectedIndexChangedAsync);

        }

        private async void AddProBtn_ClickAsync(object sender, EventArgs e)
        {
            PF = new ProjectEntryForm();
            if(PF.ShowDialog() == DialogResult.OK)
            {
                ProjectGridRefreshAsync();
            }
            var projectNameOnly = await RAB.ShowProjectNameOnlyAsync();
            this.SelectProCmbBox.SelectedIndexChanged -= new System.EventHandler(this.SelectProCmbBox_SelectedIndexChangedAsync);
            SelectProCmbBox.DataSource = projectNameOnly;
            SelectProCmbBox.DisplayMember = "ProjectName";
            SelectProCmbBox.ValueMember = "ProjectID";
            SelectProCmbBox.SelectedIndex = -1;
            this.SelectProCmbBox.SelectedIndexChanged += new System.EventHandler(this.SelectProCmbBox_SelectedIndexChangedAsync);

            var projectNameOnly2 = await RAB.ShowProjectNameOnlyAsync();
            this.ChoosePrjNameCmbBox.SelectedIndexChanged -= new System.EventHandler(this.ChoosePrjNameCmbBox_SelectedIndexChangedAsync);
            ChoosePrjNameCmbBox.DataSource = projectNameOnly2;
            ChoosePrjNameCmbBox.DisplayMember = "ProjectName";
            ChoosePrjNameCmbBox.ValueMember = "ProjectID";
            ChoosePrjNameCmbBox.SelectedIndex = -1;
            this.ChoosePrjNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.ChoosePrjNameCmbBox_SelectedIndexChangedAsync);
        }

        public async void ResourceGridRefreshAsync()
        {
            var result = await RB.ShowResourceDataAsync();
            ResourceDataGrid.DataSource = result;
        }

        public async void ProjectGridRefreshAsync()
        {
            var project = await PB.ShowProjectDataAsync();
            ProjectDataGrid.DataSource = project;
        }

        private async void SelectProCmbBox_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(SelectProCmbBox.SelectedValue.ToString(),out int final);
            if (success)
            {
                SingleIDModel s = new SingleIDModel() { ID1 = final };
                var resourceNameOnly = await RAB.ShowResourcesNotAssignedToTheProjectAsync(s);
                SelectResCmbBox.DataSource = resourceNameOnly;
                SelectResCmbBox.DisplayMember = "Name";
                SelectResCmbBox.ValueMember = "ResourceID";
                SelectResCmbBox.SelectedIndex = -1;
            }
        }

        private async void AddResAllocationBtn_ClickAsync(object sender, EventArgs e)
        {
            if (Validation_Check_For_Resource_Allocation() == true)
            {
                bool success = Int32.TryParse(SelectProCmbBox.SelectedValue.ToString(), out int id1);
                bool success1 = Int32.TryParse(SelectResCmbBox.SelectedValue.ToString(), out int id2);
                if (success && success1)
                {
                    DoubleIDModel d = new DoubleIDModel { ID1 = id1, ID2 = id2 };
                    BooleanInformationModel B = await RAB.StoreResourceAllocationAsync(d);
                    if (B.TrueOrFalse)
                        MessageBox.Show("ResourceAllocation is done");
                    else
                        MessageBox.Show("ResourceAllocation can't be done");
                }
                SelectProCmbBox_SelectedIndexChangedAsync(SelectProCmbBox.SelectedValue, null);
                var projectNameOnly2 = await RAB.ShowProjectNameOnlyAsync();
                this.ChoosePrjNameCmbBox.SelectedIndexChanged -= new System.EventHandler(this.ChoosePrjNameCmbBox_SelectedIndexChangedAsync);
                ChoosePrjNameCmbBox.DataSource = projectNameOnly2;
                ChoosePrjNameCmbBox.DisplayMember = "ProjectName";
                ChoosePrjNameCmbBox.ValueMember = "ProjectID";
                ChoosePrjNameCmbBox.SelectedIndex = -1;
                this.ChoosePrjNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.ChoosePrjNameCmbBox_SelectedIndexChangedAsync);

                var project = await PB.ShowProjectDataAsync();
                ProjectDataGrid.DataSource = project;

                var projectNameOnly3 = await RAB.ShowResourceNameOnlyAsync();
                this.ChooseResNameCmbBox.SelectedIndexChanged -= new System.EventHandler(this.ChooseResNameCmbBox_SelectedIndexChangedAsync);
                ChooseResNameCmbBox.DataSource = projectNameOnly3;
                ChooseResNameCmbBox.DisplayMember = "Name";
                ChooseResNameCmbBox.ValueMember = "ResourceID";
                ChooseResNameCmbBox.SelectedIndex = -1;
                this.ChooseResNameCmbBox.SelectedIndexChanged += new System.EventHandler(this.ChooseResNameCmbBox_SelectedIndexChangedAsync);

                this.ResourceDataGrid.DataSource = null;
                //ResourceDataGrid.Rows.Clear();
                ResourceDataGrid.Refresh();
                ProjectDataGrid.DataSource = null;
                ProjectDataGrid.Rows.Clear();
                ProjectDataGrid.Refresh();
            }
        }

        private async void ChoosePrjNameCmbBox_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            if (ChoosePrjNameCmbBox.SelectedValue != null)
            {
                bool success = Int32.TryParse(ChoosePrjNameCmbBox.SelectedValue.ToString(), out int id);
                if (success)
                {
                    SingleIDModel s = new SingleIDModel() { ID1 = id };
                    var resourceNames2 = await RAB.GetResourceNamesAsync(s);
                    ResourceAllocationDataGrid.DataSource = resourceNames2;
                }
            }
        }

        private async void ChooseResNameCmbBox_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            if (ChooseResNameCmbBox.SelectedValue != null)
            {
                bool success = Int32.TryParse(ChooseResNameCmbBox.SelectedValue.ToString(), out int id);
                if (success)
                {
                    SingleIDModel s = new SingleIDModel() { ID1 = id };
                    var resourceNames2 = await RAB.GetProjectNameAllocatedToResource(s);
                    ProjectAllocationDataGrid.DataSource = resourceNames2;
                }
            }
        }

        public bool Validation_Check_For_Resource_Allocation()
        {
            if (string.IsNullOrEmpty(SelectProCmbBox.Text) || string.IsNullOrEmpty(SelectResCmbBox.Text))
            {
                MessageBox.Show("Please Select Values For Necessary Fields");
                return false;
            }
            return true;
        }
    }
}
