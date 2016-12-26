using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using ttest1;

       


namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        int ind;
        bool started = false;
        ttest1.Class1 pcube1;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern int FindWindowEx(int hWnd1, int hWnd2, string lpsz1, string lpsz2);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);
        public Form1()
        {
            InitializeComponent();
            findpcube(); 
            Shown += Form1_Shown;
            Closing += Form1_Closing;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            pcube1 = new Class1();
            pcube1.ttest1();
            appContainer2.Start2("ttest1");
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            appContainer1.AppProcess.Kill();
        }
        //피큐브 인터페이스 찾기
        public void findpcube()
        {
            appContainer1.AppFilename = System.IO.Directory.GetCurrentDirectory() + "/PCubeS12443-V3(mini board).exe";
            appContainer1.Start();
        }
       

        private void select_file(System.Windows.Forms.TextBox texbox)
        { 
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "mat";

            openFile.Filter = "Images Files(*mat|";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    texbox.Text = filename;
                }
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Miexdatalinear_button_Click(object sender, EventArgs e)
        {
            select_file(this.Miexdatalinear_dir);
        }
 
        private void Calculate_button_Click(object sender, EventArgs e)
        {
            //인풋 폴더를 생성하고
            string currDir = System.IO.Directory.GetCurrentDirectory();
            string resultDir = System.IO.Path.Combine(currDir, "result");
            string inputDataDir = System.IO.Path.Combine(resultDir, "input");
            string outputDataDir = System.IO.Path.Combine(resultDir, "output"); 
            System.IO.Directory.CreateDirectory(inputDataDir);            
            System.IO.Directory.CreateDirectory(outputDataDir);
            //파일들을 복사하고,
            copyfile(this.Miexdatalinear_dir.Text, inputDataDir);
            //인풋경로 저장
            StreamWriter swinput = new StreamWriter(new FileStream("inputpath.txt", FileMode.Create));
            swinput.WriteLine(copyfile(this.Miexdatalinear_dir.Text, inputDataDir));
            swinput.Close();
            //ind 수치 입력
            int check;            
            swinput = new StreamWriter(new FileStream("ind.txt", FileMode.Create));
            if(int.TryParse(this.ind_text.Text, out check))
            {
                ind = check -499;
                if(ind < 1)
                {
                    ind = 1;
                }

            }
            else
            {
                ind = 1;
            }
            swinput.WriteLine(ind);
            swinput.Close();
            //아웃풋 경로 저장
            StreamWriter swoutput = new StreamWriter(new FileStream("outputpath.txt", FileMode.Create));
            swoutput.Write(outputDataDir);
            swoutput.Close();
            pcube1.ttest1();
            appContainer2.AppProcess = null;
            appContainer2.Start2("ttest1");
        }

        private string copyfile(string sourceFile, string targetPath)
        {
            string fileName = System.IO.Path.GetFileName(sourceFile);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            System.IO.File.Copy(sourceFile, destFile, true);
            return destFile;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }

}
