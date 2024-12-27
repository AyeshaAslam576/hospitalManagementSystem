namespace HopitalSystem
{
    partial class View
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
            dataGridh = new DataGridView();
            label1 = new Label();
            btnshow = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridh).BeginInit();
            SuspendLayout();
            // 
            // dataGridh
            // 
            dataGridh.BackgroundColor = Color.PaleGreen;
            dataGridh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridh.Location = new Point(93, 100);
            dataGridh.Name = "dataGridh";
            dataGridh.RowHeadersWidth = 51;
            dataGridh.RowTemplate.Height = 29;
            dataGridh.Size = new Size(793, 371);
            dataGridh.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 22);
            label1.Name = "label1";
            label1.Size = new Size(442, 41);
            label1.TabIndex = 1;
            label1.Text = "Full History of All the Pateints";
            // 
            // btnshow
            // 
            btnshow.BackColor = Color.PaleGreen;
            btnshow.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnshow.ForeColor = Color.Black;
            btnshow.Location = new Point(891, 549);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(115, 38);
            btnshow.TabIndex = 2;
            btnshow.Text = "Show Record";
            btnshow.UseVisualStyleBackColor = false;
            btnshow.Click += btnshow_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(728, 549);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 3;
            button1.Text = "Back\r\n\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_pixabay_247786;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1018, 596);
            Controls.Add(button1);
            Controls.Add(btnshow);
            Controls.Add(label1);
            Controls.Add(dataGridh);
            Name = "View";
            Text = "View";
            Load += View_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridh;
        private Label label1;
        private Button btnshow;
        private Button button1;
    }
}