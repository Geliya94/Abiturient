namespace Abiturient
{
    partial class Subject
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
            this.DGV_subject = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_generation = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subjectcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_subject)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_abit);
            this.groupBox1.Controls.Add(this.DGV_subject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTN_generation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TB_abit
            // 
            this.TB_abit.Location = new System.Drawing.Point(240, 24);
            this.TB_abit.Name = "TB_abit";
            this.TB_abit.Size = new System.Drawing.Size(100, 20);
            this.TB_abit.TabIndex = 6;
            // 
            // DGV_subject
            // 
            this.DGV_subject.AllowUserToAddRows = false;
            this.DGV_subject.AllowUserToDeleteRows = false;
            this.DGV_subject.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_subject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Subjectcol});
            this.DGV_subject.Location = new System.Drawing.Point(19, 85);
            this.DGV_subject.Name = "DGV_subject";
            this.DGV_subject.ReadOnly = true;
            this.DGV_subject.Size = new System.Drawing.Size(389, 228);
            this.DGV_subject.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите количество предметов";
            // 
            // BTN_generation
            // 
            this.BTN_generation.Location = new System.Drawing.Point(23, 56);
            this.BTN_generation.Name = "BTN_generation";
            this.BTN_generation.Size = new System.Drawing.Size(204, 23);
            this.BTN_generation.TabIndex = 0;
            this.BTN_generation.Text = "Сгенерировать список предметов";
            this.BTN_generation.UseVisualStyleBackColor = true;
            this.BTN_generation.Click += new System.EventHandler(this.BTN_generation_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Subjectcol
            // 
            this.Subjectcol.HeaderText = "Наименование предмета";
            this.Subjectcol.Name = "Subjectcol";
            this.Subjectcol.ReadOnly = true;
            this.Subjectcol.Width = 200;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 348);
            this.Controls.Add(this.groupBox1);
            this.Name = "Subject";
            this.Text = "Список предметов";
            this.Load += new System.EventHandler(this.Subject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_subject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_subject;
        private System.Windows.Forms.Button BTN_generation;
        private System.Windows.Forms.TextBox TB_abit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subjectcol;
    }
}