namespace mainprog.SubForms
{
    partial class FormOfCar
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
            setmodel_label = new Label();
            setyear_label = new Label();
            model_textBox = new TextBox();
            year_textBox = new TextBox();
            getmodel_label = new Label();
            getyear_label = new Label();
            button = new Button();
            SuspendLayout();
            // 
            // main_label
            // 
            main_label.AutoSize = true;
            main_label.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            main_label.Location = new Point(275, 9);
            main_label.Name = "main_label";
            main_label.Size = new Size(566, 62);
            main_label.TabIndex = 0;
            main_label.Text = "Легковой автомобиль";
            main_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // setmodel_label
            // 
            setmodel_label.AutoSize = true;
            setmodel_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setmodel_label.Location = new Point(76, 151);
            setmodel_label.Name = "setmodel_label";
            setmodel_label.Size = new Size(182, 50);
            setmodel_label.TabIndex = 1;
            setmodel_label.Text = "МОДЕЛЬ:";
            // 
            // setyear_label
            // 
            setyear_label.AutoSize = true;
            setyear_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setyear_label.Location = new Point(76, 225);
            setyear_label.Name = "setyear_label";
            setyear_label.Size = new Size(276, 50);
            setyear_label.TabIndex = 2;
            setyear_label.Text = "ГОД ВЫПУСКА:";
            // 
            // model_textBox
            // 
            model_textBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            model_textBox.Location = new Point(264, 151);
            model_textBox.Name = "model_textBox";
            model_textBox.Size = new Size(472, 57);
            model_textBox.TabIndex = 3;
            // 
            // year_textBox
            // 
            year_textBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            year_textBox.Location = new Point(358, 225);
            year_textBox.Name = "year_textBox";
            year_textBox.Size = new Size(378, 57);
            year_textBox.TabIndex = 4;
            // 
            // getmodel_label
            // 
            getmodel_label.AutoSize = true;
            getmodel_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getmodel_label.Location = new Point(805, 151);
            getmodel_label.Name = "getmodel_label";
            getmodel_label.Size = new Size(174, 50);
            getmodel_label.TabIndex = 5;
            getmodel_label.Text = "МОДЕЛЬ";
            getmodel_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // getyear_label
            // 
            getyear_label.AutoSize = true;
            getyear_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            getyear_label.Location = new Point(805, 228);
            getyear_label.Name = "getyear_label";
            getyear_label.Size = new Size(268, 50);
            getyear_label.TabIndex = 6;
            getyear_label.Text = "ГОД ВЫПУСКА";
            getyear_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(396, 309);
            button.Name = "button";
            button.Size = new Size(340, 77);
            button.TabIndex = 7;
            button.Text = "Установить данные";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // FormOfCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 411);
            Controls.Add(button);
            Controls.Add(getyear_label);
            Controls.Add(getmodel_label);
            Controls.Add(year_textBox);
            Controls.Add(model_textBox);
            Controls.Add(setyear_label);
            Controls.Add(setmodel_label);
            Controls.Add(main_label);
            Name = "FormOfCar";
            Text = "Легковой автомобиль";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label main_label;
        private Label setmodel_label;
        private Label setyear_label;
        private TextBox model_textBox;
        private TextBox year_textBox;
        private Label getmodel_label;
        private Label getyear_label;
        private Button button;
    }
}