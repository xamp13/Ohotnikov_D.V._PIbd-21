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
    public partial class FormCatamaranConfig : Form
    {
        ITransport cat = null;

        private event catDelegate eventAddBoat;

        public FormCatamaranConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawCatamaran()
        {
            if (cat != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxboat.Width, pictureBoxboat.Height);
                Graphics gr = Graphics.FromImage(bmp);
                cat.SetPosition(5, 5, pictureBoxboat.Width, pictureBoxboat.Height);
                cat.DrawCatamaran(gr);
                pictureBoxboat.Image = bmp;
            }
        }

        public void AddEvent(catDelegate ev)
        {
            if (eventAddBoat == null)
            {
                eventAddBoat = new catDelegate(ev);
            }
            else
            {
                eventAddBoat += ev;
            }
        }

        private void labelBoat_MouseDown(object sender, MouseEventArgs e)
        {
            labelBoat.DoDragDrop(labelBoat.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelCatamaran_MouseDown(object sender, MouseEventArgs e)
        {
            labelCatamaran.DoDragDrop(labelCatamaran.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelBoat_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelBoat_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Лодка":
                    cat = new CarCat(100, 500, Color.White);
                    break;
                case "Катамаран":
                    cat = new CatamaranGrade(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            DrawCatamaran();
        }


        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void PrimaryColor_Label_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PrimaryColor_Label_DragDrop(object sender, DragEventArgs e)
        {
            if (cat != null)
            {
                cat.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCatamaran();
            }
        }

        private void SecondaryColor_Label_DragDrop(object sender, DragEventArgs e)
        {
            if (cat != null)
            {
                if (cat is CatamaranGrade)
                {
                    (cat as CatamaranGrade).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCatamaran();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddBoat?.Invoke(cat);
            Close();
        }
    }
}
