namespace Лабораторная_работа__9_формы
{
  partial class ManualInputForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.CreateRectangleButton = new System.Windows.Forms.Button();
      this.LengthBox = new System.Windows.Forms.TextBox();
      this.CountLabel = new System.Windows.Forms.Label();
      this.WidthBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // CreateRectangleButton
      // 
      this.CreateRectangleButton.Location = new System.Drawing.Point(102, 95);
      this.CreateRectangleButton.Name = "CreateRectangleButton";
      this.CreateRectangleButton.Size = new System.Drawing.Size(75, 23);
      this.CreateRectangleButton.TabIndex = 0;
      this.CreateRectangleButton.Text = "Создать";
      this.CreateRectangleButton.UseVisualStyleBackColor = true;
      this.CreateRectangleButton.Click += new System.EventHandler(this.CreateRectangleButton_Click);
      // 
      // LengthBox
      // 
      this.LengthBox.Location = new System.Drawing.Point(34, 55);
      this.LengthBox.Name = "LengthBox";
      this.LengthBox.Size = new System.Drawing.Size(100, 20);
      this.LengthBox.TabIndex = 1;
      // 
      // CountLabel
      // 
      this.CountLabel.AutoSize = true;
      this.CountLabel.Location = new System.Drawing.Point(118, 25);
      this.CountLabel.Name = "CountLabel";
      this.CountLabel.Size = new System.Drawing.Size(35, 13);
      this.CountLabel.TabIndex = 2;
      this.CountLabel.Text = "label1";
      // 
      // WidthBox
      // 
      this.WidthBox.Location = new System.Drawing.Point(140, 55);
      this.WidthBox.Name = "WidthBox";
      this.WidthBox.Size = new System.Drawing.Size(100, 20);
      this.WidthBox.TabIndex = 3;
      // 
      // ManualInputForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(277, 151);
      this.Controls.Add(this.WidthBox);
      this.Controls.Add(this.CountLabel);
      this.Controls.Add(this.LengthBox);
      this.Controls.Add(this.CreateRectangleButton);
      this.Name = "ManualInputForm";
      this.Text = "Ручной ввод";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button CreateRectangleButton;
    private System.Windows.Forms.TextBox LengthBox;
    private System.Windows.Forms.Label CountLabel;
    private System.Windows.Forms.TextBox WidthBox;
  }
}