using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PaintAppSimple
{
    public partial class FrmDrawingScreen : Form
    {
        //Flag to control Drawing Start

        #region --== Declarations and variables==--
        private bool drawingStart = false; //control start stop off drawing
        private Graphics graphicsDrawPanel;
        private float penThicknessSeted;
        private Color eraserColor;
        private Color defaultBtnColor;
        private bool eraserStart = false; //control start stop off erasing
        private Image imageToSave;
        private Graphics imageGraphicsToSave;
        #endregion

        public FrmDrawingScreen()
        {
            InitializeComponent();

            #region --==Mouse Hover color change ==--
            btnClean.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEraser.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            #endregion

            #region --=ComboBox configuration==--
            for (int i = 0; i <= 100; i += 10)
            //Loop iniciate in 0 increment 10 until 100
            {
                string value = "00";
                //Add item to combobox, adding index "i" as values to the component iniciate in 1 incremente by 10
                if (i == 0)
                {
                    //Exclude 0 of the items
                    value += ( i + 1 ).ToString();
                    cmbPenThickness.Items.Add(value);
                }
                else if (i == 100)
                {
                    value = i.ToString();
                    cmbPenThickness.Items.Add(value);
                }
                else if (i != 100 || i != 0)
                {
                    value = "0" + i.ToString();
                    cmbPenThickness.Items.Add(value);
                }

            }

            //Configure Combobox to Sorted A-Z 0-9
            cmbPenThickness.Sorted = true;
            //Sets de Max of showing items
            cmbPenThickness.MaxDropDownItems = 5;
            cmbPenThickness.IntegralHeight = false;
            //Adding individual values
            cmbPenThickness.Items.Add("002");
            cmbPenThickness.Items.Add("004");
            cmbPenThickness.Items.Add("006");
            cmbPenThickness.Items.Add("008");
            //standard value selected
            cmbPenThickness.SelectedItem = "010";
            #endregion

            #region --== Drawing Panel ==--
            graphicsDrawPanel = pnlDrawPad.CreateGraphics(); //creates the drawing over the pad
            penThicknessSeted = float.Parse(cmbPenThickness.SelectedItem.ToString());
            imageToSave = new Bitmap(pnlDrawPad.Width, pnlDrawPad.Height);
            imageGraphicsToSave = Graphics.FromImage(imageToSave);
            imageGraphicsToSave.Clear(pnlDrawPad.BackColor);
            #endregion

            #region --== Buttons consfigurations ==--
            eraserColor = pnlDrawPad.BackColor;
            defaultBtnColor = btnEraser.BackColor;
            #endregion

        }

        #region --== Buttons Events Area ==--
        private void btnPenColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorPallete = new ColorDialog(); //CollorDialog is a color selector box, this line is the instance
            var selectedColor = colorPallete.ShowDialog(); //Open color selector box on modal form, application stay blocked until dialog completes
            if (selectedColor == DialogResult.OK) //verify iff OK was selected
            {
                btnPenColor.BackColor = colorPallete.Color;
            }
        }
       
        private void btnClean_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Limpar todo conteúdo?", "Limpar tela de desenho",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                graphicsDrawPanel.Clear(Color.WhiteSmoke); //Clean all drawing pannel
                imageToSave = new Bitmap(pnlDrawPad.Width, pnlDrawPad.Height);
                imageGraphicsToSave = Graphics.FromImage(imageToSave);
                imageGraphicsToSave.Clear(pnlDrawPad.BackColor);
            }
        }
        
        private void cmbPenThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            penThicknessSeted = float.Parse(cmbPenThickness.SelectedItem.ToString());
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveDrawingDialog = new SaveFileDialog();
            saveDrawingDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg";
            saveDrawingDialog.DefaultExt = ".png";
            if (saveDrawingDialog.ShowDialog() == DialogResult.OK) 
            {
                switch (saveDrawingDialog.FilterIndex)
                {
                    case 1:
                        imageToSave.Save(saveDrawingDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imageToSave.Save(saveDrawingDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }
        #endregion

        #region --== Drawing Panel area ==--
        private void pnlDrawPad_MouseDown(object sender, MouseEventArgs e)
        {
            drawingStart = true;
        }

        private void pnlDrawPad_MouseUp(object sender, MouseEventArgs e)
        {
            drawingStart = false;
        }

        private void pnlDrawPad_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingStart)
            {
                if (!eraserStart)
                {
                    graphicsDrawPanel.DrawEllipse(
                  new Pen(btnPenColor.BackColor, penThicknessSeted),
                  new RectangleF(e.X, e.Y, penThicknessSeted, penThicknessSeted)
                  );
                    imageGraphicsToSave.DrawEllipse(
                   new Pen(btnPenColor.BackColor, penThicknessSeted),
                   new RectangleF(e.X, e.Y, penThicknessSeted, penThicknessSeted)
                   );
                }
                else
                {
                    graphicsDrawPanel.DrawRectangle(
                   new Pen(eraserColor, penThicknessSeted),
                   new Rectangle(e.X, e.Y, ( int )penThicknessSeted, ( int )penThicknessSeted)
                   );
                    imageGraphicsToSave.DrawRectangle(
                   new Pen(eraserColor, penThicknessSeted),
                   new Rectangle(e.X, e.Y, ( int )penThicknessSeted, ( int )penThicknessSeted)
                   );
                }

            }
        }

        private void btnEraser_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog eraserColorDialog = new ColorDialog();
            if (e.Button == MouseButtons.Right)
            {
                if (eraserColorDialog.ShowDialog() == DialogResult.OK)
                {
                    eraserColor = eraserColorDialog.Color; //Select the eraser color
                    btnEraser.BackColor = eraserColor;
                }
            }
            else
            {
                if (!eraserStart)
                {
                    eraserStart = true;
                    btnEraser.BackColor = eraserColor;
                }
                else
                {
                    eraserStart = false;
                    btnEraser.BackColor = defaultBtnColor;
                }


            }
        }



        #endregion

        private void pnlDrawPad_Resize(object sender, EventArgs e)
        {
            graphicsDrawPanel = pnlDrawPad.CreateGraphics();
            var tempImage = new Bitmap(pnlDrawPad.Width, pnlDrawPad.Height);
            var tempImgGraph = Graphics.FromImage(tempImage);
            tempImgGraph.Clear(pnlDrawPad.BackColor);
            tempImgGraph.DrawImage(imageToSave, 0, 0);
            imageToSave = tempImage;
            imageGraphicsToSave = tempImgGraph; 
        }
    }
}
