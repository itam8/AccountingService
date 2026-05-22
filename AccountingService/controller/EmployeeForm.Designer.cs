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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            referenceTypeComboBox = new ComboBox();
            customTypeTextBox = new TextBox();
            label3 = new Label();
            copiesCountNumericUpDown = new NumericUpDown();
            label4 = new Label();
            reasonTextBox = new TextBox();
            sendRequestButton = new Button();
            label5 = new Label();
            RequestsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)copiesCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RequestsDataGridView).BeginInit();
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
            referenceTypeComboBox.FormattingEnabled = true;
            referenceTypeComboBox.Items.AddRange(new object[] { "2-НДФЛ", "О месте работы и стаже", "О среднем заработке", "Произвольного типа" });
            referenceTypeComboBox.Location = new Point(12, 57);
            referenceTypeComboBox.Name = "referenceTypeComboBox";
            referenceTypeComboBox.Size = new Size(165, 23);
            referenceTypeComboBox.TabIndex = 2;
            // 
            // customTypeTextBox
            // 
            customTypeTextBox.Location = new Point(12, 86);
            customTypeTextBox.Name = "customTypeTextBox";
            customTypeTextBox.Size = new Size(165, 23);
            customTypeTextBox.TabIndex = 3;
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
            copiesCountNumericUpDown.Name = "copiesCountNumericUpDown";
            copiesCountNumericUpDown.Size = new Size(109, 23);
            copiesCountNumericUpDown.TabIndex = 5;
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
            // RequestsDataGridView
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            RequestsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            RequestsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            RequestsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            RequestsDataGridView.Location = new Point(12, 172);
            RequestsDataGridView.Name = "RequestsDataGridView";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            RequestsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            RequestsDataGridView.Size = new Size(776, 266);
            RequestsDataGridView.TabIndex = 10;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RequestsDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)RequestsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox referenceTypeComboBox;
        private TextBox customTypeTextBox;
        private Label label3;
        private NumericUpDown copiesCountNumericUpDown;
        private Label label4;
        private TextBox reasonTextBox;
        private Button sendRequestButton;
        private Label label5;
        private DataGridView RequestsDataGridView;
    }
}