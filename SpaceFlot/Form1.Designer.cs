namespace SpaceFlot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            pnlInputContainer = new Panel();
            btnAddShip = new Button();
            lstShips = new ListBox();
            btnAddDestroyer = new Button();
            btnAddCargo = new Button();
            btnExecute = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Combat Ship", "Transport Ship" });
            comboBox1.Location = new Point(2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(331, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pnlInputContainer
            // 
            pnlInputContainer.Location = new Point(2, 30);
            pnlInputContainer.Name = "pnlInputContainer";
            pnlInputContainer.Size = new Size(331, 148);
            pnlInputContainer.TabIndex = 1;
            // 
            // btnAddShip
            // 
            btnAddShip.Enabled = false;
            btnAddShip.Location = new Point(2, 184);
            btnAddShip.Name = "btnAddShip";
            btnAddShip.Size = new Size(331, 75);
            btnAddShip.TabIndex = 2;
            btnAddShip.Text = "Add";
            btnAddShip.UseVisualStyleBackColor = true;
            btnAddShip.Click += btnAddShip_Click;
            // 
            // lstShips
            // 
            lstShips.FormattingEnabled = true;
            lstShips.Location = new Point(339, 7);
            lstShips.Name = "lstShips";
            lstShips.Size = new Size(449, 334);
            lstShips.TabIndex = 3;
            lstShips.SelectedIndexChanged += lstShips_SelectedIndexChanged;
            // 
            // btnAddDestroyer
            // 
            btnAddDestroyer.Location = new Point(2, 266);
            btnAddDestroyer.Name = "btnAddDestroyer";
            btnAddDestroyer.Size = new Size(331, 75);
            btnAddDestroyer.TabIndex = 4;
            btnAddDestroyer.Text = "Add Destroyer";
            btnAddDestroyer.UseVisualStyleBackColor = true;
            btnAddDestroyer.Click += btnAddDestroyer_Click;
            // 
            // btnAddCargo
            // 
            btnAddCargo.Location = new Point(2, 347);
            btnAddCargo.Name = "btnAddCargo";
            btnAddCargo.Size = new Size(331, 75);
            btnAddCargo.TabIndex = 5;
            btnAddCargo.Text = "Add Cargo";
            btnAddCargo.UseVisualStyleBackColor = true;
            btnAddCargo.Click += btnAddCargo_Click;
            // 
            // btnExecute
            // 
            btnExecute.Enabled = false;
            btnExecute.Location = new Point(339, 347);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(449, 75);
            btnExecute.TabIndex = 6;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 426);
            Controls.Add(btnExecute);
            Controls.Add(btnAddCargo);
            Controls.Add(btnAddDestroyer);
            Controls.Add(lstShips);
            Controls.Add(btnAddShip);
            Controls.Add(pnlInputContainer);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Panel pnlInputContainer;
        private Button btnAddShip;
        private ListBox lstShips;
        private Button btnAddDestroyer;
        private Button btnAddCargo;
        private Button btnExecute;
    }
}
