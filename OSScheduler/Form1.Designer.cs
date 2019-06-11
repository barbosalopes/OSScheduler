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
            this.label3 = new System.Windows.Forms.Label();
            this.quantum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_to_delete = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.execution_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Execution Time";
            // 
            // execution_time
            // 
            this.execution_time.Location = new System.Drawing.Point(19, 292);
            this.execution_time.Name = "execution_time";
            this.execution_time.Size = new System.Drawing.Size(120, 26);
            this.execution_time.TabIndex = 1;
            this.execution_time.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Location = new System.Drawing.Point(294, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(494, 382);
            this.output.TabIndex = 2;
            this.output.Text = "";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(190, 324);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 33);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // priority
            // 
            this.priority.Location = new System.Drawing.Point(145, 292);
            this.priority.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(120, 26);
            this.priority.TabIndex = 2;
            this.priority.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantum";
            // 
            // quantum
            // 
            this.quantum.Location = new System.Drawing.Point(16, 35);
            this.quantum.Name = "quantum";
            this.quantum.Size = new System.Drawing.Size(120, 26);
            this.quantum.TabIndex = 6;
            this.quantum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantum.ValueChanged += new System.EventHandler(this.quantum_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset Queue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(19, 239);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(246, 26);
            this.name.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // name_to_delete
            // 
            this.name_to_delete.Location = new System.Drawing.Point(19, 141);
            this.name_to_delete.Name = "name_to_delete";
            this.name_to_delete.Size = new System.Drawing.Size(246, 26);
            this.name_to_delete.TabIndex = 10;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(190, 173);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 33);
            this.delete.TabIndex = 11;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.name_to_delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantum);
            this.Controls.Add(this.label3);
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
            ((System.ComponentModel.ISupportInitialize)(this.quantum)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown quantum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_to_delete;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label5;
    }
}

