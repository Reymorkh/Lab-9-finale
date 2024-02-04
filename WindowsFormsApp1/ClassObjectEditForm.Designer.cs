namespace Лабораторная_работа__9_формы
{
  partial class ClassObjectEditForm
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
            this.EditWidthButton = new System.Windows.Forms.Button();
            this.EditLengthButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.MultiplicationTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditWidthButton
            // 
            this.EditWidthButton.Location = new System.Drawing.Point(224, 87);
            this.EditWidthButton.Name = "EditWidthButton";
            this.EditWidthButton.Size = new System.Drawing.Size(75, 23);
            this.EditWidthButton.TabIndex = 0;
            this.EditWidthButton.Text = "Edit";
            this.EditWidthButton.UseVisualStyleBackColor = true;
            this.EditWidthButton.Click += new System.EventHandler(this.EditWidthButton_Click);
            // 
            // EditLengthButton
            // 
            this.EditLengthButton.Location = new System.Drawing.Point(59, 87);
            this.EditLengthButton.Name = "EditLengthButton";
            this.EditLengthButton.Size = new System.Drawing.Size(75, 23);
            this.EditLengthButton.TabIndex = 1;
            this.EditLengthButton.Text = "Edit";
            this.EditLengthButton.UseVisualStyleBackColor = true;
            this.EditLengthButton.Click += new System.EventHandler(this.EditLengthButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Location = new System.Drawing.Point(144, 145);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplicationButton.TabIndex = 2;
            this.MultiplicationButton.Text = "Multiply";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // MultiplicationTextBox
            // 
            this.MultiplicationTextBox.Location = new System.Drawing.Point(121, 116);
            this.MultiplicationTextBox.Name = "MultiplicationTextBox";
            this.MultiplicationTextBox.Size = new System.Drawing.Size(119, 20);
            this.MultiplicationTextBox.TabIndex = 3;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(12, 58);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(164, 20);
            this.LengthTextBox.TabIndex = 4;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(182, 58);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(164, 20);
            this.WidthTextBox.TabIndex = 5;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(12, 42);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(46, 13);
            this.LengthLabel.TabIndex = 6;
            this.LengthLabel.Text = "Длина: ";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(179, 42);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(52, 13);
            this.WidthLabel.TabIndex = 7;
            this.WidthLabel.Text = "Ширина: ";
            // 
            // ClassObjectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 175);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.MultiplicationTextBox);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.EditLengthButton);
            this.Controls.Add(this.EditWidthButton);
            this.MaximumSize = new System.Drawing.Size(376, 214);
            this.MinimumSize = new System.Drawing.Size(376, 214);
            this.Name = "ClassObjectEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно редактирования";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button EditWidthButton;
    private System.Windows.Forms.Button EditLengthButton;
    private System.Windows.Forms.Button MultiplicationButton;
    private System.Windows.Forms.TextBox MultiplicationTextBox;
    private System.Windows.Forms.TextBox LengthTextBox;
    private System.Windows.Forms.TextBox WidthTextBox;
    private System.Windows.Forms.Label LengthLabel;
    private System.Windows.Forms.Label WidthLabel;
  }
}