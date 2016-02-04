using CL.Taksee.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIBasicApps.Common;
using UIBasicApps.Model;

namespace UIBasicApps.ViewModels
{
    class VMTitle : ViewModelBase
    {
        public string[] title = new string[5] { "List View", "Pivot", "Hub", "Flip View", "Grid View" };
        public string[] imagepath = new string[5] { "ListView.png",  "Pivot.png", "Hub.png",  "FlipView.png", "GridView.png" };

        private ObservableCollection<MTitle> _collection = new ObservableCollection<MTitle>();
        public ObservableCollection<MTitle> Collection
        {
            get { return _collection; }
            set
            {
                if (this._collection != value)
                {
                    _collection = value;
                    RaisePropertyChanged("");
                }
            }
        }

        public VMTitle(){
            this.LoadItem();    
        }
        

        private void LoadItem()
        {
            for (int i = 0; i < title.Length; i++)
            {
                MTitle mtitle = new MTitle();
                mtitle.Title = title[i].ToString();
                mtitle.ImagePath = Base.BaseUrl + imagepath[i].ToString();

                _collection.Add(mtitle);
            }
        }
    }
}
