using AccountingService.config;
using AccountingService.context;
using AccountingService.model;
using AccountingService.repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountingService
{
    public partial class AccountantForm : Form
    {
        public AccountantForm()
        {
            InitializeComponent();

            LoadDataGridView();
            requestsDataGridView.Columns["Id"].Visible = false;
            requestsDataGridView.Columns["UserId"].Visible = false;

            statusComboBox.SelectedIndex = 0;
        }

        private void LoadDataGridView()
        {
            requestsDataGridView.DataSource = RequestRepository.JoinUsersAndRequests();
        }

        private void ChangeStatusButton_Click(object sender, EventArgs e)
        {
            if (requestsDataGridView.SelectedRows.Count > 0)
            {
                var newStatus = statusComboBox.Text;
                var accounantRequest = (AccounantRequest)requestsDataGridView.SelectedRows[0].DataBoundItem;

                if (newStatus != accounantRequest.Status)
                {
                    var request = new Request()
                    {
                        Id = accounantRequest.Id,
                        UserId = accounantRequest.UserId,
                        ReferenceType = accounantRequest.ReferenceType,
                        CopiesCount = accounantRequest.CopiesCount,
                        Reason = accounantRequest.Reason,
                        Status = newStatus,
                        Date = accounantRequest.Date.ToUniversalTime()
                    };
                    RequestRepository.Update(request);
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
