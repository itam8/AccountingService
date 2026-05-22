namespace AccountingService
{
    partial class EmployeeForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            referenceTypeComboBox = new ComboBox();
            label3 = new Label();
            copiesCountNumericUpDown = new NumericUpDown();
            label4 = new Label();
            reasonTextBox = new TextBox();
            sendRequestButton = new Button();
            label5 = new Label();
            requestsDataGridView = new DataGridView();
            customTypeTextBox = new TextBox();
            errorLabel = new Label();
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)copiesCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requestsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(323, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 0;
            label1.Text = "Создание запроса";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Тип справки";
            // 
            // referenceTypeComboBox
            // 
            referenceTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            referenceTypeComboBox.FormattingEnabled = true;
            referenceTypeComboBox.Items.AddRange(new object[] { "2-НДФЛ", "О месте работы и стаже", "О среднем заработке", "Произвольного типа" });
            referenceTypeComboBox.Location = new Point(12, 57);
            referenceTypeComboBox.Name = "referenceTypeComboBox";
            referenceTypeComboBox.Size = new Size(165, 23);
            referenceTypeComboBox.TabIndex = 2;
            referenceTypeComboBox.SelectedIndexChanged += ReferenceTypeComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 39);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 4;
            label3.Text = "Количество копий";
            // 
            // copiesCountNumericUpDown
            // 
            copiesCountNumericUpDown.Location = new Point(199, 58);
            copiesCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            copiesCountNumericUpDown.Name = "copiesCountNumericUpDown";
            copiesCountNumericUpDown.ReadOnly = true;
            copiesCountNumericUpDown.Size = new Size(109, 23);
            copiesCountNumericUpDown.TabIndex = 5;
            copiesCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 39);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Причина";
            // 
            // reasonTextBox
            // 
            reasonTextBox.Location = new Point(335, 58);
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(318, 23);
            reasonTextBox.TabIndex = 7;
            // 
            // sendRequestButton
            // 
            sendRequestButton.Location = new Point(672, 58);
            sendRequestButton.Name = "sendRequestButton";
            sendRequestButton.Size = new Size(116, 23);
            sendRequestButton.TabIndex = 8;
            sendRequestButton.Text = "Отправить запрос";
            sendRequestButton.UseVisualStyleBackColor = true;
            sendRequestButton.Click += SendRequestButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(359, 148);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 9;
            label5.Text = "Запросы";
            // 
            // requestsDataGridView
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            requestsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            requestsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            requestsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            requestsDataGridView.Location = new Point(12, 172);
            requestsDataGridView.Name = "requestsDataGridView";
            requestsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            requestsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            requestsDataGridView.Size = new Size(776, 266);
            requestsDataGridView.TabIndex = 10;
            // 
            // customTypeTextBox
            // 
            customTypeTextBox.Enabled = false;
            customTypeTextBox.Location = new Point(12, 86);
            customTypeTextBox.Name = "customTypeTextBox";
            customTypeTextBox.Size = new Size(165, 23);
            customTypeTextBox.TabIndex = 3;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(297, 94);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 11;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(12, 143);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 12;
            refreshButton.Text = "Обновить";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += RefreshButton_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(refreshButton);
            Controls.Add(errorLabel);
            Controls.Add(requestsDataGridView);
            Controls.Add(label5);
            Controls.Add(sendRequestButton);
            Controls.Add(reasonTextBox);
            Controls.Add(label4);
            Controls.Add(copiesCountNumericUpDown);
            Controls.Add(label3);
            Controls.Add(customTypeTextBox);
            Controls.Add(referenceTypeComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)copiesCountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)requestsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox referenceTypeComboBox;
        private Label label3;
        private NumericUpDown copiesCountNumericUpDown;
        private Label label4;
        private TextBox reasonTextBox;
        private Button sendRequestButton;
        private Label label5;
        private DataGridView requestsDataGridView;
        private TextBox customTypeTextBox;
        private Label errorLabel;
        private Button refreshButton;
    }
}