﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class Model : INotifyPropertyChanged
    {
        private string _name;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
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

        /// <summary>
        /// Gets or sets the Q s1.
        /// </summary>
        /// <value>The Q s1.</value>
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

        /// <summary>
        /// Gets or sets the Q s2.
        /// </summary>
        /// <value>The Q s2.</value>
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

        /// <summary>
        /// Gets or sets the Q s3.
        /// </summary>
        /// <value>The Q s3.</value>
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

        /// <summary>
        /// Gets or sets the Q s4.
        /// </summary>
        /// <value>The Q s4.</value>
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

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
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

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>The year.</value>
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
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
