namespace WindowsFormsCatamarans
{
    partial class FormCatamaranConfig
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
            this.pictureBoxboat = new System.Windows.Forms.PictureBox();
            this.catamaranType = new System.Windows.Forms.GroupBox();
            this.labelCatamaran = new System.Windows.Forms.Label();
            this.labelBoat = new System.Windows.Forms.Label();
            this.panelBoat = new System.Windows.Forms.Panel();
            this.SecondaryColor_Label = new System.Windows.Forms.Label();
            this.PrimaryColor_Label = new System.Windows.Forms.Label();
            this.groupBox_Colors = new System.Windows.Forms.GroupBox();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxboat)).BeginInit();
            this.catamaranType.SuspendLayout();
            this.panelBoat.SuspendLayout();
            this.groupBox_Colors.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxboat
            // 
            this.pictureBoxboat.Location = new System.Drawing.Point(39, 17);
            this.pictureBoxboat.Name = "pictureBoxboat";
            this.pictureBoxboat.Size = new System.Drawing.Size(122, 83);
            this.pictureBoxboat.TabIndex = 0;
            this.pictureBoxboat.TabStop = false;
            this.pictureBoxboat.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragDrop);
            this.pictureBoxboat.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragEnter);
            // 
            // catamaranType
            // 
            this.catamaranType.Controls.Add(this.labelCatamaran);
            this.catamaranType.Controls.Add(this.labelBoat);
            this.catamaranType.Location = new System.Drawing.Point(12, 12);
            this.catamaranType.Name = "catamaranType";
            this.catamaranType.Size = new System.Drawing.Size(182, 122);
            this.catamaranType.TabIndex = 1;
            this.catamaranType.TabStop = false;
            this.catamaranType.Text = "Тип основы";
            // 
            // labelCatamaran
            // 
            this.labelCatamaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCatamaran.Location = new System.Drawing.Point(36, 65);
            this.labelCatamaran.Name = "labelCatamaran";
            this.labelCatamaran.Size = new System.Drawing.Size(100, 23);
            this.labelCatamaran.TabIndex = 1;
            this.labelCatamaran.Text = "Катамаран";
            this.labelCatamaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCatamaran.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCatamaran_MouseDown);
            // 
            // labelBoat
            // 
            this.labelBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoat.Location = new System.Drawing.Point(36, 33);
            this.labelBoat.Name = "labelBoat";
            this.labelBoat.Size = new System.Drawing.Size(100, 23);
            this.labelBoat.TabIndex = 0;
            this.labelBoat.Text = "Лодка";
            this.labelBoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBoat.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragDrop);
            this.labelBoat.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragEnter);
            this.labelBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBoat_MouseDown);
            // 
            // panelBoat
            // 
            this.panelBoat.AllowDrop = true;
            this.panelBoat.Controls.Add(this.SecondaryColor_Label);
            this.panelBoat.Controls.Add(this.PrimaryColor_Label);
            this.panelBoat.Controls.Add(this.pictureBoxboat);
            this.panelBoat.Location = new System.Drawing.Point(235, 13);
            this.panelBoat.Name = "panelBoat";
            this.panelBoat.Size = new System.Drawing.Size(200, 232);
            this.panelBoat.TabIndex = 2;
            this.panelBoat.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragDrop);
            this.panelBoat.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragEnter);
            // 
            // SecondaryColor_Label
            // 
            this.SecondaryColor_Label.AllowDrop = true;
            this.SecondaryColor_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondaryColor_Label.Location = new System.Drawing.Point(39, 170);
            this.SecondaryColor_Label.Name = "SecondaryColor_Label";
            this.SecondaryColor_Label.Size = new System.Drawing.Size(122, 38);
            this.SecondaryColor_Label.TabIndex = 2;
            this.SecondaryColor_Label.Text = "Доп. цвет";
            this.SecondaryColor_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SecondaryColor_Label.DragDrop += new System.Windows.Forms.DragEventHandler(this.SecondaryColor_Label_DragDrop);
            this.SecondaryColor_Label.DragEnter += new System.Windows.Forms.DragEventHandler(this.PrimaryColor_Label_DragEnter);
            // 
            // PrimaryColor_Label
            // 
            this.PrimaryColor_Label.AllowDrop = true;
            this.PrimaryColor_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimaryColor_Label.Location = new System.Drawing.Point(39, 116);
            this.PrimaryColor_Label.Name = "PrimaryColor_Label";
            this.PrimaryColor_Label.Size = new System.Drawing.Size(122, 40);
            this.PrimaryColor_Label.TabIndex = 1;
            this.PrimaryColor_Label.Text = "Основной цвет";
            this.PrimaryColor_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrimaryColor_Label.DragDrop += new System.Windows.Forms.DragEventHandler(this.PrimaryColor_Label_DragDrop);
            this.PrimaryColor_Label.DragEnter += new System.Windows.Forms.DragEventHandler(this.PrimaryColor_Label_DragEnter);
            // 
            // groupBox_Colors
            // 
            this.groupBox_Colors.Controls.Add(this.panelOrange);
            this.groupBox_Colors.Controls.Add(this.panelYellow);
            this.groupBox_Colors.Controls.Add(this.panelBlue);
            this.groupBox_Colors.Controls.Add(this.panelWhite);
            this.groupBox_Colors.Controls.Add(this.panelGray);
            this.groupBox_Colors.Controls.Add(this.panelRed);
            this.groupBox_Colors.Controls.Add(this.panelGreen);
            this.groupBox_Colors.Controls.Add(this.panelBlack);
            this.groupBox_Colors.Location = new System.Drawing.Point(441, 13);
            this.groupBox_Colors.Name = "groupBox_Colors";
            this.groupBox_Colors.Size = new System.Drawing.Size(182, 232);
            this.groupBox_Colors.TabIndex = 3;
            this.groupBox_Colors.TabStop = false;
            this.groupBox_Colors.Text = "Цвета";
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(83, 170);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(30, 30);
            this.panelOrange.TabIndex = 4;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(83, 116);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(30, 30);
            this.panelYellow.TabIndex = 1;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(83, 70);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(30, 30);
            this.panelBlue.TabIndex = 1;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(83, 28);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(30, 30);
            this.panelWhite.TabIndex = 3;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(17, 170);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(30, 30);
            this.panelGray.TabIndex = 2;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(17, 116);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(30, 30);
            this.panelRed.TabIndex = 1;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(17, 70);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(30, 30);
            this.panelGreen.TabIndex = 1;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(17, 28);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(30, 30);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(62, 146);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(119, 190);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormCatamaranConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 270);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox_Colors);
            this.Controls.Add(this.panelBoat);
            this.Controls.Add(this.catamaranType);
            this.Name = "FormCatamaranConfig";
            this.Text = "FormCatamaranConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxboat)).EndInit();
            this.catamaranType.ResumeLayout(false);
            this.panelBoat.ResumeLayout(false);
            this.groupBox_Colors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxboat;
        private System.Windows.Forms.GroupBox catamaranType;
        private System.Windows.Forms.Label labelBoat;
        private System.Windows.Forms.Label labelCatamaran;
        private System.Windows.Forms.Panel panelBoat;
        private System.Windows.Forms.GroupBox groupBox_Colors;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Label SecondaryColor_Label;
        private System.Windows.Forms.Label PrimaryColor_Label;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}