namespace WindowsFormsApp1
{
  partial class MainForm
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.RectangleListBox = new System.Windows.Forms.ListBox();
      this.SetWidthTextBox = new System.Windows.Forms.TextBox();
      this.SetLengthTextBox = new System.Windows.Forms.TextBox();
      this.ClassCounterTextBox = new System.Windows.Forms.TextBox();
      this.CreateObjectButton = new System.Windows.Forms.Button();
      this.CreateDefaultObjectButton = new System.Windows.Forms.Button();
      this.CopyRectangleButton = new System.Windows.Forms.Button();
      this.InsertRectangleButton = new System.Windows.Forms.Button();
      this.ClassCounterLabel = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.part3SwitchHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // RectangleListBox
      // 
      this.RectangleListBox.FormattingEnabled = true;
      this.RectangleListBox.Location = new System.Drawing.Point(15, 27);
      this.RectangleListBox.Name = "RectangleListBox";
      this.RectangleListBox.Size = new System.Drawing.Size(360, 173);
      this.RectangleListBox.TabIndex = 0;
      this.RectangleListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RectangleListBox_MouseDoubleClick);
      // 
      // SetWidthTextBox
      // 
      this.SetWidthTextBox.Location = new System.Drawing.Point(458, 53);
      this.SetWidthTextBox.Name = "SetWidthTextBox";
      this.SetWidthTextBox.Size = new System.Drawing.Size(70, 20);
      this.SetWidthTextBox.TabIndex = 1;
      // 
      // SetLengthTextBox
      // 
      this.SetLengthTextBox.Location = new System.Drawing.Point(378, 53);
      this.SetLengthTextBox.Name = "SetLengthTextBox";
      this.SetLengthTextBox.Size = new System.Drawing.Size(70, 20);
      this.SetLengthTextBox.TabIndex = 2;
      // 
      // ClassCounterTextBox
      // 
      this.ClassCounterTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.ClassCounterTextBox.Location = new System.Drawing.Point(378, 27);
      this.ClassCounterTextBox.Name = "ClassCounterTextBox";
      this.ClassCounterTextBox.ReadOnly = true;
      this.ClassCounterTextBox.Size = new System.Drawing.Size(150, 20);
      this.ClassCounterTextBox.TabIndex = 3;
      this.ClassCounterTextBox.Text = "0";
      this.ClassCounterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // CreateObjectButton
      // 
      this.CreateObjectButton.Location = new System.Drawing.Point(417, 79);
      this.CreateObjectButton.Name = "CreateObjectButton";
      this.CreateObjectButton.Size = new System.Drawing.Size(75, 23);
      this.CreateObjectButton.TabIndex = 4;
      this.CreateObjectButton.Text = "Создать";
      this.CreateObjectButton.UseVisualStyleBackColor = true;
      this.CreateObjectButton.Click += new System.EventHandler(this.CreateObjectButton_Click);
      // 
      // CreateDefaultObjectButton
      // 
      this.CreateDefaultObjectButton.Location = new System.Drawing.Point(378, 108);
      this.CreateDefaultObjectButton.Name = "CreateDefaultObjectButton";
      this.CreateDefaultObjectButton.Size = new System.Drawing.Size(150, 23);
      this.CreateDefaultObjectButton.TabIndex = 5;
      this.CreateDefaultObjectButton.Text = "Создать по умолчанию";
      this.CreateDefaultObjectButton.UseVisualStyleBackColor = true;
      this.CreateDefaultObjectButton.Click += new System.EventHandler(this.CreateDefaultObjectButton_Click);
      // 
      // CopyRectangleButton
      // 
      this.CopyRectangleButton.Location = new System.Drawing.Point(378, 138);
      this.CopyRectangleButton.Name = "CopyRectangleButton";
      this.CopyRectangleButton.Size = new System.Drawing.Size(75, 23);
      this.CopyRectangleButton.TabIndex = 6;
      this.CopyRectangleButton.Text = "Copy";
      this.CopyRectangleButton.UseVisualStyleBackColor = true;
      this.CopyRectangleButton.Click += new System.EventHandler(this.CopyRectangleButton_Click);
      // 
      // InsertRectangleButton
      // 
      this.InsertRectangleButton.Location = new System.Drawing.Point(453, 138);
      this.InsertRectangleButton.Name = "InsertRectangleButton";
      this.InsertRectangleButton.Size = new System.Drawing.Size(75, 23);
      this.InsertRectangleButton.TabIndex = 7;
      this.InsertRectangleButton.Text = "Insert";
      this.InsertRectangleButton.UseVisualStyleBackColor = true;
      this.InsertRectangleButton.Click += new System.EventHandler(this.InsertRectangleButton_Click);
      // 
      // ClassCounterLabel
      // 
      this.ClassCounterLabel.AutoSize = true;
      this.ClassCounterLabel.Location = new System.Drawing.Point(378, 9);
      this.ClassCounterLabel.Name = "ClassCounterLabel";
      this.ClassCounterLabel.Size = new System.Drawing.Size(137, 13);
      this.ClassCounterLabel.TabIndex = 8;
      this.ClassCounterLabel.Text = "Счётчик объектов класса";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(378, 177);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 9;
      this.button1.Text = "Inc";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.IncrementButton_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(453, 177);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 10;
      this.button2.Text = "Dec";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.DecrementButton_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.part3SwitchHereToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(540, 24);
      this.menuStrip1.TabIndex = 11;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // part3SwitchHereToolStripMenuItem
      // 
      this.part3SwitchHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchToolStripMenuItem});
      this.part3SwitchHereToolStripMenuItem.Name = "part3SwitchHereToolStripMenuItem";
      this.part3SwitchHereToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
      this.part3SwitchHereToolStripMenuItem.Text = "Part3SwitchHere";
      // 
      // switchToolStripMenuItem
      // 
      this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
      this.switchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.switchToolStripMenuItem.Text = "Switch";
      this.switchToolStripMenuItem.Click += new System.EventHandler(this.switchToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(540, 217);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.ClassCounterLabel);
      this.Controls.Add(this.InsertRectangleButton);
      this.Controls.Add(this.CopyRectangleButton);
      this.Controls.Add(this.CreateDefaultObjectButton);
      this.Controls.Add(this.CreateObjectButton);
      this.Controls.Add(this.ClassCounterTextBox);
      this.Controls.Add(this.SetLengthTextBox);
      this.Controls.Add(this.SetWidthTextBox);
      this.Controls.Add(this.RectangleListBox);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MainForm";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox RectangleListBox;
    private System.Windows.Forms.TextBox SetWidthTextBox;
    private System.Windows.Forms.TextBox SetLengthTextBox;
    private System.Windows.Forms.TextBox ClassCounterTextBox;
    private System.Windows.Forms.Button CreateObjectButton;
    private System.Windows.Forms.Button CreateDefaultObjectButton;
    private System.Windows.Forms.Button CopyRectangleButton;
    private System.Windows.Forms.Button InsertRectangleButton;
    private System.Windows.Forms.Label ClassCounterLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem part3SwitchHereToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
  }
}

