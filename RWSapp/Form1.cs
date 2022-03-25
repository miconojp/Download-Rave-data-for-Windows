using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace RWSapp
{
    public partial class Form1 : Form
    {
        public class ExStudyParm {
            public string StudyName { get; set; }
            public string Env { get; set; }
            public string ExForm { get; set; }
            public string ExPath { get; set; }

        }
        public class AppIniParm {
            public string StudyName { get; set; }
            public string Env { get; set; }
            public string ExForm { get; set; }
            public string ExPath { get; set; }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ExStart_Click(object sender, EventArgs e)
        {
            int FormsConunt = ExForms.Lines.Length;

            ExStudyParm[] ExParm = new ExStudyParm[FormsConunt];

            //インスタンスを作成
            for (int i = 0; i < FormsConunt; i++)
            {
                ExParm[i] = new ExStudyParm();

            }
            //値を配列に代入
            for (int i = 0; i < FormsConunt; i++)

            {   //全ての値が埋まっている場合に配列へ格納する。
                if (ExStudyName.Text != "" && ExStudyEnv.Text != "" && ExForms.Lines[i] != "" && ExFilePath.Text != "")
                {

                    ExParm[i].StudyName = ExStudyName.Text.Trim();
                    ExParm[i].Env = ExStudyEnv.Text.Trim();
                    ExParm[i].ExForm = ExForms.Lines[i].Trim();
                    ExParm[i].ExPath = ExFilePath.Text.Trim();

                }

            }

            //RWS関数を呼び出す
            RWS_Function_ExportCSV(ExParm);

        }

        //RWSを利用してRaveサーバーからClinical Viewをダウンロードする
        private static void RWS_Function_ExportCSV(ExStudyParm[] ExParm)
        {
            // Create request
            //配列数を取得
            int CountParm = ExParm.Length;

            //配列数だけ回してデータをダウンロードする
            for (int i = 0; i < CountParm; i++)
            {
                if (ExParm[i].StudyName != null )
                {
                    string myURLPath = "/studies/" + ExParm[i].StudyName + "(" + ExParm[i].Env + ")/datasets/raw/" + ExParm[i].ExForm + ".csv";
                    string myRequestBody = String.Empty;
                    string myHTTPVerb = "GET";
                    string myExFilePath = ExParm[i].ExPath + "/" + ExParm[i].ExForm + ".csv";

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://servername" + myURLPath);
                    request.Method = myHTTPVerb;

                    // Set HTTP Basic authentication
                    request.Credentials = new NetworkCredential("username", "password");
                   
                    // Perform request
                    try
                    {
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Encoding enc = Encoding.GetEncoding("Shift_JIS");

                        Stream stream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(stream);
                        StreamWriter writer = new StreamWriter(myExFilePath, false, enc);
                        writer.Write(reader.ReadToEnd());
                        writer.Close();
                        reader.Close();

                    }
                    catch(System.Net.WebException)
                    {
                        MessageBox.Show("データがありません", 
                                        "エラー", 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Error);
                    }

                }
            }

            MessageBox.Show("ダウンロードが完了しました","結果");
        }
                      
        private void Button2_Click(object sender, EventArgs e)
        {
            int FormsConunt = ExForms.Lines.Length;

            AppIniParm[] IniParm = new AppIniParm[FormsConunt];

            //インスタンスを作成
            for (int i = 0; i < FormsConunt; i++)
            {
                IniParm[i] = new AppIniParm();

            }
            //値を配列に代入
            for (int i = 0; i < FormsConunt; i++)
            {   //全ての値が埋まっている場合に配列へ格納する。
                if (ExStudyName.Text != "" && ExStudyEnv.Text != "" && ExForms.Lines[i] != "" && ExFilePath.Text != "")
                {

                    IniParm[i].StudyName = ExStudyName.Text.Trim();
                    IniParm[i].Env = ExStudyEnv.Text.Trim();
                    IniParm[i].ExForm = ExForms.Lines[i].Trim();
                    IniParm[i].ExPath = ExFilePath.Text.Trim();

                }
            }
                this.Close();
        }
    }
}
