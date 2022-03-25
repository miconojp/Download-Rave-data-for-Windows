namespace RWSapp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExStudyName = new System.Windows.Forms.TextBox();
            this.ExStudyEnv = new System.Windows.Forms.TextBox();
            this.ExForms = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ExFilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            // 
            // ExStudyName
            // 
            this.ExStudyName.Location = new System.Drawing.Point(32, 82);
            this.ExStudyName.Name = "ExStudyName";
            this.ExStudyName.Size = new System.Drawing.Size(180, 19);
            this.ExStudyName.TabIndex = 2;
            // 
            // ExStudyEnv
            // 
            this.ExStudyEnv.Location = new System.Drawing.Point(236, 82);
            this.ExStudyEnv.Name = "ExStudyEnv";
            this.ExStudyEnv.Size = new System.Drawing.Size(74, 19);
            this.ExStudyEnv.TabIndex = 3;
            // 
            // ExForms
            // 
            this.ExForms.Location = new System.Drawing.Point(329, 82);
            this.ExForms.Multiline = true;
            this.ExForms.Name = "ExForms";
            this.ExForms.Size = new System.Drawing.Size(142, 108);
            this.ExForms.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(477, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Study Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Env";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Export Forms";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(477, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Check ALL";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ExFilePath
            // 
            this.ExFilePath.Location = new System.Drawing.Point(32, 229);
            this.ExFilePath.Name = "ExFilePath";
            this.ExFilePath.Size = new System.Drawing.Size(542, 19);
            this.ExFilePath.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Export path";
            // 
            // ExStart
            // 
            this.ExStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExStart.Location = new System.Drawing.Point(329, 259);
            this.ExStart.Name = "ExStart";
            this.ExStart.Size = new System.Drawing.Size(124, 23);
            this.ExStart.TabIndex = 14;
            this.ExStart.Text = "Export Start";
            this.ExStart.UseVisualStyleBackColor = true;
            this.ExStart.Click += new System.EventHandler(this.ExStart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "RWS Export CSV tool";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 294);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ExStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExFilePath);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ExForms);
            this.Controls.Add(this.ExStudyEnv);
            this.Controls.Add(this.ExStudyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExStudyName;
        private System.Windows.Forms.TextBox ExStudyEnv;
        private System.Windows.Forms.TextBox ExForms;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ExFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExStart;
        private System.Windows.Forms.Label label6;
    }
}

