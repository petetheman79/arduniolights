namespace ArduinoLightApplication
{
  partial class LightForm
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnRed = new System.Windows.Forms.Button();
      this.btnYellow = new System.Windows.Forms.Button();
      this.btnGreen = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnRed);
      this.groupBox1.Controls.Add(this.btnYellow);
      this.groupBox1.Controls.Add(this.btnGreen);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(259, 134);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Light Controls";
      // 
      // btnRed
      // 
      this.btnRed.Location = new System.Drawing.Point(172, 64);
      this.btnRed.Name = "btnRed";
      this.btnRed.Size = new System.Drawing.Size(75, 23);
      this.btnRed.TabIndex = 5;
      this.btnRed.Text = "OFF";
      this.btnRed.UseVisualStyleBackColor = true;
      this.btnRed.Click += new System.EventHandler(this.btnGreen_Click);
      // 
      // btnYellow
      // 
      this.btnYellow.Location = new System.Drawing.Point(90, 65);
      this.btnYellow.Name = "btnYellow";
      this.btnYellow.Size = new System.Drawing.Size(75, 23);
      this.btnYellow.TabIndex = 4;
      this.btnYellow.Text = "OFF";
      this.btnYellow.UseVisualStyleBackColor = true;
      this.btnYellow.Click += new System.EventHandler(this.btnGreen_Click);
      // 
      // btnGreen
      // 
      this.btnGreen.Location = new System.Drawing.Point(9, 65);
      this.btnGreen.Name = "btnGreen";
      this.btnGreen.Size = new System.Drawing.Size(75, 23);
      this.btnGreen.TabIndex = 3;
      this.btnGreen.Text = "OFF";
      this.btnGreen.UseVisualStyleBackColor = true;
      this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(197, 27);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(27, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Red";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(103, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Yellow";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Green";
      // 
      // LightForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 159);
      this.Controls.Add(this.groupBox1);
      this.Name = "LightForm";
      this.Text = "LightForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LightForm_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnRed;
    private System.Windows.Forms.Button btnYellow;
    private System.Windows.Forms.Button btnGreen;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;

  }
}