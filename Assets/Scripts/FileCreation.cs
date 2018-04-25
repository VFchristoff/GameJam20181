using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System;
using System.Text;

public class FileCreation : MonoBehaviour
{
    public void test ()
    {
		StreamWriter testText = new StreamWriter("MailBox/text.txt");

        testText.Write("Arow");
        testText.Close();
    }
}

