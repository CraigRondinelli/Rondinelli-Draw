namespace Rondinelli_Draw
{
    partial class frmDraw
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
            this.panDraw = new System.Windows.Forms.Panel();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.radWhite = new System.Windows.Forms.RadioButton();
            this.radGray = new System.Windows.Forms.RadioButton();
            this.btnEllipsis = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDraw
            // 
            this.panDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDraw.Location = new System.Drawing.Point(52, 72);
            this.panDraw.Name = "panDraw";
            this.panDraw.Size = new System.Drawing.Size(1185, 643);
            this.panDraw.TabIndex = 0;
            // 
            // btnRectangle
            // 
            this.btnRectangle.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangle.Location = new System.Drawing.Point(52, 720);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(209, 68);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "&Rectangles";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // radWhite
            // 
            this.radWhite.AutoSize = true;
            this.radWhite.Checked = true;
            this.radWhite.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWhite.Location = new System.Drawing.Point(45, 27);
            this.radWhite.Name = "radWhite";
            this.radWhite.Size = new System.Drawing.Size(66, 21);
            this.radWhite.TabIndex = 3;
            this.radWhite.Text = "&White";
            this.radWhite.UseVisualStyleBackColor = true;
            this.radWhite.CheckedChanged += new System.EventHandler(this.radWhite_CheckedChanged);
            // 
            // radGray
            // 
            this.radGray.AutoSize = true;
            this.radGray.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGray.Location = new System.Drawing.Point(45, 62);
            this.radGray.Name = "radGray";
            this.radGray.Size = new System.Drawing.Size(58, 21);
            this.radGray.TabIndex = 4;
            this.radGray.Text = "&Gray";
            this.radGray.UseVisualStyleBackColor = true;
            this.radGray.CheckedChanged += new System.EventHandler(this.radGray_CheckedChanged);
            // 
            // btnEllipsis
            // 
            this.btnEllipsis.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEllipsis.Location = new System.Drawing.Point(312, 720);
            this.btnEllipsis.Name = "btnEllipsis";
            this.btnEllipsis.Size = new System.Drawing.Size(209, 68);
            this.btnEllipsis.TabIndex = 2;
            this.btnEllipsis.Text = "&Ellipses";
            this.btnEllipsis.UseVisualStyleBackColor = true;
            this.btnEllipsis.Click += new System.EventHandler(this.btnEllipsis_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(779, 720);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(209, 68);
            this.btnClear.TabIndex = 6;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radWhite);
            this.groupBox1.Controls.Add(this.radGray);
            this.groupBox1.Location = new System.Drawing.Point(563, 721);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Background Color";
            // 
            // txtIn
            // 
            this.txtIn.AcceptsTab = true;
            this.txtIn.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(234, 806);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(105, 30);
            this.txtIn.TabIndex = 1;
            this.txtIn.Text = "5";
            this.txtIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1028, 721);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(209, 68);
            this.btnExit.TabIndex = 9;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 858);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEllipsis);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.panDraw);
            this.Name = "frmDraw";
            this.Text = "Rondinelli Draw";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panDraw;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.RadioButton radWhite;
        private System.Windows.Forms.RadioButton radGray;
        private System.Windows.Forms.Button btnEllipsis;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

