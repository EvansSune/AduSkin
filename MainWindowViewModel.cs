using Prism.Mvvm;
using Prism.Regions;
using PrismRegionTest.Views;

namespace PrismRegionTest.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private IRegionManager _regionManager;
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion("HeadRegion", typeof(HeadView));
            _regionManager.RegisterViewWithRegion("LeftRegion", typeof(LeftView));
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContentView));
            _regionManager.RegisterViewWithRegion("StackPanelRegion", typeof(LeftView));

            
            //var LRegion = _regionManager.Regions["LeftRegion"]; // 对区域的访问
            

        }
    }
}
