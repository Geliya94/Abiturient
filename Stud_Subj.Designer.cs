namespace Abiturient
{
    partial class Stud_Subj
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
            this.DGV_studsubj = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_studsubj)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGV_studsubj
            // 
            this.DGV_studsubj.AllowUserToAddRows = false;
            this.DGV_studsubj.AllowUserToDeleteRows = false;
            this.DGV_studsubj.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_studsubj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_studsubj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_st,
            this.ID_sub,
            this.Scores});
            this.DGV_studsubj.Location = new System.Drawing.Point(12, 41);
            this.DGV_studsubj.Name = "DGV_studsubj";
            this.DGV_studsubj.ReadOnly = true;
            this.DGV_studsubj.Size = new System.Drawing.Size(637, 428);
            this.DGV_studsubj.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ID_st
            // 
            this.ID_st.HeaderText = "ID_st";
            this.ID_st.Name = "ID_st";
            this.ID_st.ReadOnly = true;
            // 
            // ID_sub
            // 
            this.ID_sub.HeaderText = "ID_sub";
            this.ID_sub.Name = "ID_sub";
            this.ID_sub.ReadOnly = true;
            // 
            // Scores
            // 
            this.Scores.HeaderText = "Scores";
            this.Scores.Name = "Scores";
            this.Scores.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stud_Subj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DGV_studsubj);
            this.Controls.Add(this.button1);
            this.Name = "Stud_Subj";
            this.Text = "Студент-Предмет";
            this.Load += new System.EventHandler(this.Stud_Subj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_studsubj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV_studsubj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scores;
        private System.Windows.Forms.Button button2;
    }
}