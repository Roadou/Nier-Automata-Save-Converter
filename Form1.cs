using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NieR_Automata_Save_Converter
{
    public partial class Form1 : Form
    {
        Byte[] loadedMStoreSave;
        Byte[] loadedSteamSave;
        string steamSaveFolder;
        string mStoreSavFolder;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Informations: \nYou should have created a new savegame on the version you want convert your savegame to \n  You ABSOLUTLY need to create a new save before using this program.\nConverted Save will erase newly created savegame. \n >>>>>BE SURE TO BACKUP YOUR SAVEGAME BEFORE TRYING TO CONVERT THEM!!!<<<<<\n\n Note: This program is susceptible to be updated, please be sure to download it from Github repository.");
        }

        private void LoadMStore(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                openFileDialog.InitialDirectory = LocalAppData + "\\Packages\\39EA002F.NieRAutomataPC_n746a19ndrrjg\\SystemAppData\\wgs";
                openFileDialog.Filter = "HEXADECIMAL FILENAME (*.*)|*.*";
                openFileDialog.FilterIndex = 2;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    loadedMStoreSave = File.ReadAllBytes(filePath);
                    //Checking if it a valid safe file by comparing first and second byte
                    if (loadedMStoreSave[0x7C] != 0x76 && loadedMStoreSave[0x7D] != 0x65)
                    {
                        MessageBox.Show("Error, this isn't a valid save file!");
                        Array.Clear(loadedMStoreSave, 0, loadedMStoreSave.Length);
                    }
                    else
                    {
                        MicrosoftSaveFileName.Text = openFileDialog.FileName;
                    }
                    mStoreSavFolder = filePath;
                }
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (loadedMStoreSave?.Length > 0 && loadedSteamSave?.Length > 0)
            {
                DialogResult confirmDialog = MessageBox.Show($"The save will convert \n {SteamSaveName.Text} (Your Steam SaveGame)\n " +
                    $"to\n{MicrosoftSaveFileName.Text} (Microsoft Savegame)\nAre you sure you want to proceed ?", "Confirm ?", MessageBoxButtons.YesNoCancel);
                if (confirmDialog == DialogResult.Yes)
                {
                    Array.Copy(loadedSteamSave, 0xC, loadedMStoreSave, 0xC, loadedSteamSave.Length-0xC);
                    try
                    {
                        File.WriteAllBytes(mStoreSavFolder, loadedMStoreSave);
                        MessageBox.Show("Complete!");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"{exception.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, one of the file have not been loaded !");
            }
        }

        private void LoadSteam(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string DocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.InitialDirectory = DocumentsFolder + "\\My Games\\NieR_Automata";
                openFileDialog.Filter = "SlotData_X.dat (*.DAT)|*.dat";
                openFileDialog.FilterIndex = 2;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    loadedSteamSave = File.ReadAllBytes(filePath);
                    //Checking if it a valid safe file by comparing first and second byte
                    if (loadedSteamSave[0x7C] != 0x76 && loadedSteamSave[0x7D] != 0x65) 
                    {
                        MessageBox.Show("Error, this isn't a valid save file!");
                        Array.Clear(loadedSteamSave, 0, loadedSteamSave.Length);
                    }
                    else
                    {
                        SteamSaveName.Text = openFileDialog.FileName;
                    }
                    steamSaveFolder = filePath;
                }
            }
        }

        private void ConvertToSteam_Click(object sender, EventArgs e)
        {
            if (loadedMStoreSave?.Length > 0 && loadedSteamSave?.Length > 0)
            {
                DialogResult confirmDialog = MessageBox.Show($"The save will convert \n {MicrosoftSaveFileName.Text} (Your Microsoft save)\n " +
                    $"to\n{SteamSaveName.Text} (Steam save)\nAre you sure you want to proceed ?", "Confirm ?", MessageBoxButtons.YesNoCancel);
                if (confirmDialog == DialogResult.Yes)
                {
                    Array.Copy(loadedMStoreSave, 0xC, loadedSteamSave, 0xC, loadedMStoreSave.Length-0xC);
                    try
                    {
                        File.WriteAllBytes(steamSaveFolder, loadedSteamSave);
                        MessageBox.Show("Complete!");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"{exception.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, one of the file have not been loaded !");
            }
        }
    }
}
