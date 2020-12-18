using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EIS.Forms
{
    partial class  FormUpdateSettings
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Field6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Field4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Field2 = new System.Windows.Forms.Button();
            this.Field1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Field6
            // 
            this.Field6.AutoSize = true;
            this.Field6.Location = new System.Drawing.Point(12, 9);
            this.Field6.Name = "Field6";
            this.Field6.Size = new System.Drawing.Size(102, 13);
            this.Field6.TabIndex = 0;
            this.Field6.Text = "Папка обновлений";
            // 
            // Field5
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "Field5";
            this.textBox1.Size = new System.Drawing.Size(384, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Field4
            // 
            this.Field4.AutoSize = true;
            this.Field4.Location = new System.Drawing.Point(12, 48);
            this.Field4.Name = "Field4";
            this.Field4.Size = new System.Drawing.Size(112, 13);
            this.Field4.TabIndex = 2;
            this.Field4.Text = "Частота обновлений";
            // 
            // Field3
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 64);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "Field3";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Field2
            // 
            this.Field2.Location = new System.Drawing.Point(15, 123);
            this.Field2.Name = "Field2";
            this.Field2.Size = new System.Drawing.Size(75, 23);
            this.Field2.TabIndex = 4;
            this.Field2.Text = "Сохранить";
            this.Field2.UseVisualStyleBackColor = true;
            this.Field2.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Field1
            // 
            this.Field1.Location = new System.Drawing.Point(322, 123);
            this.Field1.Name = "Field1";
            this.Field1.Size = new System.Drawing.Size(75, 23);
            this.Field1.TabIndex = 5;
            this.Field1.Text = "Закрыть";
            this.Field1.UseVisualStyleBackColor = true;
            this.Field1.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormUpdateSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 158);
            this.Controls.Add(this.Field1);
            this.Controls.Add(this.Field2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Field4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Field6);
            this.Name = "FormUpdateSettings";
            this.Text = "Настройки обновления";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
       
        private Label Field6;
        private TextBox textBox1;
        private Label Field4;
        private NumericUpDown numericUpDown1;
        private Button Field2;
        private Button Field1;
    }
}
