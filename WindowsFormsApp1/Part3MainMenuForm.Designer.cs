﻿namespace Лабораторная_работа__9_формы
{
  partial class Part3MainMenuForm
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
      this.RectangleArrayListBox = new System.Windows.Forms.ListBox();
      this.CreateDefaultArrayButton = new System.Windows.Forms.Button();
      this.CustomLengthTextBox = new System.Windows.Forms.TextBox();
      this.CreateRandomArrayButton = new System.Windows.Forms.Button();
      this.CopyArrayButton = new System.Windows.Forms.Button();
      this.InsertArrayButton = new System.Windows.Forms.Button();
      this.CreateCustomLengthArrayButton = new System.Windows.Forms.Button();
      this.ReturnButton = new System.Windows.Forms.Button();
      this.ManualInputButton = new System.Windows.Forms.Button();
      this.ManualInputTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // RectangleArrayListBox
      // 
      this.RectangleArrayListBox.FormattingEnabled = true;
      this.RectangleArrayListBox.Location = new System.Drawing.Point(12, 12);
      this.RectangleArrayListBox.Name = "RectangleArrayListBox";
      this.RectangleArrayListBox.Size = new System.Drawing.Size(488, 251);
      this.RectangleArrayListBox.TabIndex = 0;
      this.RectangleArrayListBox.DoubleClick += new System.EventHandler(this.RectangleArrayListBox_DoubleClick);
      // 
      // CreateDefaultArrayButton
      // 
      this.CreateDefaultArrayButton.Location = new System.Drawing.Point(506, 101);
      this.CreateDefaultArrayButton.Name = "CreateDefaultArrayButton";
      this.CreateDefaultArrayButton.Size = new System.Drawing.Size(147, 23);
      this.CreateDefaultArrayButton.TabIndex = 1;
      this.CreateDefaultArrayButton.Text = "Создать по умолчанию";
      this.CreateDefaultArrayButton.UseVisualStyleBackColor = true;
      this.CreateDefaultArrayButton.Click += new System.EventHandler(this.CreateDefaultArrayButton_Click);
      // 
      // CustomLengthTextBox
      // 
      this.CustomLengthTextBox.Location = new System.Drawing.Point(506, 12);
      this.CustomLengthTextBox.Name = "CustomLengthTextBox";
      this.CustomLengthTextBox.Size = new System.Drawing.Size(147, 20);
      this.CustomLengthTextBox.TabIndex = 2;
      this.CustomLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // CreateRandomArrayButton
      // 
      this.CreateRandomArrayButton.Location = new System.Drawing.Point(506, 130);
      this.CreateRandomArrayButton.Name = "CreateRandomArrayButton";
      this.CreateRandomArrayButton.Size = new System.Drawing.Size(147, 23);
      this.CreateRandomArrayButton.TabIndex = 3;
      this.CreateRandomArrayButton.Text = "Создать случайно";
      this.CreateRandomArrayButton.UseVisualStyleBackColor = true;
      this.CreateRandomArrayButton.Click += new System.EventHandler(this.CreateRandomArrayButton_Click);
      // 
      // CopyArrayButton
      // 
      this.CopyArrayButton.Location = new System.Drawing.Point(506, 159);
      this.CopyArrayButton.Name = "CopyArrayButton";
      this.CopyArrayButton.Size = new System.Drawing.Size(66, 23);
      this.CopyArrayButton.TabIndex = 4;
      this.CopyArrayButton.Text = "Copy";
      this.CopyArrayButton.UseVisualStyleBackColor = true;
      this.CopyArrayButton.Click += new System.EventHandler(this.CopyArrayButton_Click);
      // 
      // InsertArrayButton
      // 
      this.InsertArrayButton.Location = new System.Drawing.Point(587, 159);
      this.InsertArrayButton.Name = "InsertArrayButton";
      this.InsertArrayButton.Size = new System.Drawing.Size(68, 23);
      this.InsertArrayButton.TabIndex = 5;
      this.InsertArrayButton.Text = "Insert";
      this.InsertArrayButton.UseVisualStyleBackColor = true;
      this.InsertArrayButton.Click += new System.EventHandler(this.InsertArrayButton_Click);
      // 
      // CreateCustomLengthArrayButton
      // 
      this.CreateCustomLengthArrayButton.Location = new System.Drawing.Point(506, 38);
      this.CreateCustomLengthArrayButton.Name = "CreateCustomLengthArrayButton";
      this.CreateCustomLengthArrayButton.Size = new System.Drawing.Size(147, 23);
      this.CreateCustomLengthArrayButton.TabIndex = 6;
      this.CreateCustomLengthArrayButton.Text = "Создать ук. длины";
      this.CreateCustomLengthArrayButton.UseVisualStyleBackColor = true;
      this.CreateCustomLengthArrayButton.Click += new System.EventHandler(this.CreateCustomLengthArrayButton_Click);
      // 
      // ReturnButton
      // 
      this.ReturnButton.Location = new System.Drawing.Point(506, 240);
      this.ReturnButton.Name = "ReturnButton";
      this.ReturnButton.Size = new System.Drawing.Size(75, 23);
      this.ReturnButton.TabIndex = 7;
      this.ReturnButton.Text = "Назад к массивам";
      this.ReturnButton.UseVisualStyleBackColor = true;
      this.ReturnButton.Visible = false;
      this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
      // 
      // ManualInputButton
      // 
      this.ManualInputButton.Location = new System.Drawing.Point(541, 75);
      this.ManualInputButton.Name = "ManualInputButton";
      this.ManualInputButton.Size = new System.Drawing.Size(112, 20);
      this.ManualInputButton.TabIndex = 8;
      this.ManualInputButton.Text = "Создать вручную";
      this.ManualInputButton.UseVisualStyleBackColor = true;
      this.ManualInputButton.Click += new System.EventHandler(this.ManualInputButton_Click);
      // 
      // ManualInputTextBox
      // 
      this.ManualInputTextBox.Location = new System.Drawing.Point(506, 75);
      this.ManualInputTextBox.Name = "ManualInputTextBox";
      this.ManualInputTextBox.Size = new System.Drawing.Size(29, 20);
      this.ManualInputTextBox.TabIndex = 9;
      // 
      // Part3MainMenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(667, 277);
      this.Controls.Add(this.ManualInputTextBox);
      this.Controls.Add(this.ManualInputButton);
      this.Controls.Add(this.ReturnButton);
      this.Controls.Add(this.CreateCustomLengthArrayButton);
      this.Controls.Add(this.InsertArrayButton);
      this.Controls.Add(this.CopyArrayButton);
      this.Controls.Add(this.CreateRandomArrayButton);
      this.Controls.Add(this.CustomLengthTextBox);
      this.Controls.Add(this.CreateDefaultArrayButton);
      this.Controls.Add(this.RectangleArrayListBox);
      this.Name = "Part3MainMenuForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Part3";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Part3MainMenuForm_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox RectangleArrayListBox;
    private System.Windows.Forms.Button CreateDefaultArrayButton;
    private System.Windows.Forms.TextBox CustomLengthTextBox;
    private System.Windows.Forms.Button CreateRandomArrayButton;
    private System.Windows.Forms.Button CopyArrayButton;
    private System.Windows.Forms.Button InsertArrayButton;
    private System.Windows.Forms.Button CreateCustomLengthArrayButton;
    private System.Windows.Forms.Button ReturnButton;
    private System.Windows.Forms.Button ManualInputButton;
    private System.Windows.Forms.TextBox ManualInputTextBox;
  }
}