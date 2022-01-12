
namespace Bilet_System
{
    partial class EventCardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Name_Organizacii = new System.Windows.Forms.TextBox();
            this.Topic = new System.Windows.Forms.TextBox();
            this.Amount_bilets = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Place = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Kategori_Bilets = new System.Windows.Forms.ComboBox();
            this.bilet_SystemDataSet = new Bilet_System.Bilet_SystemDataSet();
            this.event_CardTableAdapter1 = new Bilet_System.Bilet_SystemDataSetTableAdapters.Event_CardTableAdapter();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bilet_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название организации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория билетов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество билетов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тема мероприятия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес проведения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Место";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Время";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Цена";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(15, 305);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(96, 305);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 10;
            this.Update.Text = "Изменить";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(177, 305);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 11;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Name_Organizacii
            // 
            this.Name_Organizacii.Location = new System.Drawing.Point(147, 7);
            this.Name_Organizacii.Name = "Name_Organizacii";
            this.Name_Organizacii.Size = new System.Drawing.Size(236, 20);
            this.Name_Organizacii.TabIndex = 12;
            // 
            // Topic
            // 
            this.Topic.Location = new System.Drawing.Point(147, 67);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(167, 20);
            this.Topic.TabIndex = 14;
            // 
            // Amount_bilets
            // 
            this.Amount_bilets.Location = new System.Drawing.Point(147, 97);
            this.Amount_bilets.Name = "Amount_bilets";
            this.Amount_bilets.Size = new System.Drawing.Size(100, 20);
            this.Amount_bilets.TabIndex = 15;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(147, 127);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(236, 20);
            this.Address.TabIndex = 16;
            // 
            // Place
            // 
            this.Place.Location = new System.Drawing.Point(147, 157);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(100, 20);
            this.Place.TabIndex = 17;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(147, 187);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(100, 20);
            this.Date.TabIndex = 18;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(147, 217);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(100, 20);
            this.Time.TabIndex = 19;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(147, 250);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 20;
            // 
            // Kategori_Bilets
            // 
            this.Kategori_Bilets.FormattingEnabled = true;
            this.Kategori_Bilets.Location = new System.Drawing.Point(147, 37);
            this.Kategori_Bilets.Name = "Kategori_Bilets";
            this.Kategori_Bilets.Size = new System.Drawing.Size(167, 21);
            this.Kategori_Bilets.TabIndex = 21;
            // 
            // bilet_SystemDataSet
            // 
            this.bilet_SystemDataSet.DataSetName = "Bilet_SystemDataSet";
            this.bilet_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // event_CardTableAdapter1
            // 
            this.event_CardTableAdapter1.ClearBeforeFill = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(258, 305);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 22;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // EventCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 348);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Kategori_Bilets);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Amount_bilets);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.Name_Organizacii);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EventCardForm";
            this.Text = "EventCardForm";
            this.Load += new System.EventHandler(this.EventCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bilet_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Name_Organizacii;
        private System.Windows.Forms.TextBox Topic;
        private System.Windows.Forms.TextBox Amount_bilets;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Place;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.ComboBox Kategori_Bilets;
        private Bilet_SystemDataSetTableAdapters.Event_CardTableAdapter event_CardTableAdapter1;
        private Bilet_SystemDataSet bilet_SystemDataSet;
        private System.Windows.Forms.Button exit;
    }
}