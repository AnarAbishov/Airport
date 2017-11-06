using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport_Form.Models;


namespace Airport_Form
{
    public partial class Form1 : Form
    {
        private AirportEntities db = new AirportEntities();

        public Form1()
        {
            InitializeComponent();
            loadData();
            fillCompany();
            fillCountry();
            fillCity();
            fillGate();
            fillRunway();
        }

        private void loadData()
        {
            dgvFlight.DataSource = db.Flights.Select(f => new { f.id, f.CompanyId, f.Cities.CountryId, f.CityId, f.GateId, f.RunwayId }).ToList();
        }

        private void fillCompany()
        {
            List<Companies> company = db.Companies.ToList();
            foreach(Companies item in company)
            {
                cmbxCompany.Items.Add(item.Name);
            }
        }
        private void fillCountry()
        {
            List<Countries> country = db.Countries.ToList();
            foreach (Countries item in country)
            {
                cmbxCountry.Items.Add(item.Name);
            }
        }
        private void fillCity()
        {
            List<Cities> city = db.Cities.ToList();
            foreach (Cities item in city)
            {
                cmbxCity.Items.Add(item.Name);
            }
        }
        private void fillGate()
        {
            List<Gates> gate = db.Gates.ToList();
            foreach (Gates item in gate)
            {
                cmbxGate.Items.Add(item.Name);
            }
        }
        private void fillRunway()
        {
            List<Runways> runway = db.Runways.ToList();
            foreach (Runways item in runway)
            {
                cmbxRunway.Items.Add(item.Name);
            }
        }


    }
}
