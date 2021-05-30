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
            try
            {


                string searchName = textBoxFindNum.Text;
                var car = _entities.Car.FirstOrDefault(b => b.Number.Contains(searchName));
                if (car == null)
                {
                    MessageBox.Show("Автомобиль с таким номером не найден");

                }
                else
                {


                    textBoxNumberFind.Text = car.Number;
                    textBoxBrandFind.Text = car.Brand;
                    numericUpDownCostFind.Value = car.Cost;
                    numericUpDownCostPerDayFind.Value = car.CostPerDay;
                    textBoxType.Text = car.Type;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Во время поиска произошла ошибка ({0})", ex.Message));

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {


                string number = textBoxNumberAdd.Text;
                string brand = textBoxBrandAdd.Text;
                int cost = (int)numericUpDownCostAdd.Value;
                int costPerDay = (int)numericUpDownCostPerDayAdd.Value;
                string type = comboBoxTypeAdd.Text;

                if (number == "" || brand == "" || type == "")
                {
                    MessageBox.Show("Некоторые поля остались незаполненными. Пожалуйста заполните их ");
                    return;
                }
                if (cost == 0 || costPerDay == 0)
                {
                    MessageBox.Show("Нулевые значения стоимости не дозволены. Пожалуйста задайте другие значения");
                    return;
                }

                _entities.Car.Add(new Car()
                {
                    Number = number,
                    Brand = brand,
                    Cost = cost,
                    CostPerDay = costPerDay,
                    Type = type

                });
                _entities.SaveChanges();
                labelSucess.Text = "Succes!";

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Во время добавления произошла ошибка ({0}). Проверьте подключение к БД и корректность введенных данных и повторите попытку", ex.Message));
            }
        }
    }
}
