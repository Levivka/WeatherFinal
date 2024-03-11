namespace weather2
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            weatherGet = new Button();
            cityName = new TextBox();
            WeatherInfo = new PictureBox();
            temperature = new Label();
            humidity = new Label();
            pressure = new Label();
            weatherState = new Label();
            ((System.ComponentModel.ISupportInitialize)WeatherInfo).BeginInit();
            SuspendLayout();
            // 
            // weatherGet
            // 
            weatherGet.Location = new Point(277, 88);
            weatherGet.Name = "weatherGet";
            weatherGet.Size = new Size(161, 23);
            weatherGet.TabIndex = 0;
            weatherGet.Text = "Узнать погоду";
            weatherGet.UseVisualStyleBackColor = true;
            weatherGet.Click += weatherGet_Click;
            // 
            // cityName
            // 
            cityName.Location = new Point(277, 44);
            cityName.Name = "cityName";
            cityName.Size = new Size(161, 23);
            cityName.TabIndex = 1;
            // 
            // WeatherInfo
            // 
            WeatherInfo.Location = new Point(388, 141);
            WeatherInfo.Name = "WeatherInfo";
            WeatherInfo.Size = new Size(192, 168);
            WeatherInfo.SizeMode = PictureBoxSizeMode.Zoom;
            WeatherInfo.TabIndex = 2;
            WeatherInfo.TabStop = false;
            // 
            // temperature
            // 
            temperature.AutoSize = true;
            temperature.Location = new Point(12, 164);
            temperature.Name = "temperature";
            temperature.Size = new Size(78, 15);
            temperature.TabIndex = 3;
            temperature.Text = "Температура";
            temperature.Click += label1_Click;
            // 
            // humidity
            // 
            humidity.AutoSize = true;
            humidity.Location = new Point(12, 197);
            humidity.Name = "humidity";
            humidity.Size = new Size(67, 15);
            humidity.TabIndex = 4;
            humidity.Text = "Влажность";
            // 
            // pressure
            // 
            pressure.AutoSize = true;
            pressure.Location = new Point(12, 231);
            pressure.Name = "pressure";
            pressure.Size = new Size(60, 15);
            pressure.TabIndex = 5;
            pressure.Text = "Давление";
            // 
            // weatherState
            // 
            weatherState.AutoSize = true;
            weatherState.Location = new Point(633, 141);
            weatherState.Name = "weatherState";
            weatherState.Size = new Size(47, 15);
            weatherState.TabIndex = 6;
            weatherState.Text = "Погода";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(weatherState);
            Controls.Add(pressure);
            Controls.Add(humidity);
            Controls.Add(temperature);
            Controls.Add(WeatherInfo);
            Controls.Add(cityName);
            Controls.Add(weatherGet);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)WeatherInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button weatherGet;
        private TextBox cityName;
        private PictureBox WeatherInfo;
        private Label temperature;
        private Label humidity;
        private Label pressure;
        private Label weatherState;
    }
}