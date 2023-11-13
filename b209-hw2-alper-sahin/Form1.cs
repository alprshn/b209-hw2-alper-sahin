namespace b209_hw2_alper_sahin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            celciusText.TextChanged += TextBox_TextChanged;
            fahrenheitText.TextChanged += TextBox_TextChanged;
            kelvinText.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;

            if (currentTextBox == celciusText)
            {
                fahrenheitText.Enabled = false;
                kelvinText.Enabled = false;
            }
            else if (currentTextBox == fahrenheitText)
            {
                celciusText.Enabled = false;
                kelvinText.Enabled = false;
            }
            else if (currentTextBox == kelvinText)
            {
                fahrenheitText.Enabled = false;
                celciusText.Enabled = false;
            }
            currentTextBox.Enabled = true;
        }

        private void converButton_Click(object sender, EventArgs e)
        {

            if (celciusText.Enabled)
            {
                double celciusValue = Convert.ToDouble(celciusText.Text);
                fahrenheitText.Text = (celciusValue * 9 / 5 + 32).ToString();
                kelvinText.Text = (celciusValue + 273.15).ToString();
                celciusText.Enabled = true;
                fahrenheitText.Enabled = true;
                kelvinText.Enabled = true;
            }
            else if (fahrenheitText.Enabled)
            {
                double fahrenheitValue = Convert.ToDouble(fahrenheitText.Text);
                celciusText.Text = ((fahrenheitValue - 32) * 5 / 9).ToString();
                kelvinText.Text = ((fahrenheitValue - 32) * 5 / 9 + 273.15).ToString();
                fahrenheitText.Enabled = true;
                celciusText.Enabled = true;
                kelvinText.Enabled = true;
            }
            else if (kelvinText.Enabled)
            {
                double kelvinValue = Convert.ToDouble(kelvinText.Text);
                celciusText.Text = (kelvinValue - 273.15).ToString();
                fahrenheitText.Text = ((kelvinValue - 273.15) * 9 / 5 + 32).ToString();
                kelvinText.Enabled = true;
                celciusText.Enabled = true;
                fahrenheitText.Enabled = true;
            }
        }
    }
}