using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDSkeleton.GUI.Views;

namespace BDDSkeleton.GUI.Tests.Mocks
{
    class HelloWorldViewMock : IHelloWorldView
    {
        public bool ShowMessageWasCalled;
        public string MessageShown;

        public void ShowMessage(string message)
        {
            ShowMessageWasCalled = true;
            MessageShown = message;
        }
    }
}
