using System.Diagnostics;
using System.Runtime.InteropServices;

namespace prueba 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //nota
        private void CustomizeDesing()
        {
            PBAsubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (PBAsubmenu.Visible == true)
            {
                PBAsubmenu.Visible = false;
            }
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void BtnArchive_Click(object sender, EventArgs e)
        {
            showsubmenu(PBAsubmenu);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnmaximized_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Abrir";
                openFileDialog1.ShowDialog();

                if (File.Exists(openFileDialog1.FileName))
                {
                    leer(openFileDialog1.FileName);
                }
            }catch (Exception)
            {
                MessageBox.Show("el Archivo no se abrio correctamente");
            }
        }

        private void leer(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName, System.Text.Encoding.Default);
                Textascompile.Text = sr.ReadToEnd();
                sr.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("el Archivo no se abrio correctamente");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                        sw.WriteLine(Textascompile.Text);
                        sw.Flush();
                        sw.Close();
                    }
                    else
                    {
                        StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                        sw.WriteLine(Textascompile.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("no pos no");
            }
        }
    }
}