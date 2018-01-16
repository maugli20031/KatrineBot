using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Media;
using System.IO;

namespace gjg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Label l;
        static NumericUpDown ND;
        static SpeechSynthesizer ss = new SpeechSynthesizer();
        static System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-ru");
        static SpeechRecognitionEngine sre = new SpeechRecognitionEngine(ci);

        static void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            string[] videost = new string[3];

            videost[0] = "Останови видео";
            videost[1] = "Постой паровоз";
            videost[2] = "Тормози ушами";

            string[] videopl = new string[3];

            videopl[0] = "Воспроизведение видео";
            videopl[1] = "Полный вперед";
            videopl[2] = "Алга Казахстан";

            string[] shootd = new string[3];

            shootd[0] = "Стоп гейм";
            shootd[1] = "Конец работы";
            shootd[2] = "Вырубай шарманку";

            string[] screen = new string[2];

            screen[0] = "Полный экран";
            screen[1] = "Маленький экран";

            string[] muter = new string[2];

            muter[0] = "Убери звук";
            muter[1] = "Верни звук";

            string[] muterms = new string[2];

            muterms[0] = "Убери звук музыки";
            muterms[1] = "Верни звук музыки";

            string[] msst = new string[2];

            msst[0] = "Включи музыку";
            msst[1] = "Останови музыку";


            if (e.Result.Confidence > (float)ND.Value)
            {

                switch (e.Result.Text)
                {
                    case "Давай познакомимся":
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync("Как вас зовут?");
                        System.Threading.Thread.Sleep(500);
                        string name = sre.RecognizeAsync(RecognizeMode.Single);
                        ss.SpeakAsync(name);
                        break;


                    case "Перемешай музыку":
                        l.Text = "Перемешала";
                        SendKeys.Send("s");
                        break;

                    case "Запусти музыку":
                        l.Text = "Наслаждайтесь";
                        Process.Start("D:\\AIMP\\AIMP.exe");
                        System.Threading.Thread.Sleep(200);
                        SendKeys.Send(" ");
                        break;

                    case "Включи музыку":
                        l.Text = "Наслаждайтесь";
                        SendKeys.Send(" ");
                        break;

                    case "Запуск вижуал студия":
                        l.Text = "Запускаю";
                        Process.Start("C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community\\Common7\\IDE\\devenv.exe");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                        break;

                    case "Запуск гугл":
                        l.Text = "Запускаю";
                        Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                        break;

                    case "Запуск стим":
                        l.Text = "Запускаю";
                        Process.Start("D:\\Steam\\Steam.exe");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                        break;

                    case "Убавь звук":
                        l.Text = "Убавляю";
                        SendKeys.Send(" ");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                        break;

                    case "Прибавь звук":
                        l.Text = "Прибавляю";
                        SendKeys.Send(" ");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                        break;

                    case "Вунд лох":
                        l.Text = "Согласна";
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                        break;

                    case "Молодец":
                        l.Text = "Доброе слово " +
                            "и боту приятно";
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                        break;
                }


                if (videopl.Contains(e.Result.Text))
                {
                    l.Text = "Воспроизведение";
                    SendKeys.Send(" ");
                    ss.Volume = 100;
                    ss.Rate = 0;
                    ss.SpeakAsync(l.Text);
                }
                if (videost.Contains(e.Result.Text))
                {
                    l.Text = "videost";
                    SendKeys.Send(" ");
                    ss.Volume = 100;
                    ss.Rate = 0;
                    ss.SpeakAsync(l.Text);
                }

                if (shootd.Contains(e.Result.Text))
                {
                    l.Text = "Выключение";
                    System.Diagnostics.Process.Start("shutdown", "/s /t 0");
                    ss.Volume = 100;
                    ss.Rate = 0;
                    ss.SpeakAsync(l.Text);
                }

                if (screen.Contains(e.Result.Text))
                {
                    l.Text = "Сделано";
                    SendKeys.Send("f");
                    ss.Volume = 100;
                    ss.Rate = 0;
                    ss.SpeakAsync(l.Text);
                }

                if (muter.Contains(e.Result.Text))
                {
                    l.Text = "Убераю";
                    SendKeys.Send("M");
                    ss.Volume = 100;
                    ss.Rate = 0;
                    ss.SpeakAsync(l.Text);
                }
                if (muter.Contains(e.Result.Text))
                {
                    l.Text = "Убераю";
                    SendKeys.Send("M");
                    ss.Volume = 100;
                    ss.Rate = 0;
                    ss.SpeakAsync(l.Text);
                }

                if (muterms.Contains(e.Result.Text))
                {
                    l.Text = "Сделано";
                    SendKeys.Send("v");
                    ss.Volume = 100;
                    ss.Rate = 0;
                    ss.SpeakAsync(l.Text);

                }

                if (msst.Contains(e.Result.Text))
                {
                    l.Text = "Сделано";
                    SendKeys.Send(" ");
                    ss.Volume = 100;
                    ss.Rate = 0;
                    ss.SpeakAsync(l.Text);
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ss.Volume = 100;
            ss.Rate = 2;
            ss.SpeakAsync("Привет! Я Екатерина");

            l = label1;
            ND = UD;

            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-ru");
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(ci);

            sre.SetInputToDefaultAudioDevice();

            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);

            Choices words = new Choices();
            words.Add(new string[] {"Запуск стим" , "Вертер открой" , "Верни звук" , "Убери звук" , "Убавь звук" , "Прибавь звук" , "Маленький экран" ,
                 "Полный экран" , "Конец работы" , "Вырубай шарманку" , "Стоп гейм" , "Останови видео" , "Постой паровоз" , "Тормози ушами" , "Воспроизведение видео" ,
                 "Полный вперед" , "Алга Казахстан" , "Вунд лох " , "Включи музыку" , "Запуск гугл" , "Запуск вижуал студия" , "Молодец" , "Максим" , "Кирилл" , "Владимир" ,
                "Александр" , "Саша" , "Михаил" , "Миша" , "Матвей" , "Роман" , "Юрий" , "Юра" , "Вова" , "Давай познакомимся" , "Перемешай музыку" , "Убавь музыку" , "Прибавь музыку" ,
                "Убери звук музыки" , "Верни звук музыки" , "Запусти музыку" , "Включи музыку" , "Останови музыку"});

            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = ci;
            gb.Append(words);

            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);

            sre.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}