namespace GUI
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
            this.pageHeader1 = new AntdUI.PageHeader();
            this.button1 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.panel1 = new AntdUI.Panel();
            this.label1 = new AntdUI.Label();
            this.button3 = new AntdUI.Button();
            this.panel2 = new AntdUI.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageHeader1
            // 
            this.pageHeader1.BackColor = System.Drawing.SystemColors.Window;
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.MaximizeBox = false;
            this.pageHeader1.MinimizeBox = false;
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.ShowIcon = true;
            this.pageHeader1.Size = new System.Drawing.Size(944, 33);
            this.pageHeader1.TabIndex = 0;
            this.pageHeader1.Text = "pageHeader1";
            // 
            // button1
            // 
            this.button1.DefaultBack = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(661, 12);
            this.button1.Name = "button1";
            this.button1.Radius = 4;
            this.button1.Size = new System.Drawing.Size(78, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "保存";
            this.button1.WaveSize = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(91, 15);
            this.button2.Name = "button2";
            this.button2.Radius = 4;
            this.button2.Size = new System.Drawing.Size(38, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.WaveSize = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 58);
            this.panel1.TabIndex = 2;
            this.panel1.Text = "panel1";
            // 
            // label1
            // 
            this.label1.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Premiere | 考生号 xxxxxx | 当前时间 $YYYY年$MM月$DD日 $HH:mm:ss";
            // 
            // button3
            // 
            this.button3.DefaultBack = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(745, 12);
            this.button3.Name = "button3";
            this.button3.OriginalBackColor = System.Drawing.SystemColors.Window;
            this.button3.Radius = 4;
            this.button3.Size = new System.Drawing.Size(78, 33);
            this.button3.TabIndex = 1;
            this.button3.Text = "交卷";
            this.button3.WaveSize = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(24, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 473);
            this.panel2.TabIndex = 3;
            this.panel2.Text = "panel2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pageHeader1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private AntdUI.Panel panel2;

        private AntdUI.Button button3;

        private AntdUI.Panel panel1;
        private AntdUI.Label label1;

        private AntdUI.Button button2;

        private AntdUI.Button button1;

        private AntdUI.PageHeader pageHeader1;

        #endregion
    }
}