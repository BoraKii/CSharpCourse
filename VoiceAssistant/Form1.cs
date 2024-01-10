using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;

namespace VoiceAssistant
{
    public partial class Form1 : Form
    {

        private SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speech = new SpeechSynthesizer();
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();

            Choices choices = new Choices();
            string[] text = File.ReadAllLines(Environment.CurrentDirectory + "//grammar.txt");
            choices.Add(text);
            Grammar grammar = new Grammar(new GrammarBuilder(choices));
            recEngine.LoadGrammar(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            recEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recEngine_SpeechRecognized);

            speech.SelectVoiceByHints(VoiceGender.Male);
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string result = e.Result.Text;

            if (result == "Merhaba")
            {
                result = "Hello, my name is OLS, how can I help you";
            }

            if (result == "Saat kaç")
            {
                result = "it is currently" + DateTime.Now.ToLongTimeString();
            }

            if (result == "Google aç")
            {
                System.Diagnostics.Process.Start("https://google.com.tr");
                result = "Opening Google";
            }

            if (result == "Chrome aç")
            {
                System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
                result = "Opening Chrome";
            }

            if (result == "Müzik aç")
            {
                System.Diagnostics.Process.Start("https://youtube.com");
                result = "Opening Youtube";
            }

            if (result == "Chrome kapat")
            {
                System.Diagnostics.Process[] close = System.Diagnostics.Process.GetProcessesByName("chrome");
                foreach (System.Diagnostics.Process process in close)
                    process.Kill();
                result = "Closing Google Chrome";
            }

            if (result == "Close app")
            {
                Application.Exit();
            }

            //if (result == "Faded")
            //{
            //    music.SoundLocation = "Faded.wav";
            //    music.Play();
            //    result = "";
            //}

            if (result == "Stop")
            {
                speech.SpeakAsyncCancelAll();
                music.Stop();
                result = "";
            }

            speech.SpeakAsync(result);
            label2.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
