namespace QGame
{
    partial class DesignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panelDesign = new System.Windows.Forms.Panel();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.btnBlueDoor = new System.Windows.Forms.Button();
            this.btnBlueBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1426, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.txtColumn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1426, 110);
            this.panel1.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(800, 24);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(228, 56);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(448, 36);
            this.txtColumn.Margin = new System.Windows.Forms.Padding(4);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(188, 35);
            this.txtColumn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Columns:";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(92, 36);
            this.txtRow.Margin = new System.Windows.Forms.Padding(4);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(188, 35);
            this.txtRow.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnBlueDoor);
            this.panel2.Controls.Add(this.btnBlueBox);
            this.panel2.Controls.Add(this.btnGreenDoor);
            this.panel2.Controls.Add(this.btnGreenBox);
            this.panel2.Controls.Add(this.btnWall);
            this.panel2.Controls.Add(this.btnNone);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 702);
            this.panel2.TabIndex = 2;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "None.jpg");
            this.imageList.Images.SetKeyName(1, "Wall.jpg");
            this.imageList.Images.SetKeyName(2, "GreenCube.png");
            this.imageList.Images.SetKeyName(3, "GreenDoor.jpg");
            this.imageList.Images.SetKeyName(4, "BlueCube.png");
            this.imageList.Images.SetKeyName(5, "BlueDoor.jpg");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(92, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toolbox";
            // 
            // panelDesign
            // 
            this.panelDesign.AutoSize = true;
            this.panelDesign.Location = new System.Drawing.Point(306, 158);
            this.panelDesign.Margin = new System.Windows.Forms.Padding(6);
            this.panelDesign.Name = "panelDesign";
            this.panelDesign.Size = new System.Drawing.Size(1120, 716);
            this.panelDesign.TabIndex = 3;
            // 
            // btnBlueDoor
            // 
            this.btnBlueDoor.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btnBlueDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueDoor.ImageIndex = 5;
            this.btnBlueDoor.ImageList = this.imageList;
            this.btnBlueDoor.Location = new System.Drawing.Point(56, 596);
            this.btnBlueDoor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlueDoor.Name = "btnBlueDoor";
            this.btnBlueDoor.Size = new System.Drawing.Size(192, 80);
            this.btnBlueDoor.TabIndex = 1;
            this.btnBlueDoor.Text = "Blue Door";
            this.btnBlueDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueDoor.UseVisualStyleBackColor = true;
            this.btnBlueDoor.Click += new System.EventHandler(this.btnBlueDoor_Click);
            // 
            // btnBlueBox
            // 
            this.btnBlueBox.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btnBlueBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueBox.ImageIndex = 4;
            this.btnBlueBox.ImageList = this.imageList;
            this.btnBlueBox.Location = new System.Drawing.Point(56, 496);
            this.btnBlueBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlueBox.Name = "btnBlueBox";
            this.btnBlueBox.Size = new System.Drawing.Size(192, 80);
            this.btnBlueBox.TabIndex = 1;
            this.btnBlueBox.Text = "Blue Box";
            this.btnBlueBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlueBox.UseVisualStyleBackColor = true;
            this.btnBlueBox.Click += new System.EventHandler(this.btnBlueBox_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.ImageIndex = 3;
            this.btnGreenDoor.ImageList = this.imageList;
            this.btnGreenDoor.Location = new System.Drawing.Point(56, 396);
            this.btnGreenDoor.Margin = new System.Windows.Forms.Padding(4);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(192, 80);
            this.btnGreenDoor.TabIndex = 1;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnGreenDoor_Click);
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.ImageIndex = 2;
            this.btnGreenBox.ImageList = this.imageList;
            this.btnGreenBox.Location = new System.Drawing.Point(56, 296);
            this.btnGreenBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(192, 80);
            this.btnGreenBox.TabIndex = 1;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btnGreenBox_Click);
            // 
            // btnWall
            // 
            this.btnWall.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.ImageIndex = 1;
            this.btnWall.ImageList = this.imageList;
            this.btnWall.Location = new System.Drawing.Point(56, 196);
            this.btnWall.Margin = new System.Windows.Forms.Padding(4);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(192, 80);
            this.btnWall.TabIndex = 1;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // btnNone
            // 
            this.btnNone.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.ImageIndex = 0;
            this.btnNone.ImageList = this.imageList;
            this.btnNone.Location = new System.Drawing.Point(56, 96);
            this.btnNone.Margin = new System.Windows.Forms.Padding(4);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(192, 80);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1426, 892);
            this.Controls.Add(this.panelDesign);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DesignForm";
            this.Text = "Design Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnBlueDoor;
        private System.Windows.Forms.Button btnBlueBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Panel panelDesign;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}