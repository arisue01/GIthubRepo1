﻿using UIKit;

namespace TestSingleApp1
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
            //.......
            //change2 for remote push
            //change3 for remote push command
        }
    }
}
