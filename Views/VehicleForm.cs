using ConstructionApp.Views.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionApp.Views
{
    public partial class VehicleForm : UserControl
    {
        public VehicleForm()
        {
            InitializeComponent();
        }

        private void btn_lorry_Click(object sender, EventArgs e)
        {
            Lorry lorry = new Lorry();
            lorry.Show();
        }

        private void btn_cab_Click(object sender, EventArgs e)
        {
            Cab cb = new Cab();
            cb.Show();
        }

        private void btn_jeep_Click(object sender, EventArgs e)
        {
            Jeep jeep = new Jeep();
            jeep.Show();
        }

        private void btn_bike_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();
            bike.Show();
        }
    }
}
