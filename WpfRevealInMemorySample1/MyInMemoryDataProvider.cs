using InputControlSample.Data.Models;
using Reveal.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRevealInMemorySample1
{
    public class MyInMemoryDataProvider : IRVDataProvider
    {
        RVInMemoryData<Customer> _customersInMemoryData;

        public MyInMemoryDataProvider(IEnumerable<Customer> customers)
        {
            _customersInMemoryData = new RVInMemoryData<Customer>(customers);
        }

        public Task<IRVInMemoryData> GetData(RVInMemoryDataSourceItem dataSourceItem)
        {
            if (dataSourceItem.DatasetId == "customersRecords")
            {
                return Task.FromResult<IRVInMemoryData>(_customersInMemoryData);
            }
            else
            {
                throw new Exception("Invalid datasetId");
            }
        }
    }
}
