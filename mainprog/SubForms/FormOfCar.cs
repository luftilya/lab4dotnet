using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using the_three_diff_objs;

namespace mainprog.SubForms;

public partial class FormOfCar : Form
{
    Car car;

    public FormOfCar(object[] objs)
    {
        InitializeComponent();
        car = (Car)objs[1];

        getmodel_label.Text = car.GetModel();
        getyear_label.Text = car.GetYearRelease();
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(model_textBox.Text))
            car.SetModel(model_textBox.Text);

        if (!string.IsNullOrWhiteSpace(year_textBox.Text))
            car.SetYearRelease(year_textBox.Text);

        getmodel_label.Text = car.GetModel();
        getyear_label.Text = car.GetYearRelease();
    }
}
