﻿using System;
using Prism.Commands;
using Xamarin.Forms;

namespace sf_sample.Commands
{
    public class CustomCommand : DelegateCommand
    {
        public CustomCommand(Action executeMethod) : base(executeMethod) { }

        public CustomCommand(Action executeMethod, Func<bool> canExecuteMethod) : base(executeMethod, canExecuteMethod)
        {
        }

        public ImageSource Image { get; set; }
        public string Text { get; set; }
    }
}