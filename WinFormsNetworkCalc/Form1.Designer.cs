namespace WinFormsNetworkCalc
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnNetzwerkBerechnen = new Button();
            cboCidr = new ComboBox();
            txtAddress = new TextBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnNetzwerkBerechnen);
            panel1.Controls.Add(cboCidr);
            panel1.Controls.Add(txtAddress);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 138);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 46);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "CIDR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 46);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Address";
            // 
            // btnNetzwerkBerechnen
            // 
            btnNetzwerkBerechnen.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNetzwerkBerechnen.Location = new Point(394, 73);
            btnNetzwerkBerechnen.Name = "btnNetzwerkBerechnen";
            btnNetzwerkBerechnen.Size = new Size(206, 24);
            btnNetzwerkBerechnen.TabIndex = 2;
            btnNetzwerkBerechnen.Text = "Netzwerk berechnen";
            btnNetzwerkBerechnen.UseVisualStyleBackColor = true;
            btnNetzwerkBerechnen.Click += btnNetzwerkBerechnen_Click;
            // 
            // cboCidr
            // 
            cboCidr.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCidr.FormattingEnabled = true;
            cboCidr.Items.AddRange(new object[] { "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32" });
            cboCidr.Location = new Point(307, 72);
            cboCidr.Name = "cboCidr";
            cboCidr.Size = new Size(82, 25);
            cboCidr.TabIndex = 1;
            cboCidr.Text = "23";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(139, 73);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(162, 24);
            txtAddress.TabIndex = 0;
            txtAddress.Text = "192.168.23.111";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(0, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(766, 225);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 363);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "WinFormsNetworkCalc";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private Label label2;
        private Label label1;
        private Button btnNetzwerkBerechnen;
        private ComboBox cboCidr;
        private TextBox txtAddress;
    }
}
