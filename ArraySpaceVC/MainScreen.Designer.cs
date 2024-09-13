namespace ArraySpaceVC
{
    partial class MainScreen
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
            lblSpaceshipFleet = new Label();
            richOutputFleet = new RichTextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnGet = new Button();
            btnSearch = new Button();
            btnResize = new Button();
            richMap = new RichTextBox();
            btnViewMap = new Button();
            SuspendLayout();
            // 
            // lblSpaceshipFleet
            // 
            lblSpaceshipFleet.AutoSize = true;
            lblSpaceshipFleet.Location = new Point(306, 20);
            lblSpaceshipFleet.Name = "lblSpaceshipFleet";
            lblSpaceshipFleet.Size = new Size(161, 25);
            lblSpaceshipFleet.TabIndex = 0;
            lblSpaceshipFleet.Text = "Spaceships in Fleet";
            // 
            // richOutputFleet
            // 
            richOutputFleet.Location = new Point(86, 59);
            richOutputFleet.Name = "richOutputFleet";
            richOutputFleet.Size = new Size(671, 229);
            richOutputFleet.TabIndex = 1;
            richOutputFleet.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(86, 312);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(221, 312);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(112, 34);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(355, 312);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(112, 34);
            btnGet.TabIndex = 4;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(498, 312);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnResize
            // 
            btnResize.Location = new Point(645, 312);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(112, 34);
            btnResize.TabIndex = 6;
            btnResize.Text = "Resize";
            btnResize.UseVisualStyleBackColor = true;
            btnResize.Click += btnResize_Click;
            // 
            // richMap
            // 
            richMap.Location = new Point(802, 59);
            richMap.Name = "richMap";
            richMap.Size = new Size(671, 229);
            richMap.TabIndex = 7;
            richMap.Text = "";
            // 
            // btnViewMap
            // 
            btnViewMap.Location = new Point(1103, 312);
            btnViewMap.Name = "btnViewMap";
            btnViewMap.Size = new Size(112, 34);
            btnViewMap.TabIndex = 8;
            btnViewMap.Text = "View Map";
            btnViewMap.UseVisualStyleBackColor = true;
            btnViewMap.Click += btnViewMap_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1576, 450);
            Controls.Add(btnViewMap);
            Controls.Add(richMap);
            Controls.Add(btnResize);
            Controls.Add(btnSearch);
            Controls.Add(btnGet);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(richOutputFleet);
            Controls.Add(lblSpaceshipFleet);
            Name = "MainScreen";
            Text = "MainScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSpaceshipFleet;
        private RichTextBox richOutputFleet;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnGet;
        private Button btnSearch;
        private Button btnResize;
        private RichTextBox richMap;
        private Button btnViewMap;
    }
}