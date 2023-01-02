/*PlayForm.cs
 *QGame Play
 *Revision History:
 *      Dany Wang, 2022.11.07: Created
 *      Dany Wang, 2022.11.16: Finished
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
//using System.Reflection;

namespace QGame
{
    /// <summary>
    /// play game form
    /// </summary>
    public partial class PlayForm : Form
    {
        private List<int> fileInts = new List<int>();
        private int moves, boxes;
        internal static Cell selectedCell, emptyCell;
        private bool isMoving = true;
        private EventArgs eventArgsargs;
        public PlayForm()
        {
            InitializeComponent();
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            eventArgsargs = e;
            List<Cell> cellQuery = panelPlay.Controls.OfType<Cell>().ToList();
            for (int i = 0; i < cellQuery.Count; i++)
            {
                panelPlay.Controls.Remove(cellQuery[i]);
            }
            txtMoves.Text = "0";
            txtBoxes.Text = "0";
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPlay.Controls.Clear();
            fileInts.Clear();
            moves = 0;
            boxes = 0;
            dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "QGame Files (*.qgame)|*.qgame|Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(dlgOpen.FileName))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            fileInts.Add(int.Parse(streamReader.ReadLine()));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in reading the file: {ex.Message}");
                }
            }
            //number sequence
            int cellNums = (fileInts.Count - 2) / 3;
            for (int i = 0; i < cellNums; i++)
            {
                Cell cell = new Cell(fileInts[2 + 3 * i], fileInts[3 + 3 * i], fileInts[4 + 3 * i]);
                panelPlay.Controls.Add(cell);
                if (fileInts[4 + 3 * i] == 2 || fileInts[4 + 3 * i] == 4)
                {
                    boxes++;
                }
            }
            txtMoves.Text = moves.ToString();
            txtBoxes.Text = boxes.ToString();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// helper method called in delegate Navigation() methods that removes the box at the matching door and resets the form when game ends or moves the box to the next empty cell 
        /// </summary>
        /// <param name="nextCell">defined in delegate Navigation() methods</param>
        /// <param name="moveBox">delegate method</param>
        /// <returns>true if the box can move to the next cell; false if the next cell is a matching door or the box is blocked</returns>
        private bool RemoveOrMoveBox(Cell nextCell, MoveBox moveBox)
        {
            //Cell nextCell = cellQuery.First<Cell>();
            if (nextCell.Type == CellImage.GreenDoor && selectedCell.Type == CellImage.GreenBox
            || nextCell.Type == CellImage.BlueDoor && selectedCell.Type == CellImage.BlueBox)
            {
                panelPlay.Controls.Remove(selectedCell);
                boxes--;
                txtBoxes.Text = boxes.ToString();
                if (boxes == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Congratulations! \n Game Ends.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.OK)
                    {
                        PlayForm_Load(this, eventArgsargs);
                    }
                }
                return false;
            }
            else if(nextCell.Type == CellImage.None)
            {
                moveBox();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// moves selected box to selected direction
        /// </summary>
        private delegate void MoveBox();
        /// <summary>
        /// defines the next cell in the selected box's moving direction
        /// </summary>
        private delegate void Navigation();
        private void MoveLeft()
        {
            //PropertyInfo position = typeof(Cell).GetProperty(cellProp);
            //int movedPosition = (int)position.GetValue(selectedCell) - 1;
            //position.SetValue(selectedCell, movedPosition);
            selectedCell.Column--;
            selectedCell.Left = Cell.CELL_INTERVAL * selectedCell.Column;
            selectedCell.BringToFront();    //?
        }
        private void NavLeft()
        {
            for (int i = selectedCell.Column - 1; i >= 0; i--)
            {
                //IEnumerable<Cell> cellQuery =
                //from cell in panelPlay.Controls.OfType<Cell>().ToList()
                //where cell.Column == i && cell.Row == selectedCell.Row
                //select cell;
                Cell nextCell = panelPlay.Controls.OfType<Cell>().ToList().Find(c => c.Column == i && c.Row == selectedCell.Row);
                MoveBox moveLeft = new MoveBox(MoveLeft); 
                isMoving = RemoveOrMoveBox(nextCell, moveLeft);
                if (!isMoving)
                {
                    return;
                }
            }
        }

        private void MoveUp()
        {
            selectedCell.Row--;
            selectedCell.Top = Cell.CELL_INTERVAL * selectedCell.Row;
            selectedCell.BringToFront();
        }
        private void NavUp()
        {
            for (int i = selectedCell.Row - 1; i >= 0; i--)
            {
                Cell nextCell = panelPlay.Controls.OfType<Cell>().ToList().Find(c => c.Row == i && c.Column == selectedCell.Column);
                MoveBox moveUp = new MoveBox(MoveUp);
                isMoving = RemoveOrMoveBox(nextCell, moveUp);
                if (!isMoving)
                {
                    return;
                }
            }
        }

        private void MoveRight()
        {
            selectedCell.Column++;
            selectedCell.Left = Cell.CELL_INTERVAL * selectedCell.Column;
            selectedCell.BringToFront();
        }
        private void NavRight()
        {
            for (int i = selectedCell.Column + 1; i < fileInts[1]; i++)
            {
                Cell nextCell = panelPlay.Controls.OfType<Cell>().ToList().Find(c => c.Column == i && c.Row == selectedCell.Row);
                MoveBox moveRight = new MoveBox(MoveRight);
                isMoving = RemoveOrMoveBox(nextCell, moveRight);
                if (!isMoving)
                {
                    return;
                }
            }
        }

        private void MoveDown()
        {
            selectedCell.Row++;
            selectedCell.Top = Cell.CELL_INTERVAL * selectedCell.Row;
            selectedCell.BringToFront();
        }
        private void NavDown()
        {
            for (int i = selectedCell.Row + 1; i < fileInts[0]; i++)
            {
                Cell nextCell = panelPlay.Controls.OfType<Cell>().ToList().Find(c => c.Row == i && c.Column == selectedCell.Column);
                MoveBox moveDown = new MoveBox(MoveDown);
                isMoving = RemoveOrMoveBox(nextCell, moveDown);
                if (!isMoving)
                {
                    return;
                }
            }
        }
        /// <summary>
        /// moves the selected box and replaced the original cell (null after box moving) with an empty cell; otherwise, prompts user to select a box
        /// </summary>
        /// <param name="navigation"></param>
        private void SelectBoxPromptOrAddMoves(Navigation navigation)
        {
            isMoving= true;
            bool selected = false;
            foreach (Cell cell in panelPlay.Controls)
            {
                if (cell.BorderStyle == BorderStyle.FixedSingle)
                {
                    selected = true;
                    selectedCell = cell;
                }
            }
            if (selected)
            {
                panelPlay.Controls.Add(emptyCell);
                emptyCell.SendToBack();
                moves++;
                txtMoves.Text = moves.ToString();
                navigation();
            }
            else
            {
                MessageBox.Show("Click a box to select.", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            Navigation left = new Navigation(NavLeft);
            SelectBoxPromptOrAddMoves(left);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Navigation up = new Navigation(NavUp);
            SelectBoxPromptOrAddMoves(up);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Navigation right = new Navigation(NavRight);
            SelectBoxPromptOrAddMoves(right);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            Navigation down = new Navigation(NavDown);
            SelectBoxPromptOrAddMoves(down);
        }
    }
}
