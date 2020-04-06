namespace DragAndDrop2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSourceDrag2 = new System.Windows.Forms.Button();
            this.textBoxTargetDrop = new System.Windows.Forms.TextBox();
            this.buttonSourceDrag = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxSourceDrag = new System.Windows.Forms.PictureBox();
            this.panelTargetDrop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourceDrag)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSourceDrag2);
            this.panel1.Controls.Add(this.textBoxTargetDrop);
            this.panel1.Controls.Add(this.buttonSourceDrag);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 124);
            this.panel1.TabIndex = 0;
            // 
            // buttonSourceDrag2
            // 
            this.buttonSourceDrag2.Location = new System.Drawing.Point(92, 63);
            this.buttonSourceDrag2.Name = "buttonSourceDrag2";
            this.buttonSourceDrag2.Size = new System.Drawing.Size(141, 23);
            this.buttonSourceDrag2.TabIndex = 2;
            this.buttonSourceDrag2.Text = "Артур";
            this.buttonSourceDrag2.UseVisualStyleBackColor = true;
            this.buttonSourceDrag2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSourceDrag2_MouseDown);
            // 
            // textBoxTargetDrop
            // 
            this.textBoxTargetDrop.AllowDrop = true;
            this.textBoxTargetDrop.Location = new System.Drawing.Point(460, 49);
            this.textBoxTargetDrop.Name = "textBoxTargetDrop";
            this.textBoxTargetDrop.Size = new System.Drawing.Size(200, 20);
            this.textBoxTargetDrop.TabIndex = 1;
            this.textBoxTargetDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxTargetDrop_DragDrop);
            this.textBoxTargetDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxTargetDrop_DragEnter);
            // 
            // buttonSourceDrag
            // 
            this.buttonSourceDrag.Location = new System.Drawing.Point(92, 23);
            this.buttonSourceDrag.Name = "buttonSourceDrag";
            this.buttonSourceDrag.Size = new System.Drawing.Size(141, 23);
            this.buttonSourceDrag.TabIndex = 0;
            this.buttonSourceDrag.Text = "тащи";
            this.buttonSourceDrag.UseVisualStyleBackColor = true;
            this.buttonSourceDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSourceDrag_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTargetDrop);
            this.panel2.Controls.Add(this.pictureBoxSourceDrag);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 204);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxSourceDrag
            // 
            this.pictureBoxSourceDrag.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSourceDrag.Image")));
            this.pictureBoxSourceDrag.Location = new System.Drawing.Point(92, 17);
            this.pictureBoxSourceDrag.Name = "pictureBoxSourceDrag";
            this.pictureBoxSourceDrag.Size = new System.Drawing.Size(215, 167);
            this.pictureBoxSourceDrag.TabIndex = 0;
            this.pictureBoxSourceDrag.TabStop = false;
            this.pictureBoxSourceDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSourceDrag_MouseDown);
            // 
            // panelTargetDrop
            // 
            this.panelTargetDrop.AllowDrop = true;
            this.panelTargetDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTargetDrop.Location = new System.Drawing.Point(429, 17);
            this.panelTargetDrop.Name = "panelTargetDrop";
            this.panelTargetDrop.Size = new System.Drawing.Size(306, 167);
            this.panelTargetDrop.TabIndex = 1;
            this.panelTargetDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTargetDrop_DragDrop);
            this.panelTargetDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTargetDrop_DragEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "DragAndDrop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourceDrag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTargetDrop;
        private System.Windows.Forms.Button buttonSourceDrag;
        private System.Windows.Forms.Button buttonSourceDrag2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTargetDrop;
        private System.Windows.Forms.PictureBox pictureBoxSourceDrag;
    }
}

