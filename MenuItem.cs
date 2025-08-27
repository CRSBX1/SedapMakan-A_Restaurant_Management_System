using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedapMakan
{
    public class MenuItem
    {
        public long menuId { get; set; }
        public string menuName { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
        public bool isAvailable { get; set; }
    }

    public class CustomerMenuItem
    {
        private string MenuName;
        private int Amount;
        private decimal Price;
        private decimal TotalPrice;


        public CustomerMenuItem(string name, int amount, decimal price)
        {
            MenuName = name;
            Amount = amount;
            Price = price;
        }

        public decimal CalculateTotalPrice()
        {
            TotalPrice = Amount * Price;
            return TotalPrice;
        }

        public string Menuname
        {
            get {  return MenuName; }
            set { MenuName = value; }
        }

        public int MenuAmount
        {
            get { return Amount; }
            set { Amount = value; }
        }

        public decimal Menuprice
        {
            get { return Price; }
            set { Price = value; }
        }
    }

    public static class Cartlist
    {
        public static List<CustomerMenuItem> customercart = new List<CustomerMenuItem>();
    }
   

    public static class DatabaseConn
    {
        public static SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;Initial Catalog = SedapMakan; Integrated Security = True");
    }

}
