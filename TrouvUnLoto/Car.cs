using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace TrouvUnLoto
{
    class Car
    {
        public string Name { get; set; }
        public int Monthly { get; set; }
        public int Vr { get; set; }
        public bool IsNew { get; set; }
        public FuelType FuelType { get; set; }
        public string CanTakeBack { get; set; }

        public static List<Car> CarsArray = new List<Car>();

        public Car()
        {
        }

        public override string ToString()
        {
            return "Name:" + this.Name + ' ' +
                "; Monthly:" + Convert.ToString(this.Monthly) + ' ' +
                "; VR:" + Convert.ToString(this.Vr) +
                (this.IsNew ? "new" : "used") +
                "; FuelType:" + Convert.ToString(this.FuelType) +
                "; CanTakeBack:" + this.CanTakeBack;
        }

        public int GetMonthly()
        {
            if (this.FuelType == FuelType.GAS)
            {
                return this.Monthly + 30;
            } else if (this.FuelType == FuelType.ELECT)
            {
                return this.Monthly - 100;
            } else
            {
                return this.Monthly;
            }
        }


        public static List<Car> GetBestTuple(List<Car> carsLi)
        {
            //Tuple<Car, Car> match;
            List <Car> match = new List<Car>();
            
            Car theCarForMicra = carsLi.Find(x => x.CanTakeBack == "MICRA");
            Car theCarForLodgy = carsLi.Find(x => x.CanTakeBack == "LODGY");

            foreach (Car c in carsLi)
            {
                if(c.CanTakeBack == "MICRA")
                {
                    // For micra
                    if (c.GetMonthly() <= theCarForMicra.GetMonthly() &&
                        c.Vr >= theCarForMicra.Vr)
                    {
                        theCarForMicra = c;
                    }
                } else
                {
                    // For LODGY
                    if (c.GetMonthly() <= theCarForLodgy.GetMonthly() &&
                        c.Vr >= theCarForLodgy.Vr)
                    {
                        theCarForLodgy = c;
                    }
                }
            }

            match = new List<Car>();
            match.Add(theCarForLodgy);
            match.Add(theCarForMicra);
            //match.Item1 = carForMicra;

            return match;
        }


        public static void WriteToExcel(List<Car> carsLi)
        {
            var xlApplication = new Excel.Application();
            var workbooks = xlApplication.Workbooks;

            Excel.Workbook sampleWorkbook = workbooks.Add();

            // header
            int x = 1;
            xlApplication.Cells[x, 1] = "Name";
            xlApplication.Cells[x, 2] = "Monthly";
            xlApplication.Cells[x, 3] = "Vr";
            xlApplication.Cells[x, 4] = "IsNew";
            xlApplication.Cells[x, 5] = "CanTakeBack";
            x++;

            // body
            foreach (Car c in carsLi)
            {
                xlApplication.Cells[x, 1] = c.Name;
                xlApplication.Cells[x, 2] = c.Monthly;
                xlApplication.Cells[x, 3] = c.Vr;
                xlApplication.Cells[x, 4] = (c.IsNew ? "new" : "used");
                xlApplication.Cells[x, 5] = c.CanTakeBack;
                x++;
            }

            sampleWorkbook.SaveAs(@"C:\Users\sbastide\Documents\TEST\Output.xlsx");
            sampleWorkbook.Close();
            xlApplication.Quit();
        }

        public static List<Car> GetMockData()
        {
            List<Car> carsLi = new List<Car>();
            // 1.
            Car t = new Car();
            t.Name = "LEAF";
            t.Monthly = 479;
            t.Vr = 5400;
            t.IsNew = false;
            t.FuelType = FuelType.ELECT;
            t.CanTakeBack = "MICRA";

            carsLi.Add(t);
            // 2.
            t = new Car();
            t.Name = "LEAF";
            t.Monthly = 526;
            t.Vr = 4500;
            t.IsNew = true;
            t.FuelType = FuelType.ELECT;
            t.CanTakeBack = "MICRA";

            carsLi.Add(t);
            // 3. 
            t = new Car();
            t.Name = "MICRA";
            t.Monthly = 262;
            t.Vr = 4256;
            t.IsNew = true;
            t.FuelType = FuelType.DIESEL;
            t.CanTakeBack = "LODGY";

            carsLi.Add(t);
            // 4.
            t = new Car();
            t.Name = "C3 aircross";
            t.Monthly = 268;
            t.Vr = 7069;
            t.IsNew = false;
            t.FuelType = FuelType.DIESEL;
            t.CanTakeBack = "LODGY";

            carsLi.Add(t);
            // 5.
            t = new Car();
            t.Name = "C4 Cactus";
            t.Monthly = 312;
            t.Vr = 6230;
            t.IsNew = false;
            t.FuelType = FuelType.DIESEL;
            t.CanTakeBack = "LODGY";

            carsLi.Add(t);
            // 6.
            t = new Car();
            t.Name = "C3 shine tech";
            t.Monthly = 307;
            t.Vr = 5809;
            t.IsNew = false;
            t.FuelType = FuelType.GAS;
            t.CanTakeBack = "MICRA";

            carsLi.Add(t);
            // 7.
            t = new Car();
            t.Name = "C3 shine";
            t.Monthly = 324;
            t.Vr = 7823;
            t.IsNew = false;
            t.FuelType = FuelType.DIESEL;
            t.CanTakeBack = "MICRA";

            carsLi.Add(t);
            // 8.
            t = new Car();
            t.Name = "C3 Almond";
            t.Monthly = 286;
            t.Vr = 5098;
            t.IsNew = true;
            t.FuelType = FuelType.GAS;
            t.CanTakeBack = "MICRA";

            carsLi.Add(t);

            // =============

            Car.CarsArray = carsLi;
            return carsLi;
        }
    }

}
