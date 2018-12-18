using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        private ObservableCollection<Model> _SalesDetails = null;

        public ObservableCollection<Model> YearlySalesDetails
        {
            get { return _SalesDetails; }
            set { _SalesDetails = value; }
        }

        public ViewModel()
        {
            _SalesDetails = new ObservableCollection<Model>();
            for (int i = 1; i <= 2; i++)
            {
                _SalesDetails.Add(new Model() { Name = "LL Road Frame", QS1 = 100, QS2 = 34, QS3 = 12, QS4 = 12, Total = 100 + 34 + 12 + 12, Year = 2001 });
                _SalesDetails.Add(new Model() { Name = "LL Road Frame", QS1 = 133, QS2 = 89, QS3 = 44, QS4 = 323, Total = 133 + 89 + 44 + 323, Year = 2002 });

                _SalesDetails.Add(new Model() { Name = "LL Road Frame", QS1 = 13, QS2 = 34, QS3 = 44, QS4 = 45, Total = 13 + 34 + 44 + 45, Year = 2003 });
                _SalesDetails.Add(new Model() { Name = "HL Mountain Frame ", QS1 = 14, QS2 = 12, QS3 = 94, QS4 = 12, Total = 14 + 12 + 94 + 12, Year = 2003 });

                _SalesDetails.Add(new Model() { Name = "Road-150", QS1 = 130, QS2 = 34, QS3 = 84, QS4 = 123, Total = 130 + 34 + 84 + 123, Year = 2004 });
                _SalesDetails.Add(new Model() { Name = "Road-450", QS1 = 123, QS2 = 3282, QS3 = 14, QS4 = 565, Total = 123 + 3282 + 14 + 565, Year = 2005 });

                _SalesDetails.Add(new Model() { Name = "Long-Sleeve Logo Jersey", QS1 = 233, QS2 = 34, QS3 = 84, QS4 = 123, Total = 233 + 34 + 84 + 123, Year = 2004 });
                _SalesDetails.Add(new Model() { Name = "L-Sleeve Jersey", QS1 = 223, QS2 = 3282, QS3 = 14, QS4 = 565, Total = 223 + 3282 + 14 + 565, Year = 2005 });

                _SalesDetails.Add(new Model() { Name = "Long-Sleeve Logo Jersey", QS1 = 100, QS2 = 34, QS3 = 12, QS4 = 12, Total = 100 + 34 + 12 + 12, Year = 2001 });
                _SalesDetails.Add(new Model() { Name = "ML Road Frame ", QS1 = 133, QS2 = 89, QS3 = 44, QS4 = 323, Total = 133 + 89 + 44 + 323, Year = 2002 });

                _SalesDetails.Add(new Model() { Name = "HL Mountain Frame ", QS1 = 13, QS2 = 34, QS3 = 44, QS4 = 45, Total = 13 + 34 + 44 + 45, Year = 2003 });
                _SalesDetails.Add(new Model() { Name = "HL Mountain Frame ", QS1 = 14, QS2 = 12, QS3 = 94, QS4 = 12, Total = 14 + 12 + 94 + 12, Year = 2003 });

                _SalesDetails.Add(new Model() { Name = "Road-150", QS1 = 130, QS2 = 34, QS3 = 84, QS4 = 123, Total = 130 + 34 + 84 + 123, Year = 2004 });
                _SalesDetails.Add(new Model() { Name = "Road-150", QS1 = 123, QS2 = 3282, QS3 = 14, QS4 = 565, Total = 123 + 3282 + 14 + 565, Year = 2005 });
            }
        }
    }
}
