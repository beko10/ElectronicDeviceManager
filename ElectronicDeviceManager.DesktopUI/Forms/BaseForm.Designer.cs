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
            btn_Save = new Button();
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_List = new Button();
            SuspendLayout();
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(12, 21);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 0;
            btn_Save.Text = "Ekle";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(131, 21);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Sil";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(263, 21);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 2;
            btn_Update.Text = "Güncelle";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_List
            // 
            btn_List.Location = new Point(382, 21);
            btn_List.Name = "btn_List";
            btn_List.Size = new Size(75, 23);
            btn_List.TabIndex = 3;
            btn_List.Text = "Listele";
            btn_List.UseVisualStyleBackColor = true;
            btn_List.Click += btn_List_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_List);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Save);
            Name = "BaseForm";
            Text = "BaseForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Save;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_List;
    }
}