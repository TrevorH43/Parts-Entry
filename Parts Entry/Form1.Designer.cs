namespace Parts_Entry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.partDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnHandTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.totalInventoryCostTextBox = new System.Windows.Forms.TextBox();
            this.leadTimeTextBox = new System.Windows.Forms.TextBox();
            this.dailyUsageTextBox = new System.Windows.Forms.TextBox();
            this.reorderPointTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.itemClassComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Part Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Units On Hand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Inventory Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lead Time In Days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Daily Usage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Reorder Point";
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.Location = new System.Drawing.Point(212, 36);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.partNumberTextBox.TabIndex = 17;
            this.partNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.partNumberTextBox_Validating);
            // 
            // partDescriptionTextBox
            // 
            this.partDescriptionTextBox.Location = new System.Drawing.Point(212, 74);
            this.partDescriptionTextBox.Name = "partDescriptionTextBox";
            this.partDescriptionTextBox.Size = new System.Drawing.Size(201, 20);
            this.partDescriptionTextBox.TabIndex = 18;
            this.partDescriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.partDescriptionTextBox_Validating);
            // 
            // unitsOnHandTextBox
            // 
            this.unitsOnHandTextBox.Location = new System.Drawing.Point(212, 153);
            this.unitsOnHandTextBox.Name = "unitsOnHandTextBox";
            this.unitsOnHandTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitsOnHandTextBox.TabIndex = 20;
            this.unitsOnHandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.unitsOnHandTextBox_Validating);
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(595, 37);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitPriceTextBox.TabIndex = 21;
            this.unitPriceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.unitPriceTextBox_Validating);
            // 
            // totalInventoryCostTextBox
            // 
            this.totalInventoryCostTextBox.Location = new System.Drawing.Point(595, 70);
            this.totalInventoryCostTextBox.Name = "totalInventoryCostTextBox";
            this.totalInventoryCostTextBox.ReadOnly = true;
            this.totalInventoryCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalInventoryCostTextBox.TabIndex = 22;
            // 
            // leadTimeTextBox
            // 
            this.leadTimeTextBox.Location = new System.Drawing.Point(595, 96);
            this.leadTimeTextBox.Name = "leadTimeTextBox";
            this.leadTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.leadTimeTextBox.TabIndex = 23;
            this.leadTimeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.leadTimeTextBox_Validating);
            // 
            // dailyUsageTextBox
            // 
            this.dailyUsageTextBox.Location = new System.Drawing.Point(595, 126);
            this.dailyUsageTextBox.Name = "dailyUsageTextBox";
            this.dailyUsageTextBox.Size = new System.Drawing.Size(100, 20);
            this.dailyUsageTextBox.TabIndex = 24;
            this.dailyUsageTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dailyUsageTextBox_Validating);
            // 
            // reorderPointTextBox
            // 
            this.reorderPointTextBox.Location = new System.Drawing.Point(595, 157);
            this.reorderPointTextBox.Name = "reorderPointTextBox";
            this.reorderPointTextBox.ReadOnly = true;
            this.reorderPointTextBox.Size = new System.Drawing.Size(100, 20);
            this.reorderPointTextBox.TabIndex = 25;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(713, 67);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 26;
            this.submitButton.Text = "Add";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(713, 96);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(713, 124);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 28;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(577, 255);
            this.dataGridView1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Display Row";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Delete Row";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemClassComboBox
            // 
            this.itemClassComboBox.FormattingEnabled = true;
            this.itemClassComboBox.Location = new System.Drawing.Point(212, 115);
            this.itemClassComboBox.Name = "itemClassComboBox";
            this.itemClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemClassComboBox.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemClassComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.reorderPointTextBox);
            this.Controls.Add(this.dailyUsageTextBox);
            this.Controls.Add(this.leadTimeTextBox);
            this.Controls.Add(this.totalInventoryCostTextBox);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.unitsOnHandTextBox);
            this.Controls.Add(this.partDescriptionTextBox);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.TextBox partDescriptionTextBox;
        private System.Windows.Forms.TextBox unitsOnHandTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox totalInventoryCostTextBox;
        private System.Windows.Forms.TextBox leadTimeTextBox;
        private System.Windows.Forms.TextBox dailyUsageTextBox;
        private System.Windows.Forms.TextBox reorderPointTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox itemClassComboBox;
    }
}

