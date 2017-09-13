using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class RadarSettings : Form
    {
        public Settings settings;

        public RadarSettings()
        {
            InitializeComponent();
            this.settings = new Settings();
            this.getSettings();
        }

        private void getSettings()
        {
            this.settings.playerP = new Pen(this.PlayersColor.BackColor);
            this.settings.friendP = new Pen(this.FriendsColor.BackColor);
            this.settings.autoturretP = new Pen(this.AutoturretColor.BackColor);
            this.settings.resourceP = new Pen(this.ResourceColor.BackColor);

            this.settings.playerB = new SolidBrush(this.PlayersColor.BackColor);
            this.settings.friendB = new SolidBrush(this.FriendsColor.BackColor);
            this.settings.autoturretB = new SolidBrush(this.AutoturretColor.BackColor);
            this.settings.resourceB = new SolidBrush(this.ResourceColor.BackColor);
            
            this.settings.radarP = new Pen(this.RadarColor.BackColor);
            this.settings.radarB = new SolidBrush(this.RadarColor.BackColor);

            this.settings.sizeRadar = (ushort) this.RadarSize.Value;
            this.settings.center = (ushort) (this.settings.sizeRadar/2);
            this.settings.buferSize = (ushort) (this.settings.sizeRadar + 1);
            this.settings.sizeDot = (ushort) this.DotSize.Value;
            this.settings.halfdot = (ushort) (this.settings.sizeDot/2);

            this.settings.radPosX = this.settings.center - this.settings.halfdot;
            this.settings.radPosY = this.settings.center - this.settings.halfdot;

            this.settings.SetCircle();

            this.settings.showName = this.ShowName.Checked;

            String str = this.FriendList.Text;
            String[] friends = str.Split(new string[] {Environment.NewLine}, StringSplitOptions.None);
            this.settings.friends = friends;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.getSettings();
            this.Hide();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Button sendButton = sender as Button;
                sendButton.BackColor = colorDialog.Color;
            }
        }

        private void RadarSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void RadarSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}