﻿namespace Abiturient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_priority = new System.Windows.Forms.Button();
            this.BTN_abitsubj = new System.Windows.Forms.Button();
            this.BTN_specsubj = new System.Windows.Forms.Button();
            this.BTN_specialty = new System.Windows.Forms.Button();
            this.BTN_subject = new System.Windows.Forms.Button();
            this.BTN_abiturient = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BTN_priority);
            this.groupBox1.Controls.Add(this.BTN_abitsubj);
            this.groupBox1.Controls.Add(this.BTN_specsubj);
            this.groupBox1.Controls.Add(this.BTN_specialty);
            this.groupBox1.Controls.Add(this.BTN_subject);
            this.groupBox1.Controls.Add(this.BTN_abiturient);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сгенерировать таблицы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_priority
            // 
            this.BTN_priority.Location = new System.Drawing.Point(861, 19);
            this.BTN_priority.Name = "BTN_priority";
            this.BTN_priority.Size = new System.Drawing.Size(140, 30);
            this.BTN_priority.TabIndex = 5;
            this.BTN_priority.Text = "Приоритет";
            this.BTN_priority.UseVisualStyleBackColor = true;
            this.BTN_priority.Click += new System.EventHandler(this.BTN_priority_Click);
            // 
            // BTN_abitsubj
            // 
            this.BTN_abitsubj.Location = new System.Drawing.Point(688, 19);
            this.BTN_abitsubj.Name = "BTN_abitsubj";
            this.BTN_abitsubj.Size = new System.Drawing.Size(140, 30);
            this.BTN_abitsubj.TabIndex = 4;
            this.BTN_abitsubj.Text = "Абитуриент-Предмет";
            this.BTN_abitsubj.UseVisualStyleBackColor = true;
            this.BTN_abitsubj.Click += new System.EventHandler(this.BTN_abitsubj_Click);
            // 
            // BTN_specsubj
            // 
            this.BTN_specsubj.Location = new System.Drawing.Point(511, 19);
            this.BTN_specsubj.Name = "BTN_specsubj";
            this.BTN_specsubj.Size = new System.Drawing.Size(152, 30);
            this.BTN_specsubj.TabIndex = 3;
            this.BTN_specsubj.Text = "Специальность-Предмет";
            this.BTN_specsubj.UseVisualStyleBackColor = true;
            this.BTN_specsubj.Click += new System.EventHandler(this.BTN_specsubj_Click);
            // 
            // BTN_specialty
            // 
            this.BTN_specialty.Location = new System.Drawing.Point(341, 19);
            this.BTN_specialty.Name = "BTN_specialty";
            this.BTN_specialty.Size = new System.Drawing.Size(140, 30);
            this.BTN_specialty.TabIndex = 2;
            this.BTN_specialty.Text = "Специальность";
            this.BTN_specialty.UseVisualStyleBackColor = true;
            this.BTN_specialty.Click += new System.EventHandler(this.BTN_specialty_Click);
            // 
            // BTN_subject
            // 
            this.BTN_subject.Location = new System.Drawing.Point(174, 19);
            this.BTN_subject.Name = "BTN_subject";
            this.BTN_subject.Size = new System.Drawing.Size(140, 30);
            this.BTN_subject.TabIndex = 1;
            this.BTN_subject.Text = "Предмет";
            this.BTN_subject.UseVisualStyleBackColor = true;
            this.BTN_subject.Click += new System.EventHandler(this.BTN_subject_Click);
            // 
            // BTN_abiturient
            // 
            this.BTN_abiturient.Location = new System.Drawing.Point(6, 19);
            this.BTN_abiturient.Name = "BTN_abiturient";
            this.BTN_abiturient.Size = new System.Drawing.Size(140, 30);
            this.BTN_abiturient.TabIndex = 0;
            this.BTN_abiturient.Text = "Абитуриенты";
            this.BTN_abiturient.UseVisualStyleBackColor = true;
            this.BTN_abiturient.Click += new System.EventHandler(this.BTN_abiturient_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 410);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(993, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Спец1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(993, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спец2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(993, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Спец3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(993, 384);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Спец4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(993, 384);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Спец5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 544);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Приемная комиссия";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_priority;
        private System.Windows.Forms.Button BTN_abitsubj;
        private System.Windows.Forms.Button BTN_specsubj;
        private System.Windows.Forms.Button BTN_specialty;
        private System.Windows.Forms.Button BTN_subject;
        private System.Windows.Forms.Button BTN_abiturient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button2;
    }
}

