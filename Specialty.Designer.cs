namespace Abiturient
{
    partial class Specialty
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

            this.TB_abit = new System.Windows.Forms.TextBox();
            this.DGV_specialty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_generation = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialtycl = new System.Windows.Forms.DataGridViewTextBoxColumn();
         
 
            ((System.ComponentModel.ISupportInitialize)(this.DGV_specialty)).BeginInit();
            this.SuspendLayout();
            // 

            // 
            // TB_abit
            // 
            this.TB_abit.Location = new System.Drawing.Point(219, 19);
            this.TB_abit.Name = "TB_abit";
            this.TB_abit.Size = new System.Drawing.Size(80, 20);
            this.TB_abit.TabIndex = 8;
            // 
            // DGV_specialty
            // 
            this.DGV_specialty.AllowUserToAddRows = false;
            this.DGV_specialty.AllowUserToDeleteRows = false;
            this.DGV_specialty.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_specialty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_specialty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Specialtycl,

 

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите количество специальностей";
            // 
            // BTN_generation
            // 
            this.BTN_generation.Location = new System.Drawing.Point(16, 48);
            this.BTN_generation.Name = "BTN_generation";
            this.BTN_generation.Size = new System.Drawing.Size(115, 23);
            this.BTN_generation.TabIndex = 0;
            this.BTN_generation.Text = "Сгенерировать";
            this.BTN_generation.UseVisualStyleBackColor = true;
            this.BTN_generation.Click += new System.EventHandler(this.BTN_generation_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Specialtycl
            // 
            this.Specialtycl.HeaderText = "Специальность";
            this.Specialtycl.Name = "Specialtycl";
            this.Specialtycl.ReadOnly = true;
            // 
            // Amount
            // 

            // 
            // Specialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 475);
    
            this.Name = "Specialty";
            this.Text = "Список специальностей";
            this.Load += new System.EventHandler(this.Specialty_Load);

            ((System.ComponentModel.ISupportInitialize)(this.DGV_specialty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_specialty;
        private System.Windows.Forms.Button BTN_generation;
        private System.Windows.Forms.TextBox TB_abit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialtycl;
    }
}