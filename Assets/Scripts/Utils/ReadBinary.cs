using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReadBinary
{
    
    public static byte ReadBinaryFromFile(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            
            BinaryReader binaryReader = new BinaryReader(fs);
            //binaryReader.
            
        }

    }
}
