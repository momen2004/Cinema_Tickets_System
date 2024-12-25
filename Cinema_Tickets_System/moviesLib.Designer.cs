namespace Cinema_Tickets_System
{
    partial class moviesLib
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moviesLib));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDays = new System.Windows.Forms.ListBox();
            this.listViewMovies = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.mainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose your prefered day";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxDays
            // 
            this.listBoxDays.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listBoxDays.BackColor = System.Drawing.Color.DarkRed;
            this.listBoxDays.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDays.ForeColor = System.Drawing.Color.White;
            this.listBoxDays.FormattingEnabled = true;
            this.listBoxDays.ItemHeight = 54;
            this.listBoxDays.Items.AddRange(new object[] {
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.listBoxDays.Location = new System.Drawing.Point(17, 228);
            this.listBoxDays.Name = "listBoxDays";
            this.listBoxDays.Size = new System.Drawing.Size(332, 436);
            this.listBoxDays.TabIndex = 2;
            this.listBoxDays.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listViewMovies
            // 
            this.listViewMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMovies.BackColor = System.Drawing.Color.Gray;
            this.listViewMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMovies.HideSelection = false;
            this.listViewMovies.LargeImageList = this.imageList1;
            this.listViewMovies.Location = new System.Drawing.Point(355, 126);
            this.listViewMovies.MultiSelect = false;
            this.listViewMovies.Name = "listViewMovies";
            this.listViewMovies.Size = new System.Drawing.Size(824, 551);
            this.listViewMovies.SmallImageList = this.imageList1;
            this.listViewMovies.TabIndex = 3;
            this.listViewMovies.TileSize = new System.Drawing.Size(600, 600);
            this.listViewMovies.UseCompatibleStateImageBehavior = false;
            this.listViewMovies.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Chris the swiss.jpg");
            this.imageList1.Images.SetKeyName(1, "Curse of Chucky.jpg");
            this.imageList1.Images.SetKeyName(2, "sdfa");
            this.imageList1.Images.SetKeyName(3, "IMG-20241220-WA0028.jpg");
            this.imageList1.Images.SetKeyName(4, "IMG-20241220-WA0029.jpg");
            this.imageList1.Images.SetKeyName(5, "IMG-20241220-WA0030.jpg");
            this.imageList1.Images.SetKeyName(6, "IMG-20241220-WA0031.jpg");
            this.imageList1.Images.SetKeyName(7, "IMG-20241220-WA0032.jpg");
            this.imageList1.Images.SetKeyName(8, "IMG-20241220-WA0033.jpg");
            this.imageList1.Images.SetKeyName(9, "IMG-20241220-WA0034.jpg");
            this.imageList1.Images.SetKeyName(10, "IMG-20241220-WA0035.jpg");
            this.imageList1.Images.SetKeyName(11, "IMG-20241220-WA0036.jpg");
            this.imageList1.Images.SetKeyName(12, "IMG-20241220-WA0037.jpg");
            this.imageList1.Images.SetKeyName(13, "IMG-20241220-WA0038.jpg");
            this.imageList1.Images.SetKeyName(14, "IMG-20241220-WA0039.jpg");
            this.imageList1.Images.SetKeyName(15, "IMG-20241220-WA0040.jpg");
            this.imageList1.Images.SetKeyName(16, "IMG-20241220-WA0041.jpg");
            this.imageList1.Images.SetKeyName(17, "IMG-20241220-WA0042.jpg");
            this.imageList1.Images.SetKeyName(18, "IMG-20241220-WA0043.jpg");
            this.imageList1.Images.SetKeyName(19, "IMG-20241220-WA0044.jpg");
            this.imageList1.Images.SetKeyName(20, "IMG-20241220-WA0045.jpg");
            this.imageList1.Images.SetKeyName(21, "IMG-20241220-WA0046.jpg");
            this.imageList1.Images.SetKeyName(22, "IMG-20241220-WA0047.jpg");
            this.imageList1.Images.SetKeyName(23, "IMG-20241220-WA0049.jpg");
            this.imageList1.Images.SetKeyName(24, "IMG-20241220-WA0050.jpg");
            this.imageList1.Images.SetKeyName(25, "IMG-20241220-WA0051.jpg");
            this.imageList1.Images.SetKeyName(26, "Inside out 2.jpg");
            this.imageList1.Images.SetKeyName(27, "Inside out.jpg");
            this.imageList1.Images.SetKeyName(28, "Jhon wick.jpg");
            this.imageList1.Images.SetKeyName(29, "Monsters.jpg");
            this.imageList1.Images.SetKeyName(30, "Mulan.jpg");
            this.imageList1.Images.SetKeyName(31, "Siccin 7.jpg");
            this.imageList1.Images.SetKeyName(32, "TCF.jpg");
            this.imageList1.Images.SetKeyName(33, "The maze runner.jpg");
            this.imageList1.Images.SetKeyName(34, "Toy story That time forgot.jpg");
            this.imageList1.Images.SetKeyName(35, "TS.jpg");
            this.imageList1.Images.SetKeyName(36, "TS2.jpg");
            this.imageList1.Images.SetKeyName(37, "TS3.jpg");
            this.imageList1.Images.SetKeyName(38, "TS4.jpg");
            this.imageList1.Images.SetKeyName(39, "Winne the pooh.jpg");
            this.imageList1.Images.SetKeyName(40, "Wreek it ralph.jpg");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(594, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 59);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movies available";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mainBtn
            // 
            this.mainBtn.BackColor = System.Drawing.Color.White;
            this.mainBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBtn.Location = new System.Drawing.Point(12, 12);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(232, 60);
            this.mainBtn.TabIndex = 5;
            this.mainBtn.Text = "Main screen";
            this.mainBtn.UseVisualStyleBackColor = false;
            this.mainBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // moviesLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1179, 689);
            this.Controls.Add(this.listViewMovies);
            this.Controls.Add(this.mainBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxDays);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "moviesLib";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "moviesLib";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.moviesLib_FormClosing);
            this.Load += new System.EventHandler(this.moviesLib_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDays;
        private System.Windows.Forms.ListView listViewMovies;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mainBtn;
    }
}