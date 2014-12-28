namespace Db2JSON
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._MG_WEB_2003DataSet = new Db2JSON._MG_WEB_2003DataSet();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new Db2JSON._MG_WEB_2003DataSetTableAdapters.ТоварыTableAdapter();
            this.кодТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.массаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоВКоробкеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остатокНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сортировкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.переходDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоБонусаТоварногоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процентБонусаТоварногоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПоставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаЗакупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.начальныйОстатокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пРОБАDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факт1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.свободный1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.инвентураDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факт2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.свободный2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MG_WEB_2003DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТовараDataGridViewTextBoxColumn,
            this.товарDataGridViewTextBoxColumn,
            this.массаDataGridViewTextBoxColumn,
            this.количествоВКоробкеDataGridViewTextBoxColumn,
            this.остатокНаСкладеDataGridViewTextBoxColumn,
            this.сортировкаDataGridViewTextBoxColumn,
            this.переходDataGridViewTextBoxColumn,
            this.группаТовараDataGridViewTextBoxColumn,
            this.количествоБонусаТоварногоDataGridViewTextBoxColumn,
            this.процентБонусаТоварногоDataGridViewTextBoxColumn,
            this.iDПоставщикDataGridViewTextBoxColumn,
            this.ценаЗакупкиDataGridViewTextBoxColumn,
            this.начальныйОстатокDataGridViewTextBoxColumn,
            this.пРОБАDataGridViewTextBoxColumn,
            this.факт1DataGridViewTextBoxColumn,
            this.свободный1DataGridViewTextBoxColumn,
            this.инвентураDataGridViewTextBoxColumn,
            this.факт2DataGridViewTextBoxColumn,
            this.свободный2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товарыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // _MG_WEB_2003DataSet
            // 
            this._MG_WEB_2003DataSet.DataSetName = "_MG_WEB_2003DataSet";
            this._MG_WEB_2003DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this._MG_WEB_2003DataSet;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // кодТовараDataGridViewTextBoxColumn
            // 
            this.кодТовараDataGridViewTextBoxColumn.DataPropertyName = "КодТовара";
            this.кодТовараDataGridViewTextBoxColumn.HeaderText = "КодТовара";
            this.кодТовараDataGridViewTextBoxColumn.Name = "кодТовараDataGridViewTextBoxColumn";
            // 
            // товарDataGridViewTextBoxColumn
            // 
            this.товарDataGridViewTextBoxColumn.DataPropertyName = "Товар";
            this.товарDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn.Name = "товарDataGridViewTextBoxColumn";
            // 
            // массаDataGridViewTextBoxColumn
            // 
            this.массаDataGridViewTextBoxColumn.DataPropertyName = "Масса";
            this.массаDataGridViewTextBoxColumn.HeaderText = "Масса";
            this.массаDataGridViewTextBoxColumn.Name = "массаDataGridViewTextBoxColumn";
            // 
            // количествоВКоробкеDataGridViewTextBoxColumn
            // 
            this.количествоВКоробкеDataGridViewTextBoxColumn.DataPropertyName = "КоличествоВКоробке";
            this.количествоВКоробкеDataGridViewTextBoxColumn.HeaderText = "КоличествоВКоробке";
            this.количествоВКоробкеDataGridViewTextBoxColumn.Name = "количествоВКоробкеDataGridViewTextBoxColumn";
            // 
            // остатокНаСкладеDataGridViewTextBoxColumn
            // 
            this.остатокНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "ОстатокНаСкладе";
            this.остатокНаСкладеDataGridViewTextBoxColumn.HeaderText = "ОстатокНаСкладе";
            this.остатокНаСкладеDataGridViewTextBoxColumn.Name = "остатокНаСкладеDataGridViewTextBoxColumn";
            // 
            // сортировкаDataGridViewTextBoxColumn
            // 
            this.сортировкаDataGridViewTextBoxColumn.DataPropertyName = "Сортировка";
            this.сортировкаDataGridViewTextBoxColumn.HeaderText = "Сортировка";
            this.сортировкаDataGridViewTextBoxColumn.Name = "сортировкаDataGridViewTextBoxColumn";
            // 
            // переходDataGridViewTextBoxColumn
            // 
            this.переходDataGridViewTextBoxColumn.DataPropertyName = "Переход";
            this.переходDataGridViewTextBoxColumn.HeaderText = "Переход";
            this.переходDataGridViewTextBoxColumn.Name = "переходDataGridViewTextBoxColumn";
            // 
            // группаТовараDataGridViewTextBoxColumn
            // 
            this.группаТовараDataGridViewTextBoxColumn.DataPropertyName = "ГруппаТовара";
            this.группаТовараDataGridViewTextBoxColumn.HeaderText = "ГруппаТовара";
            this.группаТовараDataGridViewTextBoxColumn.Name = "группаТовараDataGridViewTextBoxColumn";
            // 
            // количествоБонусаТоварногоDataGridViewTextBoxColumn
            // 
            this.количествоБонусаТоварногоDataGridViewTextBoxColumn.DataPropertyName = "КоличествоБонусаТоварного";
            this.количествоБонусаТоварногоDataGridViewTextBoxColumn.HeaderText = "КоличествоБонусаТоварного";
            this.количествоБонусаТоварногоDataGridViewTextBoxColumn.Name = "количествоБонусаТоварногоDataGridViewTextBoxColumn";
            // 
            // процентБонусаТоварногоDataGridViewTextBoxColumn
            // 
            this.процентБонусаТоварногоDataGridViewTextBoxColumn.DataPropertyName = "ПроцентБонусаТоварного";
            this.процентБонусаТоварногоDataGridViewTextBoxColumn.HeaderText = "ПроцентБонусаТоварного";
            this.процентБонусаТоварногоDataGridViewTextBoxColumn.Name = "процентБонусаТоварногоDataGridViewTextBoxColumn";
            // 
            // iDПоставщикDataGridViewTextBoxColumn
            // 
            this.iDПоставщикDataGridViewTextBoxColumn.DataPropertyName = "ID_Поставщик";
            this.iDПоставщикDataGridViewTextBoxColumn.HeaderText = "ID_Поставщик";
            this.iDПоставщикDataGridViewTextBoxColumn.Name = "iDПоставщикDataGridViewTextBoxColumn";
            // 
            // ценаЗакупкиDataGridViewTextBoxColumn
            // 
            this.ценаЗакупкиDataGridViewTextBoxColumn.DataPropertyName = "ЦенаЗакупки";
            this.ценаЗакупкиDataGridViewTextBoxColumn.HeaderText = "ЦенаЗакупки";
            this.ценаЗакупкиDataGridViewTextBoxColumn.Name = "ценаЗакупкиDataGridViewTextBoxColumn";
            // 
            // начальныйОстатокDataGridViewTextBoxColumn
            // 
            this.начальныйОстатокDataGridViewTextBoxColumn.DataPropertyName = "НачальныйОстаток";
            this.начальныйОстатокDataGridViewTextBoxColumn.HeaderText = "НачальныйОстаток";
            this.начальныйОстатокDataGridViewTextBoxColumn.Name = "начальныйОстатокDataGridViewTextBoxColumn";
            // 
            // пРОБАDataGridViewTextBoxColumn
            // 
            this.пРОБАDataGridViewTextBoxColumn.DataPropertyName = "ПРОБА";
            this.пРОБАDataGridViewTextBoxColumn.HeaderText = "ПРОБА";
            this.пРОБАDataGridViewTextBoxColumn.Name = "пРОБАDataGridViewTextBoxColumn";
            // 
            // факт1DataGridViewTextBoxColumn
            // 
            this.факт1DataGridViewTextBoxColumn.DataPropertyName = "Факт1";
            this.факт1DataGridViewTextBoxColumn.HeaderText = "Факт1";
            this.факт1DataGridViewTextBoxColumn.Name = "факт1DataGridViewTextBoxColumn";
            // 
            // свободный1DataGridViewTextBoxColumn
            // 
            this.свободный1DataGridViewTextBoxColumn.DataPropertyName = "Свободный1";
            this.свободный1DataGridViewTextBoxColumn.HeaderText = "Свободный1";
            this.свободный1DataGridViewTextBoxColumn.Name = "свободный1DataGridViewTextBoxColumn";
            // 
            // инвентураDataGridViewTextBoxColumn
            // 
            this.инвентураDataGridViewTextBoxColumn.DataPropertyName = "Инвентура";
            this.инвентураDataGridViewTextBoxColumn.HeaderText = "Инвентура";
            this.инвентураDataGridViewTextBoxColumn.Name = "инвентураDataGridViewTextBoxColumn";
            // 
            // факт2DataGridViewTextBoxColumn
            // 
            this.факт2DataGridViewTextBoxColumn.DataPropertyName = "Факт2";
            this.факт2DataGridViewTextBoxColumn.HeaderText = "Факт2";
            this.факт2DataGridViewTextBoxColumn.Name = "факт2DataGridViewTextBoxColumn";
            // 
            // свободный2DataGridViewTextBoxColumn
            // 
            this.свободный2DataGridViewTextBoxColumn.DataPropertyName = "Свободный2";
            this.свободный2DataGridViewTextBoxColumn.HeaderText = "Свободный2";
            this.свободный2DataGridViewTextBoxColumn.Name = "свободный2DataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(613, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 484);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(958, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 539);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MG_WEB_2003DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _MG_WEB_2003DataSet _MG_WEB_2003DataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private _MG_WEB_2003DataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn товарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn массаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоВКоробкеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn остатокНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сортировкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn переходDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоБонусаТоварногоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процентБонусаТоварногоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПоставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаЗакупкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn начальныйОстатокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пРОБАDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факт1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn свободный1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn инвентураDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факт2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn свободный2DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

