namespace winform5
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anotherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(439, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.cloneRepositoryToolStripMenuItem,
            this.startWindowToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anotherToolStripMenuItem,
            this.oneMoreToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "new";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "open";
            // 
            // cloneRepositoryToolStripMenuItem
            // 
            this.cloneRepositoryToolStripMenuItem.Name = "cloneRepositoryToolStripMenuItem";
            this.cloneRepositoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cloneRepositoryToolStripMenuItem.Text = "clone repository";
            // 
            // startWindowToolStripMenuItem
            // 
            this.startWindowToolStripMenuItem.Name = "startWindowToolStripMenuItem";
            this.startWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startWindowToolStripMenuItem.Text = "start window";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBoxToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.areaToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "edit";
            // 
            // toolBoxToolStripMenuItem
            // 
            this.toolBoxToolStripMenuItem.Name = "toolBoxToolStripMenuItem";
            this.toolBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolBoxToolStripMenuItem.Text = "tool box";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sizeToolStripMenuItem.Text = "size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.areaToolStripMenuItem.Text = "area";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullToolStripMenuItem,
            this.partialToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.viewToolStripMenuItem.Text = "view";
            // 
            // fullToolStripMenuItem
            // 
            this.fullToolStripMenuItem.Name = "fullToolStripMenuItem";
            this.fullToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fullToolStripMenuItem.Text = "full";
            // 
            // partialToolStripMenuItem
            // 
            this.partialToolStripMenuItem.Name = "partialToolStripMenuItem";
            this.partialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.partialToolStripMenuItem.Text = "partial";
            // 
            // anotherToolStripMenuItem
            // 
            this.anotherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOneToolStripMenuItem});
            this.anotherToolStripMenuItem.Name = "anotherToolStripMenuItem";
            this.anotherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anotherToolStripMenuItem.Text = "another";
            // 
            // oneMoreToolStripMenuItem
            // 
            this.oneMoreToolStripMenuItem.Name = "oneMoreToolStripMenuItem";
            this.oneMoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oneMoreToolStripMenuItem.Text = "one more";
            // 
            // newOneToolStripMenuItem
            // 
            this.newOneToolStripMenuItem.Name = "newOneToolStripMenuItem";
            this.newOneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newOneToolStripMenuItem.Text = "new one";
            this.newOneToolStripMenuItem.Click += new System.EventHandler(this.newOneToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anotherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneMoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneRepositoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partialToolStripMenuItem;
    }
}

