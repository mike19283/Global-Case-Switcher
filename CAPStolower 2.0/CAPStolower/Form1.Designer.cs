namespace CAPStolower
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
            this.components = new System.ComponentModel.Container();
            this.button_swap = new System.Windows.Forms.Button();
            this.label_display = new System.Windows.Forms.Label();
            this.timer_display = new System.Windows.Forms.Timer(this.components);
            this.label_clipboard = new System.Windows.Forms.Label();
            this.timer_clipboard = new System.Windows.Forms.Timer(this.components);
            this.button_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_swap
            // 
            this.button_swap.Location = new System.Drawing.Point(36, 50);
            this.button_swap.Name = "button_swap";
            this.button_swap.Size = new System.Drawing.Size(75, 23);
            this.button_swap.TabIndex = 2;
            this.button_swap.Text = "Swap";
            this.button_swap.UseVisualStyleBackColor = true;
            this.button_swap.Click += new System.EventHandler(this.button_swap_Click);
            // 
            // label_display
            // 
            this.label_display.AutoSize = true;
            this.label_display.Location = new System.Drawing.Point(44, 33);
            this.label_display.Name = "label_display";
            this.label_display.Size = new System.Drawing.Size(55, 13);
            this.label_display.TabIndex = 3;
            this.label_display.Text = "Swapped!";
            this.label_display.Visible = false;
            // 
            // timer_display
            // 
            this.timer_display.Enabled = true;
            this.timer_display.Tick += new System.EventHandler(this.timer_display_Tick);
            // 
            // label_clipboard
            // 
            this.label_clipboard.AutoSize = true;
            this.label_clipboard.Location = new System.Drawing.Point(2, 75);
            this.label_clipboard.Name = "label_clipboard";
            this.label_clipboard.Size = new System.Drawing.Size(35, 13);
            this.label_clipboard.TabIndex = 4;
            this.label_clipboard.Text = "label1";
            // 
            // timer_clipboard
            // 
            this.timer_clipboard.Enabled = true;
            this.timer_clipboard.Interval = 50;
            this.timer_clipboard.Tick += new System.EventHandler(this.timer_clipboard_Tick);
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(36, 6);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 23);
            this.button_about.TabIndex = 5;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(141, 116);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.label_clipboard);
            this.Controls.Add(this.label_display);
            this.Controls.Add(this.button_swap);
            this.Name = "Form1";
            this.Text = "Case changer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_swap;
        private System.Windows.Forms.Label label_display;
        private System.Windows.Forms.Timer timer_display;
        private System.Windows.Forms.Label label_clipboard;
        private System.Windows.Forms.Timer timer_clipboard;
        private System.Windows.Forms.Button button_about;
    }
}

