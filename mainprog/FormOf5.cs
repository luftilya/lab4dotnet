using mainprog.SubForms;
using the_three_diff_objs;

namespace mainprog;

public partial class FormOf5 : Form
{
    object[] three;

    public FormOf5()
    {
        InitializeComponent();

        three = new object[]
        {
            new Human(),
            new Car(),
            new AdminBuilding()
        };
    }

    private void human_gobutton_Click(object sender, EventArgs e)
        => new FormOfHuman(three).ShowDialog();

    private void car_gobutton_Click(object sender, EventArgs e)
        => new FormOfCar(three).ShowDialog();

    private void ab_gobutton_Click(object sender, EventArgs e)
        => new FormOfAdminBuilding(three).ShowDialog();
}
