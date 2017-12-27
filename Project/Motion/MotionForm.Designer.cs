namespace Motion
{
    partial class Model
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
            this._AddButton = new System.Windows.Forms.Button();
            this._EditButton = new System.Windows.Forms.Button();
            this._DeleteButton = new System.Windows.Forms.Button();
            this._ExitButton = new System.Windows.Forms.Button();
            this._RandButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ыToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameClumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.UserElement = new System.Windows.Forms.UserControl();
            this.userControl1 = new System.Windows.Forms.UserControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _AddButton
            // 
            this._AddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._AddButton.Location = new System.Drawing.Point(70, 328);
            this._AddButton.Name = "_AddButton";
            this._AddButton.Size = new System.Drawing.Size(75, 23);
            this._AddButton.TabIndex = 1;
            this._AddButton.Text = "Добавить";
            this._AddButton.UseVisualStyleBackColor = true;
            this._AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this._AddButton.MouseHover += new System.EventHandler(this._AddButton_MouseHover);
            // 
            // _EditButton
            // 
            this._EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._EditButton.Location = new System.Drawing.Point(151, 328);
            this._EditButton.Name = "_EditButton";
            this._EditButton.Size = new System.Drawing.Size(75, 23);
            this._EditButton.TabIndex = 2;
            this._EditButton.Text = "Изменить";
            this._EditButton.UseVisualStyleBackColor = true;
            this._EditButton.Click += new System.EventHandler(this.EditButton_Click);
            this._EditButton.MouseHover += new System.EventHandler(this._EditButton_MouseHover);
            // 
            // _DeleteButton
            // 
            this._DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._DeleteButton.Location = new System.Drawing.Point(232, 328);
            this._DeleteButton.Name = "_DeleteButton";
            this._DeleteButton.Size = new System.Drawing.Size(75, 23);
            this._DeleteButton.TabIndex = 3;
            this._DeleteButton.Text = "Удалить";
            this._DeleteButton.UseVisualStyleBackColor = true;
            this._DeleteButton.Click += new System.EventHandler(this.DeletedButton_Click);
            this._DeleteButton.MouseHover += new System.EventHandler(this._DeleteButton_MouseHover);
            // 
            // _ExitButton
            // 
            this._ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._ExitButton.Location = new System.Drawing.Point(394, 328);
            this._ExitButton.Name = "_ExitButton";
            this._ExitButton.Size = new System.Drawing.Size(75, 23);
            this._ExitButton.TabIndex = 4;
            this._ExitButton.Text = "Выход";
            this._ExitButton.UseVisualStyleBackColor = true;
            this._ExitButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // _RandButton
            // 
            this._RandButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._RandButton.Location = new System.Drawing.Point(313, 328);
            this._RandButton.Name = "_RandButton";
            this._RandButton.Size = new System.Drawing.Size(75, 23);
            this._RandButton.TabIndex = 5;
            this._RandButton.Text = "Рандом";
            this._RandButton.UseVisualStyleBackColor = true;
            this._RandButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Motion file (*.Motion)|*.Motion|All files|*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this._SaveToolStripMenuItem,
            this.ыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // _SaveToolStripMenuItem
            // 
            this._SaveToolStripMenuItem.Name = "_SaveToolStripMenuItem";
            this._SaveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this._SaveToolStripMenuItem.Text = "Сохранить";
            this._SaveToolStripMenuItem.Click += new System.EventHandler(this._SaveToolStripMenuItem_Click);
            // 
            // ыToolStripMenuItem
            // 
            this.ыToolStripMenuItem.Name = "ыToolStripMenuItem";
            this.ыToolStripMenuItem.Size = new System.Drawing.Size(129, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ReplyColumn
            // 
            this.ReplyColumn.HeaderText = "Ответ";
            this.ReplyColumn.Name = "ReplyColumn";
            this.ReplyColumn.ReadOnly = true;
            // 
            // NameClumn
            // 
            this.NameClumn.HeaderText = "Название";
            this.NameClumn.Name = "NameClumn";
            this.NameClumn.ReadOnly = true;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameClumn,
            this.ReplyColumn});
            this._dataGridView.Location = new System.Drawing.Point(12, 27);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.Size = new System.Drawing.Size(414, 295);
            this._dataGridView.TabIndex = 0;
            // 
            // UserElement
            // 
            this.UserElement.Location = new System.Drawing.Point(288, 27);
            this.UserElement.Name = "UserElement";
            this.UserElement.Size = new System.Drawing.Size(150, 150);
            this.UserElement.TabIndex = 0;
            // 
            // userControl1
            // 
            this.userControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl1.Enabled = false;
            this.userControl1.Location = new System.Drawing.Point(432, 30);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(175, 292);
            this.userControl1.TabIndex = 0;
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 357);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this._RandButton);
            this.Controls.Add(this._ExitButton);
            this.Controls.Add(this._DeleteButton);
            this.Controls.Add(this._EditButton);
            this.Controls.Add(this._AddButton);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Model";
            this.Text = "Model";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _AddButton;
        private System.Windows.Forms.UserControl UserElement;
        private System.Windows.Forms.Button _EditButton;
        private System.Windows.Forms.Button _DeleteButton;
        private System.Windows.Forms.Button _ExitButton;
        private System.Windows.Forms.Button _RandButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClumn;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.UserControl userControl1;
    }
}

