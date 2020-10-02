namespace TicketBooking
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
            this._comboBox2 = new System.Windows.Forms.ComboBox();
            this._comboBox1 = new System.Windows.Forms.ComboBox();
            this._priceLabel = new System.Windows.Forms.Label();
            this._quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _comboBox2
            // 
            this._comboBox2.FormattingEnabled = true;
            this._comboBox2.Location = new System.Drawing.Point(146, 12);
            this._comboBox2.Name = "_comboBox2";
            this._comboBox2.Size = new System.Drawing.Size(121, 21);
            this._comboBox2.TabIndex = 0;
            this._comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // _comboBox1
            // 
            this._comboBox1.FormattingEnabled = true;
            this._comboBox1.Location = new System.Drawing.Point(12, 12);
            this._comboBox1.Name = "_comboBox1";
            this._comboBox1.Size = new System.Drawing.Size(121, 21);
            this._comboBox1.TabIndex = 1;
            // 
            // _priceLabel
            // 
            this._priceLabel.AutoSize = true;
            this._priceLabel.Location = new System.Drawing.Point(290, 15);
            this._priceLabel.Name = "_priceLabel";
            this._priceLabel.Size = new System.Drawing.Size(34, 13);
            this._priceLabel.TabIndex = 2;
            this._priceLabel.Text = "Price:";
            // 
            // _quit
            // 
            this._quit.Location = new System.Drawing.Point(162, 50);
            this._quit.Name = "_quit";
            this._quit.Size = new System.Drawing.Size(75, 23);
            this._quit.TabIndex = 3;
            this._quit.Text = "Quit";
            this._quit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 85);
            this.Controls.Add(this._quit);
            this.Controls.Add(this._priceLabel);
            this.Controls.Add(this._comboBox1);
            this.Controls.Add(this._comboBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Book a Ticket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _comboBox2;
        private System.Windows.Forms.ComboBox _comboBox1;
        private System.Windows.Forms.Label _priceLabel;
        private System.Windows.Forms.Button _quit;
    }
}

