using System;
using System.Windows.Forms;
using static Лабораторная_работа__9_формы.Logic;
using Rectangle = Лабораторная_работа__9_формы.Rectangle;

namespace WindowsFormsApp1
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    public void AddValueToListBox(int index) => RectangleListBox.Items.Add($"Прямоугольник #{index} Длина: {Rectangles[index].Length:f6} Ширина: {Rectangles[index].Width:f6}");

    public void ListBoxDataReplacement(int index)
    {
      RectangleListBox.Items.RemoveAt(index);
      RectangleListBox.Items.Insert(index, $"Прямоугольник #{index} Длина: {Rectangles[index].Length:f6} Ширина: {Rectangles[index].Width:f6}");
    }

    public void ValueUpdate() => ClassCounterTextBox.Text = Convert.ToString(Rectangle.Count);

    #region Create Rectangle Buttons
    private void CreateObjectButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(SetLengthTextBox.Text, out double length) && double.TryParse(SetWidthTextBox.Text, out double width))
      {
        CreateRectangle(length, width);
        ValueUpdate();
        AddValueToListBox(Rectangles.Count - 1);
      }
      else
        MessageBox.Show("Произошла ошибка при преобразовании введённых значений в тип double.");
    }

    private void CreateDefaultObjectButton_Click(object sender, EventArgs e)
    {
      CreateRectangle();
      ValueUpdate();
      AddValueToListBox(Rectangles.Count - 1);
    }
    #endregion

    private void RectangleListBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      int index = RectangleListBox.SelectedIndex;
      if (index != -1)
      {
        ClassObjectEditForm f = new ClassObjectEditForm(index);
        f.ShowDialog();
        f.Dispose();
        ValueUpdate();
        ListBoxDataReplacement(index);
      }
    }

    private void CopyRectangleButton_Click(object sender, EventArgs e)
    {
      int temp = RectangleListBox.SelectedIndex;
      if (temp != -1)
      {
        CopyIndex = temp;
        MessageBox.Show("Копируемый прямоугольник записан.", "");
      }
    }

    private void InsertRectangleButton_Click(object sender, EventArgs e)
    {
      int temp = RectangleListBox.SelectedIndex;
      if (CopyIndex != -1 && temp != CopyIndex)
      {
        Rectangles[temp] = new Rectangle(Rectangles[CopyIndex]);
        ValueUpdate();
        ListBoxDataReplacement(temp);
        CopyIndex = -1;
      }
    }

    private void IncrementButton_Click(object sender, EventArgs e)
    {
      int index = RectangleListBox.SelectedIndex;
      if (index != -1)
      {
        Rectangle rect = Rectangles[index];
        rect++;
        Rectangles[index] = rect;
        ValueUpdate();
        ListBoxDataReplacement(index);
      }
    }

    private void DecrementButton_Click(object sender, EventArgs e)
    {
      int index = RectangleListBox.SelectedIndex;
      if (index != -1)
      {
        Rectangle rect = Rectangles[index];
        rect--;
        Rectangles[index] = rect;
        ValueUpdate();
        ListBoxDataReplacement(index);
      }
    }

    private void switchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Hide();
      new Part3MainMenuForm().ShowDialog();
      Show();
    }
  }
}