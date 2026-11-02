namespace mainprog.SubForms
{
    partial class FormOfHuman
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
            main_label = new Label();
            setname_label = new Label();
            name_textBox = new TextBox();
            setage_label = new Label();
            age_textBox = new TextBox();
            setadress_label = new Label();
            adress_textBox = new TextBox();
            setnumber_label = new Label();
            number_textBox = new TextBox();
            button = new Button();
            getname_label = new Label();
            getage_label = new Label();
            getadress_label = new Label();
            getnumber_label = new Label();
            SuspendLayout();
            // 
            // main_label
            // 
            main_label.AutoSize = true;
            main_label.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            main_label.Location = new Point(440, 0);
            main_label.Name = "main_label";
            main_label.Size = new Size(377, 106);
            main_label.TabIndex = 0;
            main_label.Text = "Человек";
            // 
            // setname_label
            // 
            setname_label.AutoSize = true;
            setname_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setname_label.Location = new Point(32, 136);
            setname_label.Name = "setname_label";
            setname_label.Size = new Size(113, 50);
            setname_label.TabIndex = 1;
            setname_label.Text = "ФИО:";
            // 
            // name_textBox
            // 
            name_textBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name_textBox.Location = new Point(151, 136);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(583, 57);
            name_textBox.TabIndex = 2;
            // 
            // setage_label
            // 
            setage_label.AutoSize = true;
            setage_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setage_label.Location = new Point(32, 214);
            setage_label.Name = "setage_label";
            setage_label.Size = new Size(186, 50);
            setage_label.TabIndex = 3;
            setage_label.Text = "ВОЗРАСТ:";
            // 
            // age_textBox
            // 
            age_textBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            age_textBox.Location = new Point(224, 211);
            age_textBox.Name = "age_textBox";
            age_textBox.Size = new Size(510, 57);
            age_textBox.TabIndex = 4;
            // 
            // setadress_label
            // 
            setadress_label.AutoSize = true;
            setadress_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setadress_label.Location = new Point(32, 292);
            setadress_label.Name = "setadress_label";
            setadress_label.Size = new Size(143, 50);
            setadress_label.TabIndex = 5;
            setadress_label.Text = "АДРЕС:";
            // 
            // adress_textBox
            // 
            adress_textBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adress_textBox.Location = new Point(181, 292);
            adress_textBox.Name = "adress_textBox";
            adress_textBox.Size = new Size(553, 57);
            adress_textBox.TabIndex = 6;
            // 
            // setnumber_label
            // 
            setnumber_label.AutoSize = true;
            setnumber_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setnumber_label.Location = new Point(32, 372);
            setnumber_label.Name = "setnumber_label";
            setnumber_label.Size = new Size(194, 50);
            setnumber_label.TabIndex = 7;
            setnumber_label.Text = "НОМЕР Т.:";
            // 
            // number_textBox
            // 
            number_textBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            number_textBox.Location = new Point(224, 372);
            number_textBox.Name = "number_textBox";
            number_textBox.Size = new Size(510, 57);
            number_textBox.TabIndex = 8;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(440, 454);
            button.Name = "button";
            button.Size = new Size(361, 55);
            button.TabIndex = 9;
            button.Text = "Установить данные";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // getname_label
            // 
            getname_label.AutoSize = true;
            getname_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getname_label.Location = new Point(808, 136);
            getname_label.Name = "getname_label";
            getname_label.Size = new Size(256, 50);
            getname_label.TabIndex = 10;
            getname_label.Text = "Зеленев Илья";
            getname_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // getage_label
            // 
            getage_label.AutoSize = true;
            getage_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getage_label.Location = new Point(808, 218);
            getage_label.Name = "getage_label";
            getage_label.Size = new Size(0, 50);
            getage_label.TabIndex = 11;
            getage_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // getadress_label
            // 
            getadress_label.AutoSize = true;
            getadress_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getadress_label.Location = new Point(808, 299);
            getadress_label.Name = "getadress_label";
            getadress_label.Size = new Size(232, 50);
            getadress_label.TabIndex = 12;
            getadress_label.Text = "ул. Пушкина";
            getadress_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // getnumber_label
            // 
            getnumber_label.AutoSize = true;
            getnumber_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getnumber_label.Location = new Point(808, 375);
            getnumber_label.Name = "getnumber_label";
            getnumber_label.Size = new Size(346, 50);
            getnumber_label.TabIndex = 13;
            getnumber_label.Text = "НОМЕР ТЕЛЕФОНА";
            getnumber_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormOfHuman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 530);
            Controls.Add(getnumber_label);
            Controls.Add(getadress_label);
            Controls.Add(getage_label);
            Controls.Add(getname_label);
            Controls.Add(button);
            Controls.Add(number_textBox);
            Controls.Add(setnumber_label);
            Controls.Add(adress_textBox);
            Controls.Add(setadress_label);
            Controls.Add(age_textBox);
            Controls.Add(setage_label);
            Controls.Add(name_textBox);
            Controls.Add(setname_label);
            Controls.Add(main_label);
            Name = "FormOfHuman";
            Text = "Человек";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label main_label;
        private Label setname_label;
        private TextBox name_textBox;
        private Label setage_label;
        private TextBox age_textBox;
        private Label setadress_label;
        private TextBox adress_textBox;
        private Label setnumber_label;
        private TextBox number_textBox;
        private Button button;
        private Label getname_label;
        private Label getage_label;
        private Label getadress_label;
        private Label getnumber_label;
    }
}