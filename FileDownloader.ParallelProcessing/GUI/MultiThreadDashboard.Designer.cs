﻿using FileDownloader.ParallelProcessing.Models;
using FileInfo = FileDownloader.ParallelProcessing.Models.FileInfo;

namespace FileDownloader.ParallelProcessing
{
    partial class MultiThreadDashboard
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
            ApplicationContainer = new Panel();
            DownloadsContainer = new Panel();
            DownloadPanel = new Panel();
            Resume = new Button();
            Cancel = new Button();
            Pause = new Button();
            SpeedValue = new Label();
            SpeedLabel = new Label();
            DownloadedValue = new Label();
            DownloadedLabel = new Label();
            ProgressBar = new ProgressBar();
            FileNameValue = new Label();
            FileNameLabel = new Label();
            LocationInput = new TextBox();
            SetLocationButton = new Button();
            DownloadButton = new Button();
            InstructionLabel = new Label();
            URLTextBox = new TextBox();
            URLLabel = new Label();
            ApplicationContainer.SuspendLayout();
            DownloadsContainer.SuspendLayout();
            DownloadPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ApplicationContainer
            // 
            ApplicationContainer.Controls.Add(DownloadsContainer);
            ApplicationContainer.Controls.Add(LocationInput);
            ApplicationContainer.Controls.Add(SetLocationButton);
            ApplicationContainer.Controls.Add(DownloadButton);
            ApplicationContainer.Controls.Add(InstructionLabel);
            ApplicationContainer.Controls.Add(URLTextBox);
            ApplicationContainer.Controls.Add(URLLabel);
            ApplicationContainer.ForeColor = SystemColors.ButtonHighlight;
            ApplicationContainer.Location = new Point(36, 12);
            ApplicationContainer.Name = "ApplicationContainer";
            ApplicationContainer.Size = new Size(1214, 649);
            ApplicationContainer.TabIndex = 1;
            // 
            // DownloadsContainer
            // 
            DownloadsContainer.Location = new Point(15, 193);
            DownloadsContainer.Name = "DownloadsContainer";
            DownloadsContainer.Size = new Size(1196, 444);
            DownloadsContainer.AutoScroll = true;
            DownloadsContainer.TabIndex = 7;
            // 
            // LocationInput
            // 
            LocationInput.BackColor = Color.FromArgb(50, 50, 50);
            LocationInput.ForeColor = SystemColors.Info;
            LocationInput.Location = new Point(537, 104);
            LocationInput.Name = "LocationInput";
            LocationInput.Size = new Size(500, 27);
            LocationInput.TabIndex = 6;
            // 
            // SetLocationButton
            // 
            SetLocationButton.BackColor = Color.SandyBrown;
            SetLocationButton.FlatAppearance.BorderColor = Color.Black;
            SetLocationButton.ForeColor = SystemColors.HighlightText;
            SetLocationButton.Location = new Point(432, 103);
            SetLocationButton.Name = "SetLocationButton";
            SetLocationButton.Size = new Size(99, 28);
            SetLocationButton.TabIndex = 5;
            SetLocationButton.Text = "Browse";
            SetLocationButton.UseVisualStyleBackColor = false;
            SetLocationButton.Click += button5_Click;
            // 
            // DownloadButton
            // 
            DownloadButton.BackColor = Color.RoyalBlue;
            DownloadButton.FlatAppearance.BorderColor = Color.Black;
            DownloadButton.ForeColor = SystemColors.HighlightText;
            DownloadButton.Location = new Point(68, 104);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(150, 28);
            DownloadButton.TabIndex = 4;
            DownloadButton.Text = "Download";
            DownloadButton.UseVisualStyleBackColor = false;
            DownloadButton.Click += button4_Click;
            // 
            // InstructionLabel
            // 
            InstructionLabel.AutoSize = true;
            InstructionLabel.Font = new Font("Segoe Script", 9F);
            InstructionLabel.ForeColor = Color.White;
            InstructionLabel.Location = new Point(68, 26);
            InstructionLabel.Name = "InstructionLabel";
            InstructionLabel.Size = new Size(403, 23);
            InstructionLabel.TabIndex = 3;
            InstructionLabel.Text = "Please Enter the URL Link in the TextBox Below\r\n";
            InstructionLabel.Click += label2_Click;
            // 
            // URLTextBox
            // 
            URLTextBox.BackColor = Color.FromArgb(50, 50, 50);
            URLTextBox.ForeColor = SystemColors.Info;
            URLTextBox.Location = new Point(68, 65);
            URLTextBox.Name = "URLTextBox";
            URLTextBox.Size = new Size(969, 27);
            URLTextBox.TabIndex = 1;
            URLTextBox.Text = "HTTTP";
            URLTextBox.TextChanged += textBox1_TextChanged;
            // 
            // URLLabel
            // 
            URLLabel.AutoSize = true;
            URLLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            URLLabel.ForeColor = SystemColors.ButtonHighlight;
            URLLabel.Location = new Point(15, 65);
            URLLabel.Name = "URLLabel";
            URLLabel.Size = new Size(47, 28);
            URLLabel.TabIndex = 0;
            URLLabel.Text = "URL";
            // 
            // MultiThreadDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1262, 673);
            Controls.Add(ApplicationContainer);
            Name = "MultiThreadDashboard";
            Text = "MultiThreadDashboard";
            ApplicationContainer.ResumeLayout(false);
            ApplicationContainer.PerformLayout();
            DownloadsContainer.ResumeLayout(false);
            DownloadPanel.ResumeLayout(false);
            DownloadPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel ApplicationContainer;
        private TextBox URLTextBox;
        private Label URLLabel;
        private Panel DownloadPanel;
        private Label InstructionLabel;
        private Button DownloadButton;
        private Button SetLocationButton;
        private TextBox LocationInput;
        private Label FileNameLabel;
        private Label FileNameValue;
        private Button Cancel;
        private Button Pause;
        private Label SpeedValue;
        private Label SpeedLabel;
        private Label DownloadedValue;
        private Label DownloadedLabel;
        private ProgressBar ProgressBar;
        private Button Resume;
        private Panel DownloadsContainer;
        private int _currentPanelYPosition = 15;
        private void CreateDownloadPanel(FileInfo file)
        {
            DownloadPanel.Name = "DownloadPanel";
            DownloadPanel.TabIndex = 2;
            Panel downloadPanel = new Panel
            {
                Size = new Size(1154,141),
                Location = new Point(12, _currentPanelYPosition),

            };

            Label FileNameValue = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ButtonHighlight,
                Location = new Point(140, 13),
                Name = "FileNameValue",
                Size = new Size(39, 28),
                TabIndex = 8,
                Text = file.FileName
            };

