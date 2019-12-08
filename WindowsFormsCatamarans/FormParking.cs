using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCatamarans
{
    public partial class FormParking : Form
    {
        MultiLevelParking parking;
        private const int countLevel = 5;
        public FormParking()

        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxlevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxlevels.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxlevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void buttonParkBoat_Click(object sender, EventArgs e)
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new CarCat(100, 1000, dialog.Color);
                    int place = parking[listBoxlevels.SelectedIndex] + car;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void buttonParkCatamaran_Click(object sender, EventArgs e)
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var cat = new CatamaranGrade(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        int place = parking[listBoxlevels.SelectedIndex] + cat;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void buttonTakeOff_Click(object sender, EventArgs e)
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
                if (maskedTextBoxParking.Text != "")
                {
                    var cat = parking[listBoxlevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxParking.Text);
                    if (cat != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxParkingS.Width, pictureBoxParkingS.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        cat.SetPosition(5, 5, pictureBoxParkingS.Width, pictureBoxParkingS.Height);
                        cat.DrawCatamaran(gr);
                        pictureBoxParkingS.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxParkingS.Width, pictureBoxParkingS.Height);
                        pictureBoxParkingS.Image = bmp;
                    }
                    Draw();
                }
            }
        }

        private void listBoxlevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}