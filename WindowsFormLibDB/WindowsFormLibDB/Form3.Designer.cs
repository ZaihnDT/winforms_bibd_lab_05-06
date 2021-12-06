namespace WindowsFormLibDB
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.forlab03DataSet = new WindowsFormLibDB.forlab03DataSet();
            this.шифр_КнигиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.шифр_КнигиTableAdapter = new WindowsFormLibDB.forlab03DataSetTableAdapters.Шифр_КнигиTableAdapter();
            this.tableAdapterManager = new WindowsFormLibDB.forlab03DataSetTableAdapters.TableAdapterManager();
            this.шифр_КнигиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.шифр_КнигиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.шифр_книгиTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.авторTextBox = new System.Windows.Forms.TextBox();
            this.издательствоTextBox = new System.Windows.Forms.TextBox();
            this.годTextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.forlab03DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.шифр_КнигиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.шифр_КнигиBindingNavigator)).BeginInit();
            this.шифр_КнигиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(43, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(73, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Шифр:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Таблица \"Шифр Книги\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(73, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Автор:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(4, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Издательство:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(95, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Год:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(169, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 76);
            this.button4.TabIndex = 19;
            this.button4.Text = "Предыдущая Запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(169, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 76);
            this.button3.TabIndex = 18;
            this.button3.Text = "Следующая Запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(17, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 76);
            this.button2.TabIndex = 17;
            this.button2.Text = "Последняя Запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(17, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 76);
            this.button1.TabIndex = 16;
            this.button1.Text = "Первая Запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.Location = new System.Drawing.Point(397, 414);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 76);
            this.button6.TabIndex = 23;
            this.button6.Text = "Сохранить Запись";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(397, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 76);
            this.button5.TabIndex = 22;
            this.button5.Text = "Добавить Запись";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button7.Location = new System.Drawing.Point(369, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 76);
            this.button7.TabIndex = 24;
            this.button7.Text = "Удалить Запись";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(427, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Осторожно!";
            // 
            // forlab03DataSet
            // 
            this.forlab03DataSet.DataSetName = "forlab03DataSet";
            this.forlab03DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // шифр_КнигиBindingSource
            // 
            this.шифр_КнигиBindingSource.DataMember = "Шифр Книги";
            this.шифр_КнигиBindingSource.DataSource = this.forlab03DataSet;
            // 
            // шифр_КнигиTableAdapter
            // 
            this.шифр_КнигиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormLibDB.forlab03DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Книги___сдача__получениеTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            this.tableAdapterManager.Шифр_КнигиTableAdapter = this.шифр_КнигиTableAdapter;
            // 
            // шифр_КнигиBindingNavigator
            // 
            this.шифр_КнигиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.шифр_КнигиBindingNavigator.BindingSource = this.шифр_КнигиBindingSource;
            this.шифр_КнигиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.шифр_КнигиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.шифр_КнигиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.шифр_КнигиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.шифр_КнигиBindingNavigatorSaveItem});
            this.шифр_КнигиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.шифр_КнигиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.шифр_КнигиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.шифр_КнигиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.шифр_КнигиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.шифр_КнигиBindingNavigator.Name = "шифр_КнигиBindingNavigator";
            this.шифр_КнигиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.шифр_КнигиBindingNavigator.Size = new System.Drawing.Size(539, 27);
            this.шифр_КнигиBindingNavigator.TabIndex = 26;
            this.шифр_КнигиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // шифр_КнигиBindingNavigatorSaveItem
            // 
            this.шифр_КнигиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.шифр_КнигиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("шифр_КнигиBindingNavigatorSaveItem.Image")));
            this.шифр_КнигиBindingNavigatorSaveItem.Name = "шифр_КнигиBindingNavigatorSaveItem";
            this.шифр_КнигиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.шифр_КнигиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.шифр_КнигиBindingNavigatorSaveItem.Click += new System.EventHandler(this.шифр_КнигиBindingNavigatorSaveItem_Click);
            // 
            // шифр_книгиTextBox
            // 
            this.шифр_книгиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.шифр_КнигиBindingSource, "Шифр книги", true));
            this.шифр_книгиTextBox.Location = new System.Drawing.Point(169, 76);
            this.шифр_книгиTextBox.Name = "шифр_книгиTextBox";
            this.шифр_книгиTextBox.Size = new System.Drawing.Size(150, 22);
            this.шифр_книгиTextBox.TabIndex = 27;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.шифр_КнигиBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(169, 120);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(150, 22);
            this.названиеTextBox.TabIndex = 28;
            // 
            // авторTextBox
            // 
            this.авторTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.шифр_КнигиBindingSource, "Автор", true));
            this.авторTextBox.Location = new System.Drawing.Point(169, 162);
            this.авторTextBox.Name = "авторTextBox";
            this.авторTextBox.Size = new System.Drawing.Size(150, 22);
            this.авторTextBox.TabIndex = 29;
            // 
            // издательствоTextBox
            // 
            this.издательствоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.шифр_КнигиBindingSource, "Издательство", true));
            this.издательствоTextBox.Location = new System.Drawing.Point(169, 207);
            this.издательствоTextBox.Name = "издательствоTextBox";
            this.издательствоTextBox.Size = new System.Drawing.Size(150, 22);
            this.издательствоTextBox.TabIndex = 30;
            // 
            // годTextBox
            // 
            this.годTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.шифр_КнигиBindingSource, "Год", true));
            this.годTextBox.Location = new System.Drawing.Point(169, 245);
            this.годTextBox.Name = "годTextBox";
            this.годTextBox.Size = new System.Drawing.Size(150, 22);
            this.годTextBox.TabIndex = 31;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button8.Location = new System.Drawing.Point(397, 245);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 41);
            this.button8.TabIndex = 32;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button9.Location = new System.Drawing.Point(397, 64);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 41);
            this.button9.TabIndex = 34;
            this.button9.Text = "Отчёт";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 514);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.годTextBox);
            this.Controls.Add(this.издательствоTextBox);
            this.Controls.Add(this.авторTextBox);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(this.шифр_книгиTextBox);
            this.Controls.Add(this.шифр_КнигиBindingNavigator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Таблица \"Шифр Книги\"";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forlab03DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.шифр_КнигиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.шифр_КнигиBindingNavigator)).EndInit();
            this.шифр_КнигиBindingNavigator.ResumeLayout(false);
            this.шифр_КнигиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private forlab03DataSet forlab03DataSet;
        private System.Windows.Forms.BindingSource шифр_КнигиBindingSource;
        private forlab03DataSetTableAdapters.Шифр_КнигиTableAdapter шифр_КнигиTableAdapter;
        private forlab03DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator шифр_КнигиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton шифр_КнигиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox шифр_книгиTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox авторTextBox;
        private System.Windows.Forms.TextBox издательствоTextBox;
        private System.Windows.Forms.TextBox годTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}