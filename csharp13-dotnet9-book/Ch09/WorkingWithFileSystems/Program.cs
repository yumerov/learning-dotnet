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
