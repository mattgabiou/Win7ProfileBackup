// Windows 7 Profile Backup Utility
// This program will backup the following folders to another drive letter: Favorites, Downloads, Desktop, and Documents.
// It will also search for some files and log the restults to BackupLog.txt
// Created by Matt Gabiou on 3-14-12

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // Needed for Directory and File Operations


namespace Win7ProfileBackup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBackupNow_Click(object sender, EventArgs e)
        {

            // Backup Location - Change this to wherever you want the backup to go
            //*****************************************************************
            //string mainFolder = @"C:\ProfileBackup";
            //*****************************************************************
             string mainFolder = folderBrowserDialog1.SelectedPath + @"\Profile_Backup";
            //MessageBox.Show(mainFolder);
           
            // Get Environment Variables
            string envUserName = System.Environment.GetEnvironmentVariable("USERNAME");
            string envCompName = System.Environment.GetEnvironmentVariable("COMPUTERNAME");
            string envUserProfile = System.Environment.GetEnvironmentVariable("UserProfile");
            string envUserDomain = System.Environment.GetEnvironmentVariable("UserDomain");
            string osVersion = Convert.ToString(System.Environment.OSVersion);

            // Create Source Folder Variables
            string userFavorites = envUserProfile + @"\Favorites";
            string userDesktop = envUserProfile + @"\Desktop";
            string userDownloads = envUserProfile + @"\Downloads";
            

            // Create Destination Folder Variables
            string targetFavorites = mainFolder + @"\Favorites";
            string targetDesktop = mainFolder + @"\Desktop";
            string targetDownloads = mainFolder + @"\Downloads";
            string targetDocs = mainFolder + @"\My Documents";
            string userDocs = "Undefined";  // Documents path is determined below
            

            bool enableCopyFavorites = true;
            bool enableCopyDesktop = true;
            bool enableCopyDownloads = true;
            bool enableCopyDocs = true;
            //bool searchNoErrors = false;        // Indicates if there was an error during search

            //string destFile;    // Holds desination filename
            //string fileNames;   // Holds the actual filename
            //string testfolder = "C:\\Furbee";
        

            // Check Version of OS
            string mainVer = osVersion.Substring(0, 24); // Checks the OS string up to 6.0 or 6.1 for the version.
            //MessageBox.Show("The variable is: " + mainVer);


            // Create Main Backup Folder or if it exists exit the method
            if (!System.IO.Directory.Exists(mainFolder))
            {
                 System.IO.Directory.CreateDirectory(mainFolder);
                 //tw.WriteLine(@"Creating Main Backup Folder");
            }
            else
            {
                 MessageBox.Show("Backup Folder Already Exists! Please choose another folder to backup to.");
                 return;
            }

            // Create logfile or append to existing if found.
            TextWriter tw = new StreamWriter(mainFolder + @"\BackupLog.txt", true); // The true on the end appends to a logfile if it exists.



            // Start writing to log file
            tw.WriteLine(@"");
            tw.WriteLine(@"");
            tw.WriteLine(@"");
            tw.WriteLine(@"");
            tw.WriteLine(@"");
            tw.WriteLine(@"---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            tw.WriteLine(@"Windows 7 Profile Backup Utility");
            tw.WriteLine(@"Created by Matt Gabiou on 3-14-12");

            tw.WriteLine(@"");
            tw.WriteLine(@"Username is: " + envUserName);
            tw.WriteLine(@"Computername is: " + envCompName);
            tw.WriteLine(@"UserProfile is: " + envUserProfile);
            tw.WriteLine(@"User Domain is: " + envUserDomain);
            tw.WriteLine(@"Windows Version is: " + osVersion);

            // Determine name of Documents folder by OS version
            if (mainVer.Equals("Microsoft Windows NT 6.1"))
            {
                 //MessageBox.Show("Windows 7 " + mainVer);
                 //userDocs = envUserProfile + @"\My Documents"; // Windows 7
                 userDocs = envUserProfile + @"\Documents"; // Windows 7
                 tw.WriteLine("Determined Windows 7 and using 'My Documents' folder ");
            }
            else if (mainVer.Equals("Microsoft Windows NT 6.0"))
            {
                 //MessageBox.Show("Windows Vista " + mainVer);
                 userDocs = envUserProfile + @"\Documents"; // Vista - Should put in logic to determine OS

                 tw.WriteLine("Determined Vista and using 'Documents' folder ");
            }
            else if (mainVer.Equals("Microsoft Windows NT 6.2"))
            {
                 //MessageBox.Show("Windows 8 " + mainVer);
                 userDocs = envUserProfile + @"\My Documents"; // Windows 7
                 tw.WriteLine("Determined Windows 8 and using 'My Documents' folder ");
            }
            else
            {
                 //MessageBox.Show("Not Windows 7  Vista, or Win 8 " + mainVer);
                 userDocs = envUserProfile + @"\My Documents"; // Windows XP
                 tw.WriteLine("Unknown Windows version and using 'My Documents' folder ");
            }



            tw.WriteLine(@"");
            tw.WriteLine(@"");
            tw.WriteLine(@"[Beginning Backup]");
            tw.WriteLine(DateTime.Now);
            tw.WriteLine(@"");
            tw.WriteLine(@"");




            // If the target sub-directories dont exist, create them.
            tw.WriteLine(@"- Creating Sub-Directories for FileCopy");
            
            if (!System.IO.Directory.Exists(mainFolder))
            {
                System.IO.Directory.CreateDirectory(mainFolder);
                tw.WriteLine(@"Creating Main Backup Folder");
            }

            if (!System.IO.Directory.Exists(targetFavorites))
            {
                System.IO.Directory.CreateDirectory(targetFavorites);
                tw.WriteLine(@"Creating Favorites Backup Folder");
            }

            if (!System.IO.Directory.Exists(targetDesktop))
            {
                System.IO.Directory.CreateDirectory(targetDesktop);
                tw.WriteLine(@"Creating Desktop Backup Folder");
            }

            if (!System.IO.Directory.Exists(targetDownloads))
            {
                System.IO.Directory.CreateDirectory(targetDownloads);
                tw.WriteLine(@"Creating Downloads Backup Folder");
            }

            if (!System.IO.Directory.Exists(targetDocs))
            {
                System.IO.Directory.CreateDirectory(targetDocs);
                tw.WriteLine(@"Creating Documents Backup Folder");
            }


            tw.WriteLine(@"");
            tw.WriteLine(@"");
            tw.WriteLine(@"");



            // Begin File Copies
            // --- Favorites Copy --- //
            // To copy all the files in one directory to another directory.
            if (System.IO.Directory.Exists(userFavorites) && enableCopyFavorites == true)
            {
                 labelFavStatus.Text = "Running... ";
                 Refresh();

                 
                tw.WriteLine(@"- Begin Favorites Backup");

                string[] files = System.IO.Directory.GetFiles(userFavorites);

                labelFavStatus.Text = "Running... ";
                Refresh();

                 CopyDirectory(userFavorites, targetFavorites, tw, labelCurrentFile);


                 labelFavStatus.Text = "Backed Up!";
                tw.WriteLine(@"- Favorites Backup Complete");
                
            }
            else
            {
                labelFavStatus.Text = "Folder Not Found!";
                //MessageBox.Show("Could not find Favorites!");
                tw.WriteLine(@"");
                tw.WriteLine(@"Favorites Folder Not Found!");
            }
            Refresh();




            // --- Downloads Backup --- //
            if (System.IO.Directory.Exists(userDownloads) && enableCopyDownloads == true)
            {
                tw.WriteLine(@"");
                tw.WriteLine(@"");
                tw.WriteLine(@"- Begin Downloads Backup");

                labelDownStatus.Text = "Running... ";
                Refresh();

                CopyDirectory(userDownloads, targetDownloads, tw, labelCurrentFile);

                labelDownStatus.Text = "Backed Up!";
                tw.WriteLine(@"- Downloads Backup Complete"); 
            }
            else
            {
                //MessageBox.Show("Could not find Downloads!");
                labelDownStatus.Text = "Folder Not Found!";
                tw.WriteLine(@"");
                tw.WriteLine(@"Downloads Folder Not Found!");
            }
            Refresh();




            // --- Desktop Backup --- //
            if (System.IO.Directory.Exists(userDesktop) && enableCopyDesktop == true)
            {
                tw.WriteLine(@"");
                tw.WriteLine(@"");
                tw.WriteLine(@"- Begin Desktop Backup");

                labelDeskStatus.Text = "Running... ";
                Refresh();

                CopyDirectory(userDesktop, targetDesktop, tw, labelCurrentFile);

                labelDeskStatus.Text = "Backed Up!";
                tw.WriteLine(@"- Desktop Backup Complete");
                tw.WriteLine(@"");
                tw.WriteLine(@"");
            }
            else
            {
                //MessageBox.Show("Could not find Desktop!");
                labelDeskStatus.Text = "Folder Not Found!";
                tw.WriteLine(@"");
                tw.WriteLine(@"Desktop Folder Not Found");
            }
            Refresh();




            // --- Documents Backup --- //
            //try // An access denied exception stops the backup. This try catch block lets it continue.
            //{

                 if (System.IO.Directory.Exists(userDocs) && enableCopyDocs == true)
                {
                    tw.WriteLine(@"");
                    tw.WriteLine(@"");
                    tw.WriteLine(@"- Begin Documents Backup");

                    labelDocsStatus.Text = "Running... ";
                    Refresh();

                    CopyDirectory(userDocs, targetDocs, tw, labelCurrentFile);

                    labelDocsStatus.Text = "Backed Up!";
                    tw.WriteLine(@"- Documents Backup Complete");
                    tw.WriteLine(@"");
                    tw.WriteLine(@"");
                }
                else
                {
                    //MessageBox.Show("Could not find Documents!");
                    labelDocsStatus.Text = "Folder Not Found!";
                    tw.WriteLine(@"");
                    tw.WriteLine(userDocs + @" - Folder Not Found!");
                }
           
     
          /*
            //catch (FileNotFoundException) { };
            catch(UnauthorizedAccessException ex)
            {
                labelDocsStatus.Text = "Access Denied! Folder not backed up, see log for details. ";
                Refresh();
                tw.WriteLine("Access was denied on " + userDocs + ". Is the folder available locally?");
                tw.WriteLine(ex);
            }
           */
            Refresh();


             // --- Search Area --- //
             /*
            // ***************************
            // Search for TXT's
            // ***************************
            labelFileSearchStatus.Text = "Searching for *.txt";
            FileSearch(@"C:\SearchTest", "*.txt", tw);
            labelFileSearchStatus.Text = "Search complete";
            
             
               // ***************************
               // Search for MP3's
               // ***************************
               labelFileSearchStatus.Text = "Searching for *.mp3";
               FileSearch(@"C:\", "*.mp3", tw);
               labelFileSearchStatus.Text = "Search complete";
                 
             */

            // Close the Log File
            tw.WriteLine(@"");
            tw.WriteLine(@"");
            tw.WriteLine(@"[End Backup]");
            tw.WriteLine(DateTime.Now);
            tw.WriteLine(@"---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            // close the stream
            tw.Close();




            // MessageBox.Show("The variable is: " + userFavorites);
            //MessageBox.Show("The program has finished running.");
            labelCurrentFile.Text = "Backup Complete!";
            Refresh();
        }

        // ***************************
        // Copy Directory
        // ***************************
        // http://stackoverflow.com/questions/1066674/how-do-i-copy-a-folder-and-all-subfolders-and-files-in-net
         // This method recursivly copies all the folder in a directory to another
        private static void CopyDirectory(string sourcePath, string destPath, TextWriter twrite, Control curFile)
        {
             if (!Directory.Exists(destPath))
             {
                  Directory.CreateDirectory(destPath);
             }

             try
             {
                  foreach (string file in Directory.GetFiles(sourcePath))
                  {
                       string dest = Path.Combine(destPath, Path.GetFileName(file));
                       File.Copy(file, dest);

                       // Display the file being copied
                       curFile.Text = file;
                       curFile.Refresh();

                       // Use static Path methods to extract only the file name from the path.
                       string fileNames = System.IO.Path.GetFileName(file);
                       string destFile = System.IO.Path.Combine(destPath, fileNames);

                       // Write files being copied to the logfile
                       twrite.WriteLine("Copied " + file + " > " + destFile);

                       // Debugging
                       //MessageBox.Show("This file was copied: " + file); // Showing what is being copied in the loop.    
                  }

                  foreach (string folder in Directory.GetDirectories(sourcePath))
                  {
                       string dest = Path.Combine(destPath, Path.GetFileName(folder));
                       curFile.Refresh();
                       CopyDirectory(folder, dest, twrite, curFile);
                  }
             } //end Try
             catch (UnauthorizedAccessException ex)
             {
                  twrite.WriteLine(" **Access Denied Copying File or Folder: ");
                  twrite.WriteLine(ex);
             }//end catch
        }// end CopyDirectory

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Windows Profile Backup Utility created by Matt Gabiou on 3-14-12", "About");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // ***************************
        // File Search
        // ***************************
        private void FileSearch(string sPath, string fType, TextWriter tWrite)
        {
             //MessageBox.Show("Searching for *.txt files");
             tWrite.WriteLine(@"");
             tWrite.WriteLine("-Looking for " + fType + " files");

             try
             {
               //foreach (string folder in Directory.GetDirectories(sPath))
                  foreach (var file in Directory.GetFiles(sPath, fType, SearchOption.AllDirectories))
                  
               //var allFiles = Directory.GetFiles(sPath, fType, SearchOption.AllDirectories);
               //foreach (var file in allFiles)

                  
                  {
                       tWrite.WriteLine("Found " + file);
                  }
             }
             catch (UnauthorizedAccessException ex)
             {
                  Refresh();
                  tWrite.WriteLine(" **Search stopped. Access was denied on " + sPath + " folder");
                  labelFileSearchStatus.Text = "Search stopped - Access Denied";
                  tWrite.WriteLine(ex);
                  
             }
             catch (DirectoryNotFoundException ex)
             {
                  Refresh();
                  tWrite.WriteLine(" **Search stopped. Folder " + sPath + " does not exist");
                  labelFileSearchStatus.Text = "Search stopped - Folder does not exist";
                  tWrite.WriteLine(ex);
             }

             
             tWrite.WriteLine(@"");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
             // Get user folder
             DialogResult result = folderBrowserDialog1.ShowDialog();
             
             // Show folder selected
             //MessageBox.Show(folderBrowserDialog1.SelectedPath);

             labelPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void buttonLogFile_Click(object sender, EventArgs e)
        {
             string profileFolder = folderBrowserDialog1.SelectedPath + @"\Profile_Backup";
             string logPath = profileFolder + @"\BackupLog.txt";
             //MessageBox.Show(profileFolder);
             //MessageBox.Show(logPath);

             // If logfle exists open it otherwise let the user know its not found
             if (System.IO.File.Exists(logPath))
                  System.Diagnostics.Process.Start(logPath);

             else
                  MessageBox.Show("The logfile does not exist");
        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

       
    }
}
