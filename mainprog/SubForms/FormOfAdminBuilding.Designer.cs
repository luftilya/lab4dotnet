namespace mainprog.SubForms
{
    partial class FormOfAdminBuilding
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
            setfunc_label = new Label();
            func_textBox = new TextBox();
            label1 = new Label();
            square_textBox = new TextBox();
            button = new Button();
            getsquare_label = new Label();
            getfunc_label = new Label();
            getname_label = new Label();
            SuspendLayout();
            // 
            // main_label
            // 
            main_label.AutoSize = true;
            main_label.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            main_label.Location = new Point(370, 9);
            main_label.Name = "main_label";
            main_label.Size = new Size(865, 81);
            main_label.TabIndex = 0;
            main_label.Text = "Административное здание";
            // 
            // setname_label
            // 
            setname_label.AutoSize = true;
            setname_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setname_label.Location = new Point(101, 145);
            setname_label.Name = "setname_label";
            setname_label.Size = new Size(206, 100);
            setname_label.TabIndex = 1;
            setname_label.Text = "Название\r\nзаведения:";
            setname_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name_textBox
            // 
            name_textBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name_textBox.Location = new Point(313, 167);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(653, 57);
            name_textBox.TabIndex = 2;
            // 
            // setfunc_label
            // 
            setfunc_label.AutoSize = true;
            setfunc_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setfunc_label.Location = new Point(130, 276);
            setfunc_label.Name = "setfunc_label";
            setfunc_label.Size = new Size(177, 50);
            setfunc_label.TabIndex = 3;
            setfunc_label.Text = "Функция:";
            // 
            // func_textBox
            // 
            func_textBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            func_textBox.Location = new Point(313, 276);
            func_textBox.Name = "func_textBox";
            func_textBox.Size = new Size(653, 57);
            func_textBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(42, 363);
            label1.Name = "label1";
            label1.Size = new Size(265, 50);
            label1.TabIndex = 5;
            label1.Text = "Площадь (м2):";
            // 
            // square_textBox
            // 
            square_textBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            square_textBox.Location = new Point(313, 363);
            square_textBox.Name = "square_textBox";
            square_textBox.Size = new Size(653, 57);
            square_textBox.TabIndex = 6;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(413, 445);
            button.Name = "button";
            button.Size = new Size(374, 59);
            button.TabIndex = 7;
            button.Text = "Установить данные";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // getsquare_label
            // 
            getsquare_label.AutoSize = true;
            getsquare_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getsquare_label.Location = new Point(1040, 363);
            getsquare_label.Name = "getsquare_label";
            getsquare_label.Size = new Size(257, 50);
            getsquare_label.TabIndex = 10;
            getsquare_label.Text = "Площадь (м2)";
            // 
            // getfunc_label
            // 
            getfunc_label.AutoSize = true;
            getfunc_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getfunc_label.Location = new Point(1040, 276);
            getfunc_label.Name = "getfunc_label";
            getfunc_label.Size = new Size(169, 50);
            getfunc_label.TabIndex = 9;
            getfunc_label.Text = "Функция";
            // 
            // getname_label
            // 
            getname_label.AutoSize = true;
            getname_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getname_label.Location = new Point(1040, 174);
            getname_label.Name = "getname_label";
            getname_label.Size = new Size(185, 50);
            getname_label.TabIndex = 8;
            getname_label.Text = "Название";
            getname_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormOfAdminBuilding
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 543);
            Controls.Add(getsquare_label);
            Controls.Add(getfunc_label);
            Controls.Add(getname_label);
            Controls.Add(button);
            Controls.Add(square_textBox);
            Controls.Add(label1);
            Controls.Add(func_textBox);
            Controls.Add(setfunc_label);
            Controls.Add(name_textBox);
            Controls.Add(setname_label);
            Controls.Add(main_label);
            Name = "FormOfAdminBuilding";
            Text = "Административное здание";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label main_label;
        private Label setname_label;
        private TextBox name_textBox;
        private Label setfunc_label;
        private TextBox func_textBox;
        private Label label1;
        private TextBox square_textBox;
        private Button button;
        private Label getsquare_label;
        private Label getfunc_label;
        private Label getname_label;
    }
}