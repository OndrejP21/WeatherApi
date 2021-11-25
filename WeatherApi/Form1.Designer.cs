namespace WeatherApi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._btnSearch = new System.Windows.Forms.Button();
            this._txtCityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._lblTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._lblDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._lblWind = new System.Windows.Forms.Label();
            this._imgWeather = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lblSunset = new System.Windows.Forms.Label();
            this._lblTown = new System.Windows.Forms.Label();
            this._lblSunrise = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this._pctSunrise = new System.Windows.Forms.PictureBox();
            this._lblHumidity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._lblCloudy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._imgWeather)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pctSunrise)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnSearch
            // 
            this._btnSearch.Location = new System.Drawing.Point(215, 39);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(75, 23);
            this._btnSearch.TabIndex = 0;
            this._btnSearch.Text = "Hledat";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _txtCityName
            // 
            this._txtCityName.Location = new System.Drawing.Point(54, 40);
            this._txtCityName.Name = "_txtCityName";
            this._txtCityName.Size = new System.Drawing.Size(155, 22);
            this._txtCityName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teplota (pocit.)";
            // 
            // _lblTemp
            // 
            this._lblTemp.AutoSize = true;
            this._lblTemp.Location = new System.Drawing.Point(159, 80);
            this._lblTemp.Name = "_lblTemp";
            this._lblTemp.Size = new System.Drawing.Size(11, 16);
            this._lblTemp.TabIndex = 3;
            this._lblTemp.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oblačnost";
            // 
            // _lblDesc
            // 
            this._lblDesc.AutoSize = true;
            this._lblDesc.Location = new System.Drawing.Point(159, 110);
            this._lblDesc.Name = "_lblDesc";
            this._lblDesc.Size = new System.Drawing.Size(11, 16);
            this._lblDesc.TabIndex = 5;
            this._lblDesc.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vítr";
            // 
            // _lblWind
            // 
            this._lblWind.AutoSize = true;
            this._lblWind.Location = new System.Drawing.Point(159, 169);
            this._lblWind.Name = "_lblWind";
            this._lblWind.Size = new System.Drawing.Size(11, 16);
            this._lblWind.TabIndex = 7;
            this._lblWind.Text = "-";
            // 
            // _imgWeather
            // 
            this._imgWeather.Location = new System.Drawing.Point(258, 80);
            this._imgWeather.Name = "_imgWeather";
            this._imgWeather.Size = new System.Drawing.Size(108, 96);
            this._imgWeather.TabIndex = 8;
            this._imgWeather.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(62, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Město";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._lblSunset);
            this.groupBox1.Controls.Add(this._lblTown);
            this.groupBox1.Controls.Add(this._lblSunrise);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this._lblTemp);
            this.groupBox1.Controls.Add(this._pctSunrise);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._lblDesc);
            this.groupBox1.Controls.Add(this._lblHumidity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._lblWind);
            this.groupBox1.Controls.Add(this._lblCloudy);
            this.groupBox1.Controls.Add(this._imgWeather);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(66, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 312);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistiky o počasí";
            // 
            // _lblSunset
            // 
            this._lblSunset.AutoSize = true;
            this._lblSunset.Location = new System.Drawing.Point(258, 243);
            this._lblSunset.Name = "_lblSunset";
            this._lblSunset.Size = new System.Drawing.Size(14, 16);
            this._lblSunset.TabIndex = 19;
            this._lblSunset.Text = "0";
            // 
            // _lblTown
            // 
            this._lblTown.AutoSize = true;
            this._lblTown.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._lblTown.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._lblTown.Location = new System.Drawing.Point(139, 33);
            this._lblTown.Name = "_lblTown";
            this._lblTown.Size = new System.Drawing.Size(66, 25);
            this._lblTown.TabIndex = 15;
            this._lblTown.Text = "Město";
            // 
            // _lblSunrise
            // 
            this._lblSunrise.AutoSize = true;
            this._lblSunrise.Location = new System.Drawing.Point(117, 243);
            this._lblSunrise.Name = "_lblSunrise";
            this._lblSunrise.Size = new System.Drawing.Size(14, 16);
            this._lblSunrise.TabIndex = 18;
            this._lblSunrise.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // _pctSunrise
            // 
            this._pctSunrise.Image = ((System.Drawing.Image)(resources.GetObject("_pctSunrise.Image")));
            this._pctSunrise.Location = new System.Drawing.Point(53, 234);
            this._pctSunrise.Name = "_pctSunrise";
            this._pctSunrise.Size = new System.Drawing.Size(40, 40);
            this._pctSunrise.TabIndex = 16;
            this._pctSunrise.TabStop = false;
            // 
            // _lblHumidity
            // 
            this._lblHumidity.AutoSize = true;
            this._lblHumidity.Location = new System.Drawing.Point(159, 196);
            this._lblHumidity.Name = "_lblHumidity";
            this._lblHumidity.Size = new System.Drawing.Size(11, 16);
            this._lblHumidity.TabIndex = 14;
            this._lblHumidity.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vlhkost";
            // 
            // _lblCloudy
            // 
            this._lblCloudy.AutoSize = true;
            this._lblCloudy.Location = new System.Drawing.Point(159, 141);
            this._lblCloudy.Name = "_lblCloudy";
            this._lblCloudy.Size = new System.Drawing.Size(11, 16);
            this._lblCloudy.TabIndex = 12;
            this._lblCloudy.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oblačnost (čís)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtCityName);
            this.Controls.Add(this._btnSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._imgWeather)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pctSunrise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.TextBox _txtCityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _lblDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _lblWind;
        private System.Windows.Forms.PictureBox _imgWeather;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblCloudy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _lblHumidity;
        private System.Windows.Forms.Label _lblTown;
        private System.Windows.Forms.PictureBox _pctSunrise;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label _lblSunset;
        private System.Windows.Forms.Label _lblSunrise;
    }
}

