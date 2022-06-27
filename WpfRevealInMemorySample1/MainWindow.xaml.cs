using InputControlSample.Repositories;
using InputControlSample.Services;
using Reveal.Sdk;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;




namespace WpfRevealInMemorySample1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        private ICustomerService _customerService;

        public MainWindow()
        {
            InitializeComponent();

            _customerService = new CustomerService(new CustomerRepositoryDapper());

            _revealView.Dashboard = new RVDashboard();

            var customers = _customerService.GetAll();
            RevealSdkSettings.DataProvider = new MyInMemoryDataProvider(customers);
        }

        private void RevealView_DataSourcesRequested(object sender, DataSourcesRequestedEventArgs e)
        {
            List<RVDashboardDataSource> datasources = new List<RVDashboardDataSource>();
            List<RVDataSourceItem> datasourceItems = new List<RVDataSourceItem>();

            var inMemoryDataSourceItem = new RVInMemoryDataSourceItem("customersRecords")
            {
                Title = "Customers Records"
            };

            datasourceItems.Add(inMemoryDataSourceItem);

            e.Callback(new RevealDataSources(datasources, datasourceItems, true));
        }
    }
}
