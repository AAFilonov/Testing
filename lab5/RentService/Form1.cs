using Labs5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentService
{
    public partial class Form1 : Form
    {
        TestingBaseEntities1 _entities = new TestingBaseEntities1();
        List<String> _types = new List<String>();
        public Form1()
        {
            InitializeComponent();
            _types.Add("Легковая");
            _types.Add("Грузовая");
            _types.Add("Мотоцикл");

            comboBoxTypeAdd.Items.AddRange(_types.ToArray());

        }



        private void buttonFind_Click(object sender, EventArgs e)
        {


            string searchName = textBoxFindNum.Text;
            var car = _entities.Car.FirstOrDefault(b => b.Number.Contains(searchName));

            textBoxNumberFind.Text = car.Number;
            textBoxBrandFind.Text = car.Brand;
            numericUpDownCostFind.Value = car.Cost;
            numericUpDownCostPerDayFind.Value = car.CostPerDay;
            textBoxType.Text = car.Type;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string number = textBoxNumberAdd.Text;
            string brand = textBoxBrandAdd.Text;
            int cost = (int)numericUpDownCostAdd.Value;
            int costPerDay = (int)numericUpDownCostPerDayAdd.Value;
            string type = comboBoxTypeAdd.Text;

            _entities.Car.Add(new Car()
            {
                Number = number,
                Brand = brand,
                Cost = cost,
                CostPerDay = costPerDay,
                Type = type

            });
            _entities.SaveChanges();



        }
    }
}
