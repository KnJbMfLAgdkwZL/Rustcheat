namespace ConsoleApplication1
{
    partial class RadarSettings
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
            this.close = new System.Windows.Forms.Button();
            this.PlayersColor = new System.Windows.Forms.Button();
            this.FriendsColor = new System.Windows.Forms.Button();
            this.FriendList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowName = new System.Windows.Forms.CheckBox();
            this.RadarSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DotSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.RadarColor = new System.Windows.Forms.Button();
            this.AutoturretColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ResourceColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RadarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DotSize)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(371, 238);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // PlayersColor
            // 
            this.PlayersColor.BackColor = System.Drawing.Color.Red;
            this.PlayersColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayersColor.Location = new System.Drawing.Point(125, 12);
            this.PlayersColor.Name = "PlayersColor";
            this.PlayersColor.Size = new System.Drawing.Size(75, 23);
            this.PlayersColor.TabIndex = 15;
            this.PlayersColor.UseVisualStyleBackColor = false;
            this.PlayersColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // FriendsColor
            // 
            this.FriendsColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FriendsColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendsColor.Location = new System.Drawing.Point(125, 41);
            this.FriendsColor.Name = "FriendsColor";
            this.FriendsColor.Size = new System.Drawing.Size(75, 23);
            this.FriendsColor.TabIndex = 17;
            this.FriendsColor.UseVisualStyleBackColor = false;
            this.FriendsColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // FriendList
            // 
            this.FriendList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FriendList.Location = new System.Drawing.Point(208, 30);
            this.FriendList.Margin = new System.Windows.Forms.Padding(5);
            this.FriendList.Multiline = true;
            this.FriendList.Name = "FriendList";
            this.FriendList.Size = new System.Drawing.Size(238, 200);
            this.FriendList.TabIndex = 19;
            this.FriendList.Text = "lllllllllll\r\ndune\r\ntyutyu\r\nYourFamilyMyDick\r\nАнаконда Хачик™\r\nhellyeah\r\nXdSfJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Friend List";
            // 
            // ShowName
            // 
            this.ShowName.AutoSize = true;
            this.ShowName.Checked = true;
            this.ShowName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowName.Location = new System.Drawing.Point(12, 138);
            this.ShowName.Name = "ShowName";
            this.ShowName.Size = new System.Drawing.Size(84, 17);
            this.ShowName.TabIndex = 42;
            this.ShowName.Text = "Show Name";
            this.ShowName.UseVisualStyleBackColor = true;
            // 
            // RadarSize
            // 
            this.RadarSize.Location = new System.Drawing.Point(140, 204);
            this.RadarSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RadarSize.Name = "RadarSize";
            this.RadarSize.Size = new System.Drawing.Size(60, 20);
            this.RadarSize.TabIndex = 55;
            this.RadarSize.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Dot Size";
            // 
            // DotSize
            // 
            this.DotSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.DotSize.Location = new System.Drawing.Point(140, 228);
            this.DotSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DotSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.DotSize.Name = "DotSize";
            this.DotSize.Size = new System.Drawing.Size(60, 20);
            this.DotSize.TabIndex = 61;
            this.DotSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Radar Color";
            // 
            // RadarColor
            // 
            this.RadarColor.BackColor = System.Drawing.Color.Blue;
            this.RadarColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadarColor.Location = new System.Drawing.Point(125, 169);
            this.RadarColor.Name = "RadarColor";
            this.RadarColor.Size = new System.Drawing.Size(75, 23);
            this.RadarColor.TabIndex = 64;
            this.RadarColor.UseVisualStyleBackColor = false;
            this.RadarColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // AutoturretColor
            // 
            this.AutoturretColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AutoturretColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoturretColor.Location = new System.Drawing.Point(125, 70);
            this.AutoturretColor.Name = "AutoturretColor";
            this.AutoturretColor.Size = new System.Drawing.Size(75, 23);
            this.AutoturretColor.TabIndex = 66;
            this.AutoturretColor.UseVisualStyleBackColor = false;
            this.AutoturretColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Players";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Friends";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Autoturret";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Resource";
            // 
            // ResourceColor
            // 
            this.ResourceColor.BackColor = System.Drawing.Color.Cyan;
            this.ResourceColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResourceColor.Location = new System.Drawing.Point(125, 99);
            this.ResourceColor.Name = "ResourceColor";
            this.ResourceColor.Size = new System.Drawing.Size(75, 23);
            this.ResourceColor.TabIndex = 70;
            this.ResourceColor.UseVisualStyleBackColor = false;
            this.ResourceColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // RadarSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 274);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ResourceColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AutoturretColor);
            this.Controls.Add(this.RadarColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DotSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RadarSize);
            this.Controls.Add(this.ShowName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FriendList);
            this.Controls.Add(this.FriendsColor);
            this.Controls.Add(this.PlayersColor);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadarSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radar Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RadarSettings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RadarSettings_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.RadarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DotSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button close;
        public System.Windows.Forms.Button PlayersColor;
        public System.Windows.Forms.Button FriendsColor;
        public System.Windows.Forms.TextBox FriendList;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox ShowName;
        public System.Windows.Forms.NumericUpDown RadarSize;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown DotSize;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button RadarColor;
        public System.Windows.Forms.Button AutoturretColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button ResourceColor;
    }
}