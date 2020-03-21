namespace MovieORM
{
    partial class Form1
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
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.films = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Awards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцийЗаФилмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавиВКаталогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.премахниОтКаталогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактиранеНаФилмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.връзкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтрийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактирайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанровеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.films)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(13, 30);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(692, 44);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.Text = "Въведете име на филм...";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // films
            // 
            this.films.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.films.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FilmName,
            this.Actors,
            this.Producers,
            this.Genre,
            this.Awards,
            this.YearOfCreation,
            this.Duration});
            this.films.Location = new System.Drawing.Point(13, 111);
            this.films.Name = "films";
            this.films.Size = new System.Drawing.Size(842, 456);
            this.films.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ИД";
            this.ID.Name = "ID";
            // 
            // FilmName
            // 
            this.FilmName.HeaderText = "Име на филм";
            this.FilmName.Name = "FilmName";
            // 
            // Actors
            // 
            this.Actors.HeaderText = "Актьори";
            this.Actors.Name = "Actors";
            // 
            // Producers
            // 
            this.Producers.HeaderText = "Продуценти";
            this.Producers.Name = "Producers";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Жанр";
            this.Genre.Name = "Genre";
            // 
            // Awards
            // 
            this.Awards.HeaderText = "Награди";
            this.Awards.Name = "Awards";
            // 
            // YearOfCreation
            // 
            this.YearOfCreation.HeaderText = "Година на създаване";
            this.YearOfCreation.Name = "YearOfCreation";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Продължителност";
            this.Duration.Name = "Duration";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцийЗаФилмToolStripMenuItem,
            this.връзкаToolStripMenuItem,
            this.хораToolStripMenuItem,
            this.жанровеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опцийЗаФилмToolStripMenuItem
            // 
            this.опцийЗаФилмToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиВКаталогаToolStripMenuItem,
            this.премахниОтКаталогаToolStripMenuItem,
            this.редактиранеНаФилмToolStripMenuItem});
            this.опцийЗаФилмToolStripMenuItem.Name = "опцийЗаФилмToolStripMenuItem";
            this.опцийЗаФилмToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.опцийЗаФилмToolStripMenuItem.Text = "Опций за филм";
            // 
            // добавиВКаталогаToolStripMenuItem
            // 
            this.добавиВКаталогаToolStripMenuItem.Name = "добавиВКаталогаToolStripMenuItem";
            this.добавиВКаталогаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.добавиВКаталогаToolStripMenuItem.Text = "Добави в каталога";
            // 
            // премахниОтКаталогаToolStripMenuItem
            // 
            this.премахниОтКаталогаToolStripMenuItem.Name = "премахниОтКаталогаToolStripMenuItem";
            this.премахниОтКаталогаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.премахниОтКаталогаToolStripMenuItem.Text = "Премахни от каталога";
            // 
            // редактиранеНаФилмToolStripMenuItem
            // 
            this.редактиранеНаФилмToolStripMenuItem.Name = "редактиранеНаФилмToolStripMenuItem";
            this.редактиранеНаФилмToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.редактиранеНаФилмToolStripMenuItem.Text = "Редактиране на филм";
            // 
            // връзкаToolStripMenuItem
            // 
            this.връзкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестToolStripMenuItem});
            this.връзкаToolStripMenuItem.Name = "връзкаToolStripMenuItem";
            this.връзкаToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.връзкаToolStripMenuItem.Text = "Връзка";
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тестToolStripMenuItem.Text = "Тест";
            // 
            // хораToolStripMenuItem
            // 
            this.хораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиToolStripMenuItem,
            this.изтрийToolStripMenuItem,
            this.редактирайToolStripMenuItem});
            this.хораToolStripMenuItem.Name = "хораToolStripMenuItem";
            this.хораToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.хораToolStripMenuItem.Text = "Хора";
            // 
            // добавиToolStripMenuItem
            // 
            this.добавиToolStripMenuItem.Name = "добавиToolStripMenuItem";
            this.добавиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавиToolStripMenuItem.Text = "Добави";
            // 
            // изтрийToolStripMenuItem
            // 
            this.изтрийToolStripMenuItem.Name = "изтрийToolStripMenuItem";
            this.изтрийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изтрийToolStripMenuItem.Text = "Изтрий";
            // 
            // редактирайToolStripMenuItem
            // 
            this.редактирайToolStripMenuItem.Name = "редактирайToolStripMenuItem";
            this.редактирайToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редактирайToolStripMenuItem.Text = "Редактирай";
            // 
            // жанровеToolStripMenuItem
            // 
            this.жанровеToolStripMenuItem.Name = "жанровеToolStripMenuItem";
            this.жанровеToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.жанровеToolStripMenuItem.Text = "Жанрове";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 633);
            this.Controls.Add(this.films);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Каталог за филми";
            ((System.ComponentModel.ISupportInitialize)(this.films)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.DataGridView films;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Awards;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опцийЗаФилмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавиВКаталогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem премахниОтКаталогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактиранеНаФилмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem връзкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изтрийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактирайToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанровеToolStripMenuItem;
    }
}

