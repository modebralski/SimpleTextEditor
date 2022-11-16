namespace SimpleTextEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.wybierzwszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.edytujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noweToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // noweToolStripMenuItem
            // 
            this.noweToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noweToolStripMenuItem.Image")));
            this.noweToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.noweToolStripMenuItem.Name = "noweToolStripMenuItem";
            this.noweToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.noweToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.noweToolStripMenuItem.Text = "&Nowe";
            this.noweToolStripMenuItem.Click += new System.EventHandler(this.noweToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("otwórzToolStripMenuItem.Image")));
            this.otwórzToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.otwórzToolStripMenuItem.Text = "&Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zapiszToolStripMenuItem.Image")));
            this.zapiszToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zapiszToolStripMenuItem.Text = "&Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zakończToolStripMenuItem.Text = "&Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.wytnijToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.wybierzwszystkoToolStripMenuItem});
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.edytujToolStripMenuItem.Text = "&Edytuj";
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cofnijToolStripMenuItem.Text = "&Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("wytnijToolStripMenuItem.Image")));
            this.wytnijToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wytnijToolStripMenuItem.Text = "Wyt&nij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // wybierzwszystkoToolStripMenuItem
            // 
            this.wybierzwszystkoToolStripMenuItem.Name = "wybierzwszystkoToolStripMenuItem";
            this.wybierzwszystkoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wybierzwszystkoToolStripMenuItem.Text = "Wybier&z wszystko";
            this.wybierzwszystkoToolStripMenuItem.Click += new System.EventHandler(this.wybierzwszystkoToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simple Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem noweToolStripMenuItem;
        private ToolStripMenuItem otwórzToolStripMenuItem;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem zakończToolStripMenuItem;
        private ToolStripMenuItem edytujToolStripMenuItem;
        private ToolStripMenuItem cofnijToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem wytnijToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem wybierzwszystkoToolStripMenuItem;
        private RichTextBox richTextBox1;
    }
}