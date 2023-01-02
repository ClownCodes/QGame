/*DesignForm.cs
 *QGame Design
 *Revision History:
 *      Dany Wang, 2022.10.28: Created
 */
using System;
using System.Windows.Forms;
using QGame.Properties;

namespace QGame
{
    /// <summary>
    /// picture box cell for autogeneration and click
    /// </summary>
    public class Cell : PictureBox
    {
        public const int CELL_INTERVAL = 51;
        public int Row { get; set; }
        public int Column { get; set; }
        public CellImage Type { get; set; }

        /// <summary>
        /// constructor for design
        /// </summary>
        /// <param name="row">the row position of the empty cell generated</param>
        /// <param name="col">the column position of the empty cell generated</param>
        public Cell(int row, int col)
        {
            Row = row;
            Column = col;
            Type = CellImage.None;
            Width = 50;
            Height = 50;
            BorderStyle = BorderStyle.FixedSingle;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Click += DesignCell_Click;
        }

        /// <summary>
        /// constructor for play
        /// </summary>
        /// <param name="row">the row of the cell in file</param>
        /// <param name="col">the column of the cell in file</param>
        /// <param name="type">the type of the cell in file</param>
        public Cell(int row, int col, int type)
        {
            Row = row;
            Column = col;
            Left = CELL_INTERVAL * col;
            Top = CELL_INTERVAL * row;
            Type = (CellImage)type;
            switch (Type)
            {
                case CellImage.Wall:
                    Image = Resources.Wall;
                    break;
                case CellImage.GreenBox:
                    Image = Resources.GreenCube;
                    break;
                case CellImage.GreenDoor:
                    Image = Resources.GreenDoor;
                    break;
                case CellImage.BlueBox:
                    Image = Resources.BlueCube;
                    break;
                case CellImage.BlueDoor:
                    Image = Resources.BlueDoor;
                    break;
                default:
                    Image = null;
                    break;
            }
            Width = 50;
            Height = 50;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Click += PlayCell_Click;
        }
        private void DesignCell_Click(object sender, EventArgs e)
        {
            Image = DesignForm.image;
            Type = DesignForm.cell;
        }
        private void PlayCell_Click(object sender, EventArgs e)
        {
            if (Type == CellImage.GreenBox || Type == CellImage.BlueBox)
            {
                if (PlayForm.selectedCell != null)
                {
                    PlayForm.selectedCell.BorderStyle = BorderStyle.None;
                }
                BorderStyle = BorderStyle.FixedSingle;
                PlayForm.selectedCell = (Cell)sender;
                PlayForm.emptyCell = new Cell(PlayForm.selectedCell.Row, PlayForm.selectedCell.Column, 0);
            }
        }
    }
}
