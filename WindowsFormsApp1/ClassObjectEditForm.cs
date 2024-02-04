using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Лабораторная_работа__9_формы.Logic;

namespace Лабораторная_работа__9_формы
{
  public partial class ClassObjectEditForm : Form
  {
    int indexArr, indexRect;
    bool isPart1;

    public static void DoubleParseFailMessage() => MessageBox.Show("Не удалось преобразовать ввод в тип double.", "Ошибка");

    public ClassObjectEditForm(int number)
    {
      InitializeComponent();
      isPart1 = true;
      indexRect = number;
      LengthLabel.Text += Rectangles[indexRect].Length;
      WidthLabel.Text += Rectangles[indexRect].Width;
    }

    public ClassObjectEditForm(int number, int index)
    {
      InitializeComponent();
      isPart1 = false;
      indexArr = number;
      indexRect = index;
      LengthLabel.Text += RectangleArrays[indexArr][indexRect].Length;
      WidthLabel.Text += RectangleArrays[indexArr][indexRect].Width;
    }

    public void LabelsUpdate()
    {
      if (isPart1)
      {
        LengthLabel.Text = "Длина: " + Rectangles[indexRect].Length;
        WidthLabel.Text = "Ширина: " + Rectangles[indexRect].Width;
      }
      else
      {
        LengthLabel.Text = "Длина: " + RectangleArrays[indexArr][indexRect].Length;
        WidthLabel.Text = "Ширина: " + RectangleArrays[indexArr][indexRect].Width;
      }
    }

    private void EditLengthButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(LengthTextBox.Text, out double temp))
      {
        if (isPart1)
        {
          Rectangles[indexRect].EditLength(temp);
          LabelsUpdate();
        }
        else
        {
          RectangleArrays[indexArr][indexRect].EditLength(temp);
          LabelsUpdate();
        }
      }
      else
        DoubleParseFailMessage();
    }

    private void EditWidthButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(WidthTextBox.Text, out double temp))
      {
        if (isPart1)
        {
          Rectangles[indexRect].EditWidth(temp);
          LabelsUpdate();
        }
        else
        {
          RectangleArrays[indexArr][indexRect].EditWidth(temp);
          LabelsUpdate();
        }
      }
      else
        DoubleParseFailMessage();
    }

    private void MultiplicationButton_Click(object sender, EventArgs e)
    {
      if (double.TryParse(MultiplicationTextBox.Text, out double temp))
      {
        if (isPart1)
        {
          Rectangles[indexRect].Multiply(temp);
          LabelsUpdate();
        }
        else
        {
          RectangleArrays[indexArr][indexRect].Multiply(temp);
          LabelsUpdate();
        }
      }
      else
        DoubleParseFailMessage();

      // Снизу реализация через статичную функцию

      //if (double.TryParse(MultiplicationTextBox.Text, out double temp))
      //{
      //  if (isPart1)
      //  {
      //    Rectangle.MultiplyStatic(temp, Rectangles[indexRect]);
      //    LabelsUpdate();
      //  }
      //  else
      //  {
      //    Rectangle.MultiplyStatic(temp, RectangleArrays[indexArr][indexRect]);
      //    LabelsUpdate();
      //  }
      //}
      //else
      //  DoubleParseFailMessage();
    }
  }
}