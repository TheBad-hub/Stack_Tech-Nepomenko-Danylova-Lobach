namespace WinFormsApp
{
    using Microsoft.EntityFrameworkCore;

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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            policemenToolStripMenuItem = new ToolStripMenuItem();
            offendersToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            button_Add = new Button();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelBadgeNumber = new Label();
            labelViolationType = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxBadgeNumber = new TextBox();
            labelPolicemanId = new Label();
            textBoxViolationType = new TextBox();
            textBoxPolicemanId = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { policemenToolStripMenuItem, offendersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1211, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // policemenToolStripMenuItem
            // 
            policemenToolStripMenuItem.Name = "policemenToolStripMenuItem";
            policemenToolStripMenuItem.Size = new Size(91, 24);
            policemenToolStripMenuItem.Text = "Policemen";
            policemenToolStripMenuItem.Click += policemenToolStripMenuItem_Click;
            // 
            // offendersToolStripMenuItem
            // 
            offendersToolStripMenuItem.Name = "offendersToolStripMenuItem";
            offendersToolStripMenuItem.Size = new Size(88, 24);
            offendersToolStripMenuItem.Text = "Offenders";
            offendersToolStripMenuItem.Click += offendersToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 31);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(859, 407);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 52);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(122, 24);
            addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click_1;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(887, 409);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(312, 29);
            button_Add.TabIndex = 2;
            button_Add.Text = "ADD";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += buttonAdd_Click;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(887, 50);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(76, 20);
            labelFirstName.TabIndex = 6;
            labelFirstName.Text = "FirstName";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(893, 86);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(75, 20);
            labelLastName.TabIndex = 7;
            labelLastName.Text = "LastName";
            // 
            // labelBadgeNumber
            // 
            labelBadgeNumber.AutoSize = true;
            labelBadgeNumber.Location = new Point(894, 117);
            labelBadgeNumber.Name = "labelBadgeNumber";
            labelBadgeNumber.Size = new Size(106, 20);
            labelBadgeNumber.TabIndex = 8;
            labelBadgeNumber.Text = "BadgeNumber";
            // 
            // labelViolationType
            // 
            labelViolationType.AutoSize = true;
            labelViolationType.Location = new Point(894, 155);
            labelViolationType.Name = "labelViolationType";
            labelViolationType.Size = new Size(100, 20);
            labelViolationType.TabIndex = 9;
            labelViolationType.Text = "ViolationType";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(877, 206);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "FirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(879, 246);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "LastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 11;
            // 
            // textBoxBadgeNumber
            // 
            textBoxBadgeNumber.Location = new Point(878, 282);
            textBoxBadgeNumber.Name = "textBoxBadgeNumber";
            textBoxBadgeNumber.PlaceholderText = "BadgeNumber";
            textBoxBadgeNumber.Size = new Size(125, 27);
            textBoxBadgeNumber.TabIndex = 12;
            // 
            // labelPolicemanId
            // 
            labelPolicemanId.AutoSize = true;
            labelPolicemanId.Location = new Point(1037, 52);
            labelPolicemanId.Name = "labelPolicemanId";
            labelPolicemanId.Size = new Size(90, 20);
            labelPolicemanId.TabIndex = 13;
            labelPolicemanId.Text = "PolicemanId";
            // 
            // textBoxViolationType
            // 
            textBoxViolationType.Location = new Point(1053, 208);
            textBoxViolationType.Name = "textBoxViolationType";
            textBoxViolationType.PlaceholderText = "ViolationType";
            textBoxViolationType.Size = new Size(125, 27);
            textBoxViolationType.TabIndex = 14;
            // 
            // textBoxPolicemanId
            // 
            textBoxPolicemanId.Location = new Point(1054, 250);
            textBoxPolicemanId.Name = "textBoxPolicemanId";
            textBoxPolicemanId.PlaceholderText = "PolicemanId";
            textBoxPolicemanId.Size = new Size(125, 27);
            textBoxPolicemanId.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 450);
            Controls.Add(textBoxPolicemanId);
            Controls.Add(textBoxViolationType);
            Controls.Add(labelPolicemanId);
            Controls.Add(textBoxBadgeNumber);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelViolationType);
            Controls.Add(labelBadgeNumber);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(button_Add);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem policemenToolStripMenuItem;
        private ToolStripMenuItem offendersToolStripMenuItem;

        private DataGridView dataGridView1;
        private Button button_Add;
        private void LoadData(string table)
        {
            if (table == "Policemen")
            {
                var policemen = context.Policemen.ToList();
                dataGridView1.DataSource = policemen;
            }
            else if (table == "Offenders")
            {
                var offenders = context.Offenders
                    .Include(o => o.Policeman)
                    .ToList();
                // Створюємо список, щоб зберігати інформацію для відображення
                var displayOffenders = offenders.Select(o => new
                {
                    o.OffenderId,
                    o.FirstName,
                    o.LastName,
                    o.ViolationType,
                    PolicemanFullName = $"{o.Policeman.FirstName} {o.Policeman.LastName}"
                }).ToList();

                dataGridView1.DataSource = displayOffenders;

                // Прибираємо колонку Policeman
                if (dataGridView1.Columns.Contains("Policeman"))
                {
                    dataGridView1.Columns["Policeman"].Visible = false;
                }
            }
        }

        private void ToggleInputFields(string table)
        {
            // Приховуємо або показуємо елементи керування залежно від вибраної таблиці
            if (table == "Policemen")
            {
                labelFirstName.Visible = true;
                labelLastName.Visible = true;
                labelBadgeNumber.Visible = true;

                labelViolationType.Visible = false;
                labelPolicemanId.Visible = false;

                textBoxBadgeNumber.Visible = true;
                textBoxFirstName.Visible = true;
                textBoxLastName.Visible = true;

                textBoxViolationType.Visible = false;
                textBoxPolicemanId.Visible = false;
            }
            else if (table == "Offenders")
            {
                labelBadgeNumber.Visible = false;
                labelFirstName.Visible = true;
                labelLastName.Visible = true;
                labelViolationType.Visible = true;
                labelPolicemanId.Visible = true;

                textBoxViolationType.Visible = true;
                textBoxPolicemanId.Visible = true;

                textBoxBadgeNumber.Visible = false;
                textBoxFirstName.Visible = true;
                textBoxLastName.Visible = true;
            }
        }

        private void cleaning_TextBoxes()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxBadgeNumber.Text = "";
            textBoxViolationType.Text = "";
            textBoxPolicemanId.Text = "";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи є джерело даних списком поліцейських
            if (textBoxBadgeNumber.Visible)
            {
                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxBadgeNumber.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля поліцейського.");
                    return; // Завершаем метод, если поля не заполнены
                }

                var newPoliceman = new Policeman
                {
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    BadgeNumber = textBoxBadgeNumber.Text
                };

                context.Policemen.Add(newPoliceman);
                context.SaveChanges();
                LoadData("Policemen");
                cleaning_TextBoxes();
            }
            else if (textBoxViolationType.Visible && textBoxPolicemanId.Visible)
            {
                // Перевірка на пусті поля
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxViolationType.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPolicemanId.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля порушника.");
                    return; // Завершаем метод, если поля не заполнены
                }

                // Перевіряємо введений ID поліцейського
                if (int.TryParse(textBoxPolicemanId.Text, out int policemanId))
                {
                    // Перевіряємо, чи є поліцейський з таким ID
                    var existingPoliceman = context.Policemen.Find(policemanId);
                    if (existingPoliceman != null)
                    {
                        var newOffender = new Offender
                        {
                            FirstName = textBoxFirstName.Text,
                            LastName = textBoxLastName.Text,
                            ViolationType = textBoxViolationType.Text,
                            PolicemanId = existingPoliceman.PolicemanId
                        };

                        context.Offenders.Add(newOffender);
                        context.SaveChanges();
                        LoadData("Offenders");
                        cleaning_TextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Поліцейський із зазначеним ID не знайдено.");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильний ID поліцейського. Будь ласка, введіть ціле число.");
                }
            }
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Отримуємо індекс обраного рядка
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
                // Підтвердження видалення
                DialogResult dr = MessageBox.Show("Видалити вибрану запис?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (dataGridView1.DataSource is List<Policeman>)
                        {
                            var selectedPoliceman = (Policeman)dataGridView1.Rows[selectedRow].DataBoundItem;
                            context.Policemen.Remove(selectedPoliceman);
                            context.SaveChanges();
                            LoadData("Policemen");
                        }
                        else if (dataGridView1.DataSource is List<Offender>)
                        {
                            var selectedOffender = (Offender)dataGridView1.Rows[selectedRow].DataBoundItem;
                            context.Offenders.Remove(selectedOffender);
                            context.SaveChanges();
                            LoadData("Offenders");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.");
            }
        }
        private void policemenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData("Policemen");
            ToggleInputFields("Policemen");
        }

        private void offendersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData("Offenders");
            ToggleInputFields("Offenders");
        }
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelBadgeNumber;
        private Label labelViolationType;
        private Label labelPolicemanId;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxBadgeNumber;
        private TextBox textBoxViolationType;
        private TextBox textBoxPolicemanId;
    }
}
