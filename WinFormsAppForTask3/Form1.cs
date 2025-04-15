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
        if (movers_status == "")
        {
            MessageBox.Show("Введите значение для грузчиков");
        }
        try
        {
            if (movers_status == "Да")
            {
                double price = LibraryForTask2.lib.spend(int.Parse(distant_str), true);
                label4.Text = price.ToString();
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Ошибка при рассчете");
        }

        try
        {
            if (movers_status == "Нет")
            {
                double price = LibraryForTask2.lib.spend(int.Parse(distant_str), false);
                label4.Text = price.ToString();
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Ошибка при рассчете. Проверьте правильность ввод числа");
        }
    }

    private void label4_Click(object sender, EventArgs e)
    {
        Console.WriteLine("");
    }
}