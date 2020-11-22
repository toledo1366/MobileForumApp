using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MobileForum.Model;
using Refit;

namespace MobileForum.API
{
    public interface IApiService
    {
        [Get("/posts")]
        Task<List<Post>> GetPosts();
    }
}