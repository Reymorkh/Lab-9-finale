using System;
using System.Windows.Forms;
using static Лабораторная_работа__9_формы.Logic;

namespace Лабораторная_работа__9_формы
{
  public partial class Part3MainMenuForm : Form
  {
    public static bool isArray = true;
    public static int indexArr;

    public Part3MainMenuForm()
    {
      InitializeComponent();
      if (RectangleArrays.Count != 0)
        FillListBoxArrays();
    }

    public void ToggleOff()
    {
      CreateCustomLengthArrayButton.Enabled = false;
      CreateDefaultArrayButton.Enabled = false;
      CreateRandomArrayButton.Enabled = false;
      CopyArrayButton.Enabled = false;
      InsertArrayButton.Enabled = false;
      CustomLengthTextBox.Enabled = false;
      ManualInputTextBox.Enabled = false;
      ManualInputButton.Enabled = false;
      ReturnButton.Visible = true;
    }

    public void ToggleOn()
    {
      CreateCustomLengthArrayButton.Enabled = true;
      CreateDefaultArrayButton.Enabled = true;
      CreateRandomArrayButton.Enabled = true;
      CopyArrayButton.Enabled = true;
      InsertArrayButton.Enabled = true;
      ReturnButton.Visible = false;
      ManualInputTextBox.Enabled = true;
      ManualInputButton.Enabled = true;
      CustomLengthTextBox.Enabled = true;
    }

    public void FillListBoxArrays()
    {
      for (int i = 0; i < RectangleArrays.Count; i++)
        RectangleArrayListBox.Items.Add($"Массив #{i + 1} элементов в нём: {RectangleArrays[i].Length}");
    }

    public void FillListBoxRectangles(int index)
    {
      for (int i = 0; i < RectangleArrays[index].Length; i++)
        RectangleArrayListBox.Items.Add($"Прямоугольник #{i + 1} Длина: {RectangleArrays[index][i].Length:f6} Ширина: {RectangleArrays[index][i].Width:f6}");
    }

    public void AddValueToListBox() => RectangleArrayListBox.Items.Add($"Массив #{RectangleArrays.Count} элементов в нём: {RectangleArrays[RectangleArrays.Count-1].Length}");

    public void ListBoxReplaceData(int index)
    {
      RectangleArrayListBox.Items.RemoveAt(index);
      RectangleArrayListBox.Items.Insert(index, $"Массив #{index + 1} элементов в нём: {RectangleArrays[index].Length}");
    }

    private void Part3MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Dispose();
    }

    private void CreateCustomLengthArrayButton_Click(object sender, EventArgs e)
    {
      if (int.TryParse(CustomLengthTextBox.Text, out int temp))
      {
        CreateRectangleArray(temp);
        AddValueToListBox();
      }
    }

    private void CreateDefaultArrayButton_Click(object sender, EventArgs e)
    {
      CreateRectangleArray();
      AddValueToListBox();
    }

    private void CreateRandomArrayButton_Click(object sender, EventArgs e)
    {
      CreateRectangleArray(new Random());
      AddValueToListBox();
    }
    private void CopyArrayButton_Click(object sender, EventArgs e)
    {
      CopyIndexPart3 = RectangleArrayListBox.SelectedIndex;
      if (CopyIndexPart3 != -1)
        MessageBox.Show("Копируемый прямоугольник записан.", "");
    }

    private void InsertArrayButton_Click(object sender, EventArgs e)
    {
      int insertIndex = RectangleArrayListBox.SelectedIndex;
      if (CopyIndexPart3 != -1 && insertIndex  != -1)
      {
        RectangleArrays[insertIndex] = new RectangleArrayClass(RectangleArrays[CopyIndexPart3]);
        ListBoxReplaceData(insertIndex);
        CopyIndexPart3 = -1;
      }
    }

    private void ReturnButton_Click(object sender, EventArgs e)
    {
      RectangleArrayListBox.Items.Clear();
      ToggleOn();
      FillListBoxArrays();
      isArray = true;
    }

    private void RectangleArrayListBox_DoubleClick(object sender, EventArgs e)
    {
      int index = RectangleArrayListBox.SelectedIndex;
      if (index != -1)
      {
        if (isArray)
        {
          indexArr = index;
          RectangleArrayListBox.Items.Clear();
          FillListBoxRectangles(indexArr);
          isArray = false;
          ToggleOff();
        }
        else
        {
          ClassObjectEditForm f = new ClassObjectEditForm(indexArr, index);
          f.ShowDialog();
          f.Dispose();
          RectangleArrayListBox.Items.Clear();
          FillListBoxRectangles(indexArr);
        }
      }
    }

    private void ManualInputButton_Click(object sender, EventArgs e)
    {
      if (int.TryParse(ManualInputTextBox.Text, out int value) && value > 0)
      {
        ManualInputForm f = new ManualInputForm(value);
        f.ShowDialog();
        f.Dispose();
        AddValueToListBox();
      }
    }
  }
}
