namespace Abiturient
{
    partial class Spec_Subj
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
            this.button1 = new System.Windows.Forms.Button();
            this.DGC_specsubj = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGC_specsubj)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGC_specsubj
            // 
            this.DGC_specsubj.AllowUserToAddRows = false;
            this.DGC_specsubj.AllowUserToDeleteRows = false;
            this.DGC_specsubj.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGC_specsubj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGC_specsubj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_specialty,
            this.ID_subject});
            this.DGC_specsubj.Location = new System.Drawing.Point(16, 48);
            this.DGC_specsubj.Name = "DGC_specsubj";
            this.DGC_specsubj.ReadOnly = true;
            this.DGC_specsubj.Size = new System.Drawing.Size(603, 391);
            this.DGC_specsubj.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ID_specialty
            // 
            this.ID_specialty.HeaderText = "Column1";
            this.ID_specialty.Name = "ID_specialty";
            this.ID_specialty.ReadOnly = true;
            // 
            // ID_subject
            // 
            this.ID_subject.HeaderText = "Column1";
            this.ID_subject.Name = "ID_subject";
            this.ID_subject.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DGC_specsubj);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 445);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Spec_Subj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 469);
            this.Controls.Add(this.groupBox1);
            this.Name = "Spec_Subj";
            this.Text = "Специальность-Предмет";
            this.Load += new System.EventHandler(this.Spec_Subj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGC_specsubj)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGC_specsubj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_subject;
    }
}