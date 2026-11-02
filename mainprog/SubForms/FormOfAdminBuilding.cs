using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using the_three_diff_objs;

namespace mainprog.SubForms;

public partial class FormOfAdminBuilding : Form
{
    AdminBuilding ab;

    public FormOfAdminBuilding(object[] objs)
    {
        InitializeComponent();
        ab = (AdminBuilding)objs[2];

        getname_label.Text = ab.GetName();
        getfunc_label.Text = ab.GetFunc();
        getsquare_label.Text = ab.GetSquare().ToString() + "м2";
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(name_textBox.Text))
            ab.SetName(name_textBox.Text);

        if (!string.IsNullOrWhiteSpace(func_textBox.Text))
            ab.SetFunc(func_textBox.Text);

        if (!string.IsNullOrWhiteSpace(square_textBox.Text)
            && double.TryParse(square_textBox.Text, out double square))
            ab.SetSquare(square);

        getname_label.Text = ab.GetName();
        getfunc_label.Text = ab.GetFunc();
        getsquare_label.Text = ab.GetSquare().ToString() + "м2";
    }
}
