namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        comboBox1.Items.AddRange(new string[] { "Кофта", "Штаны", "Рубашка", "Куртка" });
        comboBox2.Items.AddRange(new string[] { "шелк", "синтетика", "шерсть" });
        comboBox3.Items.AddRange(new string[] { "XS", "S", "M", "L", "XL" });
        comboBox4.Items.AddRange(new string[] { "молния", "пуговицы", "ленты", "тесьма", "брошка" });
        comboBox5.Items.AddRange(new string[]
            { "срочно", "очень срочно", "максимально срочно", "экстренно", "обычно" });
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
        Console.WriteLine("");
    }

    private void label4_Click(object sender, EventArgs e)
    {
        Console.WriteLine("");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string type = comboBox1.Text;
        string material = comboBox2.Text;
        string size = comboBox3.Text;
        string type_of_accessories = comboBox4.Text;
        string count_of_accessories = textBox1.Text;
        string urgency = comboBox5.Text;
        if ((type == "") || (material == "") || (size == "") || (type_of_accessories == "") ||
            (count_of_accessories == ""))
        {
            MessageBox.Show("Одно их полей не заполненно");
        }
        else
        {
            var type_price = new Dictionary<string, double>()
            {
                { "Кофта", 1.15 },
                { "Штаны", 1.05 },
                { "Рубашка", 1.0 },
                { "Куртка", 1.5 },
            };

            var material_price = new Dictionary<string, double>()
            {
                { "шелк", 1.35 },
                { "синтетика", 0.0 },
                { "шерсть", 1.1 }
            };

            var size_price = new Dictionary<string, double>()
            {
                { "M", 0.0 },
                { "XS", 0.75 },
                { "S", 0.95 },
                { "L", 1.35 },
                { "XL", 1.55 }
            };

            var type_accessories_price = new Dictionary<string, double>()
            {
                { "молния", 15.0 },
                { "пуговицы", 1.0 },
                { "ленты", 5.0 },
                { "тесьма", 7.0 },
                { "брошка", 35.0 }
            };

            var unit_price = new Dictionary<string, double>()
            {
                { "обычно", 0.0 },
                { "срочно", 1.05 },
                { "очень срочно", 1.15 },
                { "максимально срочно", 1.25 },
                { "экстренно", 2.75 }
            };

            double shirt_price = 5000.0;
            double type_surcharge = type_price[type];
            double material_surcharge = material_price[material];
            double size_surcharge = size_price[size];
            double unit_surcharge = unit_price[urgency];
            double accessories = type_accessories_price[type_of_accessories];

            try
            {
                double count_of_accessories_int = Convert.ToDouble(count_of_accessories);
                double total_price_int =
                    (shirt_price * (material_surcharge + size_surcharge + unit_surcharge + type_surcharge)) +
                    (count_of_accessories_int * accessories);
                label8.Text = total_price_int.ToString();
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                comboBox5.Text = "";
                textBox1.Text = "";
            }
            catch (Exception)
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("В кол-во фурнитуры должно быть число");
            }
        }
    }
}