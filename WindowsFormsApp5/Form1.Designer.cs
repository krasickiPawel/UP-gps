
namespace GPS_1
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
            this.buttonLocationData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCOM = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textLength = new System.Windows.Forms.TextBox();
            this.buttonShowMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLocationData
            // 
            this.buttonLocationData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.buttonLocationData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocationData.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLocationData.Location = new System.Drawing.Point(66, 280);
            this.buttonLocationData.Name = "buttonLocationData";
            this.buttonLocationData.Size = new System.Drawing.Size(263, 92);
            this.buttonLocationData.TabIndex = 0;
            this.buttonLocationData.Text = "Show location data";
            this.buttonLocationData.UseVisualStyleBackColor = false;
            this.buttonLocationData.Click += new System.EventHandler(this.buttonLocationData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(66, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(66, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(66, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Length";
            // 
            // textCOM
            // 
            this.textCOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.textCOM.ForeColor = System.Drawing.SystemColors.Control;
            this.textCOM.Location = new System.Drawing.Point(172, 49);
            this.textCOM.Name = "textCOM";
            this.textCOM.Size = new System.Drawing.Size(157, 27);
            this.textCOM.TabIndex = 4;
            // 
            // textWidth
            // 
            this.textWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.textWidth.ForeColor = System.Drawing.SystemColors.Control;
            this.textWidth.Location = new System.Drawing.Point(172, 112);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(157, 27);
            this.textWidth.TabIndex = 5;
            // 
            // textLength
            // 
            this.textLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.textLength.ForeColor = System.Drawing.SystemColors.Control;
            this.textLength.Location = new System.Drawing.Point(172, 173);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(157, 27);
            this.textLength.TabIndex = 6;
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.buttonShowMap.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonShowMap.Location = new System.Drawing.Point(423, 51);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.Size = new System.Drawing.Size(276, 229);
            this.buttonShowMap.TabIndex = 7;
            this.buttonShowMap.Text = "Show on map";
            this.buttonShowMap.UseVisualStyleBackColor = false;
            this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowMap);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.textCOM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLocationData);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "GPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLocationData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCOM;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.Button buttonShowMap;
    }
}

