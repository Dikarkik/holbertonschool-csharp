# Create C# project in each folder. Will have the folders created or a file with a folders list. Ex: dirList file contains a list of current folders
for dirname in ./*; # Using "./*" if the empties folders were created
do
   if [ -d $dirname ];
   then
      cd $dirname; dotnet new console; // Create the C# folder current
     cd .. ;
    fi;
done
// Rename Program.cs files
for dirnum in ./*;
do
   if [ -d $dirnum ];
   then
      cd $dirnum;
      mv Program.cs $dirnum.cs; 
      cd ..;
   fi;
done
