using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            GeoSharp.ReverseGeoCode geocode = new GeoSharp.ReverseGeoCode(@"allCountries.txt", true  );
            var rrr=geocode.NearestPlace(40.730885, -73.997383);

        }
    }
}
