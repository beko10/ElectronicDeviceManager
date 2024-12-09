namespace ElectronicDeviceManager.DesktopUI.Forms
{
    partial class DepartmentForm
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
            label1 = new Label();
            label2 = new Label();
            txtCName = new TextBox();
            txtCDesc = new TextBox();
            lstList = new ListBox();
            cmbState = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 130);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 4;
            label1.Text = "Kategori Adi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 155);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "Açıklması :";
            // 
            // txtCName
            // 
            txtCName.Location = new Point(95, 127);
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(128, 23);
            txtCName.TabIndex = 6;
            // 
            // txtCDesc
            // 
            txtCDesc.Location = new Point(95, 156);
            txtCDesc.Name = "txtCDesc";
            txtCDesc.Size = new Size(128, 23);
            txtCDesc.TabIndex = 7;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 15;
            lstList.Location = new Point(263, 75);
            lstList.Name = "lstList";
            lstList.Size = new Size(194, 214);
            lstList.TabIndex = 8;
            lstList.SelectedIndexChanged += lstList_SelectedIndexChanged;
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(95, 185);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(128, 23);
            cmbState.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 188);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Durumu :";
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(504, 330);
            Controls.Add(label3);
            Controls.Add(cmbState);
            Controls.Add(lstList);
            Controls.Add(txtCDesc);
            Controls.Add(txtCName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            Load += DepartmentForm_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtCName, 0);
            Controls.SetChildIndex(txtCDesc, 0);
            Controls.SetChildIndex(lstList, 0);
            Controls.SetChildIndex(cmbState, 0);
            Controls.SetChildIndex(label3, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCName;
        private TextBox txtCDesc;
        private ListBox lstList;
        private ComboBox cmbState;
        private Label label3;
    }
}