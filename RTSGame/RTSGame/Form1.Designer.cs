namespace RTSGame
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.unitLbl = new System.Windows.Forms.TextBox();
            this.upTimeLabel = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMill = new System.Windows.Forms.Label();
            this.colon1 = new System.Windows.Forms.Label();
            this.fullStop1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.unitLabel = new System.Windows.Forms.Label();
            this.teamMeleeBtn = new System.Windows.Forms.Button();
            this.teamRangeBtn = new System.Windows.Forms.Button();
            this.unitLabel2 = new System.Windows.Forms.Label();
            this.gridMap = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(947, 18);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(141, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(1096, 18);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(141, 28);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // unitLbl
            // 
            this.unitLbl.Location = new System.Drawing.Point(947, 100);
            this.unitLbl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unitLbl.Multiline = true;
            this.unitLbl.Name = "unitLbl";
            this.unitLbl.Size = new System.Drawing.Size(324, 122);
            this.unitLbl.TabIndex = 3;
            // 
            // upTimeLabel
            // 
            this.upTimeLabel.AutoSize = true;
            this.upTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upTimeLabel.Location = new System.Drawing.Point(947, 238);
            this.upTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upTimeLabel.Name = "upTimeLabel";
            this.upTimeLabel.Size = new System.Drawing.Size(94, 27);
            this.upTimeLabel.TabIndex = 4;
            this.upTimeLabel.Text = "Up Time:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(1053, 238);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(39, 29);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(1129, 238);
            this.lblSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(39, 29);
            this.lblSec.TabIndex = 5;
            this.lblSec.Text = "00";
            // 
            // lblMill
            // 
            this.lblMill.AutoSize = true;
            this.lblMill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMill.Location = new System.Drawing.Point(1197, 246);
            this.lblMill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMill.Name = "lblMill";
            this.lblMill.Size = new System.Drawing.Size(27, 20);
            this.lblMill.TabIndex = 6;
            this.lblMill.Text = "00";
            this.lblMill.Click += new System.EventHandler(this.lblMill_Click);
            // 
            // colon1
            // 
            this.colon1.AutoSize = true;
            this.colon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon1.Location = new System.Drawing.Point(1101, 235);
            this.colon1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colon1.Name = "colon1";
            this.colon1.Size = new System.Drawing.Size(19, 29);
            this.colon1.TabIndex = 7;
            this.colon1.Text = ":";
            // 
            // fullStop1
            // 
            this.fullStop1.AutoSize = true;
            this.fullStop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullStop1.Location = new System.Drawing.Point(1175, 244);
            this.fullStop1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullStop1.Name = "fullStop1";
            this.fullStop1.Size = new System.Drawing.Size(13, 20);
            this.fullStop1.TabIndex = 8;
            this.fullStop1.Text = ".";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1245, 18);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(141, 28);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.Location = new System.Drawing.Point(941, 68);
            this.unitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(315, 20);
            this.unitLabel.TabIndex = 10;
            this.unitLabel.Text = "Click on a grid block to show information.";
            // 
            // teamMeleeBtn
            // 
            this.teamMeleeBtn.Location = new System.Drawing.Point(1280, 132);
            this.teamMeleeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamMeleeBtn.Name = "teamMeleeBtn";
            this.teamMeleeBtn.Size = new System.Drawing.Size(123, 28);
            this.teamMeleeBtn.TabIndex = 13;
            this.teamMeleeBtn.Text = "Melee Unit: ♥";
            this.teamMeleeBtn.UseVisualStyleBackColor = true;
            this.teamMeleeBtn.Click += new System.EventHandler(this.teamMeleeBtn_Click);
            // 
            // teamRangeBtn
            // 
            this.teamRangeBtn.Location = new System.Drawing.Point(1280, 167);
            this.teamRangeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamRangeBtn.Name = "teamRangeBtn";
            this.teamRangeBtn.Size = new System.Drawing.Size(123, 28);
            this.teamRangeBtn.TabIndex = 14;
            this.teamRangeBtn.Text = "Ranged Unit: ♦";
            this.teamRangeBtn.UseVisualStyleBackColor = true;
            this.teamRangeBtn.Click += new System.EventHandler(this.teamRangeBtn_Click);
            // 
            // unitLabel2
            // 
            this.unitLabel2.AutoSize = true;
            this.unitLabel2.Location = new System.Drawing.Point(1320, 112);
            this.unitLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitLabel2.Name = "unitLabel2";
            this.unitLabel2.Size = new System.Drawing.Size(40, 17);
            this.unitLabel2.TabIndex = 15;
            this.unitLabel2.Text = "Click!";
            // 
            // gridMap
            // 
            this.gridMap.ColumnCount = 20;
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.gridMap.Location = new System.Drawing.Point(11, 18);
            this.gridMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridMap.Name = "gridMap";
            this.gridMap.RowCount = 20;
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.gridMap.Size = new System.Drawing.Size(903, 901);
            this.gridMap.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1413, 933);
            this.Controls.Add(this.gridMap);
            this.Controls.Add(this.unitLabel2);
            this.Controls.Add(this.teamRangeBtn);
            this.Controls.Add(this.teamMeleeBtn);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.fullStop1);
            this.Controls.Add(this.lblMill);
            this.Controls.Add(this.upTimeLabel);
            this.Controls.Add(this.unitLbl);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.colon1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "The_RTS_Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.TextBox unitLbl;
        private System.Windows.Forms.Label upTimeLabel;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMill;
        private System.Windows.Forms.Label colon1;
        private System.Windows.Forms.Label fullStop1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Button teamMeleeBtn;
        private System.Windows.Forms.Button teamRangeBtn;
        private System.Windows.Forms.Label unitLabel2;
        private System.Windows.Forms.TableLayoutPanel gridMap;
    }
}

