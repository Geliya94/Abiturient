namespace Abiturient
{
    partial class Abiturient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_abit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_abiturient = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_generation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_abiturient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TB_abit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DGV_abiturient);
            this.groupBox1.Controls.Add(this.BTN_generation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 542);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TB_abit
            // 
            this.TB_abit.Location = new System.Drawing.Point(232, 17);
            this.TB_abit.Name = "TB_abit";
            this.TB_abit.Size = new System.Drawing.Size(100, 20);
            this.TB_abit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите количество студентов";
            // 
            // DGV_abiturient
            // 
            this.DGV_abiturient.AllowUserToAddRows = false;
            this.DGV_abiturient.AllowUserToDeleteRows = false;
            this.DGV_abiturient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_abiturient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_abiturient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FIO});
            this.DGV_abiturient.Location = new System.Drawing.Point(15, 128);
            this.DGV_abiturient.Name = "DGV_abiturient";
            this.DGV_abiturient.ReadOnly = true;
            this.DGV_abiturient.Size = new System.Drawing.Size(459, 396);
            this.DGV_abiturient.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "FIO";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 200;
            // 
            // BTN_generation
            // 
            this.BTN_generation.Location = new System.Drawing.Point(15, 52);
            this.BTN_generation.Name = "BTN_generation";
            this.BTN_generation.Size = new System.Drawing.Size(223, 23);
            this.BTN_generation.TabIndex = 0;
            this.BTN_generation.Text = "Сгенерировать список абитуриентов";
            this.BTN_generation.UseVisualStyleBackColor = true;
            this.BTN_generation.Click += new System.EventHandler(this.BTN_generation_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abiturient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 566);
            this.Controls.Add(this.groupBox1);
            this.Name = "Abiturient";
            this.Text = "Список абитуриентов";
            this.Load += new System.EventHandler(this.Abiturient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_abiturient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_generation;
        private System.Windows.Forms.DataGridView DGV_abiturient;
        private System.Windows.Forms.TextBox TB_abit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.Button button1;
    }
}