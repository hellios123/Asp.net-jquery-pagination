using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplicationAga
{
    public class Interaction
    {
        public static IList<Comment> llll = Lists.ls;

        public static void  StreamingW()
        {


            StreamWriter sk = new StreamWriter(HttpContext.Current.Server.MapPath(@"\Lists\TextStorage.txt"), true, System.Text.Encoding.ASCII);
            
                for (int i = 0; i < llll.Count; i++) { sk.WriteLine(llll[i].Name + "," + llll[i].Text + "," + llll[i].Time + "," + llll[i].ImagePath+";") ;
            }
            sk.Close();
            sk.Dispose();
            return;
     
     }
        public static void StreamingR()
        {
            StreamReader fs = new StreamReader (HttpContext.Current.Server.MapPath(@"\Lists\TextStorage.txt"));
            string fsr="";
            string fsl = fs.ReadLine(); if (fsl == null) {
                fs.Close();
                fs.Dispose(); StreamingW(); 
                StreamingR(); return;
            }
            while (fsl != null)
            {
                fsr=fsr.Insert(fsr.Length,fsl);
                 fsl = fs.ReadLine();
            }

            string[] end= fsr.Split(';');
            Interaction.llll = new List<Comment> { };

            for (int i = 0; i < end.Length-1; i++) { string[] end2 = end[i].Split(','); llll.Add(new Comment()
            {
                Name = end2[0],
                Text = end2[1],
                Time = end2[2],
                ImagePath = end2[3]
            });
            }
            fs.Close();
            fs.Dispose();


            return;


        }
    }
}