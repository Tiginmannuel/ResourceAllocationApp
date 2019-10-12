using ResourceAllocation.Business.Models;
using ResourceAllocation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAllocation.Business
{
    public class ProjectBusiness
    {
        RESTClient web = new RESTClient();

        public async Task<BooleanInformationModel> SaveProjectValues(ProjectModel res)
        {
            return await web.PostAsync<BooleanInformationModel, ProjectModel>("project//storeproject", res);
        }

        public async Task<List<ProjectModel>> ShowProjectDataAsync()
        {
            return await web.GetAsync<List<ProjectModel>>("project//showproject");
        }
    }
}
