﻿namespace ZoruSor.UserControls
{
    partial class AynisiniBulUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AynisiniBulUc));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReferansResim = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DogruCevap = new System.Windows.Forms.PictureBox();
            this.celdiriciLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.soruNoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReferansResim)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogruCevap)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(40, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 180);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReferansResim);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(78, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 180);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Referans Resim";
            // 
            // ReferansResim
            // 
            this.ReferansResim.Location = new System.Drawing.Point(6, 19);
            this.ReferansResim.Name = "ReferansResim";
            this.ReferansResim.Size = new System.Drawing.Size(150, 150);
            this.ReferansResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReferansResim.TabIndex = 13;
            this.ReferansResim.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DogruCevap);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(243, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 180);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doğru Cevap";
            // 
            // DogruCevap
            // 
            this.DogruCevap.Location = new System.Drawing.Point(6, 19);
            this.DogruCevap.Name = "DogruCevap";
            this.DogruCevap.Size = new System.Drawing.Size(150, 150);
            this.DogruCevap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogruCevap.TabIndex = 13;
            this.DogruCevap.TabStop = false;
            // 
            // celdiriciLayoutPanel
            // 
            this.celdiriciLayoutPanel.AutoScroll = true;
            this.celdiriciLayoutPanel.ColumnCount = 5;
            this.celdiriciLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.celdiriciLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.celdiriciLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.celdiriciLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.celdiriciLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.celdiriciLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.celdiriciLayoutPanel.Location = new System.Drawing.Point(410, 0);
            this.celdiriciLayoutPanel.Name = "celdiriciLayoutPanel";
            this.celdiriciLayoutPanel.RowCount = 1;
            this.celdiriciLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.celdiriciLayoutPanel.Size = new System.Drawing.Size(470, 180);
            this.celdiriciLayoutPanel.TabIndex = 28;
            // 
            // soruNoLabel
            // 
            this.soruNoLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.soruNoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soruNoLabel.Location = new System.Drawing.Point(0, 0);
            this.soruNoLabel.Name = "soruNoLabel";
            this.soruNoLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.soruNoLabel.Size = new System.Drawing.Size(40, 180);
            this.soruNoLabel.TabIndex = 14;
            this.soruNoLabel.Text = "1";
            this.soruNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AynisiniBulUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.celdiriciLayoutPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.soruNoLabel);
            this.Name = "AynisiniBulUc";
            this.Size = new System.Drawing.Size(880, 180);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReferansResim)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DogruCevap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ReferansResim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox DogruCevap;
        private System.Windows.Forms.TableLayoutPanel celdiriciLayoutPanel;
        private System.Windows.Forms.Label soruNoLabel;
    }
}
