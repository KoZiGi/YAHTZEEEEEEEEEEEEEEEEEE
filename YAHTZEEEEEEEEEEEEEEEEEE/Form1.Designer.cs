
namespace YAHTZEEEEEEEEEEEEEEEEEE
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
            this.Dice1 = new System.Windows.Forms.Label();
            this.Dice2 = new System.Windows.Forms.Label();
            this.Dice3 = new System.Windows.Forms.Label();
            this.Dice4 = new System.Windows.Forms.Label();
            this.Dice5 = new System.Windows.Forms.Label();
            this.ThrowBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.yourScoreLbx = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LeaderboardLbx = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dice1
            // 
            this.Dice1.BackColor = System.Drawing.Color.PowderBlue;
            this.Dice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dice1.Font = new System.Drawing.Font("OCR A Extended", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice1.Location = new System.Drawing.Point(66, 31);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(50, 50);
            this.Dice1.TabIndex = 0;
            this.Dice1.Text = "1";
            this.Dice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dice2
            // 
            this.Dice2.BackColor = System.Drawing.Color.PowderBlue;
            this.Dice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dice2.Font = new System.Drawing.Font("OCR A Extended", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice2.Location = new System.Drawing.Point(148, 31);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(50, 50);
            this.Dice2.TabIndex = 0;
            this.Dice2.Text = "1";
            this.Dice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dice3
            // 
            this.Dice3.BackColor = System.Drawing.Color.PowderBlue;
            this.Dice3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dice3.Font = new System.Drawing.Font("OCR A Extended", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice3.Location = new System.Drawing.Point(312, 31);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(50, 50);
            this.Dice3.TabIndex = 0;
            this.Dice3.Text = "1";
            this.Dice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dice4
            // 
            this.Dice4.BackColor = System.Drawing.Color.PowderBlue;
            this.Dice4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dice4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dice4.Font = new System.Drawing.Font("OCR A Extended", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice4.Location = new System.Drawing.Point(394, 31);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(50, 50);
            this.Dice4.TabIndex = 0;
            this.Dice4.Text = "1";
            this.Dice4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dice5
            // 
            this.Dice5.BackColor = System.Drawing.Color.PowderBlue;
            this.Dice5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dice5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dice5.Font = new System.Drawing.Font("OCR A Extended", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice5.Location = new System.Drawing.Point(230, 31);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(50, 50);
            this.Dice5.TabIndex = 0;
            this.Dice5.Text = "1";
            this.Dice5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThrowBtn
            // 
            this.ThrowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThrowBtn.Location = new System.Drawing.Point(66, 99);
            this.ThrowBtn.Name = "ThrowBtn";
            this.ThrowBtn.Size = new System.Drawing.Size(378, 35);
            this.ThrowBtn.TabIndex = 1;
            this.ThrowBtn.Text = "Dobni";
            this.ThrowBtn.UseVisualStyleBackColor = true;
            this.ThrowBtn.Click += new System.EventHandler(this.ThrowBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dice4);
            this.groupBox1.Controls.Add(this.ThrowBtn);
            this.groupBox1.Controls.Add(this.Dice1);
            this.groupBox1.Controls.Add(this.Dice5);
            this.groupBox1.Controls.Add(this.Dice2);
            this.groupBox1.Controls.Add(this.Dice3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dobás";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.yourScoreLbx);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 281);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pontok";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pont leadás";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // yourScoreLbx
            // 
            this.yourScoreLbx.FormattingEnabled = true;
            this.yourScoreLbx.Location = new System.Drawing.Point(6, 19);
            this.yourScoreLbx.Name = "yourScoreLbx";
            this.yourScoreLbx.Size = new System.Drawing.Size(199, 212);
            this.yourScoreLbx.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LeaderboardLbx);
            this.groupBox3.Location = new System.Drawing.Point(242, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 281);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Leaderboard";
            // 
            // LeaderboardLbx
            // 
            this.LeaderboardLbx.FormattingEnabled = true;
            this.LeaderboardLbx.Location = new System.Drawing.Point(12, 19);
            this.LeaderboardLbx.Name = "LeaderboardLbx";
            this.LeaderboardLbx.Size = new System.Drawing.Size(259, 251);
            this.LeaderboardLbx.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 460);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Dice1;
        private System.Windows.Forms.Label Dice2;
        private System.Windows.Forms.Label Dice3;
        private System.Windows.Forms.Label Dice4;
        private System.Windows.Forms.Label Dice5;
        private System.Windows.Forms.Button ThrowBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox yourScoreLbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox LeaderboardLbx;
        private System.Windows.Forms.Button button1;
    }
}

