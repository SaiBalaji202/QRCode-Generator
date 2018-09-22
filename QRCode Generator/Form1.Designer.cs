namespace QRCode_Generator
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
            this.rtxtPayload = new System.Windows.Forms.RichTextBox();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.btnEncode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtPayload
            // 
            this.rtxtPayload.Location = new System.Drawing.Point(27, 12);
            this.rtxtPayload.Name = "rtxtPayload";
            this.rtxtPayload.Size = new System.Drawing.Size(381, 211);
            this.rtxtPayload.TabIndex = 0;
            this.rtxtPayload.Text = "";
            // 
            // picQRCode
            // 
            this.picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picQRCode.Location = new System.Drawing.Point(568, 12);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(138, 150);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode.TabIndex = 1;
            this.picQRCode.TabStop = false;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(448, 68);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 247);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.rtxtPayload);
            this.Name = "Form1";
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtPayload;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Button btnEncode;
    }
}

