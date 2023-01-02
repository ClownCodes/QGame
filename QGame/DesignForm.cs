/*DesignForm.cs
 *QGame Design
 *Revision History:
 *      Dany Wang, 2022.10.28: Created
 */
using QGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QGame
{
    public enum CellImage
    {
        None,
        Wall,
        GreenBox,
        GreenDoor,
        BlueBox,
        BlueDoor,
    }
    /// <summary>
    /// game design form 
    /// </summary>
    public partial class DesignForm : Form
    {
        private Image none = null;
        private Image wall = Resources.Wall;
        private Image greenBox = Resources.GreenCube;
        private Image greenDoor = Resources.GreenDoor;
        private Image blueBox = Resources.BlueCube;
        private Image blueDoor = Resources.BlueDoor;
        internal static CellImage cell;
        internal static Image image;
        private int rows, cols;
        private List<Cell> cells = new List<Cell>();
        private int wallNum, doorNum, boxNum;
        public DesignForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            panelDesign.Controls.Clear();
            cells.Clear();
            wallNum = 0;
            doorNum = 0;
            boxNum = 0;
            bool isValidRow = int.TryParse(txtRow.Text, out int rows);
            bool isValidCol = int.TryParse(txtColumn.Text, out int cols);
            if (isValidRow && isValidCol)
            {
                this.rows = rows;
                this.cols = cols;
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for rows and columns.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int x = 10;
            int y = 10;
            int cellInterval = 51;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Cell cell = new Cell(i, j);
                    cell.Left = x;
                    cell.Top = y;
                    panelDesign.Controls.Add(cell);
                    cells.Add(cell);
                    x += cellInterval;
                }
                x = 10;
                y += cellInterval;
            }
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            image = none;
            cell = CellImage.None;
        }

        private void btnWall_Click(object sender, EventArgs e)
        {
            image = wall;
            cell = CellImage.Wall;
        }

        private void btnGreenBox_Click(object sender, EventArgs e)
        {
            image = greenBox;
            cell = CellImage.GreenBox;
        }

        private void btnGreenDoor_Click(object sender, EventArgs e)
        {
            image = greenDoor;
            cell = CellImage.GreenDoor;
        }

        private void btnBlueBox_Click(object sender, EventArgs e)
        {
            image = blueBox;
            cell = CellImage.BlueBox;
        }

        private void btnBlueDoor_Click(object sender, EventArgs e)
        {
            image = blueDoor;
            cell = CellImage.BlueDoor;
        }
        /// <summary>
        /// counts the number of walls, doors, and boxes 
        /// </summary>
        private void count()
        {
            foreach (Cell cell in cells)
            {
                switch (cell.Type)
                {
                    case CellImage.Wall:
                        wallNum++;
                        break;
                    case CellImage.GreenBox:
                        boxNum++;
                        break;
                    case CellImage.GreenDoor:
                        doorNum++;
                        break;
                    case CellImage.BlueBox:
                        boxNum++;
                        break;
                    case CellImage.BlueDoor:
                        doorNum++;
                        break;
                }
            }
        }
        /// <summary>
        /// gets and saves cells info to file
        /// </summary>
        /// <param name="cells">a list of cells created</param>
        private void save(List<Cell> cells)
        {
            StreamWriter streamWriter = new StreamWriter(dlgSave.FileName);
            streamWriter.WriteLine(rows);
            streamWriter.Write(cols);
            foreach (Cell cell in cells)
            {
                streamWriter.Write($"\n{cell.Row}\n{cell.Column}\n{(int)cell.Type}");
            }
            streamWriter.Close();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgSave = new SaveFileDialog();
            dlgSave.FileName = "Level1.qgame";
            dlgSave.Filter = "QGame Files (*.qgame)|*.qgame|Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    save(cells);
                    count();
                    MessageBox.Show($"File saved successfully:\nTotal number of walls: {wallNum}\nTotal number of doors: {doorNum}\nTotal number of boxes: {boxNum}", 
                        "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in saving file: {ex.Message}");
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
