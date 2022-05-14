using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SimpleToPark
{
    public partial class FormSimpleToPark : Form
    {
        private DataTable SPSysDataBase; //Virtual Data Table for Database.
        public FormSimpleToPark()
        {
            InitializeComponent();
            SPSysDataBaseConfig(); //Config Method
            dtgParkingView.DataSource=SPSysDataBase; //Assign datatable to data grid as datasource

        }

        private void SPSysDataBaseConfig()
        {
            SPSysDataBase = new DataTable("NewWaySimpleParking"); //Instance with name
            SPSysDataBase.Columns.Add("Placa", typeof(string)); //add columns
            SPSysDataBase.Columns.Add("Entrada",typeof(string));

        }

        private void btnInsertRegister_Click(object sender, System.EventArgs e)
        {
            string placa = Interaction.InputBox("Digite a placa do veículo", "Entrada de veículo");
            if (!string.IsNullOrEmpty(placa)) //verifys if user clicked on cancel or ok with no information
            {
                SPSysDataBase.Rows.Add(new string[] { placa, DateTime.Now.ToString() });//imput veihicle.
            }
        }
    }
}
