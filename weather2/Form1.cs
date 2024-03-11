using System.Diagnostics.Eventing.Reader;
using System.Text.Json;
using weather2.Models;

namespace weather2
{
    public partial class Form1 : Form
    {
        WeatherController weatherController = new WeatherController();
        Weather wr = new Weather();
        string path = "./weather.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void weatherGet_Click(object sender, EventArgs e)
        {
            if (cityName.Text != String.Empty)
            {
                wr = await weatherController.GetWeather(cityName.Text);
                string tempRounded = Math.Round(wr.Main.Temp, 2).ToString();
                string pressureRounded = Math.Round(wr.Main.Pressure * 0.75, 2).ToString();
                string humidityRounded = Math.Round(wr.Main.Humidity, 2).ToString();
                temperature.Text = $"����������� � ������ {cityName.Text} - {tempRounded} �������";
                pressure.Text = $"�������� � ������ {cityName.Text} - {pressureRounded} ��.��.������";
                humidity.Text = $"��������� � ������ {cityName.Text} - {humidityRounded}%";

                switch (wr.WeatherInfo.First().Main)
                {
                    case "scattered clouds":
                        weatherState.Text = "�������";
                        WeatherInfo.LoadAsync("https://openweathermap.org/img/wn/03n@2x.png");
                        break;
                    case "rain":
                        weatherState.Text = "��������";
                        WeatherInfo.LoadAsync("https://openweathermap.org/img/wn/10n@2x.png");
                        break;
                    case "broken clouds":
                        weatherState.Text = "������� � ������������";
                        WeatherInfo.LoadAsync("https://openweathermap.org/img/wn/10n@2x.png");
                        break;
                }
            }
            else
            {
                MessageBox.Show("������� ���������� ��������");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (temperature.Text != "�����������")
            {
                if (MessageBox.Show("��������� ������ � ����?", "����������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var json = JsonSerializer.Serialize(wr);
                    File.Create(path);
                    File.WriteAllText(path, json);
                }
            }
            else
            {
                if (MessageBox.Show("�� ����� ������ ������� ���������?", "��������", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true;
                else
                    e.Cancel = false;
            }
        }
    }
}