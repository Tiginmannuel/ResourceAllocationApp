using ResourceAllocation.Business.Models;
using ResourceAllocation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAllocation.Business
{
    public class ResourceAllocationBusiness
    {
        RESTClient web = new RESTClient();

        public async Task<List<ProjectNameModel>> ShowProjectNameOnlyAsync()
        {
            return await web.GetAsync<List<ProjectNameModel>>("resourceallocation//showprojectnames");
        }

        public async Task<List<ResourceNameModel>> ShowResourceNameOnlyAsync()
        {
            return await web.GetAsync<List<ResourceNameModel>>("resourceallocation//showresourcenames");
        }

        public async Task<List<ResourceNameModel>> ShowResourcesNotAssignedToTheProjectAsync(SingleIDModel s)
        {
            return await web.PostAsync<List<ResourceNameModel>, SingleIDModel>("resourceallocation//showresourcenames", s);
        }

        public async Task<BooleanInformationModel> StoreResourceAllocationAsync(DoubleIDModel d)
        {
            return await web.PostAsync<BooleanInformationModel, DoubleIDModel>("resourceallocation//storeresourceallocation", d);
        }

        public async Task<List<ResourceNameOnlyModel>> GetResourceNamesAsync(SingleIDModel single)
        {
            return await web.PostAsync<List<ResourceNameOnlyModel>, SingleIDModel>("resourceallocation//getresourcenames", single);
        }

        public async Task<List<ProjectNameOnlyModel>> GetProjectNameAllocatedToResource(SingleIDModel single)
        {
            return await web.PostAsync<List<ProjectNameOnlyModel>, SingleIDModel>("resourceallocation//getprojectnamefortheresource", single);
        }
    }
}
