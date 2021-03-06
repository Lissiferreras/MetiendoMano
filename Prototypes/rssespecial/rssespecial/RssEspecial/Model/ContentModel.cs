﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RssEspecial.Model
{
   public class ContentModel:ViewModelBase
    {
        public string Text { get; set; }
        public bool IsImage { get; set; }

        private FontAttributes _fontAttributes=FontAttributes.None;
        public FontAttributes FontAttributes 
        {
            get => _fontAttributes;
            set
            {
                _fontAttributes = value;
                RaisePropertyChanged();
            }
        }
    }
}
