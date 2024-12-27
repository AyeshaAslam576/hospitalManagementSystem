namespace HopitalSystem
{
    partial class Staff
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
            dataView1 = new DataGridView();
            btnM = new Button();
            btnDisplay = new Button();
            ((System.ComponentModel.ISupportInitialize)dataView1).BeginInit();
            SuspendLayout();
            // 
            // dataView1
            // 
            dataView1.BackgroundColor = Color.White;
            dataView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView1.Location = new Point(51, 360);
            dataView1.Name = "dataView1";
            dataView1.RowHeadersWidth = 51;
            dataView1.Size = new Size(621, 207);
            dataView1.TabIndex = 0;
            // 
            // btnM
            // 
            btnM.BackColor = Color.LightGray;
            btnM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnM.ForeColor = Color.Black;
            btnM.Location = new Point(675, 622);
            btnM.Name = "btnM";
            btnM.Size = new Size(115, 38);
            btnM.TabIndex = 5;
            btnM.Text = "Back\r\n\r\n";
            btnM.UseVisualStyleBackColor = false;
            btnM.Click += btnM_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.LightGray;
            btnDisplay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDisplay.ForeColor = Color.Black;
            btnDisplay.Location = new Point(838, 622);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(115, 38);
            btnDisplay.TabIndex = 4;
            btnDisplay.Text = "Show Record";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnshow_Click;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.jh;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 672);
            Controls.Add(btnM);
            Controls.Add(btnDisplay);
            Controls.Add(dataView1);
            Name = "Staff";
            Text = "Staff";
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)dataView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataView1;
        private Button btnM;
        private Button btnDisplay;
    }
}