namespace ElectronicDeviceManager.DesktopUI.Forms
{
    partial class DeviceForm : BaseForm
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
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtSerialNbr = new TextBox();
            txtDesc = new TextBox();
            cmbType = new ComboBox();
            cmbState = new ComboBox();
            label5 = new Label();
            lstListe = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 109);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Aygıt Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 161);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Açıklaması :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 135);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 5;
            label3.Text = "Seri Numarası :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 188);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Tipi :";
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 9;
            // 
            // txtSerialNbr
            // 
            txtSerialNbr.Location = new Point(118, 127);
            txtSerialNbr.Name = "txtSerialNbr";
            txtSerialNbr.Size = new Size(100, 23);
            txtSerialNbr.TabIndex = 10;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(118, 156);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(100, 23);
            txtDesc.TabIndex = 11;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(118, 185);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(100, 23);
            cmbType.TabIndex = 12;
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(118, 214);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(100, 23);
            cmbState.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 217);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 14;
            label5.Text = "Durumu :";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(263, 101);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(178, 139);
            lstListe.TabIndex = 15;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged_1;
            // 
            // DeviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(633, 445);
            Controls.Add(lstListe);
            Controls.Add(label5);
            Controls.Add(cmbState);
            Controls.Add(cmbType);
            Controls.Add(txtDesc);
            Controls.Add(txtSerialNbr);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeviceForm";
            Text = "DeviceForm";
            Load += DeviceForm_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(txtSerialNbr, 0);
            Controls.SetChildIndex(txtDesc, 0);
            Controls.SetChildIndex(cmbType, 0);
            Controls.SetChildIndex(cmbState, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(lstListe, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtSerialNbr;
        private TextBox txtDesc;
        private ComboBox cmbType;
        private ComboBox cmbState;
        private Label label5;
        private ListBox lstListe;
    }
}