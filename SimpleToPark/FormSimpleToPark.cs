using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static SimpleToPark.Gerenciador;

namespace SimpleToPark
{
    public partial class FormSimpleToPark : Form
    {
        private DataTable SPSysDataBase; //Virtual Data Table for Database.
        private Gerenciador gerenciador;
        public FormSimpleToPark()
        {
            InitializeComponent();
            SPSysDataBaseConfig(); //Config Method
            dtgParkingView.DataSource = SPSysDataBase; //Assign datatable to data grid as datasource
            gerenciador = new Gerenciador// Inicializamos o gerenciador
            {
                ValorHora = 10,
                Arrecadado = 0
            };
            lblHourValue.Text = $"Valor da hora: R$ {gerenciador.ValorHora.ToString("0.00")}";
        }

        private void SPSysDataBaseConfig()
        {
            SPSysDataBase = new DataTable("NewWaySimpleParking"); //Instance with name
            SPSysDataBase.Columns.Add("Placa", typeof(string)); //add columns
            SPSysDataBase.Columns.Add("Entrada", typeof(string));

        }

        private void btnInsertRegister_Click(object sender, System.EventArgs e)
        {
            string placa = Interaction.InputBox("Digite a placa do veículo", "Entrada de veículo");
            if (!string.IsNullOrEmpty(placa)) //verifys if user clicked on cancel or ok with no information
            {
                SPSysDataBase.Rows.Add(new string[] { placa, DateTime.Now.ToString() });//imput veihicle.
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

            var valorDaHora = Interaction.InputBox("Digite o valor da hora:", "Valor da hora");
            if (!string.IsNullOrEmpty(valorDaHora))
            {
                gerenciador.ValorHora = float.Parse(valorDaHora);
                lblHourValue.Text = $"Valor da hora: R$ {gerenciador.ValorHora.ToString("0.00")}";
            }
        }

        private void dtgParkingView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1) // Verifica se clicou na linha da coluna de placas (ColumnIndex = 0) e em uma linha válida
            {
                // Recupera a hora de entrada e a placa do veículo
                var entrada = DateTime.Parse(SPSysDataBase.Rows[e.RowIndex].ItemArray[1].ToString()); // Recupera a data/hora de entrada
                var placa = SPSysDataBase.Rows[e.RowIndex].ItemArray[0].ToString(); // Recupera a placa do veículo

                var arrecadado = gerenciador.CalcularEstadiaCliente(entrada); // Calcula o valor que o cliente deverá pagar

                // Exibe mensagem
                if (MessageBox
                    .Show(this, $"Deseja encerrar o ticket de {placa}? Valor: R$ {arrecadado.ToString("0.00")}", "Encerrar Ticket", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // Remove do banco de dados
                    SPSysDataBase.Rows.RemoveAt(e.RowIndex);
                    // Arrecada o valor
                    gerenciador.Arrecadado = arrecadado;
                    // Atualiza o valor na tela
                    lblTotalValue.Text = $"Total Arrecadado: R$ {gerenciador.Arrecadado.ToString("0.00")}";
                }
            }
        }
    }
}

