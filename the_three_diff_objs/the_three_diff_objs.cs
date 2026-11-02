using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_three_diff_objs
{
    public class Human
    {
        string name, adress, number;
        double age;

        public Human()
        {
            name = null;
            adress = null;
            number = null;
            age = 0;
        }
        public Human(string name, string adress, string number, double age)
        {
            this.name = name;
            this.adress = adress;
            this.number = number;
            this.age = age;
        }
        public void SetName(string name) => this.name = name;
        public string GetName() => name;
        public void SetAdress(string adress) => this.adress = adress;
        public string GetAdress() => adress;
        public void SetNumber(string number) => this.number = number;
        public string GetNumber() => number;
        public void SetAge(double age) => this.age = age;
        public double GetAge() => age;
    }

    public class Car
    {
        string model, year_release;

        public Car()
        {
            model = null;
            year_release = null;
        }
        public Car(string model, string year_release)
        {
            this.model = model;
            this.year_release = year_release;
        }
        public void SetModel(string model) => this.model = model;
        public string GetModel() => model;
        public void SetYearRelease(string year_release)
            => this.year_release = year_release;
        public string GetYearRelease() => year_release;
    }

    public class AdminBuilding
    {
        string name, func;
        double square;

        public AdminBuilding()
        {
            name = null;
            func = null;
            square = 0;
        }
        public AdminBuilding(string name, string func, double square)
        {
            this.name = name;
            this.func = func;
            this.square = square;
        }
        public void SetName(string name) => this.name = name;
        public string GetName() => name;
        public void SetFunc(string func) => this.func = func;
        public string GetFunc() => func;
        public void SetSquare(double square) => this.square = square;
        public double GetSquare() => square;
    }
}
