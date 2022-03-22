using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Etiqueter
{
    public partial class Etiqueter : Form
    {
        public static string Version = "5.0b.220322";
        public static string SaveDir = "%appdata%\\Etiqueter";
        public static string SaveFile = SaveDir + "\\config.ini";

        public static string lang = "esp";

        public static int i_pos = 10;
        public static int ViejaCantidad = 0;
        public static string Salida = String.Empty;
        private string namForbCheck = @"\" + "/:*?" + "\"" + "<>|";
        public static string Carpeta_base = @"C:\Etiquetas\";
        public static string Archivo_porsche = Carpeta_base + "Porsche.lbx";
        public static string Archivo_general = Carpeta_base + "General.lbx";
        public static string CarpetaEsc = "Etiquetas " + DateTime.Now.ToString("dd-MM");

        public static int Hacemos = 0;
        public static int PreCant = 0;

        public Etiqueter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lb_Version.Text = "Versión: " + Version;
            button2.Visible = false;
            Rb_Format_2.Checked = true;

            if (!SoyViable())
            {
                try
                {
                    HazmeViable();
                }
                catch (Exception f)
                {
                    MessageBox.Show("Ha surgido un error. Por favor, intenta ejecutar como administrador" + Environment.NewLine + f.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Lb_Error.Text = "Hacen falta los archivos lbx en C:\\Etiquetas. General.lbx y Porsche.lbx";
                }
            }
            
            Botones(0);
            Cantidad.Select(0,1);
            this.ActiveControl = Cadena_tb;
            LoadSaved();
        }

        private bool SoyViable()
        {
            if (Directory.Exists(Carpeta_base))
            {
                if (File.Exists(Archivo_general) && File.Exists(Archivo_porsche))
                {
                    return true;
                }
            }
            return false;
        }

        private void HazmeViable()
        {
            Directory.CreateDirectory(Carpeta_base);
            try
            {
                if (!File.Exists(Archivo_general))
                {
                    File.Copy(@"\\servidorw1\TECNICOS\PREPARACION EQUIPOS\Etiqueter\General.lbx", Archivo_general, true);
                }
                if (!File.Exists(Archivo_porsche))
                {
                    File.Copy(@"\\servidorw1\TECNICOS\PREPARACION EQUIPOS\Etiqueter\Porsche.lbx", Archivo_porsche, true);
                }
            }
            catch (IOException copyError)
            {
                Console.WriteLine(copyError.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Bt_Go_Click(object sender, EventArgs e)
        {
            Hacemos = (int)Cantidad.Value;
            Lb_Tit_Pantalla.Visible = true;
            Lb_Tit_Cadena.Visible = true;
            Lb_Tit_Pais.Visible = true;
            Lb_Tit_Coment.Visible = true;

            if (Cantidad.Value > 0)
            {
                Botones(decimal.ToInt32(Cantidad.Value));
            }
            else
            {
                this.Width = 265;
                Lb_Tit_Pantalla.Visible = false;
                Lb_Tit_Cadena.Visible = false;
                Lb_Tit_Pais.Visible = false;
                Lb_Tit_Coment.Visible = false;
            }
        }

        private void Vaciar()
        {
            string[] nombres = new string[600];
            Label[] grupo = new Label[600];
            int j = 0;
            foreach (Label lb in Controls.OfType<Label>())
            {
                nombres[j] = lb.Name;
                grupo[j] = lb;
                j++;
            }
            string[] Lb_names = { "Lb_G_Cad_num", "Lb_G_Pais", "Lb_Version", "Lb_G_NumPant", "Lb_Tit_Pantalla", "Lb_Tit_Cadena", "Lb_Tit_Pais", "Lb_Tit_Coment"};
            for (int k = 0; k < nombres.Length;k++)
            {
                if (!Lb_names.Contains(nombres[k]))
                {
                    Controls.Remove(grupo[k]);
                }
            }

            string[] Tb_Nombres = new string[600];
            TextBox[] grupo_Tb = new TextBox[600];
            j = 0;
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                Tb_Nombres[j] = tb.Name;
                grupo_Tb[j] = tb;
                j++;
            }
            string[] Tb_Names = { "Cadena_tb", "Pais_tb" };
            for (int k = 0; k < Tb_Nombres.Length; k++)
            {
                if (!Tb_Names.Contains(Tb_Nombres[k]))
                {
                    Controls.Remove(grupo_Tb[k]);
                }
            }
        }

        private void Botones(int cantidad)
        {
            
            Vaciar(); Vaciar(); Vaciar(); Vaciar(); Vaciar(); Vaciar(); Vaciar(); Vaciar();

            Label Lb_pais_2 = new Label { Text = "Pais", Location = new System.Drawing.Point(Lb_Tit_Pais.Location.X + 575, 10) };
            Label Lb_comen_2 = new Label { Text = "Comentario", Location = new System.Drawing.Point(Lb_Tit_Coment.Location.X + 575, 10) };
            Label Lb_cadena_2 = new Label { Text = "Cadena", Location = new System.Drawing.Point(Lb_Tit_Cadena.Location.X + 575, 10) };
            Label Lb_pantalla_2 = new Label { Text = "Pantalla", Location = new System.Drawing.Point(Lb_Tit_Pantalla.Location.X + 575, 10) };

            if (cantidad == 0)
            {
                this.Width = 265;
                return;
            }
            
            if (cantidad < 21)
            {
                this.Width = 855;
            }else
            {
                if (cantidad < 41)
                {
                    this.Width = 1430;

                    Controls.Add(Lb_comen_2);
                    Controls.Add(Lb_pais_2);
                    
                    Controls.Add(Lb_cadena_2);
                    Controls.Add(Lb_pantalla_2);
                } else
                {
                    this.Width = 265;
                    Controls.Remove(Lb_pais_2);
                    Controls.Remove(Lb_comen_2);
                    Controls.Remove(Lb_cadena_2);
                    Controls.Remove(Lb_pantalla_2);
                    return;
                }
            }

            for (int i = 0; i < cantidad; i++)
            {
                int altura = ((i%20) * 25)+25;
                int izquierda = ((i / 20) * 575) + 245;
                int numero = i + 1;
                int tabindex = 100 + ((i+1)*5);

                Label lb_linea = new Label
                {
                    Text = "PC " + (numero).ToString(),
                    Location = new System.Drawing.Point(izquierda, altura + 2),
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight,
                    Name = "lb_eq_" + (numero).ToString()
                };
                this.Controls.Add(lb_linea);

                TextBox Tb_pant = new TextBox
                {
                    Location = new System.Drawing.Point(izquierda + 45, altura),
                    Size = new System.Drawing.Size(200, 20),
                    CharacterCasing = CharacterCasing.Upper,
                    TabIndex = tabindex,
                    Name = "Tb_Pant_" + (numero).ToString(),
                };
                Tb_pant.TextChanged += new System.EventHandler(this.PuedoYa);
                this.Controls.Add(Tb_pant);
                Tb_pant.BringToFront();

                TextBox Tb_cad = new TextBox
                {
                    Location = new System.Drawing.Point(izquierda + 250, altura),
                    Size = new System.Drawing.Size(115, 20),
                    CharacterCasing = CharacterCasing.Upper,
                    TabIndex = tabindex + 1,
                    Name = "Tb_Cad_" + (numero).ToString(),
                    Text = Cadena_tb.Text,
                };
                Tb_cad.TextChanged += new System.EventHandler(this.PuedoYa);
                this.Controls.Add(Tb_cad);
                Tb_cad.BringToFront();

                TextBox Tb_pais = new TextBox
                {
                    Location = new System.Drawing.Point(izquierda + 370, altura),
                    Size = new System.Drawing.Size(85, 20),
                    CharacterCasing = CharacterCasing.Upper,
                    TabIndex = tabindex + 2,
                    Name = "Tb_Pais_" + (numero).ToString(),
                    Text = Pais_tb.Text,
                };
                Tb_pais.TextChanged += new System.EventHandler(this.PuedoYa);
                this.Controls.Add(Tb_pais);
                Tb_pais.BringToFront();

                TextBox Tb_coment = new TextBox
                {
                    Location = new System.Drawing.Point(izquierda + 460, altura),
                    Size = new System.Drawing.Size(115, 20),
                    CharacterCasing = CharacterCasing.Upper,
                    TabIndex = tabindex + 3,
                    Name = "Tb_Coment_" + (numero).ToString(),
                };
                Tb_coment.TextChanged += new System.EventHandler(this.PuedoYa);
                this.Controls.Add(Tb_coment);
                Tb_coment.BringToFront();

            }
            return;
        }

        private void PuedoYa(object sender, EventArgs e)
        {
            button1.Enabled = false;
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.Name.StartsWith("Tb_Pant_"))
                {
                    if (tb.Text != "")
                    {
                        button1.Enabled = true;
                        return;
                    }
                }
            }
        }

        private string EscapoCadena(string cadena)
        {
            string cad = string.Empty;
            string validos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0987654321-_&ñÑÁÉÍÓÚçÇ";
            bool cambiado = false;
            foreach (char c in cadena)
            {
                if (validos.Contains(c))
                {
                    cad += c;
                    if (cambiado == true) { cambiado = false; }
                }
                else
                {
                    if (cambiado == false)
                    {
                        cambiado = true;
                        cad += '-';
                    }
                }
            }
            char[] Limpio = { ' ', '_', '-' };
            cad = cad.Trim(Limpio);
            return cad;
        }

        public string RevisoNombre(string BaseTxt)
        {
            string NewTxt = "";
            foreach (char letra in BaseTxt)
            {
                if (!namForbCheck.Contains(letra))
                {
                    NewTxt += letra;
                }
            }
            NewTxt = NewTxt.Replace(' ', '_');
            return NewTxt;
        }

        private void Excelizar_Click(object sender, EventArgs e)
        {
            Salida = String.Empty;
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.Name.StartsWith("Tb_Pant_"))
                { 
                    tb.Text = RevisoNombre(tb.Text);
//                    tb.Text = EscapoCadena(tb.Text);
                    tb.Text = tb.Text.Trim();
                }
            };

            string[] List_pantallas = new string[Hacemos];
            string[] List_cadena = new string[Hacemos];
            string[] List_pais = new string[Hacemos];
            string[] List_comentario = new string[Hacemos];
            for (int i = 0; i < Hacemos + 1; i++)
            {
                foreach (TextBox tb in Controls.OfType<TextBox>())
                {
                    if (tb.Name == "Tb_Pant_" + (i + 1).ToString())
                    {
                        List_pantallas[i] = tb.Text;
                    }
                    if (tb.Name == "Tb_Cad_" + (i + 1).ToString())
                    {
                        List_cadena[i] = tb.Text;
                    }
                    if (tb.Name == "Tb_Pais_" + (i + 1).ToString())
                    {
                        List_pais[i] = tb.Text;
                    }
                    if (tb.Name == "Tb_Coment_" + (i + 1).ToString())
                    {
                        List_comentario[i] = tb.Text;
                    }
                }
            }

            int o = 0;
            Salida = String.Empty;
//            Salida += "PAIS, TIENDA, PANTALLA, COMENTARIO" + Environment.NewLine;

            for (o = 0; o < Hacemos ; o++)
            {
                if (List_pantallas[o] != null && List_pantallas[o].Length > 0)
                {
                    string LineaNueva = List_pais[o] + ", " + List_cadena[o] + ", " + List_pantallas[o] + ", · " + List_comentario[o] + Environment.NewLine;
                    Salida += LineaNueva;


                    if (List_pantallas[o].StartsWith("LED") && Cb_LED.Checked)
                    {
                        Salida += LineaNueva;
                    }

                    if (Cb_Doble.Checked)
                    {
                        Salida += LineaNueva;
                        if (List_pantallas[o].StartsWith("LED") && Cb_LED.Checked)
                        {
                            Salida += LineaNueva;
                        }
                    }
                }
            }
                   
            try
            {
                string HistoricFolder = Carpeta_base + @"BAK\" + CarpetaEsc + @"\";
                Directory.CreateDirectory(HistoricFolder);

                string usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];

                string Desktop_adress = @"C:\Users\" + usuario + @"\Desktop\";
                string Desk_Folder = CarpetaEsc + @"\";
                string Desk_Finish = Desktop_adress + Desk_Folder;

                System.Diagnostics.Process.Start("taskkill", "/F /IM ptedit*");
                System.Threading.Thread.Sleep(500);
                System.Diagnostics.Process.Start("taskkill", "/F /IM ApliAutoUpdater*");
                System.Threading.Thread.Sleep(500);


                File.WriteAllText(Carpeta_base + "Equipos.txt", Salida, System.Text.Encoding.Unicode);

                String HistoricName = HistoricFolder + "Equipos " + DateTime.Now.ToString("dd-MM") + " " + (PreCant + 1).ToString() + ".txt";

                while (File.Exists(HistoricName))
                {
                    PreCant += 1;
                    HistoricName = HistoricFolder + "Equipos " + DateTime.Now.ToString("dd-MM") + " " + (PreCant + 1).ToString() + ".txt";
                }
                    File.WriteAllText(HistoricName, Salida, System.Text.Encoding.Unicode);

                try
                {
                    Directory.CreateDirectory(Desk_Finish);
                    File.WriteAllText(Desk_Finish + @"Etiquetas" + DateTime.Now.ToString("HHmmss") + ".txt", Salida, System.Text.Encoding.Unicode);

                }
                catch (Exception) {  }
                /*
                try
                {
                    string cad = Cadena_tb.Text.Split(' ')[Cadena_tb.Text.Split(' ').Length-1];

                    if (int.TryParse(cad, out int tienda))
                    {
                        Desk_Folder = cad + @"\";
                    }
                }
                catch (Exception) { }
                */
                //               Directory.CreateDirectory(Desk_Finish);
                //                File.WriteAllText(Desk_Finish + "/Etiquetas.txt", Salida, System.Text.Encoding.ASCII);
                //          string ArgumentoExplorer = '"' + Desk_Finish + '"';
                //                System.Diagnostics.Process.Start("explorer.exe", ArgumentoExplorer.Replace('/', '\\'));
            }
            catch (Exception exc)
            {
                File.WriteAllText(@"Etiquetas.txt", Salida, System.Text.Encoding.Unicode);
                MessageBox.Show("Error escribiendo el archivo" + Environment.NewLine + exc.Message + Environment.NewLine + Carpeta_base + @"Etiquetas.txt");
            }
            string Archivo_base = Archivo_general;
            if (Rb_Format_1.Checked == true) { Archivo_base = Archivo_porsche; }

            System.Diagnostics.Process.Start(Archivo_base);
        }

        private string Texto (int cantidad)
        {

            return "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void Lb_Version_DoubleClick(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void Cadena_tb_TextChanged(object sender, EventArgs e)
        {
            if (Cadena_tb.Text.ToUpper().Contains("PORSCHE"))
            {
                Rb_Format_1.Checked = true;
            }
        }

        private void PicB_Esp_Click(object sender, EventArgs e)
        {
            Repinto("esp");
            lang = "esp";
            SaveConf();
        }

        private void PicB_Eng_Click(object sender, EventArgs e)
        {
            lang = "eng";
            Repinto(lang);
            SaveConf();
        }

        private void Pic_B_Ger_Click(object sender, EventArgs e)
        {
            Repinto("ger");
            lang = "ger";
            SaveConf();
        }
        
        private void PicB_Chn_Click(object sender, EventArgs e)
        {
            Repinto("chn");
            lang = "chn";
            SaveConf();
        }

        private void PcB_Jpn_Click(object sender, EventArgs e)
        {
            Repinto("jpn");
            lang = "jpn";
            SaveConf();
        }


        private void Repinto(string idioma)
        {
            string[] lang = Lorem.CambiaIdioma(idioma);
            Gb_Config.Text = lang[1];
            Lb_G_Cad_num.Text = lang[2];
            Lb_G_Pais.Text = Lb_Tit_Pais.Text = lang[3];
            Lb_G_NumPant.Text = lang[4];
            Cb_Doble.Text = lang[5];
            Cb_LED.Text = lang[6];
            Bt_Go.Text = lang[7];
            button1.Text = lang[8];
            Lb_Tit_Pantalla.Text = lang[9];
            Lb_Tit_Cadena.Text = lang[10];
            Lb_Tit_Coment.Text = lang[11];
            Rb_Format_2.Text = lang[12];
            Rb_Format_1.Text = lang[13];
            Lb_conf_fold.Text = lang[14] + ":" + Environment.NewLine + Carpeta_base;
            Bt_Config.Text = lang[15];



        }
           
        private void SaveConf()
        {
            string saveText = "lang:" + lang + Environment.NewLine;
            saveText += "dir:" + Carpeta_base + Environment.NewLine;

            if (!Directory.Exists(Environment.ExpandEnvironmentVariables(SaveDir)))
            {
                try
                {
                    Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(SaveDir));
                }
                catch (Exception){}
            }
            try
            {
                File.WriteAllText(Environment.ExpandEnvironmentVariables(SaveFile), saveText);
            }
            catch (Exception){}
        }

        private void LoadSaved()
        {
            try
            {
                string LoadFile = File.ReadAllText(Environment.ExpandEnvironmentVariables(SaveFile));
                string[] Lineas = LoadFile.Split('\n');
                foreach (string singleline in Lineas)
                {
                    if (singleline.StartsWith("lang:")){
                        lang = Lineas[0].Substring(Lineas[0].Length - 4, 3);
                    }
                    if (singleline.StartsWith("dir:"))
                    {
                        Carpeta_base = singleline.Substring(4).Trim();
                    }
                }
                Repinto(lang);
            }
            catch (Exception){}
        }

        private void Bt_Config_Click(object sender, EventArgs e)
        {
            DialogResult newFolder = FolderBrowser.ShowDialog();
            if (newFolder == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowser.SelectedPath))
            {
                Carpeta_base = (FolderBrowser.SelectedPath + @"\").Trim();
            }
            SaveConf();
            Repinto(lang);

        }

    }
    }
