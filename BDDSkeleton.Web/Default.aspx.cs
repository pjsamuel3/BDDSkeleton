using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BDDSkeleton.GUI.Views;
using BDDSkeleton.GUI.Presenters;

namespace BDDSkeleton.Web
{
    public partial class _Default : Page, IHelloWorldView
    {
        private HelloWorldPresenter _presenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new HelloWorldPresenter(this);
        }

        public void ShowMessage(string message)
        {
            labelMessage.Text = message;
        }

        protected void btnHelloWorld_Click(object sender, EventArgs e)
        {
            _presenter.User_Clicked_Button();
        }

    }
}
