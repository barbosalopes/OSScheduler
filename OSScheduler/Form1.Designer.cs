namespace OSScheduler
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
            this.label1 = new System.Windows.Forms.Label();
            this.execution_time = new System.Windows.Forms.NumericUpDown();
            this.output = new System.Windows.Forms.RichTextBox();
            this.add = new System.Windows.Forms.Button();
            this.priority = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.execution_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priority)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ExecutionTime";
            // 
            // execution_time
            // 
            this.execution_time.Location = new System.Drawing.Point(16, 33);
            this.execution_time.Name = "execution_time";
            this.execution_time.Size = new System.Drawing.Size(120, 26);
            this.execution_time.TabIndex = 1;
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Location = new System.Drawing.Point(12, 154);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(776, 88);
            this.output.TabIndex = 2;
            this.output.Text = "";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(187, 65);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 33);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // priority
            // 
            this.priority.Location = new System.Drawing.Point(142, 33);
            this.priority.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(120, 26);
            this.priority.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Priority";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 254);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.output);
            this.Controls.Add(this.execution_time);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.execution_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown execution_time;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.NumericUpDown priority;
        private System.Windows.Forms.Label label2;
    }
}

