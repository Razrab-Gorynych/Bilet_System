
namespace Bilet_System
{
    partial class BiletsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bilet_SystemDataSet = new Bilet_System.Bilet_SystemDataSet();
            this.biletSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.event_CardTableAdapter = new Bilet_System.Bilet_SystemDataSetTableAdapters.Event_CardTableAdapter();
            this.categoryBiletsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicBiletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBiletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBiletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBiletsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.more = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilet_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryBiletsDataGridViewTextBoxColumn,
            this.topicBiletDataGridViewTextBoxColumn,
            this.addressBiletDataGridViewTextBoxColumn,
            this.dateBiletDataGridViewTextBoxColumn,
            this.priceBiletsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventCardBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 425);
            this.dataGridView1.TabIndex = 4;
            // 
            // bilet_SystemDataSet
            // 
            this.bilet_SystemDataSet.DataSetName = "Bilet_SystemDataSet";
            this.bilet_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletSystemDataSetBindingSource
            // 
            this.biletSystemDataSetBindingSource.DataSource = this.bilet_SystemDataSet;
            this.biletSystemDataSetBindingSource.Position = 0;
            // 
            // eventCardBindingSource
            // 
            this.eventCardBindingSource.DataMember = "Event_Card";
            this.eventCardBindingSource.DataSource = this.biletSystemDataSetBindingSource;
            // 
            // event_CardTableAdapter
            // 
            this.event_CardTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBiletsDataGridViewTextBoxColumn
            // 
            this.categoryBiletsDataGridViewTextBoxColumn.DataPropertyName = "Category_Bilets";
            this.categoryBiletsDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryBiletsDataGridViewTextBoxColumn.Name = "categoryBiletsDataGridViewTextBoxColumn";
            // 
            // topicBiletDataGridViewTextBoxColumn
            // 
            this.topicBiletDataGridViewTextBoxColumn.DataPropertyName = "Topic_Bilet";
            this.topicBiletDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.topicBiletDataGridViewTextBoxColumn.Name = "topicBiletDataGridViewTextBoxColumn";
            // 
            // addressBiletDataGridViewTextBoxColumn
            // 
            this.addressBiletDataGridViewTextBoxColumn.DataPropertyName = "Address_Bilet";
            this.addressBiletDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressBiletDataGridViewTextBoxColumn.Name = "addressBiletDataGridViewTextBoxColumn";
            // 
            // dateBiletDataGridViewTextBoxColumn
            // 
            this.dateBiletDataGridViewTextBoxColumn.DataPropertyName = "Date_Bilet";
            this.dateBiletDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateBiletDataGridViewTextBoxColumn.Name = "dateBiletDataGridViewTextBoxColumn";
            // 
            // priceBiletsDataGridViewTextBoxColumn
            // 
            this.priceBiletsDataGridViewTextBoxColumn.DataPropertyName = "Price_Bilets";
            this.priceBiletsDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceBiletsDataGridViewTextBoxColumn.Name = "priceBiletsDataGridViewTextBoxColumn";
            // 
            // more
            // 
            this.more.Location = new System.Drawing.Point(489, 443);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(75, 23);
            this.more.TabIndex = 5;
            this.more.Text = "Подробнее";
            this.more.UseVisualStyleBackColor = true;
            this.more.Click += new System.EventHandler(this.more_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 443);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // BiletsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 477);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.more);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BiletsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilet_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventCardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource biletSystemDataSetBindingSource;
        private Bilet_SystemDataSet bilet_SystemDataSet;
        private System.Windows.Forms.BindingSource eventCardBindingSource;
        private Bilet_SystemDataSetTableAdapters.Event_CardTableAdapter event_CardTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryBiletsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicBiletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressBiletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBiletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBiletsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button more;
        private System.Windows.Forms.Button exit;
    }
}

