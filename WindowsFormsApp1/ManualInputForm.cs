using System;
using System.Windows.Forms;
using static Лабораторная_работа__9_формы.Logic;

namespace Лабораторная_работа__9_формы
{
  public partial class ManualInputForm : Form
  {
    public static int length, counter = 0;
    Rectangle[] arr;
    public static string text = "Осталось элементов ";

    public void LabelUpdate() => CountLabel.Text = text + length;

    public ManualInputForm(int len)
    {
      InitializeComponent();
      length = len;
      arr = new Rectangle[length];
      LabelUpdate();
    }

    private void CreateRectangleButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(LengthBox.Text, out double len) && double.TryParse(WidthBox.Text, out double wid))
      {
        arr[counter++] = new Rectangle(len, wid);
        length--;
        LabelUpdate();
      }
      if (length == 0)
      {
        RectangleArrays.Add(new RectangleArrayClass(arr));
        this.Close();
      }
    }
  }
}
