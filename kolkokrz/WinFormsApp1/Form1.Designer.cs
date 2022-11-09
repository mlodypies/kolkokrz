namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TL = new System.Windows.Forms.Button();
            this.TC = new System.Windows.Forms.Button();
            this.TR = new System.Windows.Forms.Button();
            this.CL = new System.Windows.Forms.Button();
            this.CC = new System.Windows.Forms.Button();
            this.CR = new System.Windows.Forms.Button();
            this.BL = new System.Windows.Forms.Button();
            this.BC = new System.Windows.Forms.Button();
            this.BR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.TL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TR, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CR, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BR, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TL
            // 
            this.TL.Location = new System.Drawing.Point(3, 3);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(260, 157);
            this.TL.TabIndex = 0;
            this.TL.UseVisualStyleBackColor = true;
            this.TL.Click += new System.EventHandler(this.Mark);
            // 
            // TC
            // 
            this.TC.Location = new System.Drawing.Point(269, 3);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(260, 157);
            this.TC.TabIndex = 1;
            this.TC.UseVisualStyleBackColor = true;
            this.TC.Click += new System.EventHandler(this.Mark);
            // 
            // TR
            // 
            this.TR.Location = new System.Drawing.Point(535, 3);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(263, 157);
            this.TR.TabIndex = 2;
            this.TR.UseVisualStyleBackColor = true;
            this.TR.Click += new System.EventHandler(this.Mark);
            // 
            // CL
            // 
            this.CL.Location = new System.Drawing.Point(3, 166);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(260, 157);
            this.CL.TabIndex = 3;
            this.CL.UseVisualStyleBackColor = true;
            this.CL.Click += new System.EventHandler(this.Mark);
            // 
            // CC
            // 
            this.CC.Location = new System.Drawing.Point(269, 166);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(260, 157);
            this.CC.TabIndex = 4;
            this.CC.UseVisualStyleBackColor = true;
            this.CC.Click += new System.EventHandler(this.Mark);
            // 
            // CR
            // 
            this.CR.Location = new System.Drawing.Point(535, 166);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(263, 157);
            this.CR.TabIndex = 5;
            this.CR.UseVisualStyleBackColor = true;
            this.CR.Click += new System.EventHandler(this.Mark);
            // 
            // BL
            // 
            this.BL.Location = new System.Drawing.Point(3, 329);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(260, 159);
            this.BL.TabIndex = 6;
            this.BL.UseVisualStyleBackColor = true;
            this.BL.Click += new System.EventHandler(this.Mark);
            // 
            // BC
            // 
            this.BC.Location = new System.Drawing.Point(269, 329);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(260, 159);
            this.BC.TabIndex = 7;
            this.BC.UseVisualStyleBackColor = true;
            this.BC.Click += new System.EventHandler(this.Mark);
            // 
            // BR
            // 
            this.BR.Location = new System.Drawing.Point(535, 329);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(263, 159);
            this.BR.TabIndex = 8;
            this.BR.UseVisualStyleBackColor = true;
            this.BR.Click += new System.EventHandler(this.Mark);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktualny ruch: ";
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Location = new System.Drawing.Point(108, 517);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(0, 15);
            this.currentPlayerLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 560);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button TL;
        private Button TC;
        private Button TR;
        private Button CL;
        private Button CC;
        private Button CR;
        private Button BL;
        private Button BC;
        private Button BR;
        private Label label1;
        private Label currentPlayerLabel;
    }
}