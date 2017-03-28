using System;
using System.Collections.ObjectModel;
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
    public class MyDataContext
    {
        ObservableCollection<WarehouseItem> warehouseData;
        public ObservableCollection<WarehouseItem> WarehouseData
        {
            get
            {
                if (warehouseData == null)
                {
                    warehouseData = new ObservableCollection<WarehouseItem>();
                    var drinks = new WarehouseItem("Drinks", 35);
                    drinks.Items.Add(new MyItems("Water", 10));
                    var tea = new MyItems("Tea", 20);
                    var tea1 = new MyItems("Black", 10);
                    tea1.Items.Add(new MyItems("yellow", 10));
                    var tea2 = new MyItems("Red", 10);
                    tea2.Items.Add(new MyItems("Green", 10));
                    tea1.Items.Add(tea2);
                    tea.Items.Add(tea1);
                    tea.Items.Add(new MyItems("Green", 10));
                    drinks.Items.Add(tea);
                    drinks.Items.Add(new MyItems("Coffee", 5));
                    warehouseData.Add(drinks);

                    var vegetables = new WarehouseItem("Vegetables", 75);
                    vegetables.Items.Add(new MyItems("Tomato", 40));
                    vegetables.Items.Add(new MyItems("Carrot", 25));
                    vegetables.Items.Add(new MyItems("Onion", 10));
                    warehouseData.Add(vegetables);

                    var fruits = new WarehouseItem("Fruits", 55);
                    fruits.Items.Add(new MyItems("Cherry", 30));
                    fruits.Items.Add(new MyItems("Apple", 20));
                    fruits.Items.Add(new MyItems("Melon", 5));
                    warehouseData.Add(fruits);
                }

                return warehouseData;
            }
        }
    }
}
