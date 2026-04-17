namespace ATAS
{
    partial class Deletecountries
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
            this.components = new System.ComponentModel.Container();
            this.deletebutton = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.deleteGridView = new System.Windows.Forms.DataGridView();
            this.сountriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deleteGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сountriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(12, 222);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 1;
            this.deletebutton.Text = "Удалить";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(279, 222);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // deleteGridView
            // 
            this.deleteGridView.AllowUserToAddRows = false;
            this.deleteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete});
            this.deleteGridView.Location = new System.Drawing.Point(12, 12);
            this.deleteGridView.Name = "deleteGridView";
            this.deleteGridView.RowHeadersVisible = false;
            this.deleteGridView.Size = new System.Drawing.Size(428, 204);
            this.deleteGridView.TabIndex = 3;
            // 
            // сountriesBindingSource
            // 
            this.сountriesBindingSource.DataMember = "Сountries";
            // 
            // delete
            // 
            this.delete.HeaderText = "isdelete";
            this.delete.Name = "delete";
            // 
            // Deletecountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(479, 257);
            this.Controls.Add(this.deleteGridView);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.deletebutton);
            this.Name = "Deletecountries";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Deletecountries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сountriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView deleteGridView;
        private DBATASDataSet dBATASDataSet;
        private System.Windows.Forms.BindingSource сountriesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delete;
    }
}