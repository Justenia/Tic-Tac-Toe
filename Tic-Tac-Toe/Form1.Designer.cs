
namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnX1 = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.btnY1 = new System.Windows.Forms.Button();
            this.btnY2 = new System.Windows.Forms.Button();
            this.btnY3 = new System.Windows.Forms.Button();
            this.btnZ1 = new System.Windows.Forms.Button();
            this.btnZ2 = new System.Windows.Forms.Button();
            this.btnZ3 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnX1
            // 
            this.btnX1.Location = new System.Drawing.Point(40, 43);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(104, 88);
            this.btnX1.TabIndex = 0;
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnX2
            // 
            this.btnX2.Location = new System.Drawing.Point(145, 43);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(104, 88);
            this.btnX2.TabIndex = 1;
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnX3
            // 
            this.btnX3.Location = new System.Drawing.Point(250, 43);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(104, 88);
            this.btnX3.TabIndex = 2;
            this.btnX3.UseVisualStyleBackColor = true;
            this.btnX3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnY1
            // 
            this.btnY1.Location = new System.Drawing.Point(40, 132);
            this.btnY1.Name = "btnY1";
            this.btnY1.Size = new System.Drawing.Size(104, 88);
            this.btnY1.TabIndex = 3;
            this.btnY1.UseVisualStyleBackColor = true;
            this.btnY1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnY2
            // 
            this.btnY2.Location = new System.Drawing.Point(145, 132);
            this.btnY2.Name = "btnY2";
            this.btnY2.Size = new System.Drawing.Size(104, 88);
            this.btnY2.TabIndex = 4;
            this.btnY2.UseVisualStyleBackColor = true;
            this.btnY2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnY3
            // 
            this.btnY3.Location = new System.Drawing.Point(250, 132);
            this.btnY3.Name = "btnY3";
            this.btnY3.Size = new System.Drawing.Size(104, 88);
            this.btnY3.TabIndex = 5;
            this.btnY3.UseVisualStyleBackColor = true;
            this.btnY3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnZ1
            // 
            this.btnZ1.Location = new System.Drawing.Point(40, 221);
            this.btnZ1.Name = "btnZ1";
            this.btnZ1.Size = new System.Drawing.Size(104, 88);
            this.btnZ1.TabIndex = 6;
            this.btnZ1.UseVisualStyleBackColor = true;
            this.btnZ1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnZ2
            // 
            this.btnZ2.Location = new System.Drawing.Point(145, 221);
            this.btnZ2.Name = "btnZ2";
            this.btnZ2.Size = new System.Drawing.Size(104, 88);
            this.btnZ2.TabIndex = 7;
            this.btnZ2.UseVisualStyleBackColor = true;
            this.btnZ2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnZ3
            // 
            this.btnZ3.Location = new System.Drawing.Point(250, 221);
            this.btnZ3.Name = "btnZ3";
            this.btnZ3.Size = new System.Drawing.Size(104, 88);
            this.btnZ3.TabIndex = 8;
            this.btnZ3.UseVisualStyleBackColor = true;
            this.btnZ3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(381, 43);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(381, 286);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "End Game";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(472, 360);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnZ3);
            this.Controls.Add(this.btnZ2);
            this.Controls.Add(this.btnZ1);
            this.Controls.Add(this.btnY3);
            this.Controls.Add(this.btnY2);
            this.Controls.Add(this.btnY1);
            this.Controls.Add(this.btnX3);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnX1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Button btnY1;
        private System.Windows.Forms.Button btnY2;
        private System.Windows.Forms.Button btnY3;
        private System.Windows.Forms.Button btnZ1;
        private System.Windows.Forms.Button btnZ2;
        private System.Windows.Forms.Button btnZ3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEnd;
    }
}

