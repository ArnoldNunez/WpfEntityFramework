using System;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEntityFramework.Models.DataModels;

namespace WpfEntityFramework.ViewModels.ViewModels
{

    public class WindowViewModel
    {

        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        /// <summary>
        /// Constructor
        /// </summary>
        public WindowViewModel()
        {
            
        }
    }
}
