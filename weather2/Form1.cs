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
                temperature.Text = $"Температура в городе {cityName.Text} - {tempRounded} цельсия";
                pressure.Text = $"Давление в городе {cityName.Text} - {pressureRounded} мм.рт.столба";
                humidity.Text = $"Влажность в городе {cityName.Text} - {humidityRounded}%";

                switch (wr.WeatherInfo.First().Main)
                {
                    case "scattered clouds":
                        weatherState.Text = "Облачно";
                        WeatherInfo.LoadAsync("https://openweathermap.org/img/wn/03n@2x.png");
                        break;
                    case "rain":
                        weatherState.Text = "Дождливо";
                        WeatherInfo.LoadAsync("https://openweathermap.org/img/wn/10n@2x.png");
                        break;
                    case "broken clouds":
                        weatherState.Text = "Облачно с прояснениями";
                        WeatherInfo.LoadAsync("https://openweathermap.org/img/wn/10n@2x.png");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Введите корректное значение");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (temperature.Text != "Температура")
            {
                if (MessageBox.Show("Сохранить данные в файл?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var json = JsonSerializer.Serialize(wr);
                    File.Create(path);
                    File.WriteAllText(path, json);
                }
            }
            else
            {
                if (MessageBox.Show("Вы точно хотите закрыть программу?", "Закрытие", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true;
                else
                    e.Cancel = false;
            }
        }
    }
}