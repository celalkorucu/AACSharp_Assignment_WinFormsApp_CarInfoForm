namespace AACSharp_Assignment_WinFormsApp_CarInfoForm
{
    partial class Form1
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
            lbl_brand = new Label();
            lbl_model = new Label();
            lbl_color = new Label();
            lbl_doorCount = new Label();
            lbl_windowCount = new Label();
            lbl_fuelBurnedPer100 = new Label();
            text_brand = new TextBox();
            text_model = new TextBox();
            text_color = new TextBox();
            text_doorCount = new TextBox();
            text_windowCount = new TextBox();
            text_fuelBurnedPer100 = new TextBox();
            btn_showInfos = new Button();
            SuspendLayout();
            // 
            // lbl_brand
            // 
            lbl_brand.AutoSize = true;
            lbl_brand.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_brand.Location = new Point(117, 46);
            lbl_brand.Name = "lbl_brand";
            lbl_brand.Size = new Size(84, 25);
            lbl_brand.TabIndex = 0;
            lbl_brand.Text = "Marka : ";
            // 
            // lbl_model
            // 
            lbl_model.AutoSize = true;
            lbl_model.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_model.Location = new Point(117, 96);
            lbl_model.Name = "lbl_model";
            lbl_model.Size = new Size(84, 25);
            lbl_model.TabIndex = 1;
            lbl_model.Text = "Model : ";
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_color.Location = new Point(117, 148);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(72, 25);
            lbl_color.TabIndex = 2;
            lbl_color.Text = "Renk : ";
            // 
            // lbl_doorCount
            // 
            lbl_doorCount.AutoSize = true;
            lbl_doorCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_doorCount.Location = new Point(117, 202);
            lbl_doorCount.Name = "lbl_doorCount";
            lbl_doorCount.Size = new Size(120, 25);
            lbl_doorCount.TabIndex = 3;
            lbl_doorCount.Text = "Kapı Sayısı : ";
            // 
            // lbl_windowCount
            // 
            lbl_windowCount.AutoSize = true;
            lbl_windowCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_windowCount.Location = new Point(117, 256);
            lbl_windowCount.Name = "lbl_windowCount";
            lbl_windowCount.Size = new Size(151, 25);
            lbl_windowCount.TabIndex = 4;
            lbl_windowCount.Text = "Pencere Sayısı : ";
            // 
            // lbl_fuelBurnedPer100
            // 
            lbl_fuelBurnedPer100.AutoSize = true;
            lbl_fuelBurnedPer100.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_fuelBurnedPer100.Location = new Point(117, 314);
            lbl_fuelBurnedPer100.Name = "lbl_fuelBurnedPer100";
            lbl_fuelBurnedPer100.Size = new Size(234, 25);
            lbl_fuelBurnedPer100.TabIndex = 5;
            lbl_fuelBurnedPer100.Text = "100 km'de yaktığı yakıt : ";
            // 
            // text_brand
            // 
            text_brand.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            text_brand.Location = new Point(348, 39);
            text_brand.Margin = new Padding(5);
            text_brand.Name = "text_brand";
            text_brand.Size = new Size(283, 32);
            text_brand.TabIndex = 6;
            // 
            // text_model
            // 
            text_model.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            text_model.Location = new Point(348, 89);
            text_model.Name = "text_model";
            text_model.Size = new Size(283, 32);
            text_model.TabIndex = 7;
            // 
            // text_color
            // 
            text_color.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            text_color.Location = new Point(348, 141);
            text_color.Name = "text_color";
            text_color.Size = new Size(283, 32);
            text_color.TabIndex = 8;
            // 
            // text_doorCount
            // 
            text_doorCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            text_doorCount.Location = new Point(348, 195);
            text_doorCount.Name = "text_doorCount";
            text_doorCount.Size = new Size(283, 32);
            text_doorCount.TabIndex = 9;
            // 
            // text_windowCount
            // 
            text_windowCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            text_windowCount.Location = new Point(348, 249);
            text_windowCount.Name = "text_windowCount";
            text_windowCount.Size = new Size(283, 32);
            text_windowCount.TabIndex = 10;
            // 
            // text_fuelBurnedPer100
            // 
            text_fuelBurnedPer100.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            text_fuelBurnedPer100.Location = new Point(348, 314);
            text_fuelBurnedPer100.Name = "text_fuelBurnedPer100";
            text_fuelBurnedPer100.Size = new Size(283, 32);
            text_fuelBurnedPer100.TabIndex = 11;
            // 
            // btn_showInfos
            // 
            btn_showInfos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_showInfos.Location = new Point(348, 361);
            btn_showInfos.Name = "btn_showInfos";
            btn_showInfos.Size = new Size(283, 52);
            btn_showInfos.TabIndex = 12;
            btn_showInfos.Text = "Bilgileri Göster";
            btn_showInfos.UseVisualStyleBackColor = true;
            btn_showInfos.Click += btn_showInfos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_showInfos);
            Controls.Add(text_fuelBurnedPer100);
            Controls.Add(text_windowCount);
            Controls.Add(text_doorCount);
            Controls.Add(text_color);
            Controls.Add(text_model);
            Controls.Add(text_brand);
            Controls.Add(lbl_fuelBurnedPer100);
            Controls.Add(lbl_windowCount);
            Controls.Add(lbl_doorCount);
            Controls.Add(lbl_color);
            Controls.Add(lbl_model);
            Controls.Add(lbl_brand);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_brand;
        private Label lbl_model;
        private Label lbl_color;
        private Label lbl_doorCount;
        private Label lbl_windowCount;
        private Label lbl_fuelBurnedPer100;
        private TextBox text_brand;
        private TextBox text_model;
        private TextBox text_color;
        private TextBox text_doorCount;
        private TextBox text_windowCount;
        private TextBox text_fuelBurnedPer100;
        private Button btn_showInfos;
    }
}
