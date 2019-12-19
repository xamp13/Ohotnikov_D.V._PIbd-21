using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

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

        private Logger logger;

        public FormParking()

        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
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
                    try
                    {
                        var cat = parking[listBoxlevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxParking.Text);
                        if (cat != null)
                        {
                            Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            cat.SetPosition(5, 5, pictureBoxTake.Width, pictureBoxTake.Height);
                            cat.DrawCatamaran(gr);
                            logger.Info($"Изъята лодка {cat.ToString()} с места {maskedTextBoxParking.Text}");
                            pictureBoxTake.Image = bmp;
                        }
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        logger.Warn(ex.Message);
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                        pictureBoxTake.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        logger.Warn(ex.Message);
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                try
                {
                    int place = parking[listBoxlevels.SelectedIndex] + cat;
                    Draw();
                    logger.Info($"Лодка {cat.ToString()} помещена на место {place}");
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }

                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}