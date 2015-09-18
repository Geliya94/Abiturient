namespace Abiturient
{
    partial class Priority
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
            this.btn_gen = new System.Windows.Forms.Button();
            this.DGC_priority = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGC_priority)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_gen);
            this.groupBox1.Controls.Add(this.DGC_priority);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 493);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(16, 19);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(101, 23);
            this.btn_gen.TabIndex = 0;
            this.btn_gen.Text = "Сгенерирвоать";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // DGC_priority
            // 
            this.DGC_priority.AllowUserToAddRows = false;
            this.DGC_priority.AllowUserToDeleteRows = false;
            this.DGC_priority.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGC_priority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGC_priority.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_specialty,
            this.ID_subject,
            this.prior,
            this.sum});
            this.DGC_priority.Location = new System.Drawing.Point(16, 48);
            this.DGC_priority.Name = "DGC_priority";
            this.DGC_priority.ReadOnly = true;
            this.DGC_priority.Size = new System.Drawing.Size(687, 439);
            this.DGC_priority.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ID_specialty
            // 
            this.ID_specialty.HeaderText = "ID_stud";
            this.ID_specialty.Name = "ID_specialty";
            this.ID_specialty.ReadOnly = true;
            // 
            // ID_subject
            // 
            this.ID_subject.HeaderText = "ID_spec";
            this.ID_subject.Name = "ID_subject";
            this.ID_subject.ReadOnly = true;
            // 
            // prior
            // 
            this.prior.HeaderText = "prior";
            this.prior.Name = "prior";
            this.prior.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.HeaderText = "sum";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // Priority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 517);
            this.Controls.Add(this.groupBox1);
            this.Name = "Priority";
            this.Text = "Priority";
            this.Load += new System.EventHandler(this.Priority_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGC_priority)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.DataGridView DGC_priority;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn prior;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
    }
}