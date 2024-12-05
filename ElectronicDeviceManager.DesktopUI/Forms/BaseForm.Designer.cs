namespace ElectronicDeviceManager.DesktopUI.Forms
{
    partial class BaseForm
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
            btnEkle = new Button();
            btnSil = new Button();
            btnGüncelle = new Button();
            btnListele = new Button();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 27);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btn_Save_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(131, 27);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btn_Delete_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(263, 27);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 2;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btn_Update_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(382, 27);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 3;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btn_List_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListele);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Name = "BaseForm";
            Text = "BaseForm";
            Load += BaseForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnListele;
    }
}