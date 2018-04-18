using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_Model;
using WaterSystem_Manager.Receiver;
using WaterSystem_v1.Helpers;
using WaterSystem_v1.Logs;

namespace WaterSystem_v1
{
    public partial class FrmInvoiceApprove : Form
    {
        int _tab = 0;
        InvoiceApproveReciever _reciever = null;
        public FrmInvoiceApprove()
        {
            InitializeComponent();
        }

        public FrmInvoiceApprove(int tabIndex)
        {
            _tab = tabIndex;
            InitializeComponent();
        }

        private void FrmInvoiceApprove_Load(object sender, EventArgs e)
        {
            Configuration();
            if (_reciever == null)
            {
                _reciever = new InvoiceApproveReciever();
            }
            var approveList =  LoadPendingApprove();
            if (approveList != null && approveList.Any())
            {
                RefreshList(approveList);
            }
        }

        private void Configuration()
        {
            ovlApproval.RowHeight = 25;
            ovlApproval.EmptyListMsg = "Please start with approve.";
            ovlApproval.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlApproval.ShowGroups = false;
            ovlApproval.CheckBoxes = true;
            FillOLV();
        }

        private void RefreshList(IEnumerable<InvoiceApproveDetailsModel> pendings)
        {
            ovlApproval.SetObjects(pendings);
        }

        public void SetTab(int tabIndex)
        {
            try
            {
                _tab = tabIndex;
                var approveList = LoadPendingApprove();
                RefreshList(approveList);
            }
            catch (Exception ex)
            {
                Logger.Error("Error in invoice approve set tab.", ex);
            }
        }

        private void FillOLV()
        {
            try
            {
                DataHelper helper = new DataHelper();
                ovlApproval.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo { ColumnSize = 80, Header = helper.GetMemberName((InvoiceApproveDetailsModel c) => c.Invoice_Number), Visible = true });
                list.Add(new ListViewColumnsInfo { ColumnSize = 200, Header = helper.GetMemberName((InvoiceApproveDetailsModel c) => c.Comp_Name), Visible = true });
                list.Add(new ListViewColumnsInfo { ColumnSize = 150, Header = helper.GetMemberName((InvoiceApproveDetailsModel c) => c.Paid), Visible = true });
                list.Add(new ListViewColumnsInfo { ColumnSize = 150, Header = helper.GetMemberName((InvoiceApproveDetailsModel c) => c.Grand_Total), Visible = true });
                list.Add(new ListViewColumnsInfo { ColumnSize = 50, Header = helper.GetMemberName((InvoiceApproveDetailsModel c) => c.Type), Visible = true });
                list.Add(new ListViewColumnsInfo { ColumnSize = 150, Header = helper.GetMemberName((InvoiceApproveDetailsModel c) => c.Tran_Date), Visible = true });
                helper.GenerateListView(ovlApproval, list);
                this.ovlApproval.ItemChecked += delegate (object sender, ItemCheckedEventArgs args)
                {
                    HandleSelectButtonText();
                };
            }
            catch (Exception ex)
            {
                Logs.Logger.Error("Error in configuration: ", ex);
            }
        }

        IEnumerable<InvoiceApproveDetailsModel> LoadPendingApprove()
        {
            if (_reciever == null)
            {
                _reciever = new InvoiceApproveReciever();
            }
            IEnumerable<InvoiceApproveDetailsModel> approveList = null;
            switch (_tab)
            {
                case 0:
                    approveList = _reciever.GetSalesApproveList();
                    break;
                case 1:
                    approveList = _reciever.GetPurchaseApproveList();
                    break;
                case 2:
                    approveList = _reciever.GetExpensesApproveList();
                    break;
            }
            return approveList;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (ovlApproval.Objects != null)
            {
                if (btnSelectAll.Text == "Unselect All")
                {
                    ovlApproval.UncheckObjects(ovlApproval.Objects);
                }
                else
                {
                    ovlApproval.CheckObjects(ovlApproval.Objects);
                }
            }
            HandleSelectButtonText();
        }

        private void HandleSelectButtonText()
        {
            if (ovlApproval.CheckedObjects.Count == ovlApproval.Items.Count)
            {
                btnSelectAll.Text = "Unselect All";
            }
            else
            {
                btnSelectAll.Text = "Select All";
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in ovlApproval.CheckedObjects)
                {
                   var approveItem = item as InvoiceApproveDetailsModel;

                    switch (_tab)
                    {
                        case ApproveTabs.Sales:
                            _reciever.ApproveSales(approveItem);
                            break;
                        case ApproveTabs.Purchase:
                            _reciever.ApprovePurchase(approveItem);
                            break;
                        case ApproveTabs.Expenses:
                            _reciever.ApproveExpenses(approveItem);
                            break;
                    }
                }
                SetTab(_tab);
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Error in approve invoice. Inner exception: {0}", ex.InnerException != null ? ex.InnerException.Message : string.Empty), ex);
            }
        }
    }
}
