﻿
namespace NieR_Automata_Save_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MicrosoftSaveFileName = new System.Windows.Forms.TextBox();
            this.LoadOriginalSave = new System.Windows.Forms.Button();
            this.LoadNewSave = new System.Windows.Forms.Button();
            this.ConvertSavegameButton = new System.Windows.Forms.Button();
            this.SteamSaveName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(9, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "by Github.com/BelovedTomboyishGirl";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Convert Microsoft Store to Steam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ConvertToSteam_Click);
            // 
            // MicrosoftSaveFileName
            // 
            this.MicrosoftSaveFileName.Location = new System.Drawing.Point(180, 14);
            this.MicrosoftSaveFileName.Name = "MicrosoftSaveFileName";
            this.MicrosoftSaveFileName.ReadOnly = true;
            this.MicrosoftSaveFileName.Size = new System.Drawing.Size(241, 20);
            this.MicrosoftSaveFileName.TabIndex = 8;
            // 
            // LoadOriginalSave
            // 
            this.LoadOriginalSave.Location = new System.Drawing.Point(12, 12);
            this.LoadOriginalSave.Name = "LoadOriginalSave";
            this.LoadOriginalSave.Size = new System.Drawing.Size(162, 23);
            this.LoadOriginalSave.TabIndex = 0;
            this.LoadOriginalSave.Text = "Load Microsoft Store Save";
            this.LoadOriginalSave.UseVisualStyleBackColor = true;
            this.LoadOriginalSave.Click += new System.EventHandler(this.LoadMStore);
            // 
            // LoadNewSave
            // 
            this.LoadNewSave.Location = new System.Drawing.Point(12, 43);
            this.LoadNewSave.Name = "LoadNewSave";
            this.LoadNewSave.Size = new System.Drawing.Size(162, 24);
            this.LoadNewSave.TabIndex = 1;
            this.LoadNewSave.Text = "Load Steam Save";
            this.LoadNewSave.UseVisualStyleBackColor = true;
            this.LoadNewSave.Click += new System.EventHandler(this.LoadSteam);
            // 
            // ConvertSavegameButton
            // 
            this.ConvertSavegameButton.Location = new System.Drawing.Point(12, 73);
            this.ConvertSavegameButton.Name = "ConvertSavegameButton";
            this.ConvertSavegameButton.Size = new System.Drawing.Size(182, 23);
            this.ConvertSavegameButton.TabIndex = 3;
            this.ConvertSavegameButton.Text = "Convert Steam to Microsoft Store version";
            this.ConvertSavegameButton.UseVisualStyleBackColor = true;
            this.ConvertSavegameButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // SteamSaveName
            // 
            this.SteamSaveName.Location = new System.Drawing.Point(180, 46);
            this.SteamSaveName.Name = "SteamSaveName";
            this.SteamSaveName.ReadOnly = true;
            this.SteamSaveName.Size = new System.Drawing.Size(241, 20);
            this.SteamSaveName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 120);
            this.Controls.Add(this.SteamSaveName);
            this.Controls.Add(this.MicrosoftSaveFileName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertSavegameButton);
            this.Controls.Add(this.LoadNewSave);
            this.Controls.Add(this.LoadOriginalSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MicrosoftSaveFileName;
        private System.Windows.Forms.Button LoadOriginalSave;
        private System.Windows.Forms.Button LoadNewSave;
        private System.Windows.Forms.Button ConvertSavegameButton;
        private System.Windows.Forms.TextBox SteamSaveName;
    }
}

