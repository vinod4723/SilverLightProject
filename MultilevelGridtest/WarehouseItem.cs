using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MultilevelGridtest
{
    /// <summary>
    /// added comments
    /// </summary>
    public class MyItems: INotifyPropertyChanged
    {
        private bool isExpanded;
        private string name;
        private int count;
        private string code;

        public event PropertyChangedEventHandler PropertyChanged;

        public MyItems(string name, int count, bool isExpanded = true, string code1 = "abc02")
        {
            this.Name = name;
            this.Count = count;
            this.Code = code1;
            this.IsExpanded = isExpanded;
            this.Items = new ObservableCollection<MyItems>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        public bool IsExpanded
        {
            get
            {
                return this.isExpanded;
            }
            set
            {
                if (value != this.isExpanded)
                {
                    this.isExpanded = value;
                    this.OnPropertyChanged("IsExpanded");
                }
            }
        }
        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                if (value != this.count)
                {
                    this.count = value;
                    this.OnPropertyChanged("Count");
                }
            }
        }


        [Display(AutoGenerateField = false)]
        public ObservableCollection<MyItems> Items { get; set; }
        public string Code
        {
            get
            {
                return this.code;
            }
            set
            {
                if (value != this.code)
                {
                    this.code = value;
                    this.OnPropertyChanged("Code");
                }
            }
        }
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
    public class WarehouseItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool isExpanded;
        private string name;
        private int count;
        private string code;

        public WarehouseItem(string name, int count, bool isExpanded = true,string code1="abc02")
        {
            this.Name = name;
            this.Count = count;
            this.Code = code1;
            this.IsExpanded = isExpanded;
            this.Items = new ObservableCollection<MyItems>();
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        public bool IsExpanded
        {
            get
            {
                return this.isExpanded;
            }
            set
            {
                if (value != this.isExpanded)
                {
                    this.isExpanded = value;
                    this.OnPropertyChanged("IsExpanded");
                }
            }
        }

        [Display(AutoGenerateField = false)]
        public ObservableCollection<MyItems> Items { get; set; }



        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                if (value != this.count)
                {
                    this.count = value;
                    this.OnPropertyChanged("Count");
                }
            }
        }
        public string Code {
            get
            {
                return this.code;
            }
            set
            {
                if (value != this.code)
                {
                    this.code = value;
                    this.OnPropertyChanged("Code");
                }
            }
        }
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return this.Name;
        }
    }

    public class ProductSales
    {
        public ProductSales(int quantity, int month, string monthName)
        {
            this.Quantity = quantity;
            this.Month = month;
            this.MonthName = monthName;
        }
        public int Quantity
        {
            get;
            set;
        }
        public int Month
        {
            get;
            set;
        }
        public string MonthName
        {
            get;
            set;
        }

       
    }
}
