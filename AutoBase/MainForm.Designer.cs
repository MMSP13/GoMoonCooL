﻿namespace AutoBase
{
    partial class MainForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnCarList = new System.Windows.Forms.Button();
            this.btnListEngine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 786);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(414, 388);
            this.dgvData.TabIndex = 1;
            // 
            // btnCarList
            // 
            this.btnCarList.Location = new System.Drawing.Point(12, 406);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(75, 23);
            this.btnCarList.TabIndex = 2;
            this.btnCarList.Text = "Emitent";
            this.btnCarList.UseVisualStyleBackColor = true;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // btnListEngine
            // 
            this.btnListEngine.Location = new System.Drawing.Point(93, 406);
            this.btnListEngine.Name = "btnListEngine";
            this.btnListEngine.Size = new System.Drawing.Size(75, 23);
            this.btnListEngine.TabIndex = 3;
            this.btnListEngine.Text = "Aktsii";
            this.btnListEngine.UseVisualStyleBackColor = true;
            this.btnListEngine.Click += new System.EventHandler(this.btnListEngine_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(439, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListEngine);
            this.Controls.Add(this.btnCarList);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "База акций";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Button btnListEngine;
        private System.Windows.Forms.Button button1;
    }
}

