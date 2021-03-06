﻿using System;
using System.Collections.Generic;
using System.Text;
using TestShell.Models;

namespace TestShell.Views
{
    using Xamarin.Essentials;
    using Xamarin.Forms;

    public class BlogDetailsView : BaseView
    {
        public BlogDetailsView(FeedItem item)
        {
            Title = item.Title;
            BindingContext = item;
            var webView = new WebView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            webView.Source = new HtmlWebViewSource
            {
               // Html = item.Description
            };
            Content = new StackLayout
            {
                Children =
                {
                    webView
                }
            };
            var share = new ToolbarItem
            {
                Icon = "ic_share.png",
                Text = "Share",
                Command = new Command(async () => await Share.RequestAsync(new ShareTextRequest(item.Title, item.Link)))
            };

            ToolbarItems.Add(share);
        }
    }
}
