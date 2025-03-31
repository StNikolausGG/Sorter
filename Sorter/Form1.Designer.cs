namespace Sorter
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Upload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Loader = new System.Windows.Forms.FolderBrowserDialog();
            this.AllFiles = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.CheckBox();
            this.Video = new System.Windows.Forms.CheckBox();
            this.Doc = new System.Windows.Forms.CheckBox();
            this.Audio = new System.Windows.Forms.CheckBox();
            this.Sort = new System.Windows.Forms.Button();
            this.Archives = new System.Windows.Forms.CheckBox();
            this.App = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Upload.Location = new System.Drawing.Point(37, 26);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(113, 38);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "Обзор...";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(196, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ожидание...";
            // 
            // AllFiles
            // 
            this.AllFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllFiles.Location = new System.Drawing.Point(37, 70);
            this.AllFiles.Multiline = true;
            this.AllFiles.Name = "AllFiles";
            this.AllFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AllFiles.Size = new System.Drawing.Size(351, 368);
            this.AllFiles.TabIndex = 2;
            // 
            // Picture
            // 
            this.Picture.AutoSize = true;
            this.Picture.Checked = true;
            this.Picture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Picture.Location = new System.Drawing.Point(414, 72);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(109, 20);
            this.Picture.TabIndex = 3;
            this.Picture.Text = "Фотографии";
            this.Picture.UseVisualStyleBackColor = true;
            this.Picture.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Video
            // 
            this.Video.AutoSize = true;
            this.Video.Checked = true;
            this.Video.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Video.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Video.Location = new System.Drawing.Point(414, 98);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(67, 20);
            this.Video.TabIndex = 3;
            this.Video.Text = "Видео";
            this.Video.UseVisualStyleBackColor = true;
            this.Video.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Doc
            // 
            this.Doc.AutoSize = true;
            this.Doc.Checked = true;
            this.Doc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Doc.Location = new System.Drawing.Point(414, 124);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(99, 20);
            this.Doc.TabIndex = 3;
            this.Doc.Text = "Документы";
            this.Doc.UseVisualStyleBackColor = true;
            this.Doc.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Audio
            // 
            this.Audio.AutoSize = true;
            this.Audio.Checked = true;
            this.Audio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Audio.Location = new System.Drawing.Point(414, 150);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(67, 20);
            this.Audio.TabIndex = 3;
            this.Audio.Text = "Аудио";
            this.Audio.UseVisualStyleBackColor = true;
            this.Audio.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Sort
            // 
            this.Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort.Location = new System.Drawing.Point(414, 403);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(109, 23);
            this.Sort.TabIndex = 4;
            this.Sort.Text = "Сортировать";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Archives
            // 
            this.Archives.AutoSize = true;
            this.Archives.Checked = true;
            this.Archives.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Archives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Archives.Location = new System.Drawing.Point(414, 176);
            this.Archives.Name = "Archives";
            this.Archives.Size = new System.Drawing.Size(74, 20);
            this.Archives.TabIndex = 3;
            this.Archives.Text = "Архивы";
            this.Archives.UseVisualStyleBackColor = true;
            this.Archives.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // App
            // 
            this.App.AutoSize = true;
            this.App.Checked = true;
            this.App.CheckState = System.Windows.Forms.CheckState.Checked;
            this.App.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.App.Location = new System.Drawing.Point(414, 202);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(108, 20);
            this.App.TabIndex = 3;
            this.App.Text = "Приложения";
            this.App.UseVisualStyleBackColor = true;
            this.App.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.App);
            this.Controls.Add(this.Archives);
            this.Controls.Add(this.Audio);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.AllFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Upload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Сортировщик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog Loader;
        public System.Windows.Forms.TextBox AllFiles;
        private System.Windows.Forms.CheckBox Picture;
        private System.Windows.Forms.CheckBox Video;
        private System.Windows.Forms.CheckBox Doc;
        private System.Windows.Forms.CheckBox Audio;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.CheckBox Archives;
        private System.Windows.Forms.CheckBox App;
    }
}

