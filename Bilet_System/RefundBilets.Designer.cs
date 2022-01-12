
namespace Bilet_System
{
    partial class RefundBilets
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
            this.ComboBox_name_org = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Otmena_of_bilets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBox_name_org
            // 
            this.ComboBox_name_org.FormattingEnabled = true;
            this.ComboBox_name_org.Location = new System.Drawing.Point(180, 15);
            this.ComboBox_name_org.Name = "ComboBox_name_org";
            this.ComboBox_name_org.Size = new System.Drawing.Size(134, 21);
            this.ComboBox_name_org.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование организации";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(26, 47);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Otmena_of_bilets
            // 
            this.Otmena_of_bilets.Location = new System.Drawing.Point(180, 47);
            this.Otmena_of_bilets.Name = "Otmena_of_bilets";
            this.Otmena_of_bilets.Size = new System.Drawing.Size(134, 23);
            this.Otmena_of_bilets.TabIndex = 3;
            this.Otmena_of_bilets.Text = "Отменить все билеты";
            this.Otmena_of_bilets.UseVisualStyleBackColor = true;
            // 
            // RefundBilets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 100);
            this.Controls.Add(this.Otmena_of_bilets);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_name_org);
            this.Name = "RefundBilets";
            this.Text = "CancellationOfTheEventForm";
            this.Load += new System.EventHandler(this.RefundBilets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_name_org;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Otmena_of_bilets;
    }
}