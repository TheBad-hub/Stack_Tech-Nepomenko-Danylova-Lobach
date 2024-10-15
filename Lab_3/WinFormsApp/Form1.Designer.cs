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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { policemenToolStripMenuItem, offendersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1071, 25);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // policemenToolStripMenuItem
            // 
            policemenToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            policemenToolStripMenuItem.Name = "policemenToolStripMenuItem";
            policemenToolStripMenuItem.Size = new Size(75, 19);
            policemenToolStripMenuItem.Text = "Policemen";
            policemenToolStripMenuItem.Click += policemenToolStripMenuItem_Click;
            // 
            // offendersToolStripMenuItem
            // 
            offendersToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            offendersToolStripMenuItem.Name = "offendersToolStripMenuItem";
            offendersToolStripMenuItem.Size = new Size(71, 19);
            offendersToolStripMenuItem.Text = "Offenders";
            offendersToolStripMenuItem.Click += offendersToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(32, 51);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(746, 404);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 48);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(107, 22);
            addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click_1;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(846, 434);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(170, 22);
            button_Add.TabIndex = 2;
            button_Add.Text = "ADD";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += buttonAdd_Click;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Location = new Point(842, 90);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(64, 15);
            labelFirstName.TabIndex = 6;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Location = new Point(842, 127);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(63, 15);
            labelLastName.TabIndex = 7;
            labelLastName.Text = "Last Name";
            // 
            // labelBadgeNumber
            // 
            labelBadgeNumber.AutoSize = true;
            labelBadgeNumber.BackColor = Color.Transparent;
            labelBadgeNumber.Location = new Point(831, 162);
            labelBadgeNumber.Name = "labelBadgeNumber";
            labelBadgeNumber.Size = new Size(87, 15);
            labelBadgeNumber.TabIndex = 8;
            labelBadgeNumber.Text = "Badge Number";
            // 
            // labelViolationType
            // 
            labelViolationType.AutoSize = true;
            labelViolationType.BackColor = Color.Transparent;
            labelViolationType.Location = new Point(950, 127);
            labelViolationType.Name = "labelViolationType";
            labelViolationType.Size = new Size(81, 15);
            labelViolationType.TabIndex = 9;
            labelViolationType.Text = "Violation Type";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(815, 311);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "First Name";
            textBoxFirstName.Size = new Size(110, 23);
            textBoxFirstName.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(815, 350);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Last Name";
            textBoxLastName.Size = new Size(110, 23);
            textBoxLastName.TabIndex = 11;
            // 
            // textBoxBadgeNumber
            // 
            textBoxBadgeNumber.Location = new Point(815, 390);
            textBoxBadgeNumber.Name = "textBoxBadgeNumber";
            textBoxBadgeNumber.PlaceholderText = "Badge Number";
            textBoxBadgeNumber.Size = new Size(110, 23);
            textBoxBadgeNumber.TabIndex = 12;
            // 
            // labelPolicemanId
            // 
            labelPolicemanId.AutoSize = true;
            labelPolicemanId.BackColor = Color.Transparent;
            labelPolicemanId.Location = new Point(955, 90);
            labelPolicemanId.Name = "labelPolicemanId";
            labelPolicemanId.Size = new Size(73, 15);
            labelPolicemanId.TabIndex = 13;
            labelPolicemanId.Text = "PolicemanId";
            // 
            // textBoxViolationType
            // 
            textBoxViolationType.Location = new Point(937, 350);
            textBoxViolationType.Name = "textBoxViolationType";
            textBoxViolationType.PlaceholderText = "Violation Type";
            textBoxViolationType.Size = new Size(110, 23);
            textBoxViolationType.TabIndex = 14;
            // 
            // textBoxPolicemanId
            // 
            textBoxPolicemanId.Location = new Point(937, 311);
            textBoxPolicemanId.Name = "textBoxPolicemanId";
            textBoxPolicemanId.PlaceholderText = "PolicemanId";
            textBoxPolicemanId.Size = new Size(110, 23);
            textBoxPolicemanId.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1071, 503);
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
            Text = "Police department";
            Load += Form1_Load;
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
                var policemen = context.Policemen
                    .Include(p => p.Offenders) // Загружаємо правопорушників
                    .ToList();

                // Створюємо список для відображення інформації
                var displayPolicemen = policemen.Select(p => new
                {
                    p.PolicemanId,
                    p.FirstName,
                    p.LastName,
                    p.BadgeNumber,
                    OffendersList = p.Offenders.Count > 0
                        ? string.Join(", ", p.Offenders.Select(o => $"{o.FirstName} {o.LastName}"))
                        : "Немає правопорушників"
                }).ToList();

                dataGridView1.DataSource = displayPolicemen;
            }
            else if (table == "Offenders")
            {
                var offenders = context.Offenders
                    .Include(o => o.Policeman)
                    .ToList();

                var displayOffenders = offenders.Select(o => new
                {
                    o.OffenderId,
                    o.FirstName,
                    o.LastName,
                    o.ViolationType,
                    PolicemanFullName = $"{o.Policeman.FirstName} {o.Policeman.LastName}"
                }).ToList();

                dataGridView1.DataSource = displayOffenders;
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
            if (textBoxBadgeNumber.Visible) // Добавляем полицейского
            {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxBadgeNumber.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля поліцейського.");
                    return;
                }

                var newPoliceman = new Policeman
                {
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    BadgeNumber = textBoxBadgeNumber.Text,
                    Offenders = new List<Offender>() // Инициализация коллекции нарушителей
                };

                context.Policemen.Add(newPoliceman);
                context.SaveChanges();
                LoadData("Policemen");
                cleaning_TextBoxes();
            }
            else if (textBoxViolationType.Visible && textBoxPolicemanId.Visible) // Добавляем нарушителя
            {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxViolationType.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPolicemanId.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля порушника.");
                    return;
                }

                if (int.TryParse(textBoxPolicemanId.Text, out int policemanId))
                {
                    var existingPoliceman = context.Policemen
                        .Include(p => p.Offenders) // Загружаем связанные объекты нарушителей
                        .FirstOrDefault(p => p.PolicemanId == policemanId);

                    if (existingPoliceman != null)
                    {
                        var newOffender = new Offender
                        {
                            FirstName = textBoxFirstName.Text,
                            LastName = textBoxLastName.Text,
                            ViolationType = textBoxViolationType.Text,
                            PolicemanId = existingPoliceman.PolicemanId
                        };

                        context.Offenders.Add(newOffender); // Сохраняем нарушителя
                        context.SaveChanges();

                        // Обновляем коллекцию нарушителей для полицейского
                        existingPoliceman.Offenders.Add(newOffender);
                        context.Entry(existingPoliceman).State = EntityState.Modified; // Указываем, что полицейский изменился
                        context.SaveChanges(); // Сохраняем обновление коллекции нарушителей

                        // Обновляем данные на форме
                        LoadData("Policemen");
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
                DialogResult dr = MessageBox.Show("Видалити обраний запис?", "", MessageBoxButtons.YesNo);
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
