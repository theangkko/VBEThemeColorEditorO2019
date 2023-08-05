using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Utility.ModifyRegistry;



namespace VBEThemeColorEditor
{
    public partial class ThemeEditorForm : Form
    {
        #region Sequences to look for
        private readonly byte[] PatchFind1 = //1st sequence
        {
            0xff, 0xff, 0xff, 0x00, 0xc0, 0xc0, 0xc0, 0x00, 0x80, 0x80, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0x80, 0x80, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0x80, 0x80, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x80, 0x00, 0xff, 0x00, 0xff, 0x00, 0x80, 0x00, 0x80, 0x00
        };

        private readonly byte[] PatchFind2 = //2nd sequence
        {
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x80, 0x80, 0x00, 0x80, 0x00, 0x00, 0x00, 0x80, 0x00, 0x80, 0x00, 0x80, 0x80, 0x00, 0x00, 0xc0, 0xc0, 0xc0, 0x00, 0x80, 0x80, 0x80, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0xff, 0xff, 0x00, 0xff, 0x00, 0x00, 0x00, 0xff, 0x00, 0xff, 0x00, 0xff, 0xff, 0x00, 0x00, 0xff, 0xff, 0xff, 0x00
        };
        #endregion

        #region Preloaded themes
        private readonly byte[] ThemeDefault = //Default VBE Theme
        {
            0xff, 0xff, 0xff, 0x00, 0xc0, 0xc0, 0xc0, 0x00, 0x80, 0x80, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0x80, 0x80, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0x80, 0x80, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00, 0x80, 0x00, 0xff, 0x00, 0xff, 0x00, 0x80, 0x00, 0x80, 0x00
        };

        private readonly byte[] ThemeDark = //VS2012 Dark Theme  
        {
            //0x00, 0x00, 0x00, 0x00, 0x1e, 0x1e, 0x1e, 0x00, 0x34, 0x3a, 0x40, 0x00, 0x3c, 0x42, 0x48, 0x00, 0xd4, 0xd4, 0xd4, 0x00, 0xff, 0xff, 0xff, 0x00, 0x26, 0x4f, 0x78, 0x00, 0x56, 0x9c, 0xd6, 0x00, 0x74, 0xb0, 0xdf, 0x00, 0x79, 0x4e, 0x8b, 0x00, 0x9f, 0x74, 0xb1, 0x00, 0xe5, 0x14, 0x00, 0x00, 0xd6, 0x9d, 0x85, 0x00, 0xce, 0x91, 0x78, 0x00, 0x60, 0x8b, 0x4e, 0x00, 0xb5, 0xce, 0xa8, 0x00
			  0x00, 0x00, 0x00, 0x00, 0xD4, 0xD4, 0xD4, 0x00, 0xFF, 0xFF, 0xFF, 0x00, 0x1E, 0x1E, 0x1E, 0x00, 0xD4, 0xD4, 0xD4, 0x00, 0x34, 0x3A, 0x40, 0x00, 0xD6, 0x9D, 0x85, 0x00, 0x60, 0x8B, 0x4E, 0x00, 0xB5, 0xCE, 0xA8, 0x00, 0x56, 0x9C, 0xD6, 0x00, 0x79, 0x4E, 0x8B, 0x00, 0x9F, 0x74, 0xB1, 0x00, 0xCE, 0x91, 0x78, 0x00, 0x74, 0xB0, 0xDF, 0x00, 0xE5, 0x14, 0x00, 0x00, 0x26, 0x4F, 0x78, 0x00


		};
        #endregion

        #region Variables
        private byte[] PatchFind;
        private int FoundIteration = 0;
        private int FoundSequences = 0;
        #endregion

