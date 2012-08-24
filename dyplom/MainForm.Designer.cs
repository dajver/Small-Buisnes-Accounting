namespace dyplom
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЮрЛицоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИзСправочникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.юридическоеЛицоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.физическоеЛицоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьИнфоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.юрЛицамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.физЛицамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налоговаяОтчетностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьВсеБланкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеПользователямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.показатьИнфоToolStripMenuItem1,
            this.информацияToolStripMenuItem,
            this.налоговаяОтчетностьToolStripMenuItem,
            this.управлениеПользователямиToolStripMenuItem,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(987, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЮрЛицоToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьИзСправочникаToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(100, 23);
            this.fileToolStripMenuItem.Text = "Справочник";
            // 
            // добавитьЮрЛицоToolStripMenuItem
            // 
            this.добавитьЮрЛицоToolStripMenuItem.Image = global::dyplom.Properties.Resources.Windows_Journal;
            this.добавитьЮрЛицоToolStripMenuItem.Name = "добавитьЮрЛицоToolStripMenuItem";
            this.добавитьЮрЛицоToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.добавитьЮрЛицоToolStripMenuItem.Text = "Добавить в справочник";
            this.добавитьЮрЛицоToolStripMenuItem.Click += new System.EventHandler(this.добавитьЮрЛицоToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Image = global::dyplom.Properties.Resources.Windows_JournalЕд1;
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать справочник";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьИзСправочникаToolStripMenuItem
            // 
            this.удалитьИзСправочникаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.юридическоеЛицоToolStripMenuItem,
            this.физическоеЛицоToolStripMenuItem});
            this.удалитьИзСправочникаToolStripMenuItem.Image = global::dyplom.Properties.Resources.Windows_JournalДел;
            this.удалитьИзСправочникаToolStripMenuItem.Name = "удалитьИзСправочникаToolStripMenuItem";
            this.удалитьИзСправочникаToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.удалитьИзСправочникаToolStripMenuItem.Text = "Удалить из справочника";
            // 
            // юридическоеЛицоToolStripMenuItem
            // 
            this.юридическоеЛицоToolStripMenuItem.Image = global::dyplom.Properties.Resources.user_male1;
            this.юридическоеЛицоToolStripMenuItem.Name = "юридическоеЛицоToolStripMenuItem";
            this.юридическоеЛицоToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.юридическоеЛицоToolStripMenuItem.Tag = "UrFace";
            this.юридическоеЛицоToolStripMenuItem.Text = "Юридическое лицо";
            this.юридическоеЛицоToolStripMenuItem.Click += new System.EventHandler(this.Vocabl_Click);
            // 
            // физическоеЛицоToolStripMenuItem
            // 
            this.физическоеЛицоToolStripMenuItem.Image = global::dyplom.Properties.Resources.user_male1;
            this.физическоеЛицоToolStripMenuItem.Name = "физическоеЛицоToolStripMenuItem";
            this.физическоеЛицоToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.физическоеЛицоToolStripMenuItem.Tag = "FizFace";
            this.физическоеЛицоToolStripMenuItem.Text = "Физическое лицо";
            this.физическоеЛицоToolStripMenuItem.Click += new System.EventHandler(this.Vocabl_Click);
            // 
            // показатьИнфоToolStripMenuItem1
            // 
            this.показатьИнфоToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.юрЛицамToolStripMenuItem,
            this.физЛицамToolStripMenuItem});
            this.показатьИнфоToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.показатьИнфоToolStripMenuItem1.Name = "показатьИнфоToolStripMenuItem1";
            this.показатьИнфоToolStripMenuItem1.Size = new System.Drawing.Size(183, 23);
            this.показатьИнфоToolStripMenuItem1.Text = "Просмотреть справочник";
            // 
            // юрЛицамToolStripMenuItem
            // 
            this.юрЛицамToolStripMenuItem.Image = global::dyplom.Properties.Resources.user_male;
            this.юрЛицамToolStripMenuItem.Name = "юрЛицамToolStripMenuItem";
            this.юрЛицамToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.юрЛицамToolStripMenuItem.Tag = "UrFace";
            this.юрЛицамToolStripMenuItem.Text = "Юридических лиц";
            this.юрЛицамToolStripMenuItem.Click += new System.EventHandler(this.Vocabl_Click);
            // 
            // физЛицамToolStripMenuItem
            // 
            this.физЛицамToolStripMenuItem.Image = global::dyplom.Properties.Resources._1301402861_121;
            this.физЛицамToolStripMenuItem.Name = "физЛицамToolStripMenuItem";
            this.физЛицамToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.физЛицамToolStripMenuItem.Tag = "FizFace";
            this.физЛицамToolStripMenuItem.Text = "Физических лиц";
            this.физЛицамToolStripMenuItem.Click += new System.EventHandler(this.Vocabl_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem,
            this.сохранитьВБазуToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.информацияToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Image = global::dyplom.Properties.Resources.refresh;
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // сохранитьВБазуToolStripMenuItem
            // 
            this.сохранитьВБазуToolStripMenuItem.Image = global::dyplom.Properties.Resources.filesaveas;
            this.сохранитьВБазуToolStripMenuItem.Name = "сохранитьВБазуToolStripMenuItem";
            this.сохранитьВБазуToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.сохранитьВБазуToolStripMenuItem.Text = "Сохранить";
            this.сохранитьВБазуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВБазуToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::dyplom.Properties.Resources.images__1_;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // налоговаяОтчетностьToolStripMenuItem
            // 
            this.налоговаяОтчетностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.добавитьToolStripMenuItem2,
            this.toolStripMenuItem1,
            this.просмотретьВсеБланкиToolStripMenuItem});
            this.налоговаяОтчетностьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.налоговаяОтчетностьToolStripMenuItem.Name = "налоговаяОтчетностьToolStripMenuItem";
            this.налоговаяОтчетностьToolStripMenuItem.Size = new System.Drawing.Size(147, 23);
            this.налоговаяОтчетностьToolStripMenuItem.Text = "Бланки отчетностей";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::dyplom.Properties.Resources.бланк1;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(289, 22);
            this.toolStripMenuItem2.Text = "Создать декларацию НДС";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Image = global::dyplom.Properties.Resources.бланк2;
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(289, 22);
            this.добавитьToolStripMenuItem2.Text = "Создать финансовый отчет";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.добавитьToolStripMenuItem2_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::dyplom.Properties.Resources.бланк3;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(289, 22);
            this.toolStripMenuItem1.Text = "Создать декларацию по прибыли";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // просмотретьВсеБланкиToolStripMenuItem
            // 
            this.просмотретьВсеБланкиToolStripMenuItem.Image = global::dyplom.Properties.Resources.old_zoom_original;
            this.просмотретьВсеБланкиToolStripMenuItem.Name = "просмотретьВсеБланкиToolStripMenuItem";
            this.просмотретьВсеБланкиToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.просмотретьВсеБланкиToolStripMenuItem.Text = "Просмотреть все бланки";
            this.просмотретьВсеБланкиToolStripMenuItem.Click += new System.EventHandler(this.просмотретьВсеБланкиToolStripMenuItem_Click);
            // 
            // управлениеПользователямиToolStripMenuItem
            // 
            this.управлениеПользователямиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.просмотретьToolStripMenuItem1,
            this.удалитьПользователяToolStripMenuItem});
            this.управлениеПользователямиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.управлениеПользователямиToolStripMenuItem.Name = "управлениеПользователямиToolStripMenuItem";
            this.управлениеПользователямиToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.управлениеПользователямиToolStripMenuItem.Text = "Пользователи";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = global::dyplom.Properties.Resources.use11111r1;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить нового пользователя";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // просмотретьToolStripMenuItem1
            // 
            this.просмотретьToolStripMenuItem1.Image = global::dyplom.Properties.Resources.user1;
            this.просмотретьToolStripMenuItem1.Name = "просмотретьToolStripMenuItem1";
            this.просмотретьToolStripMenuItem1.Size = new System.Drawing.Size(288, 22);
            this.просмотретьToolStripMenuItem1.Tag = "log";
            this.просмотретьToolStripMenuItem1.Text = "Просмотреть всех пользователей";
            this.просмотретьToolStripMenuItem1.Click += new System.EventHandler(this.Vocabl_Click);
            // 
            // удалитьПользователяToolStripMenuItem
            // 
            this.удалитьПользователяToolStripMenuItem.Image = global::dyplom.Properties.Resources.user1_удал;
            this.удалитьПользователяToolStripMenuItem.Name = "удалитьПользователяToolStripMenuItem";
            this.удалитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.удалитьПользователяToolStripMenuItem.Text = "Удалить пользователя";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оНасToolStripMenuItem});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(26, 23);
            this.toolStripMenuItem3.Text = "?";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Image = global::dyplom.Properties.Resources.communityhelp;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оНасToolStripMenuItem
            // 
            this.оНасToolStripMenuItem.Image = global::dyplom.Properties.Resources.communityhelp__1_;
            this.оНасToolStripMenuItem.Name = "оНасToolStripMenuItem";
            this.оНасToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.оНасToolStripMenuItem.Text = "О программе";
            this.оНасToolStripMenuItem.Click += new System.EventHandler(this.оНасToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(987, 518);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Small Buisness Accounting v1.5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЮрЛицоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьИнфоToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem юрЛицамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem физЛицамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеПользователямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налоговаяОтчетностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВБазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзСправочникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem юридическоеЛицоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem физическоеЛицоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьВсеБланкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оНасToolStripMenuItem;

    }
}