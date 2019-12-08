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
        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelParking parking;

        FormCatamaranConfig form;

        private const int countLevel = 5;
        public FormParking()

        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxlevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxlevels.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxlevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxlevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }


        private void buttonTakeoff_Click(object sender, EventArgs e)
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
                if (maskedTextBoxParking.Text != "")
                {
                    var cat = parking[listBoxlevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxParking.Text);
                    if (cat != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        cat.SetPosition(5, 5, pictureBoxTake.Width, pictureBoxTake.Height);
                        cat.DrawCatamaran(gr);
                        pictureBoxTake.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                        pictureBoxTake.Image = bmp;
                    }
                    Draw();
                }
            }
        }

        private void listBoxlevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            form = new FormCatamaranConfig();
            form.AddEvent(AddBoat);
            form.ShowDialog();
        }

        private void AddBoat(ITransport cat)
        {
            if (cat != null && listBoxlevels.SelectedIndex > -1)
            {
                int place = parking[listBoxlevels.SelectedIndex] + cat;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}