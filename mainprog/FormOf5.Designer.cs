namespace mainprog
{
    partial class FormOf5
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
            history_label = new Label();
            human_label = new Label();
            car_label = new Label();
            ab_label = new Label();
            human_gobutton = new Button();
            car_gobutton = new Button();
            ab_gobutton = new Button();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(12, 9);
            history_label.Name = "history_label";
            history_label.Size = new Size(1013, 62);
            history_label.TabIndex = 0;
            history_label.Text = "Создать массив трёх различных записей";
            // 
            // human_label
            // 
            human_label.AutoSize = true;
            human_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            human_label.Location = new Point(137, 195);
            human_label.Name = "human_label";
            human_label.Size = new Size(135, 41);
            human_label.TabIndex = 1;
            human_label.Text = "Человек";
            // 
            // car_label
            // 
            car_label.AutoSize = true;
            car_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            car_label.Location = new Point(417, 174);
            car_label.Name = "car_label";
            car_label.Size = new Size(183, 82);
            car_label.TabIndex = 2;
            car_label.Text = "Легковой\r\nавтомобиль";
            car_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ab_label
            // 
            ab_label.AutoSize = true;
            ab_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ab_label.Location = new Point(724, 174);
            ab_label.Name = "ab_label";
            ab_label.Size = new Size(280, 82);
            ab_label.TabIndex = 3;
            ab_label.Text = "Административное\r\nздание";
            ab_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // human_gobutton
            // 
            human_gobutton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            human_gobutton.Location = new Point(110, 296);
            human_gobutton.Name = "human_gobutton";
            human_gobutton.Size = new Size(189, 63);
            human_gobutton.TabIndex = 4;
            human_gobutton.Text = "перейти";
            human_gobutton.UseVisualStyleBackColor = true;
            human_gobutton.Click += human_gobutton_Click;
            // 
            // car_gobutton
            // 
            car_gobutton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            car_gobutton.Location = new Point(417, 296);
            car_gobutton.Name = "car_gobutton";
            car_gobutton.Size = new Size(189, 63);
            car_gobutton.TabIndex = 5;
            car_gobutton.Text = "перейти";
            car_gobutton.UseVisualStyleBackColor = true;
            car_gobutton.Click += car_gobutton_Click;
            // 
            // ab_gobutton
            // 
            ab_gobutton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ab_gobutton.Location = new Point(767, 296);
            ab_gobutton.Name = "ab_gobutton";
            ab_gobutton.Size = new Size(189, 63);
            ab_gobutton.TabIndex = 6;
            ab_gobutton.Text = "перейти";
            ab_gobutton.UseVisualStyleBackColor = true;
            ab_gobutton.Click += ab_gobutton_Click;
            // 
            // FormOf5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 450);
            Controls.Add(ab_gobutton);
            Controls.Add(car_gobutton);
            Controls.Add(human_gobutton);
            Controls.Add(ab_label);
            Controls.Add(car_label);
            Controls.Add(human_label);
            Controls.Add(history_label);
            Name = "FormOf5";
            Text = "Создать массив трёх различных записей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private Label human_label;
        private Label car_label;
        private Label ab_label;
        private Button human_gobutton;
        private Button car_gobutton;
        private Button ab_gobutton;
    }
}
