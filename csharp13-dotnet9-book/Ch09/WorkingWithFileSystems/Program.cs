using Spectre.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

SectionTitle("Handling cross-platform environments and filesystems");
Table table = new();
table.AddColumn("[blue]MEMBER[/]");
table.AddColumn("[blue]VALUE[/]");

table.AddRow("Path.PathSeparator", PathSeparator.ToString());
table.AddRow("Path.DirectorySeparatorChar", DirectorySeparatorChar.ToString());
table.AddRow("Directory.GetCurrentDirectory()", GetCurrentDirectory());
table.AddRow("Environment.CurrentDirectory", CurrentDirectory);
table.AddRow("Environment.SystemDirectory", SystemDirectory);
table.AddRow("Path.GetTempPath()", GetTempPath());
table.AddRow("");
table.AddRow("GetFolderPath(SpecialFolder", "");
table.AddRow("  .System)", GetFolderPath(SpecialFolder.System));
table.AddRow("  .ApplicationData)", GetFolderPath(SpecialFolder.ApplicationData));
table.AddRow("  .MyDocuments)", GetFolderPath(SpecialFolder.MyDocuments));
table.AddRow("  .Personal)", GetFolderPath(SpecialFolder.Personal));

AnsiConsole.Write(table);

SectionTitle("Managing drives");
Table drives = new();
drives.AddColumn("[blue]NAME[/]");
drives.AddColumn("[blue]TYPE[/]");
drives.AddColumn("[blue]FORMAT[/]");
drives.AddColumn(new TableColumn(
    "[blue]SIZE (BYTES)[/]").RightAligned());
drives.AddColumn(new TableColumn(
    "[blue]FREE SPACE[/]").RightAligned());
foreach (DriveInfo drive in DriveInfo.GetDrives())
{
    if (drive.IsReady)
    {
        drives.AddRow(drive.Name, drive.DriveType.ToString(),
            drive.DriveFormat, drive.TotalSize.ToString("N0"),
            drive.AvailableFreeSpace.ToString("N0"));
    }
    else
    {
        drives.AddRow(drive.Name, drive.DriveType.ToString(),
            string.Empty, string.Empty, string.Empty);
    }
}
AnsiConsole.Write(drives);

SectionTitle("Managing directories");
string newFolder = Combine(GetFolderPath(SpecialFolder.Personal), Guid.NewGuid().ToString());
Console.WriteLine($"Working with: {newFolder}");
Console.WriteLine($"Does it exist? {Path.Exists(newFolder)}");
Console.WriteLine("Creating it...");
CreateDirectory(newFolder);

Console.WriteLine($"Does it exist? {Directory.Exists(newFolder)}");
Console.Write("Confirm the directory exists, and then press any key.");
Console.ReadKey(intercept: true);
Console.WriteLine("Deleting it...");
Delete(newFolder, recursive: true);
Console.WriteLine($"Does it exist? {Path.Exists(newFolder)}");

SectionTitle("Managing files");
string dir = Combine(GetFolderPath(SpecialFolder.Personal), "OutputFiles");
CreateDirectory(dir);

string textFile = Combine(dir, "Dummy.txt");
string backupFile = Combine(dir, "Dummy.bak");
Console.WriteLine($"Working with: {textFile}");
Console.WriteLine($"Does it exist? {File.Exists(textFile)}");
StreamWriter textWriter = File.CreateText(textFile);
textWriter.WriteLine("Hello, C#!");
textWriter.Close();
Console.WriteLine($"Does it exist? {File.Exists(textFile)}");
File.Copy(sourceFileName: textFile, destFileName: backupFile, overwrite: true);
Console.WriteLine($"Does {backupFile} exist? {File.Exists(backupFile)}");
Console.Write("Confirm the files exist, and then press any key.");
Console.ReadKey(intercept: true);
File.Delete(textFile);
Console.WriteLine($"Does it exist? {File.Exists(textFile)}");
Console.WriteLine($"Reading contents of {backupFile}:");
StreamReader textReader = File.OpenText(backupFile);
Console.WriteLine(textReader.ReadToEnd());
textReader.Close();
