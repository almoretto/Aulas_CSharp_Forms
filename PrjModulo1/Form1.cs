using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PrjModulo1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnButtonOne_Click(object sender, EventArgs e)
        {
            lblCopy.Text = lblNome.Text; 
            //Attributes text to label copy from label name
            lblCopy.BackColor = lblNome.BackColor; 
            //Attributes the color of the control label Name to the Copy
            lblNameOut.Text = txtName.Text;
            //Atributes the text in the Textbox to the label NameOut
            lstNames.Items.Add(txtName.Text);
            txtName.Text = string.Empty;
            txtName.Focus();
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
            if (txtName.Text.Length < 3)
                MessageBox.Show("Nome < que 3 caracteres!");
            /*If the length of the textbox is less them 3 chars an MessageBox pops up on screen
            creating an information for the user.*/
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        //The Class KeyEventArgs brings the key code pressed 
        {
            if (e.KeyCode == Keys.Enter) //Test if the "e" key is Enter
            {
                /*Calling the event Click of btnButtonOne, the constructor demands
                 * Object Sender - in this case the name of the object that have the event
                 * and the instance of EventArgs Class, just create new EventArgs()*/
                btnButtonOne_Click(btnButtonOne, new EventArgs());
            }
        }
    }
}
