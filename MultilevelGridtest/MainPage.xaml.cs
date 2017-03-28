using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Telerik.Windows.Controls.Charting;

namespace MultilevelGridtest
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MyDataContext();

            SeriesMapping seriesMapping = new SeriesMapping();
            seriesMapping.LegendLabel = "Product Sales";
            seriesMapping.SeriesDefinition = new SplineSeriesDefinition();
            seriesMapping.ItemMappings.Add(new ItemMapping("Quantity", DataPointMember.YValue));
            seriesMapping.ItemMappings.Add(new ItemMapping("MonthName", DataPointMember.XCategory));
            radChart.SeriesMappings.Add(seriesMapping);
            this.radChart.ItemsSource = this.CreateData();

        }

        private List<ProductSales> CreateData()
        {
            List<ProductSales> persons = new List<ProductSales>();
            persons.Add(new ProductSales(154, 1, "January"));
            persons.Add(new ProductSales(138, 2, "February"));
            persons.Add(new ProductSales(143, 3, "March"));
            persons.Add(new ProductSales(120, 4, "April"));
            persons.Add(new ProductSales(135, 5, "May"));
            persons.Add(new ProductSales(125, 6, "June"));
            persons.Add(new ProductSales(179, 7, "July"));
            persons.Add(new ProductSales(170, 8, "August"));
            persons.Add(new ProductSales(198, 9, "September"));
            persons.Add(new ProductSales(187, 10, "October"));
            persons.Add(new ProductSales(193, 11, "November"));
            persons.Add(new ProductSales(212, 12, "December"));
            return persons;
        }
    }
}
