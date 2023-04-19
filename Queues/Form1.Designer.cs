
namespace Queues
{
    partial class Queue
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nNumber = new System.Windows.Forms.TextBox();
            this.outputQueue = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.Task3 = new System.Windows.Forms.Panel();
            this.Task4 = new System.Windows.Forms.Panel();
            this.workerAge = new System.Windows.Forms.TextBox();
            this.showInfo = new System.Windows.Forms.Button();
            this.workerInfo = new System.Windows.Forms.Label();
            this.Task5 = new System.Windows.Forms.Panel();
            this.showSortInfo = new System.Windows.Forms.Button();
            this.sortedListOfWorkers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Task3.SuspendLayout();
            this.Task4.SuspendLayout();
            this.Task5.SuspendLayout();
            this.SuspendLayout();
            // 
            // nNumber
            // 
            this.nNumber.Location = new System.Drawing.Point(29, 70);
            this.nNumber.Name = "nNumber";
            this.nNumber.Size = new System.Drawing.Size(166, 20);
            this.nNumber.TabIndex = 0;
            // 
            // outputQueue
            // 
            this.outputQueue.AutoSize = true;
            this.outputQueue.Location = new System.Drawing.Point(26, 54);
            this.outputQueue.Name = "outputQueue";
            this.outputQueue.Size = new System.Drawing.Size(56, 13);
            this.outputQueue.TabIndex = 1;
            this.outputQueue.Text = "Очередь: ";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(29, 96);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(166, 23);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Ввод";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Task3
            // 
            this.Task3.Controls.Add(this.nNumber);
            this.Task3.Controls.Add(this.calculate);
            this.Task3.Controls.Add(this.outputQueue);
            this.Task3.Location = new System.Drawing.Point(12, 54);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(223, 133);
            this.Task3.TabIndex = 3;
            // 
            // Task4
            // 
            this.Task4.Controls.Add(this.workerAge);
            this.Task4.Controls.Add(this.showInfo);
            this.Task4.Controls.Add(this.workerInfo);
            this.Task4.Location = new System.Drawing.Point(12, 220);
            this.Task4.Name = "Task4";
            this.Task4.Size = new System.Drawing.Size(255, 200);
            this.Task4.TabIndex = 4;
            // 
            // workerAge
            // 
            this.workerAge.Location = new System.Drawing.Point(42, 140);
            this.workerAge.Name = "workerAge";
            this.workerAge.Size = new System.Drawing.Size(166, 20);
            this.workerAge.TabIndex = 0;
            // 
            // showInfo
            // 
            this.showInfo.Location = new System.Drawing.Point(42, 166);
            this.showInfo.Name = "showInfo";
            this.showInfo.Size = new System.Drawing.Size(166, 23);
            this.showInfo.TabIndex = 2;
            this.showInfo.Text = "Ввод";
            this.showInfo.UseVisualStyleBackColor = true;
            this.showInfo.Click += new System.EventHandler(this.showInfo_Click);
            // 
            // workerInfo
            // 
            this.workerInfo.AutoSize = true;
            this.workerInfo.Location = new System.Drawing.Point(39, 16);
            this.workerInfo.Name = "workerInfo";
            this.workerInfo.Size = new System.Drawing.Size(44, 13);
            this.workerInfo.TabIndex = 1;
            this.workerInfo.Text = "Список";
            // 
            // Task5
            // 
            this.Task5.Controls.Add(this.showSortInfo);
            this.Task5.Controls.Add(this.sortedListOfWorkers);
            this.Task5.Location = new System.Drawing.Point(334, 54);
            this.Task5.Name = "Task5";
            this.Task5.Size = new System.Drawing.Size(316, 200);
            this.Task5.TabIndex = 5;
            // 
            // showSortInfo
            // 
            this.showSortInfo.Location = new System.Drawing.Point(73, 156);
            this.showSortInfo.Name = "showSortInfo";
            this.showSortInfo.Size = new System.Drawing.Size(166, 23);
            this.showSortInfo.TabIndex = 2;
            this.showSortInfo.Text = "Вывод";
            this.showSortInfo.UseVisualStyleBackColor = true;
            this.showSortInfo.Click += new System.EventHandler(this.showSortInfo_Click);
            // 
            // sortedListOfWorkers
            // 
            this.sortedListOfWorkers.AutoSize = true;
            this.sortedListOfWorkers.Location = new System.Drawing.Point(17, 17);
            this.sortedListOfWorkers.Name = "sortedListOfWorkers";
            this.sortedListOfWorkers.Size = new System.Drawing.Size(44, 13);
            this.sortedListOfWorkers.TabIndex = 1;
            this.sortedListOfWorkers.Text = "Список";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Задание 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(329, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Задание 5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Задание 4";
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Task5);
            this.Controls.Add(this.Task4);
            this.Controls.Add(this.Task3);
            this.Name = "Queue";
            this.Text = "Queue";
            this.Task3.ResumeLayout(false);
            this.Task3.PerformLayout();
            this.Task4.ResumeLayout(false);
            this.Task4.PerformLayout();
            this.Task5.ResumeLayout(false);
            this.Task5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nNumber;
        private System.Windows.Forms.Label outputQueue;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Panel Task3;
        private System.Windows.Forms.Panel Task4;
        private System.Windows.Forms.TextBox workerAge;
        private System.Windows.Forms.Button showInfo;
        private System.Windows.Forms.Label workerInfo;
        private System.Windows.Forms.Panel Task5;
        private System.Windows.Forms.Button showSortInfo;
        private System.Windows.Forms.Label sortedListOfWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

