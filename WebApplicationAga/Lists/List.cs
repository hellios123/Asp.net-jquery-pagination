using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WebApplicationAga
{
    public class Lists

    {
        public static IList<Comment> ls = new List<Comment>()   {
            new Comment() { Name="Ana", Text="Lorem Ipsum ",Time=DateTime.Now.ToString()},
           new Comment() { Name="Sara",  Text="It was  about something",
               Time =DateTime.ParseExact("2011-03-21 13:26", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture).ToString()
    },
           new Comment() { Name="Sara",  Text="It was  about something",Time =DateTime.ParseExact("2011-03-21 13:26", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture).ToString()},
    };


    }
    

    public class Comment

        {
        [Required()]
        [MaxLength(8)]
        
        public string Name {get;set;}
    public string Text { get; set; }
        
        public string Time { get; set; } = DateTime.Now.ToString();
        public string ImagePath { get; set; } = "";
            

        }

    
}