namespace CarRental
{
    partial class UserCabinetForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUserInfo = new Label();
            lblFullName = new Label();
            lblPhoneLabel = new Label();
            lblPhone = new Label();
            groupBox1 = new GroupBox();
            btnRent = new Button();
            lblTotalPrice = new Label();
            btnCalculate = new Button();
            txtDays = new TextBox();
            lblDays = new Label();
            cmbCars = new ComboBox();
            lblCar = new Label();
            btnLogout = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserInfo
            // 
            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblUserInfo.Location = new Point(23, 23);
            lblUserInfo.Margin = new Padding(4, 0, 4, 0);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(132, 17);
            lblUserInfo.TabIndex = 0;
            lblUserInfo.Text = "Личный кабинет";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(23, 58);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(0, 15);
            lblFullName.TabIndex = 1;
            // 
            // lblPhoneLabel
            // 
            lblPhoneLabel.AutoSize = true;
            lblPhoneLabel.Location = new Point(23, 92);
            lblPhoneLabel.Margin = new Padding(4, 0, 4, 0);
            lblPhoneLabel.Name = "lblPhoneLabel";
            lblPhoneLabel.Size = new Size(59, 15);
            lblPhoneLabel.TabIndex = 2;
            lblPhoneLabel.Text = "Телефон:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(105, 92);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 15);
            lblPhone.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRent);
            groupBox1.Controls.Add(lblTotalPrice);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(txtDays);
            groupBox1.Controls.Add(lblDays);
            groupBox1.Controls.Add(cmbCars);
            groupBox1.Controls.Add(lblCar);
            groupBox1.Location = new Point(23, 138);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(408, 231);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Аренда автомобиля";
            // 
            // btnRent
            // 
            btnRent.Location = new Point(210, 127);
            btnRent.Margin = new Padding(4, 3, 4, 3);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(140, 35);
            btnRent.TabIndex = 6;
            btnRent.Text = "Арендовать";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalPrice.Location = new Point(23, 185);
            lblTotalPrice.Margin = new Padding(4, 0, 4, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(93, 17);
            lblTotalPrice.TabIndex = 5;
            lblTotalPrice.Text = "Итого: 0.00";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(23, 127);
            btnCalculate.Margin = new Padding(4, 3, 4, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(140, 35);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Рассчитать стоимость";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtDays
            // 
            txtDays.Location = new Point(152, 77);
            txtDays.Margin = new Padding(4, 3, 4, 3);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(58, 23);
            txtDays.TabIndex = 3;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(23, 81);
            lblDays.Margin = new Padding(4, 0, 4, 0);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(104, 15);
            lblDays.TabIndex = 2;
            lblDays.Text = "Количество дней:";
            // 
            // cmbCars
            // 
            cmbCars.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(117, 31);
            cmbCars.Margin = new Padding(4, 3, 4, 3);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(233, 23);
            cmbCars.TabIndex = 1;
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(23, 35);
            lblCar.Margin = new Padding(4, 0, 4, 0);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(79, 15);
            lblCar.TabIndex = 0;
            lblCar.Text = "Автомобиль:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(315, 23);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 35);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // UserCabinetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 404);
            Controls.Add(btnLogout);
            Controls.Add(groupBox1);
            Controls.Add(lblPhone);
            Controls.Add(lblPhoneLabel);
            Controls.Add(lblFullName);
            Controls.Add(lblUserInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserCabinetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Личный кабинет";
            Load += UserCabinetForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.ComboBox cmbCars;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Button btnLogout;
    }
}