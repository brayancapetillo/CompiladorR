using System.Diagnostics;
using System.Runtime.InteropServices;

namespace prueba 
{
    public partial class Form1 : Form
    {
        string archivo = " ";
        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Textascompile.KeyDown += new KeyEventHandler(validarteclas);
            
        }

        /*public void validarteclas(object sender, KeyEventArgs e)
        {
            if(archivo == " ")
            {
                MessageBox.Show("abre un archivo");
            }
            else
            {
                remarcar(archivo);
            }
            
        }*/



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

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivo de texto | *.txt";

            
            if(open.ShowDialog() == DialogResult.OK)
            {
                archivo = open.FileName;
                StreamReader lector = new StreamReader(archivo);
                Textascompile.Text = lector.ReadToEnd();
                lector.Close();
                remarcar(archivo);

            }
            else
            {
                MessageBox.Show("ha ocurrido un error");
            }
            showsubmenu(PBAsubmenu);
            
        }

        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(archivo == " ")
            {
                BtnSaveas_Click(sender, e);
            }
            else
            {
                StreamWriter textsave = new StreamWriter(archivo);
                textsave.WriteLine(Textascompile.Text);
                textsave.Close();
                
            }
            showsubmenu(PBAsubmenu);
        }

        private void BtnSaveas_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo de texto|*.txt";
            if(save.ShowDialog() == DialogResult.OK)
            {
                archivo = save.FileName;
                StreamWriter escritor = new StreamWriter(archivo);
                escritor.Write(Textascompile.Text);
                escritor.Flush();
                escritor.Close();

            }
            showsubmenu(PBAsubmenu);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Textascompile.Clear();
            Textascompile.Focus();
            archivo = " ";
            showsubmenu(PBAsubmenu);
        }

        private void Compilar_Click(object sender, EventArgs e)
        {
            remarcar(archivo);
        }

        public void remarcar(string archivo)
        {
            try
            {
                StreamReader reader = new StreamReader(archivo);
                string[]? Palabras_Separadas;
                string read;

                Color[] colores = new Color[10];

                //morado
                colores[0] = Color.FromArgb(111, 42, 255);
                //verde
                colores[1] = Color.FromArgb(59, 218, 110);
                //negro
                colores[2] = Color.FromArgb(1, 1, 1);
                //salmon
                colores[3] = Color.FromArgb(216, 65, 86);
                //naranja
                colores[4] = Color.FromArgb(219, 131, 1);
                //azul
                colores[5] = Color.FromArgb(0, 4, 255);



                int numerolinea = 0;
                Textascompile.Select(0, Textascompile.SelectionStart);

                while (reader != null)
                {
                    numerolinea++;
                    read = reader.ReadLine();

                    if (reader.EndOfStream)
                    {
                        break;
                    }
                    else
                    {
                        Palabras_Separadas = read.Split(" ");

                        foreach(var palabra in Palabras_Separadas)
                        {
                            int index = 0;

                            switch (palabra)
                            {
                                case "<stdio.h>"  : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[1]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "<iostream>" : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[1]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "#include"   : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[0]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "using"      : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[0]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "namespace"  : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[0]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "std"        : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[1]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "int"        : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[0]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "if"         : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[0]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "else"       : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[0]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "System"     : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[0]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "return"     : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[0]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case "cout"       : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[1]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;
                                case ";"          : index = 0; while (index < Textascompile.Text.LastIndexOf(palabra)) { Textascompile.Find(palabra, index, Textascompile.TextLength, RichTextBoxFinds.None); Textascompile.SelectionColor = colores[5]; index = Textascompile.Text.IndexOf(palabra, index) + 1; }; break;

                            }

                        }
                    }
                    Palabras_Separadas = null;
                }

                reader.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("El archivo no se abrio correctamente");
            }
        }

        private void darkorlight_CheckedChanged(object sender, EventArgs e)
        {
            if (darkorlight.Checked)
            {
                darkorlight.Text = "claro +";
                Textascompile.BackColor = Color.Black;
                Textascompile.ForeColor = Color.White;
                viewsourcecompile.BackgroundColor = Color.Black;
                ViewRes.BackgroundColor = Color.Black;
                if(archivo != " ")
                {
                    remarcar(archivo);
                }
                
            }
            else
            {
                darkorlight.Text = "Oscuro -";
                Textascompile.BackColor = Color.White;
                Textascompile.ForeColor = Color.Black;
                viewsourcecompile.BackgroundColor = Color.White;
                ViewRes.BackgroundColor = Color.White;
                if (archivo != " ")
                {
                    remarcar(archivo);

                }
            }
           
        }

    }
}