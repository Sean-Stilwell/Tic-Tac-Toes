namespace TicTacToe
{
    partial class FormTicTacToe
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
            this.buttonTL = new System.Windows.Forms.Button();
            this.buttonTR = new System.Windows.Forms.Button();
            this.buttonTC = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonML = new System.Windows.Forms.Button();
            this.buttonBC = new System.Windows.Forms.Button();
            this.buttonBR = new System.Windows.Forms.Button();
            this.buttonBL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.xScore = new System.Windows.Forms.Label();
            this.oScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scoreReset = new System.Windows.Forms.Button();
            this.boardReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTL
            // 
            this.buttonTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTL.Location = new System.Drawing.Point(1, 121);
            this.buttonTL.Name = "buttonTL";
            this.buttonTL.Size = new System.Drawing.Size(130, 130);
            this.buttonTL.TabIndex = 0;
            this.buttonTL.Text = "X";
            this.buttonTL.UseVisualStyleBackColor = true;
            this.buttonTL.Click += new System.EventHandler(this.ButtonTL_Click);
            // 
            // buttonTR
            // 
            this.buttonTR.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTR.Location = new System.Drawing.Point(254, 121);
            this.buttonTR.Name = "buttonTR";
            this.buttonTR.Size = new System.Drawing.Size(130, 130);
            this.buttonTR.TabIndex = 1;
            this.buttonTR.Text = "X";
            this.buttonTR.UseVisualStyleBackColor = false;
            this.buttonTR.Click += new System.EventHandler(this.ButtonTR_Click);
            // 
            // buttonTC
            // 
            this.buttonTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTC.Location = new System.Drawing.Point(127, 121);
            this.buttonTC.Name = "buttonTC";
            this.buttonTC.Size = new System.Drawing.Size(130, 130);
            this.buttonTC.TabIndex = 2;
            this.buttonTC.Text = "X";
            this.buttonTC.UseVisualStyleBackColor = true;
            this.buttonTC.Click += new System.EventHandler(this.ButtonTC_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMC.Location = new System.Drawing.Point(127, 249);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(130, 130);
            this.buttonMC.TabIndex = 5;
            this.buttonMC.Text = "X";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.ButtonMC_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMR.Location = new System.Drawing.Point(254, 249);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(130, 130);
            this.buttonMR.TabIndex = 4;
            this.buttonMR.Text = "X";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.ButtonMR_Click);
            // 
            // buttonML
            // 
            this.buttonML.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonML.Location = new System.Drawing.Point(1, 249);
            this.buttonML.Name = "buttonML";
            this.buttonML.Size = new System.Drawing.Size(130, 130);
            this.buttonML.TabIndex = 3;
            this.buttonML.Text = "X";
            this.buttonML.UseVisualStyleBackColor = true;
            this.buttonML.Click += new System.EventHandler(this.ButtonML_Click);
            // 
            // buttonBC
            // 
            this.buttonBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBC.Location = new System.Drawing.Point(127, 373);
            this.buttonBC.Name = "buttonBC";
            this.buttonBC.Size = new System.Drawing.Size(130, 130);
            this.buttonBC.TabIndex = 8;
            this.buttonBC.Text = "X";
            this.buttonBC.UseVisualStyleBackColor = true;
            this.buttonBC.Click += new System.EventHandler(this.ButtonBC_Click);
            // 
            // buttonBR
            // 
            this.buttonBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBR.Location = new System.Drawing.Point(254, 373);
            this.buttonBR.Name = "buttonBR";
            this.buttonBR.Size = new System.Drawing.Size(130, 130);
            this.buttonBR.TabIndex = 7;
            this.buttonBR.Text = "X";
            this.buttonBR.UseVisualStyleBackColor = true;
            this.buttonBR.Click += new System.EventHandler(this.ButtonBR_Click);
            // 
            // buttonBL
            // 
            this.buttonBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBL.Location = new System.Drawing.Point(1, 373);
            this.buttonBL.Name = "buttonBL";
            this.buttonBL.Size = new System.Drawing.Size(130, 130);
            this.buttonBL.TabIndex = 6;
            this.buttonBL.Text = "X";
            this.buttonBL.UseVisualStyleBackColor = true;
            this.buttonBL.Click += new System.EventHandler(this.ButtonBL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // xScore
            // 
            this.xScore.AutoSize = true;
            this.xScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xScore.Location = new System.Drawing.Point(35, 88);
            this.xScore.Name = "xScore";
            this.xScore.Size = new System.Drawing.Size(18, 20);
            this.xScore.TabIndex = 10;
            this.xScore.Text = "0";
            // 
            // oScore
            // 
            this.oScore.AutoSize = true;
            this.oScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oScore.Location = new System.Drawing.Point(338, 88);
            this.oScore.Name = "oScore";
            this.oScore.Size = new System.Drawing.Size(18, 20);
            this.oScore.TabIndex = 11;
            this.oScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "O";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tic Tac Toe Game!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "by Sean Stilwell";
            // 
            // scoreReset
            // 
            this.scoreReset.Location = new System.Drawing.Point(108, 88);
            this.scoreReset.Name = "scoreReset";
            this.scoreReset.Size = new System.Drawing.Size(75, 23);
            this.scoreReset.TabIndex = 15;
            this.scoreReset.Text = "Reset Score";
            this.scoreReset.UseVisualStyleBackColor = true;
            this.scoreReset.Click += new System.EventHandler(this.ScoreReset_Click);
            // 
            // boardReset
            // 
            this.boardReset.Location = new System.Drawing.Point(200, 88);
            this.boardReset.Name = "boardReset";
            this.boardReset.Size = new System.Drawing.Size(75, 23);
            this.boardReset.TabIndex = 16;
            this.boardReset.Text = "Reset Board";
            this.boardReset.UseVisualStyleBackColor = true;
            this.boardReset.Click += new System.EventHandler(this.BoardReset_Click);
            // 
            // FormTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 503);
            this.Controls.Add(this.boardReset);
            this.Controls.Add(this.scoreReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oScore);
            this.Controls.Add(this.xScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBC);
            this.Controls.Add(this.buttonBR);
            this.Controls.Add(this.buttonBL);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonML);
            this.Controls.Add(this.buttonTC);
            this.Controls.Add(this.buttonTR);
            this.Controls.Add(this.buttonTL);
            this.Name = "FormTicTacToe";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTL;
        private System.Windows.Forms.Button buttonTR;
        private System.Windows.Forms.Button buttonTC;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonML;
        private System.Windows.Forms.Button buttonBC;
        private System.Windows.Forms.Button buttonBR;
        private System.Windows.Forms.Button buttonBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label xScore;
        private System.Windows.Forms.Label oScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button scoreReset;
        private System.Windows.Forms.Button boardReset;
    }
}

