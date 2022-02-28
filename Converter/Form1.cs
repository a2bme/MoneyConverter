namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxFrom.SelectedIndex > -1 && comboBoxTo.SelectedIndex > -1 && textBoxFrom.Text != "")
            {
                if (comboBoxFrom.SelectedIndex == comboBoxTo.SelectedIndex)
                {
                    textBoxTo.Text = textBoxFrom.Text;
                }
                else if (comboBoxFrom.SelectedIndex == 0)
                {
                    if (comboBoxTo.SelectedIndex == 1)
                    {
                        textBoxTo.Text = Convert.ToString(Convert.ToDouble(textBoxFrom.Text) * 0.33);
                    }
                    if (comboBoxTo.SelectedIndex == 2)
                    {
                        textBoxTo.Text = Convert.ToString(Convert.ToDouble(textBoxFrom.Text) * 0.29);
                    }
                }
                else if (comboBoxFrom.SelectedIndex == 1)
                {
                    if (comboBoxTo.SelectedIndex == 0)
                    {
                        textBoxTo.Text = Convert.ToString(Convert.ToDouble(textBoxFrom.Text) * 2.99);
                    }
                    if (comboBoxTo.SelectedIndex == 2)
                    {
                        textBoxTo.Text = Convert.ToString(Convert.ToDouble(textBoxFrom.Text) * 0.88);
                    }
                }
                else if (comboBoxFrom.SelectedIndex == 2)
                {
                    if (comboBoxTo.SelectedIndex == 0)
                    {
                        textBoxTo.Text = Convert.ToString(Convert.ToDouble(textBoxFrom.Text) * 3.40);
                    }
                    if (comboBoxTo.SelectedIndex == 1)
                    {
                        textBoxTo.Text = Convert.ToString(Convert.ToDouble(textBoxFrom.Text) * 1.14);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out the blanks!!!");
            }
        }
    }
}