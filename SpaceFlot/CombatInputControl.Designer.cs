namespace SpaceFlot
{
    partial class CombatInputControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            txtModelName = new TextBox();
            txtFirePower = new TextBox();
            lblModelName = new Label();
            lblFirePower = new Label();
            SuspendLayout();
            // 
            // txtModelName
            // 
            txtModelName.Location = new Point(0, 80);
            txtModelName.Name = "txtModelName";
            txtModelName.Size = new Size(453, 23);
            txtModelName.TabIndex = 7;
            // 
            // txtFirePower
            // 
            txtFirePower.Location = new Point(0, 17);
            txtFirePower.Name = "txtFirePower";
            txtFirePower.Size = new Size(453, 23);
            txtFirePower.TabIndex = 6;
            // 
            // lblModelName
            // 
            lblModelName.AutoSize = true;
            lblModelName.Location = new Point(0, 62);
            lblModelName.Name = "lblModelName";
            lblModelName.Size = new Size(76, 15);
            lblModelName.TabIndex = 5;
            lblModelName.Text = "Model Name";
            // 
            // lblFirePower
            // 
            lblFirePower.AutoSize = true;
            lblFirePower.BackColor = SystemColors.Control;
            lblFirePower.Cursor = Cursors.SizeAll;
            lblFirePower.Location = new Point(0, 0);
            lblFirePower.Name = "lblFirePower";
            lblFirePower.Size = new Size(62, 15);
            lblFirePower.TabIndex = 4;
            lblFirePower.Text = "Fire Power";
            // 
            // CombatInputControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtModelName);
            Controls.Add(txtFirePower);
            Controls.Add(lblModelName);
            Controls.Add(lblFirePower);
            Name = "CombatInputControl";
            Size = new Size(453, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtModelName;
        private TextBox txtFirePower;
        private Label lblModelName;
        private Label lblFirePower;
    }
}
