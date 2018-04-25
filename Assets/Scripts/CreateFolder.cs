using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class CreateFolder : MonoBehaviour
{
    public void Folder()
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string folder = path + @"\MailBox";

        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
        else
        {
            System.IO.DirectoryInfo pasta = new DirectoryInfo(folder);
            foreach (FileInfo file in pasta.GetFiles())
            {
                file.Delete();
            }
            //Directory.Delete(folder, true);
            //Directory.CreateDirectory(folder);
        }

    }
}