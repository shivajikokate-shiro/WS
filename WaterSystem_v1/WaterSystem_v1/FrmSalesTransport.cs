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

namespace WaterSystem_v1
{
    public partial class FrmSalesTransport : Form
    {
        VehicleReciever vehicleReciever = null;
        TransportationReciever transportReciever = null;
        Helpers.DataHelper helper = null;
        SalesTransportModel _model = null;
        public FrmSalesTransport()
        {
            InitializeComponent();
        }

        public FrmSalesTransport(SalesTransportModel model)
        {
            InitializeComponent();
            _model = model;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillVehicleList();
        }

        private void FillVehicleList()
        {
            helper.FillCombo(cmbVehicleNumber, GetVehicles());
            cmbVehicleNumber.SelectedIndex = 0;
        }

        private void FrmSalesTransport_Load(object sender, EventArgs e)
        {
            vehicleReciever = new VehicleReciever();
            transportReciever = new TransportationReciever();
            helper = new Helpers.DataHelper();

            // Fill transportation list
            helper.FillCombo(cmbTransport, GetTransports());
            FillVehicleList();
            if (_model != null)
            {
                cmbTransport.SelectedIndex = GetTransports().Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.TransportationID.ToString()).Select(x => x.index).FirstOrDefault();
                if (_model.TVehicleNumberID > 0)
                {
                    cmbVehicleNumber.SelectedIndex = GetVehicles().Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.TVehicleNumberID.ToString()).Select(x => x.index).FirstOrDefault();
                }
                txtDriverName.Text = _model.TEmployeeName;
                txtDriverMobNumber.Text = _model.TEmployeeMobNumber;
            }
        }

        private List<DropDown> GetVehicles()
        {
            VehicleModel vehicle = new VehicleModel();
            vehicle.Transportation_ID = cmbTransport.SelectedItem != null ? Convert.ToDecimal((cmbTransport.SelectedItem as DropDown).Value) : 0;
            var vehicles = vehicleReciever.GetVehiclesByTransport(vehicle);
            var vehicleList = vehicles.Select(x => new DropDown { Name = x.Vehical_No, Value = x.ID.ToString() }).ToList();
            vehicleList.Insert(0, new DropDown() { Name = "-- Select --", Value = 0.ToString() });
            return vehicleList;
        }

        private List<DropDown> GetTransports()
        {
            var transports = transportReciever.GetList();
            var transportationList = transports.Select(x => new DropDown { Name = x.Transportation_Name, Value = x.Transportation_Id.ToString() }).ToList();
            transportationList.Insert(0, new DropDown() { Name = "-- Select --", Value = 0.ToString() });
            return transportationList;
        }

        private void Clear()
        {
            txtDriverMobNumber.Text = string.Empty;
            txtDriverName.Text = string.Empty;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_model != null)
            {
                _model.TransportationID = Convert.ToInt32((cmbTransport.SelectedItem as DropDown).Value);
                _model.TVehicleNumberID = Convert.ToInt32((cmbVehicleNumber.SelectedItem as DropDown).Value);
                _model.TVehicleNumber = (cmbVehicleNumber.SelectedItem as DropDown).Name;
                _model.TEmployeeName = txtDriverName.Text;
                _model.TEmployeeMobNumber = txtDriverMobNumber.Text;
            }
        }
    }
}
