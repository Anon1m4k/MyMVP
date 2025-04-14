namespace MyMVP
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersList = new System.Windows.Forms.DataGridView();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameFiltr = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ComboBoxFiltr = new System.Windows.Forms.ComboBox();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.Card = new UserCard.UserControl();
            ((System.ComponentModel.ISupportInitialize)(this.UsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersList
            // 
            this.UsersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UsersList.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.UsersList.Location = new System.Drawing.Point(29, 38);
            this.UsersList.Name = "UsersList";
            this.UsersList.ReadOnly = true;
            this.UsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersList.Size = new System.Drawing.Size(768, 207);
            this.UsersList.TabIndex = 0;
            this.UsersList.SelectionChanged += new System.EventHandler(this.UsersList_SelectionChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(272, 262);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameFiltr
            // 
            this.NameFiltr.Location = new System.Drawing.Point(29, 251);
            this.NameFiltr.Name = "NameFiltr";
            this.NameFiltr.Size = new System.Drawing.Size(110, 39);
            this.NameFiltr.TabIndex = 2;
            this.NameFiltr.Text = "Отфильтровать по";
            this.NameFiltr.UseVisualStyleBackColor = true;
            this.NameFiltr.Click += new System.EventHandler(this.NameFiltr_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(29, 294);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 40);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Сбросить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ComboBoxFiltr
            // 
            this.ComboBoxFiltr.FormattingEnabled = true;
            this.ComboBoxFiltr.Items.AddRange(new object[] {
            "имени",
            "логину"});
            this.ComboBoxFiltr.Location = new System.Drawing.Point(145, 261);
            this.ComboBoxFiltr.Name = "ComboBoxFiltr";
            this.ComboBoxFiltr.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxFiltr.TabIndex = 4;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(29, 340);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(343, 50);
            this.ButtonRemove.TabIndex = 6;
            this.ButtonRemove.Text = "Удалить пользователя";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // Card
            // 
            this.Card.Location = new System.Drawing.Point(378, 267);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(416, 257);
            this.Card.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(818, 536);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.ComboBoxFiltr);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.NameFiltr);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.UsersList);
            this.Name = "MainForm";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.UsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersList;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button NameFiltr;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox ComboBoxFiltr;
        private UserCard.UserControl Card;
        private System.Windows.Forms.Button ButtonRemove;
    }
}

