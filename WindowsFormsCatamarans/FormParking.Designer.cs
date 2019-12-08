namespace WindowsFormsCatamarans
{
    partial class FormParking
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
            this.groupBoxTakeoff = new System.Windows.Forms.GroupBox();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.buttonTakeoff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.listBoxlevels = new System.Windows.Forms.ListBox();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.groupBoxTakeoff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTakeoff
            // 
            this.groupBoxTakeoff.Controls.Add(this.pictureBoxTake);
            this.groupBoxTakeoff.Controls.Add(this.buttonTakeoff);
            this.groupBoxTakeoff.Controls.Add(this.label1);
            this.groupBoxTakeoff.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeoff.Location = new System.Drawing.Point(912, 288);
            this.groupBoxTakeoff.Name = "groupBoxTakeoff";
            this.groupBoxTakeoff.Size = new System.Drawing.Size(110, 211);
            this.groupBoxTakeoff.TabIndex = 3;
            this.groupBoxTakeoff.TabStop = false;
            this.groupBoxTakeoff.Text = "Забрать лодку";
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(0, 120);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(98, 74);
            this.pictureBoxTake.TabIndex = 4;
            this.pictureBoxTake.TabStop = false;
            // 
            // buttonTakeoff
            // 
            this.buttonTakeoff.Location = new System.Drawing.Point(11, 74);
            this.buttonTakeoff.Name = "buttonTakeoff";
            this.buttonTakeoff.Size = new System.Drawing.Size(87, 23);
            this.buttonTakeoff.TabIndex = 3;
            this.buttonTakeoff.Text = "Забрать";
            this.buttonTakeoff.UseVisualStyleBackColor = true;
            this.buttonTakeoff.Click += new System.EventHandler(this.buttonTakeoff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Место:";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(54, 39);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(44, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(889, 506);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // listBoxlevels
            // 
            this.listBoxlevels.FormattingEnabled = true;
            this.listBoxlevels.Location = new System.Drawing.Point(912, 12);
            this.listBoxlevels.Name = "listBoxlevels";
            this.listBoxlevels.Size = new System.Drawing.Size(110, 108);
            this.listBoxlevels.TabIndex = 4;
            this.listBoxlevels.SelectedIndexChanged += new System.EventHandler(this.listBoxlevels_SelectedIndexChanged);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(912, 160);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(110, 60);
            this.buttonRequest.TabIndex = 5;
            this.buttonRequest.Text = "Заказать";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 511);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.listBoxlevels);
            this.Controls.Add(this.groupBoxTakeoff);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            this.groupBoxTakeoff.ResumeLayout(false);
            this.groupBoxTakeoff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxTakeoff;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button buttonTakeoff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.ListBox listBoxlevels;
        private System.Windows.Forms.Button buttonRequest;
    }
}