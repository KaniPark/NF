using System;
using System.Collections.Generic;

using Xamarin.Forms;

using NF.Models;

namespace NF.Views
{
    public partial class MemberListPage : ContentPage
    {
        public MemberListPage()
        {
            InitializeComponent();

            lstMember.ItemsSource = new List<Member>() { new Member() { FirstName = "Hanhee", LastName = "Park" } };
        }
    }
}
