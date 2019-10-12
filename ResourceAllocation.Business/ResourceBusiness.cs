using ResourceAllocation.Business.Models;
using ResourceAllocation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAllocation.Business
{
    public class ResourceBusiness
    {
        RESTClient web = new RESTClient();

        public async Task<List<ResourceModel>> ShowResourceDataAsync()
        {
            return await web.GetAsync<List<ResourceModel>>("resource//showresource");
        }

        public async Task<BooleanInformationModel> SaveResourceValues(ResourceModel res)
        {
            return await web.PostAsync<BooleanInformationModel, ResourceModel>("resource//storeresource", res);
        }

    }
}
