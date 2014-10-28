namespace os_lab_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxFirstFolder = new System.Windows.Forms.TextBox();
            this.txbxSecondFolder = new System.Windows.Forms.TextBox();
            this.btnObzor = new System.Windows.Forms.Button();
            this.btnObzor2 = new System.Windows.Forms.Button();
            this.txbxRes1 = new System.Windows.Forms.TextBox();
            this.txbxRes2 = new System.Windows.Forms.TextBox();
            this.btnGoSearch = new System.Windows.Forms.Button();
            this.btnClearRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первая папка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вторая папка";
            // 
            // txbxFirstFolder
            // 
            this.txbxFirstFolder.Location = new System.Drawing.Point(16, 29);
            this.txbxFirstFolder.Name = "txbxFirstFolder";
            this.txbxFirstFolder.Size = new System.Drawing.Size(305, 20);
            this.txbxFirstFolder.TabIndex = 2;
            // 
            // txbxSecondFolder
            // 
            this.txbxSecondFolder.Location = new System.Drawing.Point(16, 79);
            this.txbxSecondFolder.Name = "txbxSecondFolder";
            this.txbxSecondFolder.Size = new System.Drawing.Size(305, 20);
            this.txbxSecondFolder.TabIndex = 3;
            // 
            // btnObzor
            // 
            this.btnObzor.Location = new System.Drawing.Point(344, 29);
            this.btnObzor.Name = "btnObzor";
            this.btnObzor.Size = new System.Drawing.Size(75, 23);
            this.btnObzor.TabIndex = 4;
            this.btnObzor.Text = "Обзор";
            this.btnObzor.UseVisualStyleBackColor = true;
            this.btnObzor.Click += new System.EventHandler(this.btnObzor_Click);
            // 
            // btnObzor2
            // 
            this.btnObzor2.Location = new System.Drawing.Point(344, 76);
            this.btnObzor2.Name = "btnObzor2";
            this.btnObzor2.Size = new System.Drawing.Size(75, 23);
            this.btnObzor2.TabIndex = 5;
            this.btnObzor2.Text = "Обзор";
            this.btnObzor2.UseVisualStyleBackColor = true;
            this.btnObzor2.Click += new System.EventHandler(this.btnObzor2_Click);
            // 
            // txbxRes1
            // 
            this.txbxRes1.Location = new System.Drawing.Point(16, 134);
            this.txbxRes1.Multiline = true;
            this.txbxRes1.Name = "txbxRes1";
            this.txbxRes1.Size = new System.Drawing.Size(196, 233);
            this.txbxRes1.TabIndex = 6;
            // 
            // txbxRes2
            // 
            this.txbxRes2.Location = new System.Drawing.Point(218, 134);
            this.txbxRes2.Multiline = true;
            this.txbxRes2.Name = "txbxRes2";
            this.txbxRes2.Size = new System.Drawing.Size(201, 233);
            this.txbxRes2.TabIndex = 7;
            // 
            // btnGoSearch
            // 
            this.btnGoSearch.Location = new System.Drawing.Point(137, 105);
            this.btnGoSearch.Name = "btnGoSearch";
            this.btnGoSearch.Size = new System.Drawing.Size(75, 23);
            this.btnGoSearch.TabIndex = 8;
            this.btnGoSearch.Text = "Поиск";
            this.btnGoSearch.UseVisualStyleBackColor = true;
            this.btnGoSearch.Click += new System.EventHandler(this.btnGoSearch_Click);
            // 
            // btnClearRes
            // 
            this.btnClearRes.Location = new System.Drawing.Point(218, 105);
            this.btnClearRes.Name = "btnClearRes";
            this.btnClearRes.Size = new System.Drawing.Size(75, 23);
            this.btnClearRes.TabIndex = 9;
            this.btnClearRes.Text = "Очистить";
            this.btnClearRes.UseVisualStyleBackColor = true;
            this.btnClearRes.Click += new System.EventHandler(this.btnClearRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 383);
            this.Controls.Add(this.btnClearRes);
            this.Controls.Add(this.btnGoSearch);
            this.Controls.Add(this.txbxRes2);
            this.Controls.Add(this.txbxRes1);
            this.Controls.Add(this.btnObzor2);
            this.Controls.Add(this.btnObzor);
            this.Controls.Add(this.txbxSecondFolder);
            this.Controls.Add(this.txbxFirstFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Поиск файлов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxFirstFolder;
        private System.Windows.Forms.TextBox txbxSecondFolder;
        private System.Windows.Forms.Button btnObzor;
        private System.Windows.Forms.Button btnObzor2;
        private System.Windows.Forms.TextBox txbxRes1;
        private System.Windows.Forms.TextBox txbxRes2;
        private System.Windows.Forms.Button btnGoSearch;
        private System.Windows.Forms.Button btnClearRes;
    }
}

