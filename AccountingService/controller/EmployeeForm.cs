using AccountingService.context;
using AccountingService.helper;
using AccountingService.model;
using AccountingService.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountingService
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();

            LoadDataGridView();
            requestsDataGridView.Columns["Id"].Visible = false;
            requestsDataGridView.Columns["UserId"].Visible = false;
            requestsDataGridView.Columns["User"].Visible = false;

            referenceTypeComboBox.SelectedIndex = 0;
        }

        private void LoadDataGridView()
        {
            requestsDataGridView.DataSource = RequestRepository.FindAllByUser(ControllerContext.User);
        }

        private void ReferenceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (referenceTypeComboBox.SelectedItem.ToString() == "Произвольного типа")
                customTypeTextBox.Enabled = true;
            else
                customTypeTextBox.Enabled = false;
        }

        private void SendRequestButton_Click(object sender, EventArgs e)
        {
            if (reasonTextBox.Text == "" || customTypeTextBox.Enabled && customTypeTextBox.Text == "")
                MessageDisplayHelper.ShowMessage(errorLabel, "Все поля должны быть заполнены");
            else
            {
                MessageDisplayHelper.HideMessage(errorLabel);

                var user = ControllerContext.User;
                var request = new Request()
                {
                    UserId = user.Id,
                    ReferenceType = customTypeTextBox.Enabled ? customTypeTextBox.Text : referenceTypeComboBox.Text,
                    CopiesCount = (int)copiesCountNumericUpDown.Value,
                    Reason = reasonTextBox.Text,
                    Status = Status.SENT
                };
                RequestRepository.Create(request);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
