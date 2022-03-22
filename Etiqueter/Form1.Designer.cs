namespace Etiqueter
{
    partial class Etiqueter
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etiqueter));
            this.Cantidad = new System.Windows.Forms.NumericUpDown();
            this.Bt_Go = new System.Windows.Forms.Button();
            this.Lb_G_NumPant = new System.Windows.Forms.Label();
            this.Cadena_tb = new System.Windows.Forms.TextBox();
            this.Lb_G_Cad_num = new System.Windows.Forms.Label();
            this.Lb_G_Pais = new System.Windows.Forms.Label();
            this.Pais_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Gb_Config = new System.Windows.Forms.GroupBox();
            this.Lb_conf_fold = new System.Windows.Forms.Label();
            this.Rb_Format_2 = new System.Windows.Forms.RadioButton();
            this.Rb_Format_1 = new System.Windows.Forms.RadioButton();
            this.Cb_LED = new System.Windows.Forms.CheckBox();
            this.Bt_Config = new System.Windows.Forms.Button();
            this.Cb_Doble = new System.Windows.Forms.CheckBox();
            this.Lb_Version = new System.Windows.Forms.Label();
            this.Lb_Error = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Tb_Coment_0 = new System.Windows.Forms.TextBox();
            this.Tb_Pais_0 = new System.Windows.Forms.TextBox();
            this.Tb_Cad_0 = new System.Windows.Forms.TextBox();
            this.Tb_Pant_0 = new System.Windows.Forms.TextBox();
            this.Lb_Tit_Pantalla = new System.Windows.Forms.Label();
            this.Lb_Tit_Cadena = new System.Windows.Forms.Label();
            this.Lb_Tit_Pais = new System.Windows.Forms.Label();
            this.Lb_EQ_1 = new System.Windows.Forms.Label();
            this.Lb_Tit_Coment = new System.Windows.Forms.Label();
            this.Gb_Lang_jpn = new System.Windows.Forms.GroupBox();
            this.PcB_Jpn = new System.Windows.Forms.PictureBox();
            this.PicB_Chn = new System.Windows.Forms.PictureBox();
            this.Pic_B_Ger = new System.Windows.Forms.PictureBox();
            this.PicB_Esp = new System.Windows.Forms.PictureBox();
            this.Gb_Lang_esp = new System.Windows.Forms.GroupBox();
            this.Gb_Lang_eng = new System.Windows.Forms.GroupBox();
            this.PicB_Eng = new System.Windows.Forms.PictureBox();
            this.Gb_Lang_ger = new System.Windows.Forms.GroupBox();
            this.Gb_Lang_chn = new System.Windows.Forms.GroupBox();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            this.Gb_Config.SuspendLayout();
            this.Gb_Lang_jpn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcB_Jpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Chn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_B_Ger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Esp)).BeginInit();
            this.Gb_Lang_esp.SuspendLayout();
            this.Gb_Lang_eng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Eng)).BeginInit();
            this.Gb_Lang_ger.SuspendLayout();
            this.Gb_Lang_chn.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(170, 101);
            this.Cantidad.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(50, 20);
            this.Cantidad.TabIndex = 12;
            // 
            // Bt_Go
            // 
            this.Bt_Go.Location = new System.Drawing.Point(10, 196);
            this.Bt_Go.Name = "Bt_Go";
            this.Bt_Go.Size = new System.Drawing.Size(210, 23);
            this.Bt_Go.TabIndex = 15;
            this.Bt_Go.Text = "Preparar";
            this.Bt_Go.UseVisualStyleBackColor = true;
            this.Bt_Go.Click += new System.EventHandler(this.Bt_Go_Click);
            // 
            // Lb_G_NumPant
            // 
            this.Lb_G_NumPant.AutoSize = true;
            this.Lb_G_NumPant.Location = new System.Drawing.Point(60, 106);
            this.Lb_G_NumPant.Name = "Lb_G_NumPant";
            this.Lb_G_NumPant.Size = new System.Drawing.Size(107, 13);
            this.Lb_G_NumPant.TabIndex = 0;
            this.Lb_G_NumPant.Text = "Número de pantallas:";
            this.Lb_G_NumPant.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Cadena_tb
            // 
            this.Cadena_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cadena_tb.Location = new System.Drawing.Point(10, 35);
            this.Cadena_tb.Name = "Cadena_tb";
            this.Cadena_tb.Size = new System.Drawing.Size(210, 20);
            this.Cadena_tb.TabIndex = 10;
            this.Cadena_tb.TextChanged += new System.EventHandler(this.Cadena_tb_TextChanged);
            // 
            // Lb_G_Cad_num
            // 
            this.Lb_G_Cad_num.AutoSize = true;
            this.Lb_G_Cad_num.Location = new System.Drawing.Point(15, 20);
            this.Lb_G_Cad_num.Name = "Lb_G_Cad_num";
            this.Lb_G_Cad_num.Size = new System.Drawing.Size(143, 13);
            this.Lb_G_Cad_num.TabIndex = 1;
            this.Lb_G_Cad_num.Text = "Cadena y número de tienda: ";
            // 
            // Lb_G_Pais
            // 
            this.Lb_G_Pais.AutoSize = true;
            this.Lb_G_Pais.Location = new System.Drawing.Point(15, 60);
            this.Lb_G_Pais.Name = "Lb_G_Pais";
            this.Lb_G_Pais.Size = new System.Drawing.Size(32, 13);
            this.Lb_G_Pais.TabIndex = 2;
            this.Lb_G_Pais.Text = "País:";
            // 
            // Pais_tb
            // 
            this.Pais_tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Pais_tb.Location = new System.Drawing.Point(10, 75);
            this.Pais_tb.Name = "Pais_tb";
            this.Pais_tb.Size = new System.Drawing.Size(210, 20);
            this.Pais_tb.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 47);
            this.button1.TabIndex = 500;
            this.button1.Text = "ETIQUETAS!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Excelizar_Click);
            // 
            // Gb_Config
            // 
            this.Gb_Config.Controls.Add(this.Lb_conf_fold);
            this.Gb_Config.Controls.Add(this.Rb_Format_2);
            this.Gb_Config.Controls.Add(this.Rb_Format_1);
            this.Gb_Config.Controls.Add(this.Cb_LED);
            this.Gb_Config.Controls.Add(this.Bt_Config);
            this.Gb_Config.Controls.Add(this.Cb_Doble);
            this.Gb_Config.Controls.Add(this.Lb_Version);
            this.Gb_Config.Controls.Add(this.Lb_Error);
            this.Gb_Config.Controls.Add(this.Lb_G_Cad_num);
            this.Gb_Config.Controls.Add(this.Cantidad);
            this.Gb_Config.Controls.Add(this.Lb_G_Pais);
            this.Gb_Config.Controls.Add(this.Bt_Go);
            this.Gb_Config.Controls.Add(this.Pais_tb);
            this.Gb_Config.Controls.Add(this.Lb_G_NumPant);
            this.Gb_Config.Controls.Add(this.Cadena_tb);
            this.Gb_Config.Location = new System.Drawing.Point(10, 10);
            this.Gb_Config.Name = "Gb_Config";
            this.Gb_Config.Size = new System.Drawing.Size(230, 391);
            this.Gb_Config.TabIndex = 101;
            this.Gb_Config.TabStop = false;
            this.Gb_Config.Text = "Configuración";
            // 
            // Lb_conf_fold
            // 
            this.Lb_conf_fold.AutoSize = true;
            this.Lb_conf_fold.ForeColor = System.Drawing.Color.Gray;
            this.Lb_conf_fold.Location = new System.Drawing.Point(15, 251);
            this.Lb_conf_fold.Name = "Lb_conf_fold";
            this.Lb_conf_fold.Size = new System.Drawing.Size(36, 13);
            this.Lb_conf_fold.TabIndex = 508;
            this.Lb_conf_fold.Text = "Folder";
            // 
            // Rb_Format_2
            // 
            this.Rb_Format_2.AutoSize = true;
            this.Rb_Format_2.Location = new System.Drawing.Point(11, 173);
            this.Rb_Format_2.Name = "Rb_Format_2";
            this.Rb_Format_2.Size = new System.Drawing.Size(101, 17);
            this.Rb_Format_2.TabIndex = 17;
            this.Rb_Format_2.TabStop = true;
            this.Rb_Format_2.Text = "Formato general";
            this.Rb_Format_2.UseVisualStyleBackColor = true;
            // 
            // Rb_Format_1
            // 
            this.Rb_Format_1.AutoSize = true;
            this.Rb_Format_1.Location = new System.Drawing.Point(10, 150);
            this.Rb_Format_1.Name = "Rb_Format_1";
            this.Rb_Format_1.Size = new System.Drawing.Size(105, 17);
            this.Rb_Format_1.TabIndex = 16;
            this.Rb_Format_1.TabStop = true;
            this.Rb_Format_1.Text = "Formato Porsche";
            this.Rb_Format_1.UseVisualStyleBackColor = true;
            // 
            // Cb_LED
            // 
            this.Cb_LED.AutoSize = true;
            this.Cb_LED.Checked = true;
            this.Cb_LED.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_LED.Location = new System.Drawing.Point(131, 127);
            this.Cb_LED.Name = "Cb_LED";
            this.Cb_LED.Size = new System.Drawing.Size(89, 17);
            this.Cb_LED.TabIndex = 14;
            this.Cb_LED.Text = "Duplicar LED";
            this.Cb_LED.UseVisualStyleBackColor = true;
            // 
            // Bt_Config
            // 
            this.Bt_Config.Location = new System.Drawing.Point(10, 225);
            this.Bt_Config.Name = "Bt_Config";
            this.Bt_Config.Size = new System.Drawing.Size(89, 23);
            this.Bt_Config.TabIndex = 503;
            this.Bt_Config.Text = "Config";
            this.Bt_Config.UseVisualStyleBackColor = true;
            this.Bt_Config.Click += new System.EventHandler(this.Bt_Config_Click);
            // 
            // Cb_Doble
            // 
            this.Cb_Doble.AutoSize = true;
            this.Cb_Doble.Checked = true;
            this.Cb_Doble.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_Doble.Location = new System.Drawing.Point(10, 127);
            this.Cb_Doble.Name = "Cb_Doble";
            this.Cb_Doble.Size = new System.Drawing.Size(105, 17);
            this.Cb_Doble.TabIndex = 13;
            this.Cb_Doble.Text = "Dobles etiquetas";
            this.Cb_Doble.UseVisualStyleBackColor = true;
            // 
            // Lb_Version
            // 
            this.Lb_Version.AutoSize = true;
            this.Lb_Version.Location = new System.Drawing.Point(8, 375);
            this.Lb_Version.Name = "Lb_Version";
            this.Lb_Version.Size = new System.Drawing.Size(29, 13);
            this.Lb_Version.TabIndex = 14;
            this.Lb_Version.Text = "Ver: ";
            this.Lb_Version.DoubleClick += new System.EventHandler(this.Lb_Version_DoubleClick);
            // 
            // Lb_Error
            // 
            this.Lb_Error.AutoSize = true;
            this.Lb_Error.Location = new System.Drawing.Point(8, 305);
            this.Lb_Error.Name = "Lb_Error";
            this.Lb_Error.Size = new System.Drawing.Size(10, 13);
            this.Lb_Error.TabIndex = 501;
            this.Lb_Error.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "DebugButton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tb_Coment_0
            // 
            this.Tb_Coment_0.Location = new System.Drawing.Point(705, 25);
            this.Tb_Coment_0.Name = "Tb_Coment_0";
            this.Tb_Coment_0.Size = new System.Drawing.Size(115, 20);
            this.Tb_Coment_0.TabIndex = 103;
            // 
            // Tb_Pais_0
            // 
            this.Tb_Pais_0.Location = new System.Drawing.Point(615, 25);
            this.Tb_Pais_0.Name = "Tb_Pais_0";
            this.Tb_Pais_0.Size = new System.Drawing.Size(85, 20);
            this.Tb_Pais_0.TabIndex = 102;
            // 
            // Tb_Cad_0
            // 
            this.Tb_Cad_0.Location = new System.Drawing.Point(495, 25);
            this.Tb_Cad_0.Name = "Tb_Cad_0";
            this.Tb_Cad_0.Size = new System.Drawing.Size(115, 20);
            this.Tb_Cad_0.TabIndex = 101;
            // 
            // Tb_Pant_0
            // 
            this.Tb_Pant_0.Location = new System.Drawing.Point(289, 25);
            this.Tb_Pant_0.Name = "Tb_Pant_0";
            this.Tb_Pant_0.Size = new System.Drawing.Size(200, 20);
            this.Tb_Pant_0.TabIndex = 100;
            // 
            // Lb_Tit_Pantalla
            // 
            this.Lb_Tit_Pantalla.AutoSize = true;
            this.Lb_Tit_Pantalla.Location = new System.Drawing.Point(295, 10);
            this.Lb_Tit_Pantalla.Name = "Lb_Tit_Pantalla";
            this.Lb_Tit_Pantalla.Size = new System.Drawing.Size(45, 13);
            this.Lb_Tit_Pantalla.TabIndex = 106;
            this.Lb_Tit_Pantalla.Text = "Pantalla";
            // 
            // Lb_Tit_Cadena
            // 
            this.Lb_Tit_Cadena.AutoSize = true;
            this.Lb_Tit_Cadena.Location = new System.Drawing.Point(495, 10);
            this.Lb_Tit_Cadena.Name = "Lb_Tit_Cadena";
            this.Lb_Tit_Cadena.Size = new System.Drawing.Size(44, 13);
            this.Lb_Tit_Cadena.TabIndex = 107;
            this.Lb_Tit_Cadena.Text = "Cadena";
            // 
            // Lb_Tit_Pais
            // 
            this.Lb_Tit_Pais.AutoSize = true;
            this.Lb_Tit_Pais.Location = new System.Drawing.Point(615, 10);
            this.Lb_Tit_Pais.Name = "Lb_Tit_Pais";
            this.Lb_Tit_Pais.Size = new System.Drawing.Size(29, 13);
            this.Lb_Tit_Pais.TabIndex = 108;
            this.Lb_Tit_Pais.Text = "País";
            // 
            // Lb_EQ_1
            // 
            this.Lb_EQ_1.AutoSize = true;
            this.Lb_EQ_1.Location = new System.Drawing.Point(245, 30);
            this.Lb_EQ_1.Name = "Lb_EQ_1";
            this.Lb_EQ_1.Size = new System.Drawing.Size(30, 13);
            this.Lb_EQ_1.TabIndex = 109;
            this.Lb_EQ_1.Text = "PC 1";
            // 
            // Lb_Tit_Coment
            // 
            this.Lb_Tit_Coment.AutoSize = true;
            this.Lb_Tit_Coment.Location = new System.Drawing.Point(710, 10);
            this.Lb_Tit_Coment.Name = "Lb_Tit_Coment";
            this.Lb_Tit_Coment.Size = new System.Drawing.Size(60, 13);
            this.Lb_Tit_Coment.TabIndex = 110;
            this.Lb_Tit_Coment.Text = "Comentario";
            // 
            // Gb_Lang_jpn
            // 
            this.Gb_Lang_jpn.Controls.Add(this.PcB_Jpn);
            this.Gb_Lang_jpn.Location = new System.Drawing.Point(190, 478);
            this.Gb_Lang_jpn.Name = "Gb_Lang_jpn";
            this.Gb_Lang_jpn.Size = new System.Drawing.Size(39, 44);
            this.Gb_Lang_jpn.TabIndex = 502;
            this.Gb_Lang_jpn.TabStop = false;
            this.Gb_Lang_jpn.Text = "jpn";
            // 
            // PcB_Jpn
            // 
            this.PcB_Jpn.Image = ((System.Drawing.Image)(resources.GetObject("PcB_Jpn.Image")));
            this.PcB_Jpn.Location = new System.Drawing.Point(6, 19);
            this.PcB_Jpn.Name = "PcB_Jpn";
            this.PcB_Jpn.Size = new System.Drawing.Size(25, 18);
            this.PcB_Jpn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcB_Jpn.TabIndex = 503;
            this.PcB_Jpn.TabStop = false;
            this.PcB_Jpn.Click += new System.EventHandler(this.PcB_Jpn_Click);
            // 
            // PicB_Chn
            // 
            this.PicB_Chn.Image = ((System.Drawing.Image)(resources.GetObject("PicB_Chn.Image")));
            this.PicB_Chn.Location = new System.Drawing.Point(6, 19);
            this.PicB_Chn.Name = "PicB_Chn";
            this.PicB_Chn.Size = new System.Drawing.Size(25, 18);
            this.PicB_Chn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicB_Chn.TabIndex = 3;
            this.PicB_Chn.TabStop = false;
            this.PicB_Chn.Click += new System.EventHandler(this.PicB_Chn_Click);
            // 
            // Pic_B_Ger
            // 
            this.Pic_B_Ger.Image = ((System.Drawing.Image)(resources.GetObject("Pic_B_Ger.Image")));
            this.Pic_B_Ger.Location = new System.Drawing.Point(6, 19);
            this.Pic_B_Ger.Name = "Pic_B_Ger";
            this.Pic_B_Ger.Size = new System.Drawing.Size(25, 18);
            this.Pic_B_Ger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_B_Ger.TabIndex = 2;
            this.Pic_B_Ger.TabStop = false;
            this.Pic_B_Ger.Click += new System.EventHandler(this.Pic_B_Ger_Click);
            // 
            // PicB_Esp
            // 
            this.PicB_Esp.Image = ((System.Drawing.Image)(resources.GetObject("PicB_Esp.Image")));
            this.PicB_Esp.Location = new System.Drawing.Point(6, 19);
            this.PicB_Esp.Name = "PicB_Esp";
            this.PicB_Esp.Size = new System.Drawing.Size(25, 18);
            this.PicB_Esp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicB_Esp.TabIndex = 0;
            this.PicB_Esp.TabStop = false;
            this.PicB_Esp.Click += new System.EventHandler(this.PicB_Esp_Click);
            // 
            // Gb_Lang_esp
            // 
            this.Gb_Lang_esp.Controls.Add(this.PicB_Esp);
            this.Gb_Lang_esp.Location = new System.Drawing.Point(10, 478);
            this.Gb_Lang_esp.Name = "Gb_Lang_esp";
            this.Gb_Lang_esp.Size = new System.Drawing.Size(39, 44);
            this.Gb_Lang_esp.TabIndex = 504;
            this.Gb_Lang_esp.TabStop = false;
            this.Gb_Lang_esp.Text = "esp";
            // 
            // Gb_Lang_eng
            // 
            this.Gb_Lang_eng.Controls.Add(this.PicB_Eng);
            this.Gb_Lang_eng.Location = new System.Drawing.Point(55, 478);
            this.Gb_Lang_eng.Name = "Gb_Lang_eng";
            this.Gb_Lang_eng.Size = new System.Drawing.Size(39, 44);
            this.Gb_Lang_eng.TabIndex = 505;
            this.Gb_Lang_eng.TabStop = false;
            this.Gb_Lang_eng.Text = "eng";
            // 
            // PicB_Eng
            // 
            this.PicB_Eng.Image = ((System.Drawing.Image)(resources.GetObject("PicB_Eng.Image")));
            this.PicB_Eng.Location = new System.Drawing.Point(6, 19);
            this.PicB_Eng.Name = "PicB_Eng";
            this.PicB_Eng.Size = new System.Drawing.Size(25, 18);
            this.PicB_Eng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicB_Eng.TabIndex = 1;
            this.PicB_Eng.TabStop = false;
            this.PicB_Eng.Click += new System.EventHandler(this.PicB_Eng_Click);
            // 
            // Gb_Lang_ger
            // 
            this.Gb_Lang_ger.Controls.Add(this.Pic_B_Ger);
            this.Gb_Lang_ger.Location = new System.Drawing.Point(100, 478);
            this.Gb_Lang_ger.Name = "Gb_Lang_ger";
            this.Gb_Lang_ger.Size = new System.Drawing.Size(39, 44);
            this.Gb_Lang_ger.TabIndex = 506;
            this.Gb_Lang_ger.TabStop = false;
            this.Gb_Lang_ger.Text = "ger";
            // 
            // Gb_Lang_chn
            // 
            this.Gb_Lang_chn.Controls.Add(this.PicB_Chn);
            this.Gb_Lang_chn.Location = new System.Drawing.Point(145, 478);
            this.Gb_Lang_chn.Name = "Gb_Lang_chn";
            this.Gb_Lang_chn.Size = new System.Drawing.Size(39, 44);
            this.Gb_Lang_chn.TabIndex = 507;
            this.Gb_Lang_chn.TabStop = false;
            this.Gb_Lang_chn.Text = "chn";
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.SelectedPath = "C:\\Etiquetas";
            // 
            // Etiqueter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 587);
            this.Controls.Add(this.Gb_Lang_chn);
            this.Controls.Add(this.Gb_Lang_ger);
            this.Controls.Add(this.Gb_Lang_eng);
            this.Controls.Add(this.Gb_Lang_esp);
            this.Controls.Add(this.Gb_Lang_jpn);
            this.Controls.Add(this.Lb_Tit_Coment);
            this.Controls.Add(this.Lb_EQ_1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Lb_Tit_Pais);
            this.Controls.Add(this.Lb_Tit_Cadena);
            this.Controls.Add(this.Lb_Tit_Pantalla);
            this.Controls.Add(this.Tb_Pant_0);
            this.Controls.Add(this.Tb_Cad_0);
            this.Controls.Add(this.Tb_Pais_0);
            this.Controls.Add(this.Tb_Coment_0);
            this.Controls.Add(this.Gb_Config);
            this.Controls.Add(this.button1);
            this.Name = "Etiqueter";
            this.Text = "Etiqueter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            this.Gb_Config.ResumeLayout(false);
            this.Gb_Config.PerformLayout();
            this.Gb_Lang_jpn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcB_Jpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Chn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_B_Ger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Esp)).EndInit();
            this.Gb_Lang_esp.ResumeLayout(false);
            this.Gb_Lang_eng.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicB_Eng)).EndInit();
            this.Gb_Lang_ger.ResumeLayout(false);
            this.Gb_Lang_chn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Cantidad;
        private System.Windows.Forms.Button Bt_Go;
        private System.Windows.Forms.Label Lb_G_NumPant;
        private System.Windows.Forms.TextBox Cadena_tb;
        private System.Windows.Forms.Label Lb_G_Cad_num;
        private System.Windows.Forms.Label Lb_G_Pais;
        private System.Windows.Forms.TextBox Pais_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Gb_Config;
        private System.Windows.Forms.Label Lb_Version;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Tb_Coment_0;
        private System.Windows.Forms.TextBox Tb_Pais_0;
        private System.Windows.Forms.TextBox Tb_Cad_0;
        private System.Windows.Forms.TextBox Tb_Pant_0;
        private System.Windows.Forms.Label Lb_Tit_Pantalla;
        private System.Windows.Forms.Label Lb_Tit_Cadena;
        private System.Windows.Forms.Label Lb_Tit_Pais;
        private System.Windows.Forms.Label Lb_EQ_1;
        private System.Windows.Forms.Label Lb_Tit_Coment;
        private System.Windows.Forms.CheckBox Cb_LED;
        private System.Windows.Forms.CheckBox Cb_Doble;
        private System.Windows.Forms.Label Lb_Error;
        private System.Windows.Forms.GroupBox Gb_Lang_jpn;
        private System.Windows.Forms.PictureBox PicB_Esp;
        private System.Windows.Forms.RadioButton Rb_Format_2;
        private System.Windows.Forms.RadioButton Rb_Format_1;
        private System.Windows.Forms.PictureBox Pic_B_Ger;
        private System.Windows.Forms.PictureBox PicB_Chn;
        private System.Windows.Forms.PictureBox PcB_Jpn;
        private System.Windows.Forms.Button Bt_Config;
        private System.Windows.Forms.GroupBox Gb_Lang_esp;
        private System.Windows.Forms.GroupBox Gb_Lang_eng;
        private System.Windows.Forms.PictureBox PicB_Eng;
        private System.Windows.Forms.GroupBox Gb_Lang_ger;
        private System.Windows.Forms.GroupBox Gb_Lang_chn;
        private System.Windows.Forms.Label Lb_conf_fold;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
    }
}

