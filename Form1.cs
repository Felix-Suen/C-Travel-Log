using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Travel
{
    public partial class AppName : Form
    {
        public AppName()
        {
            InitializeComponent();
        }

        List<Location> locations = new List<Location>();

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path = "C:\\Users\\waiho\\source\\repos\\Travel\\Locations - Felix"))
            {
                Directory.CreateDirectory(path = "C:\\Users\\waiho\\source\\repos\\Travel\\Locations - Felix");
            }

            if (!File.Exists(path = "C:\\Users\\waiho\\source\\repos\\Travel\\Locations - Felix\\settings.xml"))
            {
                File.Create(path = "C:\\Users\\waiho\\source\\repos\\Travel\\Locations - Felix\\settings.xml"); 
            }
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Location p = new Location();
            p.City = CityText.Text;
            p.Country = CountryText.Text;
            p.Year = Int32.Parse(YearText.Text);
            locations.Add(p);
            History.Items.Add(string.Format("{0} | {1}, {2}", p.Year, p.City, p.Country));
            CityText.Clear();
            CountryText.Clear();
            YearText.Clear();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            
        }
    }

    class Location
    {
        public string City
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }
    }
}
