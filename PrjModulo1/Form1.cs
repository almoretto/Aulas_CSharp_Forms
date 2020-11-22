using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PrjModulo1
{
    public partial class frmMain : Form
    {
        private int iSelecionado;
        public frmMain()
        {
            InitializeComponent();
            iSelecionado = -1;
        }
        private void btnButtonOne_Click(object sender, EventArgs e)
        {
            if (iSelecionado > -1)
            {
                lstNames.Items[iSelecionado] = txtName.Text;
                if (chkOrdered.Checked)
                {
                    Ordenar();
                }
                txtName.Text = string.Empty;
                iSelecionado = -1;
                btnButtonOne.Text = "Cadastrar";
                return;
            }
            lblCopy.Text = lblNome.Text;
            //Attributes text to label copy from label name
            lblCopy.BackColor = lblNome.BackColor;
            //Attributes the color of the control label Name to the Copy
            lblNameOut.Text = txtName.Text;
            //Atributes the text in the Textbox to the label NameOut
            lstNames.Items.Add(txtName.Text);
            if (chkOrdered.Checked)
            {
                Ordenar();
            }
            txtName.Text = string.Empty;
        }
        private void btnButtonTwo_Click(object sender, EventArgs e)
        {
            lblCopy.Text = string.Empty;
            //Atributes a empy string or an "" string to the text property
            lblCopy.BackColor = frmMain.DefaultBackColor;
            //Attributes the default color of main form to the label control
            lblNameOut.Text = string.Empty;
            txtName.Text = string.Empty;
            //Atributes a empy string or an "" string to the text property
        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            //Validation on key change

        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)//The Class KeyEventArgs brings the key code pressed 
        {
            if (e.KeyCode == Keys.Enter) //Test if the "e" key is Enter
            {
                if (txtName.Text.Length < 3)
                {
                    if (txtName.Text.Length == 0)
                    {
                        return;
                    }
                    MessageBox.Show("Nome < que 3 caracteres!");
                    return;
                    /*If the length of the textbox is less them 3 chars an MessageBox pops up on screen
                    creating an information for the user.*/
                }
                /*Calling the event Click of btnButtonOne, the constructor demands
                 * Object Sender - in this case the name of the object that have the event
                 * and the instance of EventArgs Class, just create new EventArgs()*/
                btnButtonOne_Click(btnButtonOne, new EventArgs());
            }
        }
        private void lstNames_DoubleClick(object sender, EventArgs e)
        {
            iSelecionado = lstNames.SelectedIndex;
            //txtName.Text = lstNames.SelectedItem.ToString();
            txtName.Text = lstNames.Items[iSelecionado].ToString();
            //Other form to do
            btnButtonOne.Text = "Editar";
        }
        private void Ordenar()
        {
            ListBox.ObjectCollection list = lstNames.Items;
            List<string> listStringNames = new List<string>();
            foreach (var item in list)
            {
                listStringNames.Add(item.ToString());
            }
            /*
             * listStringNames = (from s in listStringNames select s)
             * .OrderBy(x => x)
             * .ToList();*/
            listStringNames.Sort(); //Maneira Simples;
            lstNames.Items.Clear();
            foreach (var item in listStringNames)
            {
                lstNames.Items.Add(item);
            }
        }
        private void chkYes_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Status Alterado");
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (chkYes.Checked)
            {
                lblNome.Text = "Resposta: ";
                txtName.Text = " A Opção Foi Sim!";
            }
            else
            {
                lblNome.Text = "Resposta: ";
                txtName.Text = " A Opção Foi Não!";
            }
        }

        private void chkOrdered_CheckStateChanged(object sender, EventArgs e)
        {
            if (!chkUnOrdered.Checked && !chkOrdered.Checked)
            {
                chkUnOrdered.Checked = true;
            }
            else if (chkUnOrdered.Checked && chkOrdered.Checked)
            {
                chkUnOrdered.Checked = false;
            }
        }

        private void rbtQuestion1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtQuestion1AnsA.Checked)
            {
                MessageBox.Show("Wrong Answer!");
            }
            else if (rbtQuestion1AnsB.Checked)
            {
                MessageBox.Show("Wrong Answer!");
            }
            else if (rbtQuestion1AnsC.Checked)
            {
                MessageBox.Show("Correct!!");
            }
            else
            {
                MessageBox.Show("Select one Answer");
            }
        }

        private void rbtQuestion2AnsA_CheckedChanged(object sender, EventArgs e){
            if (rbtQuestion2AnsA.Checked && !rbtQuestion2AnsB.Checked && !rbtQuestion2AnsC.Checked){
                MessageBox.Show("Wrong Answer!");
            }
            if (!rbtQuestion2AnsA.Checked && !rbtQuestion2AnsB.Checked && !rbtQuestion2AnsC.Checked){
                MessageBox.Show("Select at least one Answer");
            } }
        private void rbtQuestion2AnsB_CheckedChanged(object sender, EventArgs e){  
           if (rbtQuestion2AnsB.Checked && !rbtQuestion2AnsA.Checked && !rbtQuestion2AnsC.Checked){
                MessageBox.Show("Wrong Answer!");
            }
            if (!rbtQuestion2AnsA.Checked && !rbtQuestion2AnsB.Checked && !rbtQuestion2AnsC.Checked){
                MessageBox.Show("Select at least one Answer");
            } }
        private void rbtQuestion2AnsC_CheckedChanged(object sender, EventArgs e){   
            if (rbtQuestion2AnsC.Checked && !rbtQuestion2AnsA.Checked && !rbtQuestion2AnsB.Checked){
                MessageBox.Show("Correct!!");
            }
            if (!rbtQuestion2AnsA.Checked && !rbtQuestion2AnsB.Checked && !rbtQuestion2AnsC.Checked){
                MessageBox.Show("Select at least one Answer");
            } }

        private void cmbStones_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbStones.SelectedItem.ToString());
        }
    }
}
