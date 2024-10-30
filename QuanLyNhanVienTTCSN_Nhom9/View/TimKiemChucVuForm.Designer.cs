namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class TimKiemChucVuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemChucVuForm));
            this.confirm = new System.Windows.Forms.Button();
            this.departmentTextbox = new System.Windows.Forms.TextBox();
            this.positonTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(306, 156);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(108, 31);
            this.confirm.TabIndex = 9;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // departmentTextbox
            // 
            this.departmentTextbox.Location = new System.Drawing.Point(179, 99);
            this.departmentTextbox.Name = "departmentTextbox";
            this.departmentTextbox.Size = new System.Drawing.Size(235, 22);
            this.departmentTextbox.TabIndex = 8;
            // 
            // positonTextBox
            // 
            this.positonTextBox.Location = new System.Drawing.Point(179, 41);
            this.positonTextBox.Name = "positonTextBox";
            this.positonTextBox.Size = new System.Drawing.Size(235, 22);
            this.positonTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Phòng ban:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên chức vụ:";
            // 
            // TimKiemChucVuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 201);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.departmentTextbox);
            this.Controls.Add(this.positonTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemChucVuForm";
            this.Text = "TimKiemChucVuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox departmentTextbox;
        private System.Windows.Forms.TextBox positonTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}