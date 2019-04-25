using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Homework_02_04
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button connectButton;
        private TextBox sqlConnectionBox;
        private Label infoLabel;
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


        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectButton = new System.Windows.Forms.Button();
            this.sqlConnectionBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.Location = new System.Drawing.Point(321, 351);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(109, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sqlConnectionBox
            // 
            this.sqlConnectionBox.Location = new System.Drawing.Point(321, 312);
            this.sqlConnectionBox.Name = "sqlConnectionBox";
            this.sqlConnectionBox.Size = new System.Drawing.Size(109, 20);
            this.sqlConnectionBox.TabIndex = 5;
            this.sqlConnectionBox.Text = "";
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(321, 280);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(109, 29);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Введите строку подключения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 463);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.sqlConnectionBox);
            this.Controls.Add(this.infoLabel);
            this.Name = "Form1";
            this.Text = "Homework";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder connectionBuild = new SqlConnectionStringBuilder(this.sqlConnectionBox.Text);
                if (!string.IsNullOrWhiteSpace(sqlConnectionBox.Text))
                {
                    using (var connection = new SqlConnection(connectionBuild.ConnectionString))
                    {
                        try
                        {
                            connection.Open();
                            MessageBox.Show("Успешно подключено!");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка подключения!");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Неверный аргумент!");
            }
              
        }
    }
}

