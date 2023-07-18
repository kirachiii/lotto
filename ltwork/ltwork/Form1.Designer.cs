namespace ltwork
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn隨機 = new System.Windows.Forms.Button();
            this.lab主要顯示 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lab副顯示區域 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab第二區 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn自選號碼 = new System.Windows.Forms.Button();
            this.lab自選號碼 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn對獎 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn產生隨機號碼 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn隨機
            // 
            this.btn隨機.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn隨機.Location = new System.Drawing.Point(12, 504);
            this.btn隨機.Name = "btn隨機";
            this.btn隨機.Size = new System.Drawing.Size(156, 90);
            this.btn隨機.TabIndex = 0;
            this.btn隨機.Text = "產生開獎號碼";
            this.btn隨機.UseVisualStyleBackColor = true;
            this.btn隨機.Click += new System.EventHandler(this.btn隨機_Click);
            // 
            // lab主要顯示
            // 
            this.lab主要顯示.BackColor = System.Drawing.Color.Green;
            this.lab主要顯示.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab主要顯示.Location = new System.Drawing.Point(12, 59);
            this.lab主要顯示.Name = "lab主要顯示";
            this.lab主要顯示.Size = new System.Drawing.Size(352, 90);
            this.lab主要顯示.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1154, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab副顯示區域
            // 
            this.lab副顯示區域.BackColor = System.Drawing.Color.Green;
            this.lab副顯示區域.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab副顯示區域.Location = new System.Drawing.Point(12, 238);
            this.lab副顯示區域.Name = "lab副顯示區域";
            this.lab副顯示區域.Size = new System.Drawing.Size(352, 90);
            this.lab副顯示區域.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "開出順序";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(110, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "大小順序";
            // 
            // lab第二區
            // 
            this.lab第二區.BackColor = System.Drawing.Color.DarkRed;
            this.lab第二區.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab第二區.ForeColor = System.Drawing.Color.White;
            this.lab第二區.Location = new System.Drawing.Point(12, 393);
            this.lab第二區.Name = "lab第二區";
            this.lab第二區.Size = new System.Drawing.Size(127, 90);
            this.lab第二區.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(13, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "第二區";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn自選號碼
            // 
            this.btn自選號碼.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn自選號碼.Location = new System.Drawing.Point(662, 75);
            this.btn自選號碼.Name = "btn自選號碼";
            this.btn自選號碼.Size = new System.Drawing.Size(156, 90);
            this.btn自選號碼.TabIndex = 9;
            this.btn自選號碼.Text = "輸入自選號碼";
            this.btn自選號碼.UseVisualStyleBackColor = true;
            this.btn自選號碼.Click += new System.EventHandler(this.btn自選號碼_Click);
            // 
            // lab自選號碼
            // 
            this.lab自選號碼.BackColor = System.Drawing.Color.Yellow;
            this.lab自選號碼.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab自選號碼.ForeColor = System.Drawing.Color.Black;
            this.lab自選號碼.Location = new System.Drawing.Point(1008, 75);
            this.lab自選號碼.Name = "lab自選號碼";
            this.lab自選號碼.Size = new System.Drawing.Size(235, 75);
            this.lab自選號碼.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(862, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 522);
            this.listBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(975, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "自選記錄";
            // 
            // btn對獎
            // 
            this.btn對獎.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn對獎.Location = new System.Drawing.Point(462, 507);
            this.btn對獎.Name = "btn對獎";
            this.btn對獎.Size = new System.Drawing.Size(156, 90);
            this.btn對獎.TabIndex = 13;
            this.btn對獎.Text = "對獎!";
            this.btn對獎.UseVisualStyleBackColor = true;
            this.btn對獎.Click += new System.EventHandler(this.btn對獎_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("新細明體", 30F);
            this.label5.Location = new System.Drawing.Point(380, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 279);
            this.label5.TabIndex = 14;
            // 
            // btn產生隨機號碼
            // 
            this.btn產生隨機號碼.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn產生隨機號碼.Location = new System.Drawing.Point(662, 192);
            this.btn產生隨機號碼.Name = "btn產生隨機號碼";
            this.btn產生隨機號碼.Size = new System.Drawing.Size(156, 90);
            this.btn產生隨機號碼.TabIndex = 15;
            this.btn產生隨機號碼.Text = "產生隨機號碼";
            this.btn產生隨機號碼.UseVisualStyleBackColor = true;
            this.btn產生隨機號碼.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 646);
            this.Controls.Add(this.btn產生隨機號碼);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn對獎);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lab自選號碼);
            this.Controls.Add(this.btn自選號碼);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab第二區);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab副顯示區域);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab主要顯示);
            this.Controls.Add(this.btn隨機);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn隨機;
        private System.Windows.Forms.Label lab主要顯示;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab副顯示區域;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab第二區;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn自選號碼;
        private System.Windows.Forms.Label lab自選號碼;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn對獎;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn產生隨機號碼;
    }
}

