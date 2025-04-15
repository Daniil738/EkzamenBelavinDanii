namespace WinFormsAppForTask3;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        button1 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        textBox1 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(233, 261);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(165, 41);
        button1.TabIndex = 0;
        button1.Text = "Расчитать";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(163, 134);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(104, 30);
        label1.TabIndex = 1;
        label1.Text = "Расстояние";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(162, 181);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(104, 27);
        label2.TabIndex = 2;
        label2.Text = "Грузчики";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(316, 178);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(131, 28);
        comboBox1.TabIndex = 3;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(316, 126);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(130, 27);
        textBox1.TabIndex = 4;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(171, 341);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(133, 39);
        label3.TabIndex = 5;
        label3.Text = "Итоговая цена";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(334, 334);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(135, 45);
        label4.TabIndex = 6;
        label4.Click += label4_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(textBox1);
        Controls.Add(comboBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox textBox1;

    #endregion
}