        public ThemeEditorForm()
        {
            InitializeComponent();
            UpdateButtonColors(ThemeDark);  // ThemeDark를 기본으로 설정
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool DetectPatch(byte[] sequence, int position)
        {
            // Look for 1st iteration of the 1st sequence
            // and 2nd iteration of the 2nd sequence

            if (position + PatchFind.Length > sequence.Length) return false;
            for (int p = 0; p < PatchFind.Length; p++)
            {
                if (PatchFind[p] != sequence[position + p]) return false;
            }

            FoundIteration++;
            if (FoundIteration == 2)
                return false;
            else
            {
                FoundSequences++;
                return true;
            }
        }

        private void PatchFile(string originalFile, string backupFile)
        {
            // Ensure target directory exists.
            var targetDirectory = Path.GetDirectoryName(originalFile);
            if (targetDirectory == null) return;
            Directory.CreateDirectory(targetDirectory);

            byte[] fileContent = File.ReadAllBytes(originalFile);

            // Backup original file, unless it has already been done
            if (!File.Exists(backupFile))
            {
                File.WriteAllBytes(backupFile, fileContent);
                MessageBox.Show("VBEx.DLL backup has been created:\n" + backupFile);
            }
            else // Load backup file for a clean theme installation
            {
                // Read file bytes.
                fileContent = File.ReadAllBytes(backupFile);
            }

            // Apply selected theme/colors
            byte[] ThemeColors = LoadColorsFromButtons();

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                    // 1st sequence
                    PatchFind = PatchFind1;
                else if (i > 0)
                    // 2nd sequence
                    PatchFind = PatchFind2;

                // Detect and patch file.
                for (int p = 0; p < fileContent.Length; p++)
                {
                    if (!DetectPatch(fileContent, p)) continue;

                    for (int w = 0; w < PatchFind.Length; w++)
                    {
                        fileContent[p + w] = ThemeColors[w];
                    }

                    if (FoundIteration > 2)
                        break;
                }
            }

            if (FoundSequences == 2)
            {
                // Save file
                try
                {
                    File.WriteAllBytes(originalFile, fileContent);
                    //if (ForeColorsVal.Length > 0)
                    //    UpdateRegistry(ForeColorsVal, BackColorsVal);

                    toolStripStatusLabel.Text = "Theme successfully applied";
                }
                catch (System.IO.IOException)
                {
                    toolStripStatusLabel.Text = "Theme could not be applied";
                    MessageBox.Show("A Microsoft Office Application is opened. Please close it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                toolStripStatusLabel.Text = "Theme could not be applied";
        }



        private void buttonModifyDLL_Click(object sender, EventArgs e)
        {
            string excelVersion = getExcelVersion ();
      
            // Reset variables
            FoundIteration = 0;
            FoundSequences = 0;

            // Show the dialog and get result.
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "VBEx.DLL|VBE7.DLL;VBE6.DLL";

            string defaultdir = SetDefaultDir();
            openFile.InitialDirectory = defaultdir;  //경로 64bit기준으로 변경/업데이트
            openFile.Title = "Select VBEx.DLL file";

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                string sFileName = openFile.FileName;
                PatchFile(sFileName, sFileName + ".BAK");
            }
        }

        private void UpdateColor(object sender, EventArgs e)
        {
            var buttonColor = (Button)sender;

            ColorDialog MyColorDialog = new ColorDialog();
            MyColorDialog.Color = buttonColor.BackColor;
            DialogResult pickedColor = MyColorDialog.ShowDialog();

            if (pickedColor == DialogResult.OK)
            {
                // Set button background to the selected color.
                buttonColor.BackColor = MyColorDialog.Color;
            }
        }

        private void UpdateButtonColors(byte[] ThemeTmp)
        {
            for (int i = 1; i < 17; i++)
            {
                Button tmpButton = this.Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;
                tmpButton.BackColor = Color.FromArgb
                    (
                        ThemeTmp[(i - 1) * 4],
                        ThemeTmp[(i - 1) * 4 + 1],
                        ThemeTmp[(i - 1) * 4 + 2]
                    );
            }
        }

        private byte[] LoadColorsFromButtons()
        {
            byte[] ThemeColorTmp = new byte[64];

            int tmpButtonID;
            for (int i = 1; i < 17; i++)
            {
                Button tmpButton = this.Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;

                tmpButtonID = Int32.Parse(Regex.Match(tmpButton.Name, @"\d+").Value);
                ThemeColorTmp[(i - 1) * 4] = tmpButton.BackColor.R;
                ThemeColorTmp[(i - 1) * 4 + 1] = tmpButton.BackColor.G;
                ThemeColorTmp[(i - 1) * 4 + 2] = tmpButton.BackColor.B;
                ThemeColorTmp[(i - 1) * 4 + 3] = 0x00;
            }

            return ThemeColorTmp;
        }

        private void UpdateRegistry(string ForeColorsVal, string BackColorsVal)
        {
            // Unused => Modifies ForeColors/BackColors values directly in the registry

            RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\VBA\7.1\Common", true);
            if (myKey == null)
                myKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\VBA\6.0\Common", true);

            if (myKey != null)
            {
                myKey.SetValue("CodeForeColors", ForeColorsVal, RegistryValueKind.String);
                myKey.SetValue("CodeBackColors", BackColorsVal, RegistryValueKind.String);
                myKey.Close();
                toolStripStatusLabel.Text = "Registry successfully updated";
            }
            else
                toolStripStatusLabel.Text = "Registry key not found";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "VBE Theme|*.xml;VBE7.DLL;VBE6.DLL";
            openFile.InitialDirectory = Directory.GetCurrentDirectory();
            openFile.InitialDirectory = openFile.InitialDirectory + @"\Themes";
            openFile.Title = "Select theme";

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                string FileName = openFile.FileName;

                byte[] ThemeColors = new byte[64];

                //try
                //{
                if (FileName.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
                    LoadThemeFromXml(FileName, ThemeColors);
                else
                    LoadThemeFromDll(FileName, ThemeColors);

                UpdateButtonColors(ThemeColors);
                //}
                //catch
                //{
                //    toolStripStatusLabel.Text = "Theme could not be loaded, invalid file";
                //    MessageBox.Show("Invalid Theme", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void LoadThemeFromDll(string FileName, byte[] ThemeColors)
        {
            byte[] content = File.ReadAllBytes(FileName);

            byte[] backup;

            if (FileName.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
                backup = content;
            else if (!File.Exists(FileName + ".BAK"))
                backup = content;
            else
                backup = File.ReadAllBytes(FileName + ".BAK");

            foreach (var pf in new byte[][] { PatchFind1, PatchFind2 })
            {
                PatchFind = pf;

                for (int p = 0; p < content.Length; p++)
                {
                    if (!DetectPatch(backup, p)) continue;

                    for (int w = 0; w < PatchFind.Length; w++)
                    {
                        ThemeColors[w] = content[p + w];
                    }

                    if (FoundIteration > 2)
                        break;
                }
            }

            toolStripStatusLabel.Text = "Theme loaded: " + FileName;
        }

        private void LoadThemeFromXml(string FileName, byte[] ThemeColors)
        {
            int j = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FileName);

            XmlNode nodeTheme = xmlDoc.DocumentElement.SelectSingleNode("/VbeTheme");
            XmlNode nodeThemeColors = nodeTheme.SelectSingleNode("ThemeColors");

            string XMLname = nodeTheme.Attributes["name"]?.InnerText;
            string XMLDescription = nodeTheme.Attributes["desc"]?.InnerText;
            string[] XMLhexColor = new string[16];

            foreach (XmlNode nodeColor in nodeThemeColors)
            {
                XMLhexColor[j] = nodeColor.Attributes["HexColor"]?.InnerText;
                j++;
            }

            // Colors / DLL
            for (int i = 0; i < 16; i++)
            {
                ThemeColors[i * 4] = Convert.ToByte(Int32.Parse(XMLhexColor[i].Substring(0, 2), System.Globalization.NumberStyles.HexNumber));
                ThemeColors[i * 4 + 1] = Convert.ToByte(Int32.Parse(XMLhexColor[i].Substring(2, 2), System.Globalization.NumberStyles.HexNumber));
                ThemeColors[i * 4 + 2] = Convert.ToByte(Int32.Parse(XMLhexColor[i].Substring(4, 2), System.Globalization.NumberStyles.HexNumber));
                ThemeColors[i * 4 + 3] = 0x00;
            }

            toolStripStatusLabel.Text = "Theme loaded: " + XMLDescription;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "VBE Theme|*.xml";
            saveFile.InitialDirectory = Directory.GetCurrentDirectory();
            saveFile.InitialDirectory = saveFile.InitialDirectory + @"\Themes";
            saveFile.Title = "Save theme";
            saveFile.ShowDialog();

            if (saveFile.FileName.Length > 0) // Test result.
            {
                // Ugly way to write the xml file
                string tmpFileName = Path.GetFileNameWithoutExtension(saveFile.FileName);

                string savedTheme_str =
                @"<?xml version=""1.0""?>
                    <!-- Description: " + tmpFileName + @" -->
                    <VbeTheme name =""" + tmpFileName + @""" desc=""" + tmpFileName + @""">" +
                    @"<ThemeColors>";

                int tmpButtonID;
                string savedColors_str = "";
                for (int i = 1; i < 17; i++)
                {
                    savedColors_str = savedColors_str + @"<Color colorID=""" + i.ToString() + @""" HexColor=""";

                    // Convert button color RGB to Hex
                    Button tmpButton = this.Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;

                    tmpButtonID = Int32.Parse(Regex.Match(tmpButton.Name, @"\d+").Value);
                    savedColors_str = savedColors_str + tmpButton.BackColor.R.ToString("X2") + tmpButton.BackColor.G.ToString("X2") + tmpButton.BackColor.B.ToString("X2") + @"""/>";
                }

                savedTheme_str = savedTheme_str + savedColors_str +
                @" </ThemeColors>
                    </VbeTheme>";

                XDocument savedTheme = XDocument.Parse(savedTheme_str);
                savedTheme.Save(saveFile.FileName);

                toolStripStatusLabel.Text = "Theme saved";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ThemeEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifyDLLauto_Click(object sender, EventArgs e)
        {

        }



        private void AddRegistry_Click(object sender, EventArgs e)
        {
            ModifyRegistry myRegistry = new ModifyRegistry();
            myRegistry.BaseRegistryKey = Registry.CurrentUser;
            SetmyRegistrySubkey(myRegistry);
            //myRegistry.Write("CodeForeColors", "13 5 12 1 6 15 8 5 1 1 0 0 0 0 0 0");
            //myRegistry.Write("CodeBackColors", "2 7 1 13 15 2 2 2 11 9 0 0 0 0 0 0");
			myRegistry.Write("CodeForeColors", "7 2 15 1 2 8 10 2 1 1 0 0 0 0 0 0");
			myRegistry.Write("CodeBackColors", "4 16 14 13 15 4 4 4 11 9 0 0 0 0 0 0");
			//myRegistry.Write("FontFace", "D2Coding");
			//myRegistry.Write("FontHeight", "dword: 0000000d");

			toolStripStatusLabel.Text = "Registry-CodeColor- is added";
        }

        private static void SetmyRegistrySubkey(ModifyRegistry myRegistry)
        {
            if (Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\VBA\7.1\Common", true) != null)
                myRegistry.SubKey = "SOFTWARE\\Microsoft\\VBA\\7.1\\Common";
            else
                myRegistry.SubKey = @"SOFTWARE\Microsoft\VBA\6.0\Common";
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void ApplyFont_Click(object sender, EventArgs e)
        {
            ModifyRegistry myRegistry = new ModifyRegistry();
            myRegistry.BaseRegistryKey = Registry.CurrentUser;
            //myRegistry.SubKey = "SOFTWARE\\Microsoft\\VBA\\7.1\\Common";
            SetmyRegistrySubkey(myRegistry);
            myRegistry.Write("FontFace", "D2Coding");


            toolStripStatusLabel.Text = "Font is applied";
        }

        private void ApplyFontSize_Click(object sender, EventArgs e)
        {
            int fontSize;
            
            try
            {
                fontSize = Convert.ToInt32(textBoxFontSize.Text);
                
            }
            catch (FormatException)
            {
                fontSize = Convert.ToInt32("12");
            }

            ModifyRegistry myRegistry = new ModifyRegistry();
            myRegistry.BaseRegistryKey = Registry.CurrentUser;
            //myRegistry.SubKey = "SOFTWARE\\Microsoft\\VBA\\7.1\\Common";
            SetmyRegistrySubkey(myRegistry);
            myRegistry.Write("FontHeight", fontSize);

            toolStripStatusLabel.Text = "FontSize is applied";
        }

        private void textBoxFontSize_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxFontSize.Text, "[^0-9]"))
            {
                textBoxFontSize.Text = textBoxFontSize.Text.Remove(textBoxFontSize.Text.Length - 1);
            }
        }


        //using Microsoft.Win32;
        private string getExcelVersion()

        {
            RegistryKey baseKey = Registry.ClassesRoot;
            RegistryKey subKey = baseKey.OpenSubKey(@"Excel.Application\CurVer");
            return subKey.GetValue(string.Empty).ToString();
        }



        private static string SetDefaultDir()
        {
            // DLL 2021 64bit
            //C:\Program Files\Microsoft Office\root\vfs\ProgramFilesCommonX64\Microsoft Shared\VBA\VBA7.1
            // DLL 2016 32bit
            // C:\Program Files (x86)\Microsoft Office\root\vfs\ProgramFilesCommonX86\Microsoft Shared\VBA\VBA7.1

            // for 64bit as Default
            string defaultdir = @"C:\Program Files\Microsoft Office\root\vfs\ProgramFilesCommonX64\Microsoft Shared\VBA\VBA7.1";
            string dir32bit = @"C:\Program Files (x86)\Microsoft Office\root\vfs\ProgramFilesCommonX86\Microsoft Shared\VBA\VBA7.1";

            if (Directory.Exists(defaultdir))
            {
                // Directory exits!
            }
            else
            {
                defaultdir = dir32bit;
            }

            return defaultdir;
        }


        private void buttonModifyDLLauto1_Click(object sender, EventArgs e)
        {
            //string sFileName = @"C:\Program Files\Microsoft Office\root\vfs\ProgramFilesCommonX64\Microsoft Shared\VBA\VBA7.1\VBE7.DLL";
            string defaultdir = SetDefaultDir();
            string sFileName = defaultdir + @"\VBE7.DLL";
            
            PatchFile(sFileName, sFileName + ".BAK");

            AddRegistry_Click(null, new EventArgs());
            //AddRegistry.PerformClick();
        }

        private void linkLabel01_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel01.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://github.com/naver/d2codingfont");
        }


        ///
    }
}