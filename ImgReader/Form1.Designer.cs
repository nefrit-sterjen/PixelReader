
namespace ImgReader
{
    partial class ImgReader
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.writeBoxPath = new System.Windows.Forms.TextBox();
            this.buttonWritePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReadPath = new System.Windows.Forms.Button();
            this.readBoxPath = new System.Windows.Forms.TextBox();
            this.buttonAddImg = new System.Windows.Forms.Button();
            this.buttonWritePix = new System.Windows.Forms.Button();
            this.buttonReadPix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(46, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(279, 309);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // writeBoxPath
            // 
            this.writeBoxPath.Location = new System.Drawing.Point(532, 55);
            this.writeBoxPath.Name = "writeBoxPath";
            this.writeBoxPath.Size = new System.Drawing.Size(202, 20);
            this.writeBoxPath.TabIndex = 1;
            // 
            // buttonWritePath
            // 
            this.buttonWritePath.Location = new System.Drawing.Point(532, 92);
            this.buttonWritePath.Name = "buttonWritePath";
            this.buttonWritePath.Size = new System.Drawing.Size(202, 23);
            this.buttonWritePath.TabIndex = 2;
            this.buttonWritePath.Text = "выбрать файл";
            this.buttonWritePath.UseVisualStyleBackColor = true;
            this.buttonWritePath.Click += new System.EventHandler(this.buttonWritePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь для записи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь для чтения";
            // 
            // buttonReadPath
            // 
            this.buttonReadPath.Location = new System.Drawing.Point(535, 227);
            this.buttonReadPath.Name = "buttonReadPath";
            this.buttonReadPath.Size = new System.Drawing.Size(202, 23);
            this.buttonReadPath.TabIndex = 5;
            this.buttonReadPath.Text = "выбрать файл";
            this.buttonReadPath.UseVisualStyleBackColor = true;
            this.buttonReadPath.Click += new System.EventHandler(this.buttonReadPath_Click);
            // 
            // readBoxPath
            // 
            this.readBoxPath.Location = new System.Drawing.Point(535, 190);
            this.readBoxPath.Name = "readBoxPath";
            this.readBoxPath.Size = new System.Drawing.Size(202, 20);
            this.readBoxPath.TabIndex = 4;
            // 
            // buttonAddImg
            // 
            this.buttonAddImg.Location = new System.Drawing.Point(73, 403);
            this.buttonAddImg.Name = "buttonAddImg";
            this.buttonAddImg.Size = new System.Drawing.Size(202, 23);
            this.buttonAddImg.TabIndex = 7;
            this.buttonAddImg.Text = "выбрать картинку";
            this.buttonAddImg.UseVisualStyleBackColor = true;
            this.buttonAddImg.Click += new System.EventHandler(this.buttonAddImg_Click);
            // 
            // buttonWritePix
            // 
            this.buttonWritePix.Location = new System.Drawing.Point(532, 399);
            this.buttonWritePix.Name = "buttonWritePix";
            this.buttonWritePix.Size = new System.Drawing.Size(147, 23);
            this.buttonWritePix.TabIndex = 8;
            this.buttonWritePix.Text = "Записать пиксели";
            this.buttonWritePix.UseVisualStyleBackColor = true;
            this.buttonWritePix.Click += new System.EventHandler(this.buttonWritePix_Click);
            // 
            // buttonReadPix
            // 
            this.buttonReadPix.Location = new System.Drawing.Point(720, 399);
            this.buttonReadPix.Name = "buttonReadPix";
            this.buttonReadPix.Size = new System.Drawing.Size(147, 23);
            this.buttonReadPix.TabIndex = 9;
            this.buttonReadPix.Text = "Прочитать пиксели";
            this.buttonReadPix.UseVisualStyleBackColor = true;
            this.buttonReadPix.Click += new System.EventHandler(this.buttonReadPix_Click);
            // 
            // ImgReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 881);
            this.Controls.Add(this.buttonReadPix);
            this.Controls.Add(this.buttonWritePix);
            this.Controls.Add(this.buttonAddImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReadPath);
            this.Controls.Add(this.readBoxPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWritePath);
            this.Controls.Add(this.writeBoxPath);
            this.Controls.Add(this.pictureBox);
            this.Name = "ImgReader";
            this.Text = "Image reader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox writeBoxPath;
        private System.Windows.Forms.Button buttonWritePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReadPath;
        private System.Windows.Forms.TextBox readBoxPath;
        private System.Windows.Forms.Button buttonAddImg;
        private System.Windows.Forms.Button buttonWritePix;
        private System.Windows.Forms.Button buttonReadPix;
    }
}

