/*ControlPanel.cs
 *QGame Design
 *Revision History:
 *      Dany Wang, 2022.10.28: Created
 */
using System;
using System.Windows.Forms;

namespace QGame
{
    /// <summary>
    /// control panel form
    /// </summary>
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            Form designForm = new DesignForm();
            designForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form playForm = new PlayForm();
            playForm.ShowDialog();
        }
    }
}
