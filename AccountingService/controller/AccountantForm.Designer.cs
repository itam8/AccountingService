namespace AccountingService
{
    partial class AccountantForm
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
            requestsDataGridView = new DataGridView();
            label1 = new Label();
            statusComboBox = new ComboBox();
            changeStatusButton = new Button();
            ((System.ComponentModel.ISupportInitialize)requestsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // requestsDataGridView
            // 
            requestsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestsDataGridView.Location = new Point(12, 97);
            requestsDataGridView.Name = "requestsDataGridView";
            requestsDataGridView.Size = new Size(776, 341);
            requestsDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Статус";
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Отправлено", "В процессе", "Готово" });
            statusComboBox.Location = new Point(61, 22);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(136, 23);
            statusComboBox.TabIndex = 2;
            // 
            // changeStatusButton
            // 
            changeStatusButton.Location = new Point(255, 22);
            changeStatusButton.Name = "changeStatusButton";
            changeStatusButton.Size = new Size(108, 23);
            changeStatusButton.TabIndex = 3;
            changeStatusButton.Text = "Изменить статус";
            changeStatusButton.UseVisualStyleBackColor = true;
            // 
            // AccountantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(changeStatusButton);
            Controls.Add(statusComboBox);
            Controls.Add(label1);
            Controls.Add(requestsDataGridView);
            Name = "AccountantForm";
            Text = "AccountantForm";
            ((System.ComponentModel.ISupportInitialize)requestsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView requestsDataGridView;
        private Label label1;
        private ComboBox statusComboBox;
        private Button changeStatusButton;
    }
}