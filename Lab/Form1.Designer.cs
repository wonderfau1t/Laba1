namespace Lab
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.deviceBrandBox = new System.Windows.Forms.ComboBox();
            this.deviceTypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusSelectBox = new System.Windows.Forms.ComboBox();
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.calculatedSumBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Устройство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Производитель";
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(111, 110);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(137, 20);
            this.orderDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата приема";
            // 
            // deviceBrandBox
            // 
            this.deviceBrandBox.FormattingEnabled = true;
            this.deviceBrandBox.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Huawei",
            "Google",
            "Haier",
            "Xiaomi"});
            this.deviceBrandBox.Location = new System.Drawing.Point(111, 73);
            this.deviceBrandBox.Name = "deviceBrandBox";
            this.deviceBrandBox.Size = new System.Drawing.Size(139, 21);
            this.deviceBrandBox.TabIndex = 4;
            // 
            // deviceTypeBox
            // 
            this.deviceTypeBox.FormattingEnabled = true;
            this.deviceTypeBox.Items.AddRange(new object[] {
            "Смартфон",
            "Планшет",
            "Телевизор",
            "Монитор"});
            this.deviceTypeBox.Location = new System.Drawing.Point(111, 38);
            this.deviceTypeBox.Name = "deviceTypeBox";
            this.deviceTypeBox.Size = new System.Drawing.Size(139, 21);
            this.deviceTypeBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Приоритет";
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "Обычный",
            "Срочный"});
            this.priorityBox.Location = new System.Drawing.Point(111, 143);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(137, 21);
            this.priorityBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Записи";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceType,
            this.DeviceBrand,
            this.Date,
            this.Sum,
            this.Priority,
            this.Status});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.orderBindingSource, "Status", true));
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(316, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderClass.Order);
            // 
            // statusSelectBox
            // 
            this.statusSelectBox.FormattingEnabled = true;
            this.statusSelectBox.Items.AddRange(new object[] {
            "Не выполнен",
            "Выполнен"});
            this.statusSelectBox.Location = new System.Drawing.Point(316, 194);
            this.statusSelectBox.Name = "statusSelectBox";
            this.statusSelectBox.Size = new System.Drawing.Size(121, 21);
            this.statusSelectBox.TabIndex = 11;
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.Location = new System.Drawing.Point(443, 194);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(113, 21);
            this.changeStatusButton.TabIndex = 12;
            this.changeStatusButton.Text = "Изменить статус";
            this.changeStatusButton.UseVisualStyleBackColor = true;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(113, 177);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(137, 21);
            this.addOrder.TabIndex = 13;
            this.addOrder.Text = "Добавить запись";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // calculatedSumBox
            // 
            this.calculatedSumBox.Location = new System.Drawing.Point(111, 204);
            this.calculatedSumBox.Name = "calculatedSumBox";
            this.calculatedSumBox.ReadOnly = true;
            this.calculatedSumBox.Size = new System.Drawing.Size(137, 20);
            this.calculatedSumBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Рассчитанная стоимость";
            // 
            // DeviceType
            // 
            this.DeviceType.DataPropertyName = "DeviceType";
            this.DeviceType.HeaderText = "Устройство";
            this.DeviceType.Name = "DeviceType";
            this.DeviceType.ReadOnly = true;
            // 
            // DeviceBrand
            // 
            this.DeviceBrand.DataPropertyName = "DeviceBrand";
            this.DeviceBrand.HeaderText = "Производитель";
            this.DeviceBrand.Name = "DeviceBrand";
            this.DeviceBrand.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.DataPropertyName = "Sum";
            this.Sum.HeaderText = "Сумма";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Приоритет";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 258);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculatedSumBox);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.changeStatusButton);
            this.Controls.Add(this.statusSelectBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deviceTypeBox);
            this.Controls.Add(this.deviceBrandBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Учет заказов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox deviceBrandBox;
        private System.Windows.Forms.ComboBox deviceTypeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox statusSelectBox;
        private System.Windows.Forms.Button changeStatusButton;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.TextBox calculatedSumBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}