            Label FileNameLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ButtonHighlight,
                Location = new Point(18, 13),
                Name = "FileNameLabel",
                Size = new Size(113, 28),
                TabIndex = 7,
                Text = "File Name : "
            };

            ProgressBar ProgressBar = new ProgressBar
            {
                Location = new Point(18, 54),
                Name = "ProgressBar",
                Size = new Size(822, 29),
                TabIndex = 9
            };

            Label DownloadedLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ButtonHighlight,
                Location = new Point(18, 97),
                Name = "DownloadedLabel",
                Size = new Size(133, 28),
                TabIndex = 10,
                Text = "Downloaded :"
            };

            Label DownloadedValue = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ButtonHighlight,
                Location = new Point(182, 97),
                Name = "DownloadedValue",
                Size = new Size(42, 28),
                TabIndex = 11,
                Text = $"Mb"
            };

            Label SpeedLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ButtonHighlight,
                Location = new Point(653, 97),
                Name = "SpeedLabel",
                Size = new Size(81, 28),
                TabIndex = 12,
                Text = "Speed : "
            };

            Label SpeedValue = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ButtonHighlight,
                Location = new Point(740, 97),
                Name = "SpeedValue",
                Size = new Size(90, 28),
                TabIndex = 13,
                Text = "??? Mb/s"
            };

            Button ResumeButton = new Button
            {
                BackColor = Color.ForestGreen,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(846, 54),
                Name = "Resume",
                Size = new Size(94, 29),
                TabIndex = 16,
                Text = "Resume",
                UseVisualStyleBackColor = false
            };

            Button CancelButton = new Button
            {
                BackColor = Color.Maroon,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(1046, 54),
                Name = "Cancel",
                Size = new Size(94, 29),
                TabIndex = 15,
                Text = "Cancel",
                UseVisualStyleBackColor = false
            };

            Button PauseButton = new Button
            {
                BackColor = Color.Goldenrod,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(946, 54),
                Name = "Pause",
                Size = new Size(94, 29),
                TabIndex = 14,
                Text = "Pause",
                UseVisualStyleBackColor = false
            };
            PauseButton.Click += button6_Click;


            downloadPanel.Controls.AddRange([
                FileNameValue,
                FileNameLabel,
                PauseButton,
                ResumeButton,
                CancelButton,
                SpeedLabel,
                SpeedValue,
                ProgressBar,
                DownloadedValue,
                DownloadedLabel
            ]);
            DownloadsContainer.Controls.Add(downloadPanel);
            // 10 for spacing between panels
            _currentPanelYPosition += downloadPanel.Height + 10; 
        }

    }
}