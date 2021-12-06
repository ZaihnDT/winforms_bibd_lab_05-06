namespace WindowsFormLibDB
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.forlab03DataSet = new WindowsFormLibDB.forlab03DataSet();
            this.книги___сдача__получениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книги___сдача__получениеTableAdapter = new WindowsFormLibDB.forlab03DataSetTableAdapters.Книги___сдача__получениеTableAdapter();
            this.tableAdapterManager = new WindowsFormLibDB.forlab03DataSetTableAdapters.TableAdapterManager();
            this.книги___сдача__получениеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.книги___сдача__получениеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.шифр_книгиTextBox = new System.Windows.Forms.TextBox();
            this._ЧитателяTextBox = new System.Windows.Forms.TextBox();
            this.дата_ВыдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_ВозвратаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.forlab03DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книги___сдача__получениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книги___сдача__получениеBindingNavigator)).BeginInit();
            this.книги___сдача__получениеBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Книги - сдача, возврат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер Студента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(55, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шифр Книги:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(46, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата Выдачи:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(29, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата Возврата:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(196, 417);
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
            this.button3.Location = new System.Drawing.Point(196, 309);
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
            this.button2.Location = new System.Drawing.Point(30, 417);
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
            this.button1.Location = new System.Drawing.Point(30, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 76);
            this.button1.TabIndex = 16;
            this.button1.Text = "Первая Запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(387, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 76);
            this.button5.TabIndex = 20;
            this.button5.Text = "Добавить Запись";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.Location = new System.Drawing.Point(387, 417);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 76);
            this.button6.TabIndex = 21;
            this.button6.Text = "Сохранить Запись";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button7.Location = new System.Drawing.Point(376, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 76);
            this.button7.TabIndex = 22;
            this.button7.Text = "Удалить Запись";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(434, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Осторожно!";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // forlab03DataSet
            // 
            this.forlab03DataSet.DataSetName = "forlab03DataSet";
            this.forlab03DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книги___сдача__получениеBindingSource
            // 
            this.книги___сдача__получениеBindingSource.DataMember = "Книги - сдача, получение";
            this.книги___сдача__получениеBindingSource.DataSource = this.forlab03DataSet;
            // 
            // книги___сдача__получениеTableAdapter
            // 
            this.книги___сдача__получениеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormLibDB.forlab03DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Книги___сдача__получениеTableAdapter = this.книги___сдача__получениеTableAdapter;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            this.tableAdapterManager.Шифр_КнигиTableAdapter = null;
            // 
            // книги___сдача__получениеBindingNavigator
            // 
            this.книги___сдача__получениеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.книги___сдача__получениеBindingNavigator.BindingSource = this.книги___сдача__получениеBindingSource;
            this.книги___сдача__получениеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.книги___сдача__получениеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.книги___сдача__получениеBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.книги___сдача__получениеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.книги___сдача__получениеBindingNavigatorSaveItem});
            this.книги___сдача__получениеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.книги___сдача__получениеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.книги___сдача__получениеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.книги___сдача__получениеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.книги___сдача__получениеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.книги___сдача__получениеBindingNavigator.Name = "книги___сдача__получениеBindingNavigator";
            this.книги___сдача__получениеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.книги___сдача__получениеBindingNavigator.Size = new System.Drawing.Size(546, 27);
            this.книги___сдача__получениеBindingNavigator.TabIndex = 24;
            this.книги___сдача__получениеBindingNavigator.Text = "bindingNavigator1";
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
            // книги___сдача__получениеBindingNavigatorSaveItem
            // 
            this.книги___сдача__получениеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.книги___сдача__получениеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("книги___сдача__получениеBindingNavigatorSaveItem.Image")));
            this.книги___сдача__получениеBindingNavigatorSaveItem.Name = "книги___сдача__получениеBindingNavigatorSaveItem";
            this.книги___сдача__получениеBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.книги___сдача__получениеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.книги___сдача__получениеBindingNavigatorSaveItem.Click += new System.EventHandler(this.книги___сдача__получениеBindingNavigatorSaveItem_Click);
            // 
            // шифр_книгиTextBox
            // 
            this.шифр_книгиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книги___сдача__получениеBindingSource, "Шифр книги", true));
            this.шифр_книгиTextBox.Location = new System.Drawing.Point(196, 75);
            this.шифр_книгиTextBox.Name = "шифр_книгиTextBox";
            this.шифр_книгиTextBox.Size = new System.Drawing.Size(150, 22);
            this.шифр_книгиTextBox.TabIndex = 25;
            // 
            // _ЧитателяTextBox
            // 
            this._ЧитателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книги___сдача__получениеBindingSource, "№Читателя", true));
            this._ЧитателяTextBox.Location = new System.Drawing.Point(196, 124);
            this._ЧитателяTextBox.Name = "_ЧитателяTextBox";
            this._ЧитателяTextBox.Size = new System.Drawing.Size(150, 22);
            this._ЧитателяTextBox.TabIndex = 26;
            // 
            // дата_ВыдачиDateTimePicker
            // 
            this.дата_ВыдачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.книги___сдача__получениеBindingSource, "Дата Выдачи", true));
            this.дата_ВыдачиDateTimePicker.Location = new System.Drawing.Point(196, 185);
            this.дата_ВыдачиDateTimePicker.Name = "дата_ВыдачиDateTimePicker";
            this.дата_ВыдачиDateTimePicker.Size = new System.Drawing.Size(150, 22);
            this.дата_ВыдачиDateTimePicker.TabIndex = 27;
            // 
            // дата_ВозвратаDateTimePicker
            // 
            this.дата_ВозвратаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.книги___сдача__получениеBindingSource, "Дата Возврата", true));
            this.дата_ВозвратаDateTimePicker.Location = new System.Drawing.Point(196, 239);
            this.дата_ВозвратаDateTimePicker.Name = "дата_ВозвратаDateTimePicker";
            this.дата_ВозвратаDateTimePicker.Size = new System.Drawing.Size(150, 22);
            this.дата_ВозвратаDateTimePicker.TabIndex = 28;
            this.дата_ВозвратаDateTimePicker.ValueChanged += new System.EventHandler(this.дата_ВозвратаDateTimePicker_ValueChanged);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button8.Location = new System.Drawing.Point(387, 236);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 41);
            this.button8.TabIndex = 29;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button9.Location = new System.Drawing.Point(404, 56);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 41);
            this.button9.TabIndex = 34;
            this.button9.Text = "Отчёт";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 531);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.дата_ВозвратаDateTimePicker);
            this.Controls.Add(this.дата_ВыдачиDateTimePicker);
            this.Controls.Add(this._ЧитателяTextBox);
            this.Controls.Add(this.шифр_книгиTextBox);
            this.Controls.Add(this.книги___сдача__получениеBindingNavigator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Таблица \"Книги - сдача, возврат\"";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forlab03DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книги___сдача__получениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книги___сдача__получениеBindingNavigator)).EndInit();
            this.книги___сдача__получениеBindingNavigator.ResumeLayout(false);
            this.книги___сдача__получениеBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private forlab03DataSet forlab03DataSet;
        private System.Windows.Forms.BindingSource книги___сдача__получениеBindingSource;
        private forlab03DataSetTableAdapters.Книги___сдача__получениеTableAdapter книги___сдача__получениеTableAdapter;
        private forlab03DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator книги___сдача__получениеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton книги___сдача__получениеBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox шифр_книгиTextBox;
        private System.Windows.Forms.TextBox _ЧитателяTextBox;
        private System.Windows.Forms.DateTimePicker дата_ВыдачиDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_ВозвратаDateTimePicker;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}