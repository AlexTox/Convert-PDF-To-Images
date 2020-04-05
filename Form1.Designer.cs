namespace PDFTools
{
    partial class PDFToolsMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFToolsMainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImageFormatComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OutputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.StartConvertationButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DpiBox = new System.Windows.Forms.NumericUpDown();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DpiBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(328, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // InputTextBox
            // 
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox.Location = new System.Drawing.Point(12, 106);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ReadOnly = true;
            this.InputTextBox.Size = new System.Drawing.Size(310, 27);
            this.InputTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь до PDF Файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь для вывода изображений";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTextBox.Location = new System.Drawing.Point(12, 160);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(310, 27);
            this.OutputTextBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button2.Location = new System.Drawing.Point(328, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Указать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OutputChooseButton_OnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "PDF TO IMAGES CONVERTER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(77, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "By MDA | Сообщество разработчиков";
            // 
            // ImageFormatComboBox
            // 
            this.ImageFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageFormatComboBox.FormattingEnabled = true;
            this.ImageFormatComboBox.Items.AddRange(new object[] {
            "JPEG (.jpg)",
            "PNG (.png)",
            "BMP (.bmp)"});
            this.ImageFormatComboBox.Location = new System.Drawing.Point(12, 218);
            this.ImageFormatComboBox.Name = "ImageFormatComboBox";
            this.ImageFormatComboBox.Size = new System.Drawing.Size(117, 21);
            this.ImageFormatComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Формат изображений";
            // 
            // StartConvertationButton
            // 
            this.StartConvertationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartConvertationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.StartConvertationButton.Location = new System.Drawing.Point(235, 202);
            this.StartConvertationButton.Name = "StartConvertationButton";
            this.StartConvertationButton.Size = new System.Drawing.Size(183, 37);
            this.StartConvertationButton.TabIndex = 11;
            this.StartConvertationButton.Text = "Конвертировать";
            this.StartConvertationButton.UseVisualStyleBackColor = true;
            this.StartConvertationButton.Click += new System.EventHandler(this.StartConvertationButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DPI";
            // 
            // DpiBox
            // 
            this.DpiBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DpiBox.Location = new System.Drawing.Point(151, 219);
            this.DpiBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DpiBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DpiBox.Name = "DpiBox";
            this.DpiBox.Size = new System.Drawing.Size(78, 20);
            this.DpiBox.TabIndex = 13;
            this.DpiBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DpiBox.ValueChanged += new System.EventHandler(this.DpiBox_ValueChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 245);
            this.ProgressBar.MarqueeAnimationSpeed = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(406, 23);
            this.ProgressBar.Step = 5;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.TabIndex = 14;
            this.ProgressBar.Value = 14;
            // 
            // PDFToolsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 275);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.DpiBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StartConvertationButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ImageFormatComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PDFToolsMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PDF TO IMAGES | MDA";
            this.Load += new System.EventHandler(this.PDFToolsMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DpiBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ImageFormatComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog OutputFolderBrowserDialog;
        private System.Windows.Forms.Button StartConvertationButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown DpiBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

