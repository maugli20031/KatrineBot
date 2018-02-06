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

            string[] muter = new string[3];

            muter[0] = "Убери звук";
            muter[1] = "Верни звук";
            muter[2] = "Без звука";

            string[] muterms = new string[2];

            muterms[0] = "Убери звук музыки";
            muterms[1] = "Верни звук музыки";

            string[] msst = new string[6];

            msst[0] = "Включи музыку";
            msst[1] = "Останови музыку";
            msst[2] = "Включи пожалуйста музыку";
            msst[3] = "Пожалуйста включи музыку";
            msst[4] = "Останови пожалуйста музыку";
            msst[5] = "Пожалуйста останови музыку";

            string[] steam = new string[4];

            steam[0] = "Запуск стим";
            steam[1] = "Запусти пожалуйста стим";
            steam[2] = "Пожалуйста запусти стим";
            steam[3] = "Запусти стим";

            string[] mswoop = new string[3];

            mswoop[0] = "Перемешай музыку";
            mswoop[1] = "Перемешай пожалуйста музыку";
            mswoop[2] = "Пожалуйста перемешай музыку";

            string[] msstart = new string[3];

            msstart[0] = "Запусти музыку";
            msstart[1] = "Запусти пожалуйста музыку";
            msstart[2] = "Пожалуйста запусти музыку";

            string[] VS = new string[4];

            VS[0] = "Запуск вижуал студия";
            VS[1] = "Запусти пожалуйста вижуал студию";
            VS[2] = "Пожалуйста запусти вижуал студию";
            VS[3] = "Запусти вижуал студию";

            string[] google = new string[4];

            google[0] = "Запуск гугл";
            google[1] = "Запусти гугл";
            google[2] = "Запусти пожалуйста гугл";
            google[3] = "Пожалуйста запусти гугл";

            string[] thx = new string[5];

            thx[0] = "Спасибо";
            thx[1] = "Молодец";
            thx[2] = "Большое спасибо";
            thx[3] = "Огромное спасибо";
            thx[4] = "Ты большая молодец";

            string[] bad = new string[3];

            bad[0] = "Работай лучше";
            bad[1] = "Постарайся";
            bad[2] = "Давай работай";

            string[] youtube = new string[4];

            youtube[0] = "Открой ютуб";
            youtube[1] = "Запусти ютуб";
            youtube[2] = "Запусти пожалуйста ютуб";
            youtube[3] = "Пожалуйста запусти ютуб";

            string[] end = new string[3];

            end[0] = "Конец работы";
            end[1] = "Вырубай шарманку";
            end[2] = "Стоп гейм";

            string[] start = new string[2];

            start[0] = "Катерина";
            start[1] = "Катя";

                if (e.Result.Confidence > (float)ND.Value)
                {
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
                        l.Text = "Сделано";
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

                    if (steam.Contains(e.Result.Text))
                    {
                        l.Text = "Запускаю";
                        Process.Start("D:\\Steam\\Steam.exe");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                    }

                    if (mswoop.Contains(e.Result.Text))
                    {
                        l.Text = "Перемешала";
                        SendKeys.Send("s");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                    }

                    if (msstart.Contains(e.Result.Text))
                    {
                        l.Text = "Наслаждайтесь";
                        Process.Start("D:\\AIMP\\AIMP.exe");
                        System.Threading.Thread.Sleep(200);
                        SendKeys.Send(" ");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                    }

                    if (VS.Contains(e.Result.Text))
                    {
                        l.Text = "Запускаю";
                        Process.Start("C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community\\Common7\\IDE\\devenv.exe");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                    }

                    if (google.Contains(e.Result.Text))
                    {
                        l.Text = "Запускаю";
                        Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                    }

                    if (thx.Contains(e.Result.Text))
                    {
                        l.Text = "Доброе слово и боту приятно";
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                    }

                    if (bad.Contains(e.Result.Text))
                    {
                        l.Text = "Я буду стараться";
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                    }

                    if (youtube.Contains(e.Result.Text))
                    {
                        l.Text = "Открываю";
                        System.Diagnostics.Process.Start("http://youtube.com");
                        ss.Volume = 100;
                        ss.Rate = 0;
                        ss.SpeakAsync(l.Text);
                    }

                    if (youtube.Contains(e.Result.Text))
                    {
                        l.Text = "Выключение";
                        System.Diagnostics.Process.Start("Shutdown", "/s");
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
                 "Полный вперед" , "Алга Казахстан" , "Вунд лох" , "Включи музыку" , "Запуск гугл" , "Запуск вижуал студия" , "Молодец" , "Спасибо" , "Большое спасибо" , "Огромное спасибо" ,
                "Ты большая молодец" , "Запусти гугл" , "Запусти пожалуйста гугл" , "Пожалуйста запусти гугл" , "Запусти пожалуйста вижуал студию" , "Пожалуйста запусти вижуал студию" , "Запусти вижуал студию" 
                , "Включи пожалуйста музыку" , "Пожалуйста включи музыку" , "Запусти пожалуйста музыку" , "Перемешай музыку" , "Убавь музыку" , "Прибавь музыку" ,
                "Убери звук музыки" , "Верни звук музыки" , "Запусти музыку" , "Включи музыку" , "Останови музыку" , "Работай лучше" , "Открой ютуб" , "Запусти ютуб" , "Запусти пожалуйста ютуб"
                , "Постарайся" , "Давай работай" , "Пожалуйста запусти музыку" , "Перемешай пожалуйста музыку" , "Пожалуйста перемешай музыку" , "Запусти пожалуйста стим" , "Пожалуйста запусти стим"
            , "Запусти стим" , "Останови пожалуйста музыку" , "Пожалуйста останови музыку" , "Включи пожалуйста музыку" , "Пожалуйста включи музыку" , "Без звука" , "Катерина" , "Катя"});

            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = ci;
            gb.Append(words);

            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);

            sre.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}