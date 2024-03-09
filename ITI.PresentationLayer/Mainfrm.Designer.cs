namespace ITI.PresentationLayer
{
    partial class Mainfrm
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
            label1 = new Label();
            label2 = new Label();
            txt_CrsName = new TextBox();
            combo_Topic = new ComboBox();
            label4 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridCrs = new DataGridView();
            num_CrsDuration = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridCrs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_CrsDuration).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 32);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 0;
            label2.Text = "Course Duration";
            // 
            // txt_CrsName
            // 
            txt_CrsName.Location = new Point(104, 29);
            txt_CrsName.Name = "txt_CrsName";
            txt_CrsName.Size = new Size(133, 23);
            txt_CrsName.TabIndex = 1;
            // 
            // combo_Topic
            // 
            combo_Topic.FormattingEnabled = true;
            combo_Topic.Location = new Point(597, 28);
            combo_Topic.Name = "combo_Topic";
            combo_Topic.Size = new Size(121, 23);
            combo_Topic.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 32);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 0;
            label4.Text = "Topic";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkTurquoise;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.Location = new Point(62, 91);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F);
            btnUpdate.Location = new Point(293, 91);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 36);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.Location = new Point(545, 91);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 36);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridCrs
            // 
            dataGridCrs.BackgroundColor = Color.AliceBlue;
            dataGridCrs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCrs.Location = new Point(3, 149);
            dataGridCrs.Name = "dataGridCrs";
            dataGridCrs.Size = new Size(743, 299);
            dataGridCrs.TabIndex = 4;
            dataGridCrs.RowHeaderMouseDoubleClick += dataGridCrs_RowHeaderMouseDoubleClick;
            // 
            // num_CrsDuration
            // 
            num_CrsDuration.Location = new Point(387, 29);
            num_CrsDuration.Name = "num_CrsDuration";
            num_CrsDuration.Size = new Size(71, 23);
            num_CrsDuration.TabIndex = 6;
            // 
            // Mainfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(748, 450);
            Controls.Add(num_CrsDuration);
            Controls.Add(dataGridCrs);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(combo_Topic);
            Controls.Add(txt_CrsName);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Mainfrm";
            ShowIcon = false;
            Text = "Main Form";
            Load += Mainfrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCrs).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_CrsDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_CrsName;
        private ComboBox combo_Topic;
        private Label label4;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridCrs;
        private NumericUpDown num_CrsDuration;
    }
}
