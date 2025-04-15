namespace WinFormsApp1;

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
        comboBox1 = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        comboBox2 = new System.Windows.Forms.ComboBox();
        comboBox3 = new System.Windows.Forms.ComboBox();
        comboBox4 = new System.Windows.Forms.ComboBox();
        textBox1 = new System.Windows.Forms.TextBox();
        comboBox5 = new System.Windows.Forms.ComboBox();
        button1 = new System.Windows.Forms.Button();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(279, 20);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(187, 28);
        comboBox1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(104, 21);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(158, 26);
        label1.TabIndex = 1;
        label1.Text = "Тип изделия";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(104, 65);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(157, 39);
        label2.TabIndex = 2;
        label2.Text = "Материал";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(104, 104);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(152, 39);
        label3.TabIndex = 3;
        label3.Text = "Размер";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(104, 143);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(152, 39);
        label4.TabIndex = 4;
        label4.Text = "Вид фурнитуры";
        label4.Click += label4_Click;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(104, 182);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(152, 39);
        label5.TabIndex = 5;
        label5.Text = "Кол-во фурнитуры";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(104, 221);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(158, 39);
        label6.TabIndex = 6;
        label6.Text = "Срочность";
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new System.Drawing.Point(279, 65);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new System.Drawing.Size(186, 28);
        comboBox2.TabIndex = 7;
        // 
        // comboBox3
        // 
        comboBox3.FormattingEnabled = true;
        comboBox3.Location = new System.Drawing.Point(279, 104);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new System.Drawing.Size(186, 28);
        comboBox3.TabIndex = 8;
        // 
        // comboBox4
        // 
        comboBox4.FormattingEnabled = true;
        comboBox4.Location = new System.Drawing.Point(279, 143);
        comboBox4.Name = "comboBox4";
        comboBox4.Size = new System.Drawing.Size(186, 28);
        comboBox4.TabIndex = 9;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(279, 182);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(186, 27);
        textBox1.TabIndex = 10;
        // 
        // comboBox5
        // 
        comboBox5.FormattingEnabled = true;
        comboBox5.Location = new System.Drawing.Point(279, 225);
        comboBox5.Name = "comboBox5";
        comboBox5.Size = new System.Drawing.Size(185, 28);
        comboBox5.TabIndex = 11;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(197, 280);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(169, 33);
        button1.TabIndex = 12;
        button1.Text = "Расчитать стоимость";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(104, 337);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(93, 35);
        label7.TabIndex = 13;
        label7.Text = "Цена";
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(233, 333);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(106, 38);
        label8.TabIndex = 14;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(button1);
        Controls.Add(comboBox5);
        Controls.Add(textBox1);
        Controls.Add(comboBox4);
        Controls.Add(comboBox3);
        Controls.Add(comboBox2);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.ComboBox comboBox3;
    private System.Windows.Forms.ComboBox comboBox4;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ComboBox comboBox5;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.ComboBox comboBox1;

    #endregion
}