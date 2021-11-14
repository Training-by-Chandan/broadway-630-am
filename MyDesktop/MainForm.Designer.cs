
namespace MyDesktop
{
    partial class MainForm
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
            this.GridStudent = new System.Windows.Forms.DataGridView();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelDOB = new System.Windows.Forms.Label();
            this.TextFirstName = new System.Windows.Forms.TextBox();
            this.TextLastName = new System.Windows.Forms.TextBox();
            this.DateDob = new System.Windows.Forms.DateTimePicker();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // GridStudent
            // 
            this.GridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStudent.Location = new System.Drawing.Point(63, 267);
            this.GridStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridStudent.Name = "GridStudent";
            this.GridStudent.RowHeadersWidth = 51;
            this.GridStudent.RowTemplate.Height = 24;
            this.GridStudent.Size = new System.Drawing.Size(785, 195);
            this.GridStudent.TabIndex = 0;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(72, 35);
            this.LabelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(88, 21);
            this.LabelFirstName.TabIndex = 1;
            this.LabelFirstName.Text = "First Name";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(72, 89);
            this.LabelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(106, 25);
            this.LabelLastName.TabIndex = 2;
            this.LabelLastName.Text = "Last Name";
            // 
            // LabelDOB
            // 
            this.LabelDOB.AutoSize = true;
            this.LabelDOB.Location = new System.Drawing.Point(72, 145);
            this.LabelDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDOB.Name = "LabelDOB";
            this.LabelDOB.Size = new System.Drawing.Size(98, 21);
            this.LabelDOB.TabIndex = 3;
            this.LabelDOB.Text = "Date of Birth";
            // 
            // TextFirstName
            // 
            this.TextFirstName.Location = new System.Drawing.Point(270, 32);
            this.TextFirstName.Name = "TextFirstName";
            this.TextFirstName.Size = new System.Drawing.Size(307, 30);
            this.TextFirstName.TabIndex = 4;
            // 
            // TextLastName
            // 
            this.TextLastName.Location = new System.Drawing.Point(270, 86);
            this.TextLastName.Name = "TextLastName";
            this.TextLastName.Size = new System.Drawing.Size(307, 30);
            this.TextLastName.TabIndex = 5;
            // 
            // DateDob
            // 
            this.DateDob.Location = new System.Drawing.Point(270, 140);
            this.DateDob.Name = "DateDob";
            this.DateDob.Size = new System.Drawing.Size(306, 30);
            this.DateDob.TabIndex = 6;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(426, 210);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(151, 36);
            this.BtnCreate.TabIndex = 7;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(622, 210);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(151, 36);
            this.BtnRefresh.TabIndex = 8;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(251, 210);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(151, 36);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 578);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.DateDob);
            this.Controls.Add(this.TextLastName);
            this.Controls.Add(this.TextFirstName);
            this.Controls.Add(this.LabelDOB);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.GridStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridStudent;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelDOB;
        private System.Windows.Forms.TextBox TextFirstName;
        private System.Windows.Forms.TextBox TextLastName;
        private System.Windows.Forms.DateTimePicker DateDob;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnReset;
    }
}