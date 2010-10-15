using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDSkeleton.GUI.Views;

namespace BDDSkeleton.GUI.Presenters
{
    public class HelloWorldPresenter
    {
        private IHelloWorldView _view;

        public HelloWorldPresenter(IHelloWorldView view)
        {
            _view = view;
        }

        public void User_Clicked_Button()
        {
            _view.ShowMessage("Hello World. The date is: " + DateTime.Now.ToShortDateString());
        }
    }
}
