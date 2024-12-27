namespace HopitalSystem
{
    partial class DeleteRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRecord));
            CName = new TextBox();
            CID = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            GridView2 = new DataGridView();
            btndelete = new Button();
            btndelview = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)GridView2).BeginInit();
            SuspendLayout();
            // 
            // CName
            // 
            CName.Location = new Point(194, 193);
            CName.Name = "CName";
            CName.Size = new Size(199, 27);
            CName.TabIndex = 19;
            // 
            // CID
            // 
            CID.FormattingEnabled = true;
            CID.Location = new Point(197, 138);
            CID.Name = "CID";
            CID.Size = new Size(196, 28);
            CID.TabIndex = 18;
            CID.SelectedIndexChanged += CID_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(113, 195);
            label12.Name = "label12";
            label12.Size = new Size(57, 23);
            label12.TabIndex = 17;
            label12.Text = "Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(85, 141);
            label11.Name = "label11";
            label11.Size = new Size(88, 23);
            label11.TabIndex = 16;
            label11.Text = "Patient Id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(290, 36);
            label10.Name = "label10";
            label10.Size = new Size(481, 41);
            label10.TabIndex = 15;
            label10.Text = "Delete The Record of The Pateint\r\n";
            // 
            // GridView2
            // 
            GridView2.BackgroundColor = SystemColors.ActiveCaption;
            GridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView2.Location = new Point(2, 235);
            GridView2.Name = "GridView2";
            GridView2.RowHeadersWidth = 51;
            GridView2.RowTemplate.Height = 29;
            GridView2.Size = new Size(1025, 245);
            GridView2.TabIndex = 20;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.ForeColor = Color.White;
            btndelete.Location = new Point(786, 188);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(107, 42);
            btndelete.TabIndex = 21;
            btndelete.Text = "Delete Record";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += button1_Click;
            // 
            // btndelview
            // 
            btndelview.BackColor = Color.DarkOliveGreen;
            btndelview.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btndelview.ForeColor = Color.White;
            btndelview.Location = new Point(909, 187);
            btndelview.Name = "btndelview";
            btndelview.Size = new Size(107, 42);
            btndelview.TabIndex = 22;
            btndelview.Text = "View Record";
            btndelview.UseVisualStyleBackColor = false;
            btndelview.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(909, 589);
            button3.Name = "button3";
            button3.Size = new Size(107, 42);
            button3.TabIndex = 23;
            button3.Text = "Back\r\n";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // DeleteRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1028, 632);
            Controls.Add(button3);
            Controls.Add(btndelview);
            Controls.Add(btndelete);
            Controls.Add(GridView2);
            Controls.Add(CName);
            Controls.Add(CID);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Name = "DeleteRecord";
            Text = "Delete Record of The Patient";
            Load += DeleteRecord_Load;
            ((System.ComponentModel.ISupportInitialize)GridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CName;
        private ComboBox CID;
        private Label label12;
        private Label label11;
        private Label label10;
        private DataGridView GridView2;
        private Button btndelete;
        private Button btndelview;
        private Button button3;
    }
}