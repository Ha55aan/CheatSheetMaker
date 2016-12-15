namespace ChEncoder
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
            this.btnEncode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudImageHeight = new System.Windows.Forms.NumericUpDown();
            this.nudImageWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4Widt = new System.Windows.Forms.Label();
            this.nudCharSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(12, 498);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 0;
            this.btnEncode.Text = "Chencode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(357, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(12, 34);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(339, 360);
            this.tbxMessage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preview";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(276, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudImageHeight
            // 
            this.nudImageHeight.Location = new System.Drawing.Point(57, 441);
            this.nudImageHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudImageHeight.Name = "nudImageHeight";
            this.nudImageHeight.Size = new System.Drawing.Size(95, 20);
            this.nudImageHeight.TabIndex = 5;
            this.nudImageHeight.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // nudImageWidth
            // 
            this.nudImageWidth.Location = new System.Drawing.Point(57, 413);
            this.nudImageWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudImageWidth.Name = "nudImageWidth";
            this.nudImageWidth.Size = new System.Drawing.Size(95, 20);
            this.nudImageWidth.TabIndex = 6;
            this.nudImageWidth.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Height";
            // 
            // label4Widt
            // 
            this.label4Widt.AutoSize = true;
            this.label4Widt.Location = new System.Drawing.Point(13, 415);
            this.label4Widt.Name = "label4Widt";
            this.label4Widt.Size = new System.Drawing.Size(35, 13);
            this.label4Widt.TabIndex = 7;
            this.label4Widt.Text = "Width";
            // 
            // nudCharSize
            // 
            this.nudCharSize.Location = new System.Drawing.Point(260, 415);
            this.nudCharSize.Name = "nudCharSize";
            this.nudCharSize.Size = new System.Drawing.Size(91, 20);
            this.nudCharSize.TabIndex = 6;
            this.nudCharSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Image Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Character Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 545);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4Widt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudCharSize);
            this.Controls.Add(this.nudImageWidth);
            this.Controls.Add(this.nudImageHeight);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEncode);
            this.Name = "Form1";
            this.Text = "Chencoder 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudImageHeight;
        private System.Windows.Forms.NumericUpDown nudImageWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4Widt;
        private System.Windows.Forms.NumericUpDown nudCharSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

