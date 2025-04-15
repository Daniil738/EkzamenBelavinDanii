namespace WinFormsAppForTask3;
using LibraryForTask2;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        comboBox1.Items.AddRange(new string[] { "Да", "Нет"});
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string movers_status = comboBox1.Text;
        string distant_str = textBox1.Text;
        int distant_int = int.Parse(distant_str); 
        if (movers_status == "Да")
        {
            double price = LibraryForTask2.lib.spend(distant_int, true);
            label4.Text = price.ToString();
        }
        else
        {
            double price = LibraryForTask2.lib.spend(distant_int, false);
            label4.Text = price.ToString();
        }
    }

    private void label4_Click(object sender, EventArgs e)
    {
        Console.WriteLine("");
    }
}