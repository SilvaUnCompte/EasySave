﻿using EasySave.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageManager
{
    internal partial class PageManager
    {
        public static void ShowHomePage()
        {
            Console.Clear();
            Console.WriteLine(Language.GetText("create_job"));
            Console.WriteLine(Language.GetText("delete_job"));
            Console.WriteLine(Language.GetText("lunch_job"));
            Console.WriteLine(Language.GetText("show_options"));
            Console.WriteLine($"5. {Language.GetText("exit")}");

            Console.WriteLine(Language.GetText("enter_choice"));
            Char choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                    ShowCreateJobPage();
                    break;
                case '2':
                    ShowDeleteJobPage();
                    break;
                case '3':
                    ShowRunJobPage();
                    break;
                case '4':
                    ShowOptionsPage();
                    break;
                case '5':
                    Environment.Exit(0);
                    break;
                default:
                    ShowHomePage();
                    break;
            }
        }


    }
}