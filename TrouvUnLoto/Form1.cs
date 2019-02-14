using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TrouvUnLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.initCarList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_car_Click(object sender, EventArgs e)
        {
            Car aCar = new Car();
            aCar.Name = txtb_car_name.Text;
            try
            {
                aCar.Monthly = (int)numi_car_monthly.Value;
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                aCar.Vr = (int)numi_car_vr.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            aCar.IsNew = status_new.Checked;
            if (radbtn_car_diesel.Checked)
            {
                aCar.FuelType = FuelType.DIESEL;
            } else if (radbtn_car_gas.Checked)
            {
                aCar.FuelType = FuelType.GAS;
            } else
            {
                aCar.FuelType = FuelType.ELECT;
            }
            aCar.CanTakeBack = txtb_take_back.Text;

            Car.CarsArray.Add(aCar);
            listv_cars.Items.Add(aCar.ToString());
        }

        private void onChangeStatus(object sender, EventArgs e)
        {
            //if (((RadioButton)sender).Checked == true)
            //    status = ((RadioButton)sender).Tag.ToString();
        }

        private void initCarList()
        {
            List<Car> carLi = Car.GetMockData();

            foreach(Car car in carLi)
            {
                listv_cars.Items.Add(car.ToString());
            }
        }

        private void btn_gen_excel_Click(object sender, EventArgs e)
        {

            //var xlApplication = new Excel.Application();
            //var workbooks = xlApplication.Workbooks;

            //Excel.Workbook sampleWorkbook = workbooks.Add();
            ////Excel.Worksheet sampleWorksheet = sampleWorkbook[1];
            ////Excel.Range sampleCell = sampleWorksheet.get_Range("A1");
            ////sampleCell.Value = "New Value";
            //xlApplication.Cells[1, "A"] = "TEST";
            //sampleWorkbook.SaveAs(@"C:\Users\sbastide\Documents\TEST\Output.xlsx");
            //sampleWorkbook.Close();
            //xlApplication.Quit();

            Car.WriteToExcel( Car.GetBestTuple(Car.CarsArray) );
        }
    }
}
