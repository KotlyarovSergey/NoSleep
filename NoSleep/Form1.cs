using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NoSleep
{
    public partial class Form1 : Form
    {
        public static Boolean NoSleepFlag = false;

        //  -----------     ИМПОРТ БИБЛИОТЕК -------------
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //public static extern int SetThreadExecutionState(ES_CONTINUOUS | ES_SYSTEM_REQUIRED | ES_AWAYMODE_REQUIRED);
        public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE flags);

        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_SYSTEM_REQUIRED = 0x00000001,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_CONTINUOUS = 0x80000000
        }

        // Unmanaged function from user32.dll
        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        // Struct we'll need to pass to the function
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }
        // -----------------------------------------------

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartStop();
        }


        // Запуск/остановка программы
        private void StartStop()
        {
            // нормальное состояние (нажатие стоп)
            if (Form1.NoSleepFlag)
            {
                NoSleepFlag = false;
                btnStart.Text = "START";
                // Отменяем запрет сна
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
                //timer1.Start();
                pictureBox1.Image = global::NoSleep.Properties.Resources.StartPict;
                notifyIcon1.Text = "NoSleep остановлен";
            }
            else    // Запрет сна!!  (нажатие старт)
            {
                NoSleepFlag = true;
                btnStart.Text = "STOP";
                lblVremyaProstoya.Text = "Система бодрствует";
                //timer1.Stop();
                // Запрещаем переходить в сон:
                SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS);
                pictureBox1.Image = global::NoSleep.Properties.Resources.StopPict;
                notifyIcon1.Text = "NoSleep запущен";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
            // Получаем симтемное время в тактах
            int systemUptime = Environment.TickCount;

            // Время (в тактах) последнего события
            int LastInputTicks = 0;

            // разница м/у временем последнего события и ситсемного времени
            int IdleTicks = 0;

            // Создем структуру LastInputInfo
            LASTINPUTINFO LastInputInfo = new LASTINPUTINFO();
            LastInputInfo.cbSize = (uint)Marshal.SizeOf(LastInputInfo);
            LastInputInfo.dwTime = 0;
            
            // Получаем время последнего ввода (события)
            if (GetLastInputInfo(ref LastInputInfo))
            {
                // Get the number of ticks at the point when the last activity was seen
                LastInputTicks = (int)LastInputInfo.dwTime;
                
                // время простоя = разница м\у временем события и текущим временем
                IdleTicks = systemUptime - LastInputTicks;

                string vrpr = "Время простоя системы: " + Convert.ToString(IdleTicks / 1000) + " сек.";
                lblVremyaProstoya.Text = vrpr;
            }
            //timer1.Start();
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VosstanovitFormu();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            VosstanovitFormu();
        }

        // восстанавливаем форму из трея
        private void VosstanovitFormu()
        {

            this.Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            notifyIcon1.Visible = false;
            timer1.Start();

        }

        // Изменение размерво формы
        private void Form1_Resize(object sender, EventArgs e)
        {
            // если форма сворачивается
            if (this.WindowState == FormWindowState.Minimized)
            {
                   // если сворчиваем в трей
                if (chbSvernut.Checked)
                {
                    notifyIcon1.Visible = true;
                    this.ShowInTaskbar = false;
                    this.Hide();
                    timer1.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StartStop();
        }
    }
}

