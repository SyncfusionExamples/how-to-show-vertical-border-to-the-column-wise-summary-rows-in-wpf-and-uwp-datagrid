using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class Model : NotificationObject
    {
        private string _name;
       
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        private double _qS1;
      
        public double QS1
        {
            get
            {
                return _qS1;
            }
            set
            {
                _qS1 = value;
                RaisePropertyChanged("QS1");
            }
        }

        private double _qS2;
      
        public double QS2
        {
            get
            {
                return _qS2;
            }
            set
            {
                _qS2 = value;
                RaisePropertyChanged("QS2");
            }
        }

        private double _qS3;

        public double QS3
        {
            get
            {
                return _qS3;
            }
            set
            {
                _qS3 = value;
                RaisePropertyChanged("QS3");
            }
        }

        private double _qS4;
       
        public double QS4
        {
            get
            {
                return _qS4;
            }
            set
            {
                _qS4 = value;
                RaisePropertyChanged("QS4");
            }
        }

        private double _total;
      
        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                RaisePropertyChanged("Total");
            }
        }

        private int _year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
                RaisePropertyChanged("Year");
            }
        }
    }
}
