﻿namespace Motion
{
    partial class UserControlControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._RadioButtonUnidormMotion = new System.Windows.Forms.RadioButton();
            this._RadioButtonOcillatoryMotion = new System.Windows.Forms.RadioButton();
            this._RadioButtonAscillatoryMotion = new System.Windows.Forms.RadioButton();
            this._GroupBoxAcceleratedMotion = new System.Windows.Forms.GroupBox();
            this._TextboxAcellerationMotion_Time = new System.Windows.Forms.TextBox();
            this._TextboxAcellerationMotion_AX0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._TextboxAcellerationMotion_X0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._TextboxAcellerationMotion_V0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this._GroupBoxAcceleratedMotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._RadioButtonUnidormMotion);
            this.groupBox1.Controls.Add(this._RadioButtonOcillatoryMotion);
            this.groupBox1.Controls.Add(this._RadioButtonAscillatoryMotion);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // _RadioButtonUnidormMotion
            // 
            this._RadioButtonUnidormMotion.AutoSize = true;
            this._RadioButtonUnidormMotion.Location = new System.Drawing.Point(6, 20);
            this._RadioButtonUnidormMotion.Name = "_RadioButtonUnidormMotion";
            this._RadioButtonUnidormMotion.Size = new System.Drawing.Size(147, 17);
            this._RadioButtonUnidormMotion.TabIndex = 4;
            this._RadioButtonUnidormMotion.Text = "Равномерное движение";
            this._RadioButtonUnidormMotion.UseVisualStyleBackColor = true;
            // 
            // _RadioButtonOcillatoryMotion
            // 
            this._RadioButtonOcillatoryMotion.AutoSize = true;
            this._RadioButtonOcillatoryMotion.Location = new System.Drawing.Point(5, 68);
            this._RadioButtonOcillatoryMotion.Name = "_RadioButtonOcillatoryMotion";
            this._RadioButtonOcillatoryMotion.Size = new System.Drawing.Size(156, 17);
            this._RadioButtonOcillatoryMotion.TabIndex = 6;
            this._RadioButtonOcillatoryMotion.TabStop = true;
            this._RadioButtonOcillatoryMotion.Text = "Калебательное движение";
            this._RadioButtonOcillatoryMotion.UseVisualStyleBackColor = true;
            // 
            // _RadioButtonAscillatoryMotion
            // 
            this._RadioButtonAscillatoryMotion.AutoSize = true;
            this._RadioButtonAscillatoryMotion.Location = new System.Drawing.Point(6, 44);
            this._RadioButtonAscillatoryMotion.Name = "_RadioButtonAscillatoryMotion";
            this._RadioButtonAscillatoryMotion.Size = new System.Drawing.Size(162, 17);
            this._RadioButtonAscillatoryMotion.TabIndex = 5;
            this._RadioButtonAscillatoryMotion.TabStop = true;
            this._RadioButtonAscillatoryMotion.Text = "Равноускореное движение";
            this._RadioButtonAscillatoryMotion.UseVisualStyleBackColor = true;
            // 
            // _GroupBoxAcceleratedMotion
            // 
            this._GroupBoxAcceleratedMotion.Controls.Add(this._TextboxAcellerationMotion_Time);
            this._GroupBoxAcceleratedMotion.Controls.Add(this._TextboxAcellerationMotion_AX0);
            this._GroupBoxAcceleratedMotion.Controls.Add(this.label4);
            this._GroupBoxAcceleratedMotion.Controls.Add(this._TextboxAcellerationMotion_X0);
            this._GroupBoxAcceleratedMotion.Controls.Add(this.label3);
            this._GroupBoxAcceleratedMotion.Controls.Add(this.label2);
            this._GroupBoxAcceleratedMotion.Controls.Add(this._TextboxAcellerationMotion_V0);
            this._GroupBoxAcceleratedMotion.Controls.Add(this.label1);
            this._GroupBoxAcceleratedMotion.Location = new System.Drawing.Point(3, 112);
            this._GroupBoxAcceleratedMotion.Name = "_GroupBoxAcceleratedMotion";
            this._GroupBoxAcceleratedMotion.Size = new System.Drawing.Size(184, 156);
            this._GroupBoxAcceleratedMotion.TabIndex = 8;
            this._GroupBoxAcceleratedMotion.TabStop = false;
            this._GroupBoxAcceleratedMotion.Visible = false;
            // 
            // _TextboxAcellerationMotion_Time
            // 
            this._TextboxAcellerationMotion_Time.Location = new System.Drawing.Point(42, 110);
            this._TextboxAcellerationMotion_Time.Name = "_TextboxAcellerationMotion_Time";
            this._TextboxAcellerationMotion_Time.Size = new System.Drawing.Size(100, 20);
            this._TextboxAcellerationMotion_Time.TabIndex = 4;
            // 
            // _TextboxAcellerationMotion_AX0
            // 
            this._TextboxAcellerationMotion_AX0.Location = new System.Drawing.Point(42, 84);
            this._TextboxAcellerationMotion_AX0.Name = "_TextboxAcellerationMotion_AX0";
            this._TextboxAcellerationMotion_AX0.Size = new System.Drawing.Size(100, 20);
            this._TextboxAcellerationMotion_AX0.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // _TextboxAcellerationMotion_X0
            // 
            this._TextboxAcellerationMotion_X0.Location = new System.Drawing.Point(42, 32);
            this._TextboxAcellerationMotion_X0.Name = "_TextboxAcellerationMotion_X0";
            this._TextboxAcellerationMotion_X0.Size = new System.Drawing.Size(100, 20);
            this._TextboxAcellerationMotion_X0.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "AX0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "V0";
            // 
            // _TextboxAcellerationMotion_V0
            // 
            this._TextboxAcellerationMotion_V0.Location = new System.Drawing.Point(42, 58);
            this._TextboxAcellerationMotion_V0.Name = "_TextboxAcellerationMotion_V0";
            this._TextboxAcellerationMotion_V0.Size = new System.Drawing.Size(100, 20);
            this._TextboxAcellerationMotion_V0.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X0";
            // 
            // UserControlControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._GroupBoxAcceleratedMotion);
            this.Name = "UserControlControl";
            this.Size = new System.Drawing.Size(193, 275);
            this.Load += new System.EventHandler(this.UserControlControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._GroupBoxAcceleratedMotion.ResumeLayout(false);
            this._GroupBoxAcceleratedMotion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _RadioButtonUnidormMotion;
        private System.Windows.Forms.RadioButton _RadioButtonOcillatoryMotion;
        private System.Windows.Forms.RadioButton _RadioButtonAscillatoryMotion;
        private System.Windows.Forms.GroupBox _GroupBoxAcceleratedMotion;
        private System.Windows.Forms.TextBox _TextboxAcellerationMotion_Time;
        private System.Windows.Forms.TextBox _TextboxAcellerationMotion_AX0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _TextboxAcellerationMotion_X0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _TextboxAcellerationMotion_V0;
        private System.Windows.Forms.Label label1;
    }
}
