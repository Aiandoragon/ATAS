namespace WindowsFormsApp1
{
    partial class RequestForm
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.dateTimePickerStartTour = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientRequestGridView = new System.Windows.Forms.DataGridView();
            this.addClient = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snpClientRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tourComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFinishTour = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.clientRequestGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(17, 412);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(6);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(262, 50);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Добавить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(557, 412);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(256, 50);
            this.cancelbutton.TabIndex = 1;
            this.cancelbutton.Text = "Отмена";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // dateTimePickerStartTour
            // 
            this.dateTimePickerStartTour.CustomFormat = "";
            this.dateTimePickerStartTour.Location = new System.Drawing.Point(277, 40);
            this.dateTimePickerStartTour.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePickerStartTour.Name = "dateTimePickerStartTour";
            this.dateTimePickerStartTour.Size = new System.Drawing.Size(269, 31);
            this.dateTimePickerStartTour.TabIndex = 5;
            this.dateTimePickerStartTour.ValueChanged += new System.EventHandler(this.dateTimePickerStartTour_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Начало тура";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(330, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Клиенты";
            // 
            // clientRequestGridView
            // 
            this.clientRequestGridView.AllowUserToAddRows = false;
            this.clientRequestGridView.AllowUserToDeleteRows = false;
            this.clientRequestGridView.AllowUserToResizeColumns = false;
            this.clientRequestGridView.AllowUserToResizeRows = false;
            this.clientRequestGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clientRequestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientRequestGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addClient,
            this.clientId,
            this.snpClientRequest,
            this.Column3});
            this.clientRequestGridView.Location = new System.Drawing.Point(12, 100);
            this.clientRequestGridView.Name = "clientRequestGridView";
            this.clientRequestGridView.RowHeadersVisible = false;
            this.clientRequestGridView.Size = new System.Drawing.Size(801, 303);
            this.clientRequestGridView.TabIndex = 10;
            // 
            // addClient
            // 
            this.addClient.HeaderText = "Добавить";
            this.addClient.Name = "addClient";
            this.addClient.Width = 114;
            // 
            // clientId
            // 
            this.clientId.HeaderText = "ID";
            this.clientId.Name = "clientId";
            this.clientId.Width = 57;
            // 
            // snpClientRequest
            // 
            this.snpClientRequest.HeaderText = "ФИО";
            this.snpClientRequest.Name = "snpClientRequest";
            this.snpClientRequest.Width = 86;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Паспорт";
            this.Column3.Name = "Column3";
            this.Column3.Width = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Тур";
            // 
            // tourComboBox
            // 
            this.tourComboBox.FormattingEnabled = true;
            this.tourComboBox.Location = new System.Drawing.Point(12, 42);
            this.tourComboBox.Name = "tourComboBox";
            this.tourComboBox.Size = new System.Drawing.Size(183, 33);
            this.tourComboBox.TabIndex = 12;
            this.tourComboBox.SelectedIndexChanged += new System.EventHandler(this.tourComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(688, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Конец тура";
            // 
            // dateTimePickerFinishTour
            // 
            this.dateTimePickerFinishTour.CustomFormat = "";
            this.dateTimePickerFinishTour.Enabled = false;
            this.dateTimePickerFinishTour.Location = new System.Drawing.Point(558, 40);
            this.dateTimePickerFinishTour.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePickerFinishTour.Name = "dateTimePickerFinishTour";
            this.dateTimePickerFinishTour.Size = new System.Drawing.Size(255, 31);
            this.dateTimePickerFinishTour.TabIndex = 6;
            // 
            // AddRowRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 477);
            this.Controls.Add(this.tourComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientRequestGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFinishTour);
            this.Controls.Add(this.dateTimePickerStartTour);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.acceptButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddRowRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать Заявку";
            this.Load += new System.EventHandler(this.addRowRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientRequestGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView clientRequestGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn snpClientRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tourComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinishTour;
    }
}