using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Oct10_2017GamesMVC.Models
{
    public class Score
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

        //we did that much already. then entered some data from its website.
        //what if we want to add more fields to the model?

        //that's where migration comes in...

        //if you just add more stuff to the model, 
        //the program might not run or you'll get errors. so...

        //nuget pck mng console (in tools)
        //something will open at the bottom of the screen
        //that's where you put commands

        //enable-migrations
        //just needed to do ONCE per project
        //oops lol that's not right.
        //but type that, and it will tell you what to use instead
        //it'll open up a new part: Configuration.cs

        public string Team { get; set; }

        //one you make the change in the model, 
        //and you've allowed and added migrations,
        //you need to change a bunch more:
        //all view pages related to the model,
        //in this project: index, edit, create, delete, details
        //in this project: controller

        //note folder: Migrations.
        //labeled by date of creation

        //see class ppt for instructions about all the migration steps.

        //try one on your own:

        public int Crashes { get; set; }
    }
}