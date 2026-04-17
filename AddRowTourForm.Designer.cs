namespace ATAS
{
    partial class AddRowTourForm
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
            this.nameTourTextBox = new System.Windows.Forms.TextBox();
            this.countDayTextBox = new System.Windows.Forms.TextBox();
            this.transportComboBox = new System.Windows.Forms.ComboBox();
            this.descriptonTourTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvHotel = new System.Windows.Forms.DataGridView();
            this.add_hotel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hotel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotel_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTourTextBox
            // 
            this.nameTourTextBox.Location = new System.Drawing.Point(192, 15);
            this.nameTourTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTourTextBox.Name = "nameTourTextBox";
            this.nameTourTextBox.Size = new System.Drawing.Size(212, 31);
            this.nameTourTextBox.TabIndex = 0;
            // 
            // countDayTextBox
            // 
            this.countDayTextBox.Location = new System.Drawing.Point(192, 100);
            this.countDayTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.countDayTextBox.Name = "countDayTextBox";
            this.countDayTextBox.Size = new System.Drawing.Size(51, 31);
            this.countDayTextBox.TabIndex = 2;
            // 
            // transportComboBox
            // 
            this.transportComboBox.FormattingEnabled = true;
            this.transportComboBox.Location = new System.Drawing.Point(192, 58);
            this.transportComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.transportComboBox.Name = "transportComboBox";
            this.transportComboBox.Size = new System.Drawing.Size(212, 33);
            this.transportComboBox.TabIndex = 3;
            this.transportComboBox.SelectedIndexChanged += new System.EventHandler(this.transportComboBox_SelectedIndexChanged);
            // 
            // descriptonTourTextBox
            // 
            this.descriptonTourTextBox.Location = new System.Drawing.Point(416, 46);
            this.descriptonTourTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.descriptonTourTextBox.Multiline = true;
            this.descriptonTourTextBox.Name = "descriptonTourTextBox";
            this.descriptonTourTextBox.Size = new System.Drawing.Size(435, 334);
            this.descriptonTourTextBox.TabIndex = 4;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(254, 407);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(6);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(150, 44);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Создать";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(701, 407);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вид транспорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Кол-во дней";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отели";
            // 
            // dgvHotel
            // 
            this.dgvHotel.AllowUserToAddRows = false;
            this.dgvHotel.AllowUserToDeleteRows = false;
            this.dgvHotel.AllowUserToResizeColumns = false;
            this.dgvHotel.AllowUserToResizeRows = false;
            this.dgvHotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.add_hotel,
            this.hotel_id,
            this.hotel_name});
            this.dgvHotel.Location = new System.Drawing.Point(192, 142);
            this.dgvHotel.Name = "dgvHotel";
            this.dgvHotel.RowHeadersVisible = false;
            this.dgvHotel.Size = new System.Drawing.Size(212, 238);
            this.dgvHotel.TabIndex = 12;
            // 
            // add_hotel
            // 
            this.add_hotel.HeaderText = "";
            this.add_hotel.Name = "add_hotel";
            this.add_hotel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.add_hotel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.add_hotel.Width = 19;
            // 
            // hotel_id
            // 
            this.hotel_id.HeaderText = "ID";
            this.hotel_id.Name = "hotel_id";
            this.hotel_id.Visible = false;
            this.hotel_id.Width = 57;
            // 
            // hotel_name
            // 
            this.hotel_name.HeaderText = "Название отеля";
            this.hotel_name.Name = "hotel_name";
            this.hotel_name.Width = 179;
            // 
            // AddRowTourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 466);
            this.Controls.Add(this.dgvHotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.descriptonTourTextBox);
            this.Controls.Add(this.transportComboBox);
            this.Controls.Add(this.countDayTextBox);
            this.Controls.Add(this.nameTourTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddRowTourForm";
            this.Text = "Создать тур";
            this.Load += new System.EventHandler(this.AddRowTourForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTourTextBox;
        private System.Windows.Forms.TextBox countDayTextBox;
        private System.Windows.Forms.ComboBox transportComboBox;
        private System.Windows.Forms.TextBox descriptonTourTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHotel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn add_hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotel_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotel_name;
    }
}