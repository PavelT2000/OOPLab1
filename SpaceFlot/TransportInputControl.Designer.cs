namespace SpaceFlot
{
    partial class TransportInputControl
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
            txtCapacity = new TextBox();
            lblModelName = new Label();
            lblCapacity = new Label();
            SuspendLayout();
            // 
            // txtModelName
            // 
            txtModelName.Location = new Point(0, 59);
            txtModelName.Name = "txtModelName";
            txtModelName.Size = new Size(150, 23);
            txtModelName.TabIndex = 7;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(0, 17);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(150, 23);
            txtCapacity.TabIndex = 6;
            // 
            // lblModelName
            // 
            lblModelName.AutoSize = true;
            lblModelName.Location = new Point(0, 41);
            lblModelName.Name = "lblModelName";
            lblModelName.Size = new Size(76, 15);
            lblModelName.TabIndex = 5;
            lblModelName.Text = "Model Name";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.BackColor = SystemColors.Control;
            lblCapacity.Cursor = Cursors.SizeAll;
            lblCapacity.Location = new Point(0, 0);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(53, 15);
            lblCapacity.TabIndex = 4;
            lblCapacity.Text = "Capacity";
            // 
            // TransportInputControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtModelName);
            Controls.Add(txtCapacity);
            Controls.Add(lblModelName);
            Controls.Add(lblCapacity);
            Name = "TransportInputControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtModelName;
        private TextBox txtCapacity;
        private Label lblModelName;
        private Label lblCapacity;
    }
}
