namespace GearBox
{
    partial class EasyGearBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyGearBox));
            this.button0 = new System.Windows.Forms.Button();
            this.textBoxOn = new System.Windows.Forms.TextBox();
            this.textBoxOff = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.fLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fLPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxGearBox = new System.Windows.Forms.TextBox();
            this.textBoxRPS = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(206, 12);
            this.button0.Margin = new System.Windows.Forms.Padding(0);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(20, 20);
            this.button0.TabIndex = 0;
            this.button0.Text = "+";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // textBoxOn
            // 
            this.textBoxOn.Enabled = false;
            this.textBoxOn.Location = new System.Drawing.Point(54, 12);
            this.textBoxOn.Name = "textBoxOn";
            this.textBoxOn.Size = new System.Drawing.Size(70, 20);
            this.textBoxOn.TabIndex = 10;
            this.textBoxOn.Text = "On";
            this.textBoxOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOff
            // 
            this.textBoxOff.Enabled = false;
            this.textBoxOff.Location = new System.Drawing.Point(130, 12);
            this.textBoxOff.Name = "textBoxOff";
            this.textBoxOff.Size = new System.Drawing.Size(70, 20);
            this.textBoxOff.TabIndex = 11;
            this.textBoxOff.Text = "Off";
            this.textBoxOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.Location = new System.Drawing.Point(12, 266);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(214, 46);
            this.buttonCount.TabIndex = 2;
            this.buttonCount.Text = "Calculate";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // fLPanel
            // 
            this.fLPanel.AutoScroll = true;
            this.fLPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLPanel.Location = new System.Drawing.Point(11, 38);
            this.fLPanel.Name = "fLPanel";
            this.fLPanel.Size = new System.Drawing.Size(216, 222);
            this.fLPanel.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0-100";
            this.toolTip1.SetToolTip(this.textBox1, "Minimum RPS difference between near gears in %");
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(232, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fLPanel1
            // 
            this.fLPanel1.AutoScroll = true;
            this.fLPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLPanel1.Location = new System.Drawing.Point(231, 38);
            this.fLPanel1.Name = "fLPanel1";
            this.fLPanel1.Size = new System.Drawing.Size(180, 222);
            this.fLPanel1.TabIndex = 13;
            // 
            // textBoxGearBox
            // 
            this.textBoxGearBox.Enabled = false;
            this.textBoxGearBox.Location = new System.Drawing.Point(232, 12);
            this.textBoxGearBox.Name = "textBoxGearBox";
            this.textBoxGearBox.Size = new System.Drawing.Size(72, 20);
            this.textBoxGearBox.TabIndex = 36;
            this.textBoxGearBox.Text = "Gears";
            this.textBoxGearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRPS
            // 
            this.textBoxRPS.Enabled = false;
            this.textBoxRPS.Location = new System.Drawing.Point(310, 12);
            this.textBoxRPS.Name = "textBoxRPS";
            this.textBoxRPS.Size = new System.Drawing.Size(57, 20);
            this.textBoxRPS.TabIndex = 37;
            this.textBoxRPS.Text = "RPS";
            this.textBoxRPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(373, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 38;
            this.textBox2.Text = "0";
            this.toolTip1.SetToolTip(this.textBox2, "Number of gears");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // EasyGearBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 324);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxRPS);
            this.Controls.Add(this.textBoxGearBox);
            this.Controls.Add(this.fLPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.fLPanel);
            this.Controls.Add(this.textBoxOff);
            this.Controls.Add(this.textBoxOn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EasyGearBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyGearBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.TextBox textBoxOn;
        private System.Windows.Forms.TextBox textBoxOff;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.FlowLayoutPanel fLPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel fLPanel1;
        private System.Windows.Forms.TextBox textBoxGearBox;
        private System.Windows.Forms.TextBox textBoxRPS;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}