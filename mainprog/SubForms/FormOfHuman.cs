using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using the_three_diff_objs;

namespace mainprog.SubForms;

public partial class FormOfHuman : Form
{
    Human human;

    public FormOfHuman(object[] objs)
    {
        InitializeComponent();
        human = (Human)objs[0];

        getname_label.Text = human.GetName();
        if (human.GetAge() != 0)
            getage_label.Text = human.GetAge().ToString();
        getadress_label.Text = human.GetAdress();
        getnumber_label.Text = human.GetNumber();
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(name_textBox.Text))
            human.SetName(name_textBox.Text);

        if (!string.IsNullOrWhiteSpace(age_textBox.Text)
            && double.TryParse(age_textBox.Text, out double age))
            human.SetAge(age);

        if (!string.IsNullOrWhiteSpace(adress_textBox.Text))
            human.SetAdress(adress_textBox.Text);

        if (!string.IsNullOrWhiteSpace(number_textBox.Text))
            human.SetNumber(number_textBox.Text);

        getname_label.Text = human.GetName();
        if (human.GetAge() != 0)
            getage_label.Text = human.GetAge().ToString();
        getadress_label.Text = human.GetAdress();
        getnumber_label.Text = human.GetNumber();
    }
}
