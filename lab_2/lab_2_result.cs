public partial class BaseForm : Form
{
  public BaseForm()
  {
    InitializeComponent();
  }

  private void submitButton(object sender, EventArgs e)
  {
    if (int.TryParse(textBox1.Text, out int s) && int.TryParse(textBox2.Text, out int t))
    {
      if (t != 0)
      {
        int v = s / t;
        label4.Text = v.ToString();
      }
      else
      {
        MessageBox.Show("Час не може бути нулем!");
      }
    }
    else
    {
      MessageBox.Show("Некоректно введені дані!");
    }
  }
}
